Imports System
Imports System.IO
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms


Public Class Main_Screen


    Private lastinputline As String = ""
    Private inputlines As Long = 0
    Private statusmessage As String = ""
    Private highestPercentageReached As Integer = 0
    Private inputlinesprecount As Long = 0
    Private datelaunched As Date = Now()
    Private pretestdone As Boolean = False
    




    Private Sub Error_Handler(ByVal ex As Exception, Optional ByVal identifier_msg As String = "")
        Try
            If ex.Message.IndexOf("Thread was being aborted") < 0 Then
                Dim Display_Message1 As New Display_Message()
                If FullErrors_Checkbox.Checked = True Then
                    Display_Message1.Message_Textbox.Text = "The Application encountered the following problem: " & vbCrLf & identifier_msg & ":" & ex.ToString
                Else
                    Display_Message1.Message_Textbox.Text = "The Application encountered the following problem: " & vbCrLf & identifier_msg & ":" & ex.Message.ToString
                End If
                Display_Message1.Timer1.Interval = 1000
                Display_Message1.ShowDialog()
                Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs")
                If dir.Exists = False Then
                    dir.Create()
                End If
                dir = Nothing
                Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs\" & Format(Now(), "yyyyMMdd") & "_Error_Log.txt", True)
                filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & identifier_msg & ":" & ex.ToString)
                filewriter.Flush()
                filewriter.Close()
                filewriter = Nothing
            End If
        Catch exc As Exception
            MsgBox("An error occurred in the application's error handling routine. The application will try to recover from this serious error.", MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub


    Private Sub Activity_Handler(ByVal Message As String)
        Try
            Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs")
            If dir.Exists = False Then
                dir.Create()
            End If
            dir = Nothing
            Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt", True)
            filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & Message)
            filewriter.Flush()
            filewriter.Close()
            filewriter = Nothing
        Catch ex As Exception
            Error_Handler(ex, "Activity_Logger")
        End Try
    End Sub

    Private Sub Status_Handler(ByVal Message As String)
        Try
            Status_Textbox.Text = Message.ToUpper
            Status_Textbox.Select(0, 0)
        Catch ex As Exception
            Error_Handler(ex, "Status_Handler")
        End Try
    End Sub


    Private Sub InputFolder_Textbox_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputDatabase_Textbox.DragEnter, InputDatabase2_Textbox.DragEnter, InputTextFile_Textbox.DragEnter
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.All
            End If
        Catch ex As Exception
            Error_Handler(ex)
        End Try
    End Sub

    Private Sub InputFolder_Textbox_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputDatabase_Textbox.DragDrop, InputDatabase2_Textbox.DragDrop, InputTextFile_Textbox.DragDrop
        Try

            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim MyFiles() As String
                ' Assign the files to an array.
                MyFiles = e.Data.GetData(DataFormats.FileDrop)
                ' Loop through the array and add the files to the list.
                'For i = 0 To MyFiles.Length - 1
                If MyFiles.Length > 0 Then
                    Dim dinfo As FileInfo = New FileInfo(MyFiles(0))
                    If dinfo.Exists = True Then

                        If sender.Equals(InputTextFile_Textbox) = True Then
                            InputTextFile_Textbox.Text = (MyFiles(0))
                        End If
                        If sender.Equals(InputDatabase_Textbox) = True Then
                            InputDatabase_Textbox.Text = (MyFiles(0))
                        End If
                        If sender.Equals(InputDatabase2_Textbox) = True Then
                            InputDatabase2_Textbox.Text = (MyFiles(0))
                        End If
                    End If
                    dinfo = Nothing
                End If
                'Next
            End If
        Catch ex As Exception
            Error_Handler(ex, "InputFolder_Textbox DragDrop")
        End Try
    End Sub


    Private Sub Browse1_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse1_Button.Click
        Status_Handler("Selecting Input File")
        Try
            OpenFileDialog1.Filter = "Access Files|*.mdb|All Files|*.*"
            OpenFileDialog1.FileName = ""
            If File_Exists(InputDatabase_Textbox.Text) = True Then
                OpenFileDialog1.FileName = InputDatabase_Textbox.Text
            End If
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                InputDatabase_Textbox.Text = OpenFileDialog1.FileName
            End If

            Dim res As String
            res = WorkerExecuteSpecialScalar("select distinct CD_Disk_Number from File_Collection order by CD_Disk_Number desc", 1)
            res = "CD" & (Integer.Parse(res.Remove(0, 2)) + 1).ToString
            InputDiskNumber_Textbox.Text = res
            InputCategory_Textbox.Text = "Anime"
            Anime_Medium_Textbox.Text = InputDiskNumber_Textbox.Text
        Catch ex As Exception
            Error_Handler(ex, "Browse1_Button")
        End Try
        Status_Handler("Input File Selected")
    End Sub

    Private Sub Browse2_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse2_Button.Click
        Status_Handler("Selecting Input Folder")
        Try
            '  OpenFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
            'OpenFileDialog1.FileName = ""
            FolderBrowserDialog1.Description = "Select input folder"

            If Directory_Exists(InputTextFile_Textbox.Text) = True Then
                FolderBrowserDialog1.SelectedPath = InputTextFile_Textbox.Text
            End If
            Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                InputTextFile_Textbox.Text = FolderBrowserDialog1.SelectedPath
            End If

        Catch ex As Exception
            Error_Handler(ex, "Browse2_Button")
        End Try
        Status_Handler("Input Folder Selected")
    End Sub



    Private Function File_Exists(ByVal file_path As String) As Boolean
        Dim result As Boolean = False
        Try
            If Not file_path = "" And Not file_path Is Nothing Then
                Dim dinfo As FileInfo = New FileInfo(file_path)
                If dinfo.Exists = False Then
                    result = False
                Else
                    result = True
                End If
                dinfo = Nothing
            End If
        Catch ex As Exception
            Error_Handler(ex, "File_Exists")
        End Try
        Return result
    End Function

    Private Function Directory_Exists(ByVal directory_path As String) As Boolean
        Dim result As Boolean = False
        Try
            If Not directory_path = "" And Not directory_path Is Nothing Then
                Dim dinfo As DirectoryInfo = New DirectoryInfo(directory_path)
                If dinfo.Exists = False Then
                    result = False
                Else
                    result = True
                End If
                dinfo = Nothing
            End If
        Catch ex As Exception
            Error_Handler(ex, "Directory_Exists")
        End Try
        Return result
    End Function


    Private Sub Main_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InputDatabase_Textbox.Text = My.Settings.InputDatabase_Textbox
            InputDatabase_Textbox.Select(0, 0)
            If File_Exists(InputDatabase_Textbox.Text) = False Then
                InputDatabase_Textbox.Text = ""
            End If

            InputDatabase2_Textbox.Text = My.Settings.InputDatabase2_Textbox
            InputDatabase2_Textbox.Select(0, 0)
            If File_Exists(InputDatabase2_Textbox.Text) = False Then
                InputDatabase2_Textbox.Text = ""
            End If

            InputTextFile_Textbox.Text = My.Settings.InputTextFile_Textbox
            InputTextFile_Textbox.Select(0, 0)
            If Directory_Exists(InputTextFile_Textbox.Text) = False Then
                InputTextFile_Textbox.Text = ""
            End If

            InputDiskNumber_Textbox.Text = My.Settings.InputDiskNumber_Textbox
            InputDiskNumber_Textbox.Select(0, 0)

            InputCategory_Textbox.Text = My.Settings.InputCategory_Textbox
            InputCategory_Textbox.Select(0, 0)

            Select Case My.Settings.FullErrors_Checkbox
                Case True
                    FullErrors_Checkbox.Checked = True
                    Exit Select
                Case False
                    FullErrors_Checkbox.Checked = False
                    Exit Select
                Case Else
                    FullErrors_Checkbox.Checked = True
                    Exit Select
            End Select

           
        Catch ex As Exception
            Error_Handler(ex, "Main_Screen_Load")
        End Try
    End Sub

    Private Sub Main_Screen_Close(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            My.Settings.FullErrors_Checkbox = FullErrors_Checkbox.Checked

            My.Settings.InputDatabase_Textbox = InputDatabase_Textbox.Text
            My.Settings.InputDatabase2_Textbox = InputDatabase2_Textbox.Text
            My.Settings.InputTextFile_Textbox = InputTextFile_Textbox.Text

            My.Settings.InputCategory_Textbox = InputCategory_Textbox.Text
            My.Settings.InputDiskNumber_Textbox = InputDiskNumber_Textbox.Text

            My.Settings.Save()
        Catch ex As Exception
            Error_Handler(ex, "Main_Screen_Close")
        End Try

    End Sub

    Private Sub InputDatabase_Textbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDatabase_Textbox.TextChanged, InputDatabase2_Textbox.TextChanged
        Status_Handler("Input Database Selected")
    End Sub
    Private Sub InputTextfile_Textbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputTextFile_Textbox.TextChanged
        Status_Handler("Input Text File Selected")
    End Sub




    Private Sub startAsyncButton_Click(ByVal sender As System.Object, _
     ByVal e As System.EventArgs) _
     Handles startAsyncButton.Click

        Try
            statusmessage = "Initializing Application for Operation Launch"
            Status_Handler(statusmessage)

            ' Reset the text in the result label.

            inputlines_label.Text = [String].Empty
            lastinputline_label.Text = [String].Empty
            datelaunched_label.Text = [String].Empty


            inputlines = 0
            lastinputline = ""
            statusmessage = ""
            highestPercentageReached = 0
            inputlinesprecount = 0
            datelaunched = Now()
            pretestdone = False
            

            Controls_Enabler("run")

            Dim res As String
            res = WorkerExecuteSpecialScalar("select distinct CD_Disk_Number from File_Collection order by CD_Disk_Number desc", 1)
            res = "CD" & (Integer.Parse(res.Remove(0, 2)) + 1).ToString
            InputDiskNumber_Textbox.Text = res
            InputCategory_Textbox.Text = "Anime"
            Anime_Medium_Textbox.Text = InputDiskNumber_Textbox.Text

            ' Start the asynchronous operation.
            Me.LinkLabel1.Visible = True
            BackgroundWorker1.RunWorkerAsync(InputTextFile_Textbox.Text)

        Catch ex As Exception
            Error_Handler(ex, "startAsyncButton_Click")
        End Try
    End Sub 'startAsyncButton_Click


    Private Sub cancelAsyncButton_Click( _
    ByVal sender As System.Object, _
    ByVal e As System.EventArgs) _
    Handles cancelAsyncButton.Click

        ' Cancel the asynchronous operation.
        Me.backgroundWorker1.CancelAsync()

        ' Disable the Cancel button.
        cancelAsyncButton.Enabled = False

    End Sub 'cancelAsyncButton_Click

    ' This event handler is where the actual work is done.
    Private Sub backgroundWorker1_DoWork( _
    ByVal sender As Object, _
    ByVal e As DoWorkEventArgs) _
    Handles BackgroundWorker1.DoWork

        ' Get the BackgroundWorker object that raised this event.
        Dim worker As BackgroundWorker = _
            CType(sender, BackgroundWorker)

        ' Assign the result of the computation
        ' to the Result property of the DoWorkEventArgs
        ' object. This is will be available to the 
        ' RunWorkerCompleted eventhandler.
        e.Result = MainWorkerFunction(e.Argument, worker, e)
    End Sub 'backgroundWorker1_DoWork

    ' This event handler deals with the results of the
    ' background operation.
    Private Sub backgroundWorker1_RunWorkerCompleted( _
    ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) _
    Handles BackgroundWorker1.RunWorkerCompleted

        ' First, handle the case where an exception was thrown.
        If Not (e.Error Is Nothing) Then
            Error_Handler(e.Error, "backgroundWorker1_RunWorkerCompleted")
        ElseIf e.Cancelled Then
            ' Next, handle the case where the user canceled the 
            ' operation.
            ' Note that due to a race condition in 
            ' the DoWork event handler, the Cancelled
            ' flag may not have been set, even though
            ' CancelAsync was called.
            Me.ProgressBar1.Value = 0
            inputlines_label.Text = "Cancelled"
            lastinputline_label.Text = "Cancelled"
            datelaunched_label.Text = "Cancelled"
            statusmessage = "Operation Cancelled"
        Else
            ' Finally, handle the case where the operation succeeded.

            Status_Handler(e.Result)

            Me.ProgressBar1.Value = 100
            Me.inputlines_label.Text = inputlines
            Me.lastinputline_label.Text = lastinputline
            Me.datelaunched_label.Text = Format(datelaunched, "yyyy/MM/dd HH:mm:ss") & " - " & Format(Now, "yyyy/MM/dd HH:mm:ss") & " (" & Now.Subtract(Me.datelaunched).TotalSeconds() & " s)"
            Me.LinkLabel1.Visible = True
            statusmessage = "Operation Completed"
        End If

        Status_Handler(statusmessage)
        Controls_Enabler("stop")

    End Sub 'backgroundWorker1_RunWorkerCompleted

    Private Sub Controls_Enabler(ByVal action As String)
        Select Case action.ToLower
            Case "run"
                Me.InputDatabase_Textbox.Enabled = False
                Me.InputDatabase2_Textbox.Enabled = False
                Me.Anime_Title_Textbox.Enabled = False
                Me.Anime_Episode_Number_Textbox.Enabled = False
                Me.Anime_Watched_Textbox.Enabled = False
                Me.Anime_Length_Textbox.Enabled = False
                Me.Anime_Quality_Textbox.Enabled = False
                Me.Anime_Video_Encoding_Textbox.Enabled = False
                Me.Anime_Sound_Encoding_Textbox.Enabled = False
                Me.Anime_Language_Textbox.Enabled = False
                Me.Anime_Subtitles_Textbox.Enabled = False
                Me.Anime_File_Size_Textbox.Enabled = False
                Me.Anime_Medium_Textbox.Enabled = False
                Me.Anime_File_Type_Textbox.Enabled = False
                Me.InputTextFile_Textbox.Enabled = False
                Me.InputCategory_Textbox.Enabled = False
                Me.InputDiskNumber_Textbox.Enabled = False
                Me.Browse1_Button.Enabled = False
                Me.Browse2_Button.Enabled = False
                Me.Browse3_Button.Enabled = False

                Me.startAsyncButton.Enabled = False
                Me.LinkLabel1.Enabled = False
                ' Disable the Cancel button.
                Me.cancelAsyncButton.Enabled = True
                Exit Select
            Case "stop"
                Me.InputDatabase_Textbox.Enabled = True
                Me.InputDatabase2_Textbox.Enabled = True
                'Me.Anime_Title_Textbox.Enabled = True
                'Me.Anime_Episode_Number_Textbox.Enabled = True
                Me.Anime_Watched_Textbox.Enabled = True
                'Me.Anime_Length_Textbox.Enabled = True
                Me.Anime_Quality_Textbox.Enabled = True
                'Me.Anime_Video_Encoding_Textbox.Enabled = True
                'Me.Anime_Sound_Encoding_Textbox.Enabled = True
                Me.Anime_Language_Textbox.Enabled = True
                Me.Anime_Subtitles_Textbox.Enabled = True
                'Me.Anime_File_Size_Textbox.Enabled = True
                'Me.Anime_Medium_Textbox.Enabled = True
                'Me.Anime_File_Type_Textbox.Enabled = True
                Me.InputTextFile_Textbox.Enabled = True
                Me.InputCategory_Textbox.Enabled = True
                Me.InputDiskNumber_Textbox.Enabled = True
                Me.Browse1_Button.Enabled = True
                Me.Browse2_Button.Enabled = True
                Me.Browse3_Button.Enabled = True

                Me.startAsyncButton.Enabled = True
                Me.LinkLabel1.Enabled = True
                ' Disable the Cancel button.
                Me.cancelAsyncButton.Enabled = False
                Exit Select
            Case Else
                Me.InputDatabase_Textbox.Enabled = False
                Me.InputDatabase2_Textbox.Enabled = False
                Me.Anime_Title_Textbox.Enabled = False
                Me.Anime_Episode_Number_Textbox.Enabled = False
                Me.Anime_Watched_Textbox.Enabled = False
                Me.Anime_Length_Textbox.Enabled = False
                Me.Anime_Quality_Textbox.Enabled = False
                Me.Anime_Video_Encoding_Textbox.Enabled = False
                Me.Anime_Sound_Encoding_Textbox.Enabled = False
                Me.Anime_Language_Textbox.Enabled = False
                Me.Anime_Subtitles_Textbox.Enabled = False
                Me.Anime_File_Size_Textbox.Enabled = False
                Me.Anime_Medium_Textbox.Enabled = False
                Me.Anime_File_Type_Textbox.Enabled = False
                Me.InputTextFile_Textbox.Enabled = False
                Me.InputCategory_Textbox.Enabled = False
                Me.InputDiskNumber_Textbox.Enabled = False
                Me.Browse1_Button.Enabled = False
                Me.Browse2_Button.Enabled = False
                Me.Browse3_Button.Enabled = False

                Me.startAsyncButton.Enabled = False
                Me.LinkLabel1.Enabled = False
                ' Disable the Cancel button.
                Me.cancelAsyncButton.Enabled = True
                Exit Select
        End Select


    End Sub

    ' This event handler updates the progress bar.
    Private Sub backgroundWorker1_ProgressChanged( _
    ByVal sender As Object, ByVal e As ProgressChangedEventArgs) _
    Handles BackgroundWorker1.ProgressChanged

        Me.ProgressBar1.Value = e.ProgressPercentage
        inputlines_label.Text = inputlines
        lastinputline_label.Text = lastinputline

        datelaunched_label.Text = Format(datelaunched, "yyyy/MM/dd HH:mm:ss") & " - " & Format(Now, "yyyy/MM/dd HH:mm:ss") & " (" & Now.Subtract(Me.datelaunched).TotalSeconds() & " s)"
        Status_Handler(statusmessage)
    End Sub

    ' This is the method that does the actual work. 
    Function MainWorkerFunction( _
        ByVal input As String, _
        ByVal worker As BackgroundWorker, _
        ByVal e As DoWorkEventArgs) As String



        Dim result As String = ""






        ' Abort the operation if the user has canceled.
        ' Note that a call to CancelAsync may have set 
        ' CancellationPending to true just after the
        ' last invocation of this method exits, so this 
        ' code will not have the opportunity to set the 
        ' DoWorkEventArgs.Cancel flag to true. This means
        ' that RunWorkerCompletedEventArgs.Cancelled will
        ' not be set to true in your RunWorkerCompleted
        ' event handler. This is a race condition.
        If worker.CancellationPending Then
            e.Cancel = True
        Else
            Try

                If Me.pretestdone = False Then
                    worker.ReportProgress(0)
                    PreCount_Function()
                    Me.pretestdone = True

                End If
                statusmessage = "Parsing Input Folder"


                ' Dim filereader As StreamReader = New StreamReader(InputTextFile_Textbox.Text)
                'While filereader.Peek > -1
                Dim dinfo As DirectoryInfo = New DirectoryInfo(InputTextFile_Textbox.Text)
                Dim finfo As FileInfo
                Dim filesize As Long
                Dim filesize_string As String
                For Each finfo In dinfo.GetFiles

                
                    If worker.CancellationPending Then
                        e.Cancel = True
                        Exit For
                    Else

                        If File_Exists(finfo.FullName) Then


                            inputlines = inputlines + 1
                            ' Report progress as a percentage of the total task.
                            Dim percentComplete As Integer = 0
                            If inputlinesprecount > 0 Then
                                percentComplete = CSng(inputlines) / CSng(inputlinesprecount) * 100
                            Else
                                percentComplete = 100
                            End If

                            If percentComplete > highestPercentageReached Then
                                highestPercentageReached = percentComplete
                                worker.ReportProgress(percentComplete)
                            End If
                            
                            filesize = finfo.Length

                            filesize_string = ""
                            If filesize < 1024 Then
                                filesize_string = filesize & " bytes"
                            End If
                            If filesize < 1048576 And filesize >= 1024 Then
                                filesize = Math.Round(filesize / 1024, 2)
                                filesize_string = filesize & " KB"
                            End If
                            If filesize < 1073741824 And filesize >= 1048576 Then
                                filesize = Math.Round(filesize / 1048576, 2)
                                filesize_string = filesize & " MB"
                            End If
                            If filesize >= 1073741824 Then
                                filesize = Math.Round(filesize / 1073741824, 2)
                                filesize_string = filesize & " GB"
                            End If


                            Dim CD_Title, CD_Category, CD_Disk_Number, CD_File_Size As String
                            CD_Category = InputCategory_Textbox.Text.Replace("'", "''")
                            CD_Disk_Number = InputDiskNumber_Textbox.Text.Replace("'", "''")
                            CD_Title = finfo.Name.Replace(("." & finfo.Extension).Replace("..", "."), "").Replace("'", "''")
                            CD_File_Size = filesize_string.Replace("'", "''")
                            lastinputline = CD_Title
                            Activity_Handler("INSERT INTO File_Collection ( CD_Title, CD_Category, CD_Disk_Number, CD_File_Size ) values ('" & CD_Title & "','" & CD_Category & "','" & CD_Disk_Number & "','" & CD_File_Size & "')")
                            Activity_Handler(WorkerExecuteNonQuery("INSERT INTO File_Collection ( CD_Title, CD_Category, CD_Disk_Number, CD_File_Size ) values ('" & CD_Title & "','" & CD_Category & "','" & CD_Disk_Number & "','" & CD_File_Size & "')", 1))

                            Dim Anime_Title As String = ""
                            Dim Anime_Episode_Number As String = ""
                            Dim Anime_Watched As String = ""
                            Dim Anime_Length As String = ""
                            Dim Anime_Quality As String = ""
                            Dim Anime_Video_Encoding As String = ""
                            Dim Anime_Sound_Encoding As String = ""
                            Dim Anime_Language As String = ""
                            Dim Anime_Subtitles As String = ""
                            Dim Anime_File_Size As String = ""
                            Dim Anime_Medium As String = ""
                            Dim Anime_File_Type As String = ""
                            Dim Anime_Video_Size As String = ""

                            Anime_Watched = Anime_Watched_Textbox.Text
                            Anime_Quality = Anime_Quality_Textbox.Text
                            Anime_Language = Anime_Language_Textbox.Text
                            Anime_Subtitles = Anime_Subtitles_Textbox.Text
                            Anime_Title = finfo.Name.Replace(("." & finfo.Extension).Replace("..", "."), "").Replace("'", "''")
                            If Anime_Title.IndexOf(" - Episode") <> -1 Then
                                Dim temp As String() = Anime_Title.Split(" ")
                                Anime_Episode_Number = temp(temp.Length - 1)
                                temp = Nothing
                                Anime_Title = Anime_Title.Substring(0, Anime_Title.LastIndexOf("-")).Trim
                            End If
                            Anime_File_Size = CD_File_Size.Replace(" ", "")
                            Anime_Medium = CD_Disk_Number
                            Anime_File_Type = finfo.Extension.Replace(".", "").ToUpper
                            If My.Computer.FileSystem.FileExists((Application.StartupPath & "\results.txt").Replace("\\", "\")) = True Then
                                My.Computer.FileSystem.DeleteFile((Application.StartupPath & "\results.txt").Replace("\\", "\"), FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                            End If
                            DosShellCommand("""" & (Application.StartupPath & "\MediaInfo.exe").Replace("\\", "\") & """ """ & finfo.FullName & """ > """ & (Application.StartupPath & "\results.txt").Replace("\\", "\") & """")

                            If My.Computer.FileSystem.FileExists((Application.StartupPath & "\results.txt").Replace("\\", "\")) = True Then
                                Dim reader As StreamReader = New StreamReader((Application.StartupPath & "\results.txt").Replace("\\", "\"))
                                Dim linetoread As String
                                While reader.Peek <> -1
                                    linetoread = reader.ReadLine
                                    If linetoread.StartsWith("PlayTime") And Anime_Length = "" Then
                                        linetoread = linetoread.Remove(0, linetoread.LastIndexOf(":") + 1)
                                        Dim hr, mn, ss As String
                                        hr = "0"
                                        mn = "00"
                                        ss = "00"
                                        Dim rs As String() = linetoread.Split(" ")
                                        For Each sr As String In rs
                                            If sr.EndsWith("mn") Then
                                                mn = sr.Replace("mn", "")
                                                While mn.Length < 2
                                                    mn = "0" & mn
                                                End While
                                            End If
                                            If sr.EndsWith("s") Then
                                                ss = sr.Replace("s", "")
                                                While ss.Length < 2
                                                    ss = "0" & ss
                                                End While
                                            End If
                                            If sr.EndsWith("h") Then
                                                hr = sr.Replace("h", "")
                                            End If
                                        Next
                                        Anime_Length = hr & ":" & mn & ":" & ss
                                    End If
                                    If linetoread.StartsWith("Video #0") Then
                                        linetoread = reader.ReadLine
                                        linetoread = reader.ReadLine
                                        If linetoread.StartsWith("Codec") And Anime_Video_Encoding = "" Then
                                            linetoread = linetoread.Remove(0, linetoread.LastIndexOf(":") + 1)
                                            Anime_Video_Encoding = linetoread.Trim
                                        End If
                                    End If
                                    If linetoread.StartsWith("Audio #0") Then
                                        linetoread = reader.ReadLine
                                        linetoread = reader.ReadLine
                                        If linetoread.StartsWith("Codec") And Anime_Sound_Encoding = "" Then
                                            linetoread = linetoread.Remove(0, linetoread.LastIndexOf(":") + 1)
                                            Anime_Sound_Encoding = linetoread.Trim
                                        End If
                                    End If
                                    If linetoread.StartsWith("Width") And Anime_Video_Size = "" Then
                                        linetoread = linetoread.Remove(0, linetoread.LastIndexOf(":") + 1)
                                        Anime_Video_Size = linetoread.Trim
                                        linetoread = reader.ReadLine
                                        linetoread = reader.ReadLine
                                        linetoread = linetoread.Remove(0, linetoread.LastIndexOf(":") + 1)
                                        Anime_Video_Size = Anime_Video_Size & "x" & linetoread.Trim
                                    End If
                                End While
                                reader.DiscardBufferedData()
                                reader.Close()
                                reader = Nothing
                                My.Computer.FileSystem.DeleteFile((Application.StartupPath & "\results.txt").Replace("\\", "\"), FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                            End If
                            

                            Activity_Handler("INSERT INTO Anime ( Anime_Title, Anime_Episode_Number, Anime_Watched, Anime_Length, Anime_Quality, Anime_Video_Encoding, Anime_Sound_Encoding, Anime_Language, Anime_Subtitles, Anime_File_Size, Anime_Medium, Anime_File_Type, Anime_Video_Size ) values ('" & Anime_Title & "','" & Anime_Episode_Number & "'," & Anime_Watched & ",'" & Anime_Length & "','" & Anime_Quality & "','" & Anime_Video_Encoding & "','" & Anime_Sound_Encoding & "','" & Anime_Language & "','" & Anime_Subtitles & "','" & Anime_File_Size & "','" & Anime_Medium & "','" & Anime_File_Type & "','" & Anime_Video_Size & "')")
                            Activity_Handler(WorkerExecuteNonQuery("INSERT INTO Anime ( Anime_Title, Anime_Episode_Number, Anime_Watched, Anime_Length, Anime_Quality, Anime_Video_Encoding, Anime_Sound_Encoding, Anime_Language, Anime_Subtitles, Anime_File_Size, Anime_Medium, Anime_File_Type, Anime_Video_Size ) values ('" & Anime_Title & "','" & Anime_Episode_Number & "'," & Anime_Watched & ",'" & Anime_Length & "','" & Anime_Quality & "','" & Anime_Video_Encoding & "','" & Anime_Sound_Encoding & "','" & Anime_Language & "','" & Anime_Subtitles & "','" & Anime_File_Size & "','" & Anime_Medium & "','" & Anime_File_Type & "','" & Anime_Video_Size & "')", 2))

                        End If
                    End If
                Next
                finfo = Nothing
                dinfo = Nothing


            Catch ex As Exception
                Error_Handler(ex, "MainWorkerFunction")
            End Try
        End If

        Return result

    End Function

    Private Sub PreCount_Function()
        Try
            If Directory_Exists(InputTextFile_Textbox.Text) = True Then
                'Dim filereader As StreamReader = New StreamReader(InputTextFile_Textbox.Text)
                'While filereader.Peek > -1
                'Dim lineread As String
                'lineread = filereader.ReadLine
                'If lineread.Length > 0 Then
                Dim dinfo As DirectoryInfo = New DirectoryInfo(InputTextFile_Textbox.Text)
                inputlinesprecount = dinfo.GetFiles().Length
                dinfo = Nothing
                'End If
                '   End While
                '  filereader.Close()
            End If

        Catch ex As Exception
            Error_Handler(ex, "PreCount_Function")
        End Try
    End Sub






    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            If File_Exists((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt") = True Then
                Dim systemDirectory As String
                systemDirectory = System.Environment.SystemDirectory
                Dim finfo As FileInfo = New FileInfo((systemDirectory & "\notepad.exe").Replace("\\", "\"))
                If finfo.Exists = True Then
                    Dim apptorun As String
                    apptorun = """" & (systemDirectory & "\notepad.exe").Replace("\\", "\") & """ """ & (Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt" & """"
                    Dim procID As Integer = Shell(apptorun, AppWinStyle.NormalFocus, False)
                End If
                finfo = Nothing
            End If
        Catch ex As Exception
            Error_Handler(ex, "LinkLabel1_LinkClicked")
        End Try
    End Sub




    Protected Friend Function Get_Connection(ByVal dbselect As Integer) As OleDb.OleDbConnection
        'Standard(Security)
        '"Provider=sqloledb;Data Source=Aron1;Initial Catalog=pubs;User Id=sa;Password=asdasd;" 

        'Trusted(Connection)
        '"Provider=sqloledb;Data Source=Aron1;Initial Catalog=pubs;Integrated Security=SSPI;" 
        '(use serverName\instanceName as Data Source to use an specifik SQLServer instance, only SQLServer2000)

        'Prompt for username and password:
        'oConn.Provider = "sqloledb"
        'oConn.Properties("Prompt") = adPromptAlways
        'oConn.Open("Data Source=Aron1;Initial Catalog=pubs;")

        'Connect via an IP address:
        '"Provider=sqloledb;Data Source=190.190.200.100,1433;Network Library=DBMSSOCN;Initial Catalog=pubs;User ID=sa;Password=asdasd;" 
        '(DBMSSOCN=TCP/IP instead of Named Pipes, at the end of the Data Source is the port to use (1433 is the default))

        Dim connection_string As String
        'If dbserver.IndexOf(".") = -1 Then
        'connection_string = "Provider=sqloledb;Data Source=" & dbserver & ";Initial Catalog=" & dbtable & ";User Id=" & dbuser & ";Password=" & dbpassword & ";"
        'Else
        'connection_string = "Provider=sqloledb;Data Source=" & dbserver & ",1433;Network Library=DBMSSOCN;Initial Catalog=" & dbtable & ";User Id=" & dbuser & ";Password=" & dbpassword & ";"
        'End If
        'Dim connection_string As String = "User ID=" & dbuser & ";password=" & dbpassword & ";Data Source=" & dbserver & ";Tag with column collation when possible=False;Initial Catalog=" & dbtable & ";Use Procedure for Prepare=1;Auto Translate=True;Persist Security Info=False;Provider=""SQLOLEDB.1"";Use Encryption for Data=False;Packet Size=4096"
        Select Case dbselect
            Case 1
                connection_string = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""" & InputDatabase_Textbox.Text & """"
            Case 2
                connection_string = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""" & InputDatabase2_Textbox.Text & """"
        End Select



        Dim conn As OleDb.OleDbConnection = New OleDb.OleDbConnection(connection_string)
        Return conn
    End Function



    Public Function WorkerExecuteNonQuery(ByVal SQLstatement As String, ByVal dbselect As Integer) As String
        Dim result As String
        Try

            Dim conn As OleDb.OleDbConnection
            Try
                conn = Get_Connection(dbselect)
                conn.Open()

                Dim sql As OleDb.OleDbCommand
                sql = New OleDb.OleDbCommand
                sql.CommandText = SQLstatement
                sql.Connection = conn
                result = sql.ExecuteNonQuery().ToString & " SQL Statement Succeeded"
                sql.Dispose()

            Catch ex As Exception
                Error_Handler(ex)
                result = "0 SQL Statement Failed"
            Finally
                Try
                    conn.Close()
                Catch ex1 As Exception
                    Error_Handler(ex1)
                End Try
                conn.Dispose()
            End Try
        Catch ex As Exception
            Error_Handler(ex)
            result = "0 SQL Statement Failed"


        End Try
        Return result
    End Function



    Public Function WorkerExecuteSpecialScalar(ByVal SQLstatement As String, ByVal dbselect As Integer) As String
        Dim result As String
        Try

            Dim conn As OleDb.OleDbConnection
            Try
                conn = Get_Connection(dbselect)
                conn.Open()

                Dim sql As OleDb.OleDbCommand
                sql = New OleDb.OleDbCommand
                sql.CommandText = SQLstatement
                sql.Connection = conn
                result = sql.ExecuteScalar().ToString
                sql.Dispose()

            Catch ex As Exception
                Error_Handler(ex)
                result = "0 SQL Statement Failed"
            Finally
                Try
                    conn.Close()
                Catch ex1 As Exception
                    Error_Handler(ex1)
                End Try
                conn.Dispose()
            End Try
        Catch ex As Exception
            Error_Handler(ex)
            result = "0 SQL Statement Failed"


        End Try
        Return result
    End Function

    Private Sub Browse3_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse3_Button.Click
        Status_Handler("Selecting Input File")
        Try
            OpenFileDialog1.Filter = "Access Files|*.mdb|All Files|*.*"
            OpenFileDialog1.FileName = ""
            If File_Exists(InputDatabase2_Textbox.Text) = True Then
                OpenFileDialog1.FileName = InputDatabase2_Textbox.Text
            End If
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                InputDatabase2_Textbox.Text = OpenFileDialog1.FileName
            End If

            Anime_Medium_Textbox.Text = InputDiskNumber_Textbox.Text


        Catch ex As Exception
            Error_Handler(ex, "Browse3_Button")
        End Try
        Status_Handler("Input File Selected")
    End Sub
    Private Function DosShellCommand(ByVal AppToRun As String) As String
        Dim s As String = ""
        Try
            Dim myProcess As Process = New Process

            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.StartInfo.RedirectStandardError = True
            myProcess.Start()
            Dim sIn As StreamWriter = myProcess.StandardInput
            sIn.AutoFlush = True

            Dim sOut As StreamReader = myProcess.StandardOutput
            Dim sErr As StreamReader = myProcess.StandardError
            sIn.Write(AppToRun & _
               System.Environment.NewLine)
            sIn.Write("exit" & System.Environment.NewLine)
            s = sOut.ReadToEnd()
            If Not myProcess.HasExited Then
                myProcess.Kill()
            End If

            'MessageBox.Show("The 'dir' command window was closed at: " & myProcess.ExitTime & "." & System.Environment.NewLine & "Exit Code: " & myProcess.ExitCode)

            sIn.Close()
            sOut.Close()
            sErr.Close()
            myProcess.Close()
            'MessageBox.Show(s)
        Catch ex As Exception
            Error_Handler(ex, "DOS Shell Command")
        End Try
        Return s
    End Function
End Class

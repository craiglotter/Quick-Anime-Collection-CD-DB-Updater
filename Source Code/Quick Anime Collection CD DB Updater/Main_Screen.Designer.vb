<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Screen))
        Me.startAsyncButton = New System.Windows.Forms.Button
        Me.Status_Textbox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FullErrors_Checkbox = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Anime_Video_Size_Textbox = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Anime_File_Type_Textbox = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Anime_Medium_Textbox = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Anime_File_Size_Textbox = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Anime_Subtitles_Textbox = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Anime_Language_Textbox = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Anime_Sound_Encoding_Textbox = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Anime_Video_Encoding_Textbox = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Anime_Quality_Textbox = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label1at = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Anime_Length_Textbox = New System.Windows.Forms.TextBox
        Me.Anime_Watched_Textbox = New System.Windows.Forms.TextBox
        Me.Anime_Episode_Number_Textbox = New System.Windows.Forms.TextBox
        Me.Anime_Title_Textbox = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.InputDatabase2_Textbox = New System.Windows.Forms.TextBox
        Me.Browse3_Button = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Browse2_Button = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.InputTextFile_Textbox = New System.Windows.Forms.TextBox
        Me.InputSize_Textbox = New System.Windows.Forms.TextBox
        Me.InputDiskNumber_Textbox = New System.Windows.Forms.TextBox
        Me.InputCategory_Textbox = New System.Windows.Forms.TextBox
        Me.InputTitle_Textbox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.InputDatabase_Textbox = New System.Windows.Forms.TextBox
        Me.Browse1_Button = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.cancelAsyncButton = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lastinputline_label = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.datelaunched_label = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.inputlines_label = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'startAsyncButton
        '
        Me.startAsyncButton.Location = New System.Drawing.Point(12, 402)
        Me.startAsyncButton.Name = "startAsyncButton"
        Me.startAsyncButton.Size = New System.Drawing.Size(75, 23)
        Me.startAsyncButton.TabIndex = 15
        Me.startAsyncButton.Text = "Update"
        Me.startAsyncButton.UseVisualStyleBackColor = True
        '
        'Status_Textbox
        '
        Me.Status_Textbox.BackColor = System.Drawing.Color.Lavender
        Me.Status_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Status_Textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_Textbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Status_Textbox.Location = New System.Drawing.Point(9, 8)
        Me.Status_Textbox.Name = "Status_Textbox"
        Me.Status_Textbox.ReadOnly = True
        Me.Status_Textbox.Size = New System.Drawing.Size(599, 10)
        Me.Status_Textbox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(614, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "20070110.3"
        '
        'FullErrors_Checkbox
        '
        Me.FullErrors_Checkbox.AutoSize = True
        Me.FullErrors_Checkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullErrors_Checkbox.Location = New System.Drawing.Point(684, 8)
        Me.FullErrors_Checkbox.Name = "FullErrors_Checkbox"
        Me.FullErrors_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.FullErrors_Checkbox.TabIndex = 16
        Me.FullErrors_Checkbox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(673, 26)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Anime_Video_Size_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Anime_File_Type_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Anime_Medium_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Anime_File_Size_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Anime_Subtitles_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Anime_Language_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Anime_Sound_Encoding_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Anime_Video_Encoding_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Anime_Quality_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label1at)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Anime_Length_Textbox)
        Me.GroupBox1.Controls.Add(Me.Anime_Watched_Textbox)
        Me.GroupBox1.Controls.Add(Me.Anime_Episode_Number_Textbox)
        Me.GroupBox1.Controls.Add(Me.Anime_Title_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.InputDatabase2_Textbox)
        Me.GroupBox1.Controls.Add(Me.Browse3_Button)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Browse2_Button)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.InputTextFile_Textbox)
        Me.GroupBox1.Controls.Add(Me.InputSize_Textbox)
        Me.GroupBox1.Controls.Add(Me.InputDiskNumber_Textbox)
        Me.GroupBox1.Controls.Add(Me.InputCategory_Textbox)
        Me.GroupBox1.Controls.Add(Me.InputTitle_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.InputDatabase_Textbox)
        Me.GroupBox1.Controls.Add(Me.Browse1_Button)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(15, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 274)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(349, 249)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 13)
        Me.Label24.TabIndex = 68
        Me.Label24.Text = "Anime_Video_Size"
        '
        'Anime_Video_Size_Textbox
        '
        Me.Anime_Video_Size_Textbox.Enabled = False
        Me.Anime_Video_Size_Textbox.Location = New System.Drawing.Point(352, 226)
        Me.Anime_Video_Size_Textbox.Name = "Anime_Video_Size_Textbox"
        Me.Anime_Video_Size_Textbox.ReadOnly = True
        Me.Anime_Video_Size_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_Video_Size_Textbox.TabIndex = 67
        Me.Anime_Video_Size_Textbox.Text = "#Auto#"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(243, 249)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 13)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "Anime_File_Type"
        '
        'Anime_File_Type_Textbox
        '
        Me.Anime_File_Type_Textbox.Enabled = False
        Me.Anime_File_Type_Textbox.Location = New System.Drawing.Point(246, 226)
        Me.Anime_File_Type_Textbox.Name = "Anime_File_Type_Textbox"
        Me.Anime_File_Type_Textbox.ReadOnly = True
        Me.Anime_File_Type_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_File_Type_Textbox.TabIndex = 65
        Me.Anime_File_Type_Textbox.Text = "#Auto#"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(137, 249)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 13)
        Me.Label26.TabIndex = 64
        Me.Label26.Text = "Anime_Medium"
        '
        'Anime_Medium_Textbox
        '
        Me.Anime_Medium_Textbox.Enabled = False
        Me.Anime_Medium_Textbox.Location = New System.Drawing.Point(140, 226)
        Me.Anime_Medium_Textbox.Name = "Anime_Medium_Textbox"
        Me.Anime_Medium_Textbox.ReadOnly = True
        Me.Anime_Medium_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_Medium_Textbox.TabIndex = 63
        Me.Anime_Medium_Textbox.Text = "#Auto#"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(561, 210)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 13)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Anime_File_Size"
        '
        'Anime_File_Size_Textbox
        '
        Me.Anime_File_Size_Textbox.Enabled = False
        Me.Anime_File_Size_Textbox.Location = New System.Drawing.Point(564, 187)
        Me.Anime_File_Size_Textbox.Name = "Anime_File_Size_Textbox"
        Me.Anime_File_Size_Textbox.ReadOnly = True
        Me.Anime_File_Size_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_File_Size_Textbox.TabIndex = 61
        Me.Anime_File_Size_Textbox.Text = "#Auto#"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(455, 210)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 13)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "Anime_Subtitles"
        '
        'Anime_Subtitles_Textbox
        '
        Me.Anime_Subtitles_Textbox.BackColor = System.Drawing.SystemColors.Control
        Me.Anime_Subtitles_Textbox.Location = New System.Drawing.Point(458, 187)
        Me.Anime_Subtitles_Textbox.Name = "Anime_Subtitles_Textbox"
        Me.Anime_Subtitles_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_Subtitles_Textbox.TabIndex = 59
        Me.Anime_Subtitles_Textbox.Text = "English"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(349, 210)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 13)
        Me.Label22.TabIndex = 58
        Me.Label22.Text = "Anime_Language"
        '
        'Anime_Language_Textbox
        '
        Me.Anime_Language_Textbox.BackColor = System.Drawing.SystemColors.Control
        Me.Anime_Language_Textbox.Location = New System.Drawing.Point(352, 187)
        Me.Anime_Language_Textbox.Name = "Anime_Language_Textbox"
        Me.Anime_Language_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_Language_Textbox.TabIndex = 57
        Me.Anime_Language_Textbox.Text = "Japanese"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(243, 210)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "Sound_Encoding"
        '
        'Anime_Sound_Encoding_Textbox
        '
        Me.Anime_Sound_Encoding_Textbox.Enabled = False
        Me.Anime_Sound_Encoding_Textbox.Location = New System.Drawing.Point(246, 187)
        Me.Anime_Sound_Encoding_Textbox.Name = "Anime_Sound_Encoding_Textbox"
        Me.Anime_Sound_Encoding_Textbox.ReadOnly = True
        Me.Anime_Sound_Encoding_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_Sound_Encoding_Textbox.TabIndex = 55
        Me.Anime_Sound_Encoding_Textbox.Text = "#Auto#"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(137, 210)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 13)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Video_Encoding"
        '
        'Anime_Video_Encoding_Textbox
        '
        Me.Anime_Video_Encoding_Textbox.Enabled = False
        Me.Anime_Video_Encoding_Textbox.Location = New System.Drawing.Point(140, 187)
        Me.Anime_Video_Encoding_Textbox.Name = "Anime_Video_Encoding_Textbox"
        Me.Anime_Video_Encoding_Textbox.ReadOnly = True
        Me.Anime_Video_Encoding_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_Video_Encoding_Textbox.TabIndex = 53
        Me.Anime_Video_Encoding_Textbox.Text = "#Auto#"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(561, 171)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 13)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Anime_Quality"
        '
        'Anime_Quality_Textbox
        '
        Me.Anime_Quality_Textbox.BackColor = System.Drawing.SystemColors.Control
        Me.Anime_Quality_Textbox.Location = New System.Drawing.Point(564, 148)
        Me.Anime_Quality_Textbox.Name = "Anime_Quality_Textbox"
        Me.Anime_Quality_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_Quality_Textbox.TabIndex = 51
        Me.Anime_Quality_Textbox.Text = "High"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(455, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Anime_Length"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(349, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Anime_Watched"
        '
        'Label1at
        '
        Me.Label1at.AutoSize = True
        Me.Label1at.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1at.ForeColor = System.Drawing.Color.Black
        Me.Label1at.Location = New System.Drawing.Point(243, 171)
        Me.Label1at.Name = "Label1at"
        Me.Label1at.Size = New System.Drawing.Size(87, 13)
        Me.Label1at.TabIndex = 48
        Me.Label1at.Text = "Episode_Number"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(137, 171)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Anime_Title"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(12, 151)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Insert Field Values:"
        '
        'Anime_Length_Textbox
        '
        Me.Anime_Length_Textbox.Enabled = False
        Me.Anime_Length_Textbox.Location = New System.Drawing.Point(458, 148)
        Me.Anime_Length_Textbox.Name = "Anime_Length_Textbox"
        Me.Anime_Length_Textbox.ReadOnly = True
        Me.Anime_Length_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_Length_Textbox.TabIndex = 45
        Me.Anime_Length_Textbox.Text = "#Auto#"
        '
        'Anime_Watched_Textbox
        '
        Me.Anime_Watched_Textbox.BackColor = System.Drawing.SystemColors.Control
        Me.Anime_Watched_Textbox.Location = New System.Drawing.Point(352, 148)
        Me.Anime_Watched_Textbox.Name = "Anime_Watched_Textbox"
        Me.Anime_Watched_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_Watched_Textbox.TabIndex = 44
        Me.Anime_Watched_Textbox.Text = "0"
        '
        'Anime_Episode_Number_Textbox
        '
        Me.Anime_Episode_Number_Textbox.BackColor = System.Drawing.SystemColors.Control
        Me.Anime_Episode_Number_Textbox.Enabled = False
        Me.Anime_Episode_Number_Textbox.Location = New System.Drawing.Point(246, 148)
        Me.Anime_Episode_Number_Textbox.Name = "Anime_Episode_Number_Textbox"
        Me.Anime_Episode_Number_Textbox.ReadOnly = True
        Me.Anime_Episode_Number_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_Episode_Number_Textbox.TabIndex = 43
        Me.Anime_Episode_Number_Textbox.Text = "#Auto#"
        '
        'Anime_Title_Textbox
        '
        Me.Anime_Title_Textbox.Enabled = False
        Me.Anime_Title_Textbox.Location = New System.Drawing.Point(140, 148)
        Me.Anime_Title_Textbox.Name = "Anime_Title_Textbox"
        Me.Anime_Title_Textbox.ReadOnly = True
        Me.Anime_Title_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Anime_Title_Textbox.TabIndex = 42
        Me.Anime_Title_Textbox.Text = "#Auto#"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Anime Info Database:"
        '
        'InputDatabase2_Textbox
        '
        Me.InputDatabase2_Textbox.AllowDrop = True
        Me.InputDatabase2_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.InputDatabase2_Textbox.Location = New System.Drawing.Point(140, 121)
        Me.InputDatabase2_Textbox.Name = "InputDatabase2_Textbox"
        Me.InputDatabase2_Textbox.ReadOnly = True
        Me.InputDatabase2_Textbox.Size = New System.Drawing.Size(418, 20)
        Me.InputDatabase2_Textbox.TabIndex = 39
        '
        'Browse3_Button
        '
        Me.Browse3_Button.Location = New System.Drawing.Point(570, 119)
        Me.Browse3_Button.Name = "Browse3_Button"
        Me.Browse3_Button.Size = New System.Drawing.Size(75, 23)
        Me.Browse3_Button.TabIndex = 40
        Me.Browse3_Button.Text = "Browse"
        Me.Browse3_Button.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(455, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "CD_File_Size"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(349, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "CD_Disk_Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(248, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "CD_Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(137, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "CD_Title"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Insert Field Values:"
        '
        'Browse2_Button
        '
        Me.Browse2_Button.Location = New System.Drawing.Point(570, 20)
        Me.Browse2_Button.Name = "Browse2_Button"
        Me.Browse2_Button.Size = New System.Drawing.Size(75, 23)
        Me.Browse2_Button.TabIndex = 33
        Me.Browse2_Button.Text = "Browse"
        Me.Browse2_Button.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Input Folder:"
        '
        'InputTextFile_Textbox
        '
        Me.InputTextFile_Textbox.AllowDrop = True
        Me.InputTextFile_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.InputTextFile_Textbox.Location = New System.Drawing.Point(140, 22)
        Me.InputTextFile_Textbox.Name = "InputTextFile_Textbox"
        Me.InputTextFile_Textbox.ReadOnly = True
        Me.InputTextFile_Textbox.Size = New System.Drawing.Size(418, 20)
        Me.InputTextFile_Textbox.TabIndex = 31
        '
        'InputSize_Textbox
        '
        Me.InputSize_Textbox.Enabled = False
        Me.InputSize_Textbox.Location = New System.Drawing.Point(458, 77)
        Me.InputSize_Textbox.Name = "InputSize_Textbox"
        Me.InputSize_Textbox.ReadOnly = True
        Me.InputSize_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.InputSize_Textbox.TabIndex = 30
        Me.InputSize_Textbox.Text = "#Auto#"
        '
        'InputDiskNumber_Textbox
        '
        Me.InputDiskNumber_Textbox.BackColor = System.Drawing.SystemColors.Control
        Me.InputDiskNumber_Textbox.Location = New System.Drawing.Point(352, 77)
        Me.InputDiskNumber_Textbox.Name = "InputDiskNumber_Textbox"
        Me.InputDiskNumber_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.InputDiskNumber_Textbox.TabIndex = 29
        Me.InputDiskNumber_Textbox.Text = "#Auto#"
        '
        'InputCategory_Textbox
        '
        Me.InputCategory_Textbox.BackColor = System.Drawing.SystemColors.Control
        Me.InputCategory_Textbox.Location = New System.Drawing.Point(246, 77)
        Me.InputCategory_Textbox.Name = "InputCategory_Textbox"
        Me.InputCategory_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.InputCategory_Textbox.TabIndex = 28
        Me.InputCategory_Textbox.Text = "#Auto#"
        '
        'InputTitle_Textbox
        '
        Me.InputTitle_Textbox.Enabled = False
        Me.InputTitle_Textbox.Location = New System.Drawing.Point(140, 77)
        Me.InputTitle_Textbox.Name = "InputTitle_Textbox"
        Me.InputTitle_Textbox.ReadOnly = True
        Me.InputTitle_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.InputTitle_Textbox.TabIndex = 27
        Me.InputTitle_Textbox.Text = "#Auto#"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "CD Collection Database:"
        '
        'InputDatabase_Textbox
        '
        Me.InputDatabase_Textbox.AllowDrop = True
        Me.InputDatabase_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.InputDatabase_Textbox.Location = New System.Drawing.Point(140, 50)
        Me.InputDatabase_Textbox.Name = "InputDatabase_Textbox"
        Me.InputDatabase_Textbox.ReadOnly = True
        Me.InputDatabase_Textbox.Size = New System.Drawing.Size(418, 20)
        Me.InputDatabase_Textbox.TabIndex = 24
        '
        'Browse1_Button
        '
        Me.Browse1_Button.Location = New System.Drawing.Point(570, 48)
        Me.Browse1_Button.Name = "Browse1_Button"
        Me.Browse1_Button.Size = New System.Drawing.Size(75, 23)
        Me.Browse1_Button.TabIndex = 25
        Me.Browse1_Button.Text = "Browse"
        Me.Browse1_Button.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(197, 412)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(97, 13)
        Me.LinkLabel1.TabIndex = 40
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "[Open Activity Log]"
        Me.LinkLabel1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(300, 402)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(395, 23)
        Me.ProgressBar1.TabIndex = 39
        '
        'cancelAsyncButton
        '
        Me.cancelAsyncButton.Enabled = False
        Me.cancelAsyncButton.Location = New System.Drawing.Point(93, 402)
        Me.cancelAsyncButton.Name = "cancelAsyncButton"
        Me.cancelAsyncButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelAsyncButton.TabIndex = 38
        Me.cancelAsyncButton.Text = "Cancel"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lastinputline_label)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.datelaunched_label)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.inputlines_label)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(12, 327)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(681, 69)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operation Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(239, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Last Input File Registered:"
        '
        'lastinputline_label
        '
        Me.lastinputline_label.AutoEllipsis = True
        Me.lastinputline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lastinputline_label.Location = New System.Drawing.Point(374, 18)
        Me.lastinputline_label.Name = "lastinputline_label"
        Me.lastinputline_label.Size = New System.Drawing.Size(278, 23)
        Me.lastinputline_label.TabIndex = 20
        Me.lastinputline_label.Text = "(no result)"
        Me.lastinputline_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(15, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Operational Time:"
        '
        'datelaunched_label
        '
        Me.datelaunched_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datelaunched_label.Location = New System.Drawing.Point(166, 40)
        Me.datelaunched_label.Name = "datelaunched_label"
        Me.datelaunched_label.Size = New System.Drawing.Size(468, 23)
        Me.datelaunched_label.TabIndex = 23
        Me.datelaunched_label.Text = "(no result)"
        Me.datelaunched_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(15, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(145, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Number of Input Files Parsed:"
        '
        'inputlines_label
        '
        Me.inputlines_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inputlines_label.Location = New System.Drawing.Point(166, 18)
        Me.inputlines_label.Name = "inputlines_label"
        Me.inputlines_label.Size = New System.Drawing.Size(67, 23)
        Me.inputlines_label.TabIndex = 25
        Me.inputlines_label.Text = "(no result)"
        Me.inputlines_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.Status_Textbox)
        Me.Panel1.Controls.Add(Me.FullErrors_Checkbox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-4, 431)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 31)
        Me.Panel1.TabIndex = 42
        '
        'Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(705, 462)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cancelAsyncButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.startAsyncButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(713, 496)
        Me.MinimumSize = New System.Drawing.Size(713, 496)
        Me.Name = "Main_Screen"
        Me.Text = "Quick Anime Collection CD DB Updater"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startAsyncButton As System.Windows.Forms.Button
    Friend WithEvents Status_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FullErrors_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Browse2_Button As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InputTextFile_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents InputSize_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents InputDiskNumber_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents InputCategory_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents InputTitle_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InputDatabase_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Browse1_Button As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents cancelAsyncButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents lastinputline_label As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents datelaunched_label As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents inputlines_label As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents InputDatabase2_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Browse3_Button As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1at As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Anime_Length_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Anime_Watched_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Anime_Episode_Number_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Anime_Title_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Anime_Video_Size_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Anime_File_Type_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Anime_Medium_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Anime_File_Size_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Anime_Subtitles_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Anime_Language_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Anime_Sound_Encoding_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Anime_Video_Encoding_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Anime_Quality_Textbox As System.Windows.Forms.TextBox

End Class

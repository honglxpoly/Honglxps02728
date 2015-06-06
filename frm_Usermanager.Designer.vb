<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Usermanager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Usermanager))
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grb_Info = New System.Windows.Forms.GroupBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Startdate = New System.Windows.Forms.DateTimePicker()
        Me.btn_Refesh = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_startdate = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_terminal = New System.Windows.Forms.Label()
        Me.lbl_birthday = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Info.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Title.Font = New System.Drawing.Font("VNI-Korin", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.White
        Me.lbl_Title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(946, 67)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "THEÂM NHAÂN VIEÂN MÔÙI"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INF205___Assignment.My.Resources.Resources.male1
        Me.PictureBox1.Location = New System.Drawing.Point(44, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 471)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'grb_Info
        '
        Me.grb_Info.Controls.Add(Me.btn_Back)
        Me.grb_Info.Controls.Add(Me.DateTimePicker1)
        Me.grb_Info.Controls.Add(Me.dtp_Startdate)
        Me.grb_Info.Controls.Add(Me.btn_Refesh)
        Me.grb_Info.Controls.Add(Me.ComboBox1)
        Me.grb_Info.Controls.Add(Me.btn_Search)
        Me.grb_Info.Controls.Add(Me.btn_Delete)
        Me.grb_Info.Controls.Add(Me.TextBox5)
        Me.grb_Info.Controls.Add(Me.TextBox4)
        Me.grb_Info.Controls.Add(Me.btn_Edit)
        Me.grb_Info.Controls.Add(Me.btn_Add)
        Me.grb_Info.Controls.Add(Me.TextBox1)
        Me.grb_Info.Controls.Add(Me.lbl_startdate)
        Me.grb_Info.Controls.Add(Me.lbl_password)
        Me.grb_Info.Controls.Add(Me.lbl_username)
        Me.grb_Info.Controls.Add(Me.lbl_terminal)
        Me.grb_Info.Controls.Add(Me.lbl_birthday)
        Me.grb_Info.Controls.Add(Me.lbl_Name)
        Me.grb_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grb_Info.Font = New System.Drawing.Font("VNI-Korin", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_Info.ForeColor = System.Drawing.Color.White
        Me.grb_Info.Location = New System.Drawing.Point(328, 97)
        Me.grb_Info.Name = "grb_Info"
        Me.grb_Info.Size = New System.Drawing.Size(630, 487)
        Me.grb_Info.TabIndex = 2
        Me.grb_Info.TabStop = False
        Me.grb_Info.Text = "Nhaäp thoâng tin nhaân vieân"
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.White
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("VNI-Korin", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Back.Location = New System.Drawing.Point(458, 407)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(150, 50)
        Me.btn_Back.TabIndex = 12
        Me.btn_Back.Text = "Trôû veà"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(288, 89)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(320, 35)
        Me.DateTimePicker1.TabIndex = 2
        Me.DateTimePicker1.Value = New Date(1991, 9, 11, 0, 0, 0, 0)
        '
        'dtp_Startdate
        '
        Me.dtp_Startdate.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Startdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Startdate.Location = New System.Drawing.Point(288, 134)
        Me.dtp_Startdate.Name = "dtp_Startdate"
        Me.dtp_Startdate.Size = New System.Drawing.Size(320, 35)
        Me.dtp_Startdate.TabIndex = 3
        '
        'btn_Refesh
        '
        Me.btn_Refesh.BackColor = System.Drawing.Color.White
        Me.btn_Refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refesh.Font = New System.Drawing.Font("VNI-Korin", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Refesh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Refesh.Location = New System.Drawing.Point(247, 407)
        Me.btn_Refesh.Name = "btn_Refesh"
        Me.btn_Refesh.Size = New System.Drawing.Size(150, 50)
        Me.btn_Refesh.TabIndex = 11
        Me.btn_Refesh.Text = "Laøm môùi"
        Me.btn_Refesh.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"15F Nguyeãn Thò Minh Khai", "53C Nguyeãn Du", "11 Voõ Vaên Taàn", "47 Traàn Cao Vaân", "126 Ñieän Bieân Phuû", "227 Xoâ Vieát Ngheä Tónh", "213 Nguyeãn Vaên Cöø", "410 Leâ Hoàng Phong"})
        Me.ComboBox1.Location = New System.Drawing.Point(288, 182)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(320, 36)
        Me.ComboBox1.TabIndex = 4
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.White
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("VNI-Korin", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Search.Location = New System.Drawing.Point(45, 407)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(150, 50)
        Me.btn_Search.TabIndex = 10
        Me.btn_Search.Text = "Tìm kieám"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.White
        Me.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete.Font = New System.Drawing.Font("VNI-Korin", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Delete.Location = New System.Drawing.Point(458, 333)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(150, 50)
        Me.btn_Delete.TabIndex = 9
        Me.btn_Delete.Text = "Xoùa"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(288, 272)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox5.Size = New System.Drawing.Size(320, 35)
        Me.TextBox5.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(288, 227)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(320, 35)
        Me.TextBox4.TabIndex = 5
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.White
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Font = New System.Drawing.Font("VNI-Korin", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Edit.Location = New System.Drawing.Point(247, 333)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(150, 50)
        Me.btn_Edit.TabIndex = 8
        Me.btn_Edit.Text = "Söûa"
        Me.btn_Edit.UseVisualStyleBackColor = False
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.White
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Font = New System.Drawing.Font("VNI-Korin", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btn_Add.Location = New System.Drawing.Point(45, 333)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(150, 50)
        Me.btn_Add.TabIndex = 7
        Me.btn_Add.Text = "Theâm môùi"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(288, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 35)
        Me.TextBox1.TabIndex = 1
        '
        'lbl_startdate
        '
        Me.lbl_startdate.AutoSize = True
        Me.lbl_startdate.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_startdate.Location = New System.Drawing.Point(40, 140)
        Me.lbl_startdate.Name = "lbl_startdate"
        Me.lbl_startdate.Size = New System.Drawing.Size(239, 29)
        Me.lbl_startdate.TabIndex = 0
        Me.lbl_startdate.Text = "Ngaøy baét ñaàu laøm vieäc:"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(40, 275)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(111, 29)
        Me.lbl_password.TabIndex = 0
        Me.lbl_password.Text = "Maät khaåu:"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(40, 230)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(166, 29)
        Me.lbl_username.TabIndex = 0
        Me.lbl_username.Text = "Teân ñaêng nhaäp:"
        '
        'lbl_terminal
        '
        Me.lbl_terminal.AutoSize = True
        Me.lbl_terminal.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_terminal.Location = New System.Drawing.Point(40, 185)
        Me.lbl_terminal.Name = "lbl_terminal"
        Me.lbl_terminal.Size = New System.Drawing.Size(113, 29)
        Me.lbl_terminal.TabIndex = 0
        Me.lbl_terminal.Text = "Cöûa haøng:"
        '
        'lbl_birthday
        '
        Me.lbl_birthday.AutoSize = True
        Me.lbl_birthday.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_birthday.Location = New System.Drawing.Point(40, 95)
        Me.lbl_birthday.Name = "lbl_birthday"
        Me.lbl_birthday.Size = New System.Drawing.Size(117, 29)
        Me.lbl_birthday.TabIndex = 0
        Me.lbl_birthday.Text = "Ngaøy sinh:"
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("VNI-Korin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(40, 50)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(85, 29)
        Me.lbl_Name.TabIndex = 0
        Me.lbl_Name.Text = "Hoï teân:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frm_Usermanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 596)
        Me.ControlBox = False
        Me.Controls.Add(Me.grb_Info)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_Title)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_Usermanager"
        Me.Text = "Quản lý nhân viên"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Info.ResumeLayout(False)
        Me.grb_Info.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grb_Info As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_startdate As System.Windows.Forms.Label
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents lbl_terminal As System.Windows.Forms.Label
    Friend WithEvents lbl_birthday As System.Windows.Forms.Label
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents dtp_Startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents btn_Refesh As System.Windows.Forms.Button
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class

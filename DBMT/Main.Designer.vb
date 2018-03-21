<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnModify = New System.Windows.Forms.Button()
        Me.BtnExtra = New System.Windows.Forms.Button()
        Me.MainView = New System.Windows.Forms.TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.WindowsAuthenticationCheckBool = New System.Windows.Forms.CheckBox()
        Me.MakeConnUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LocalServerCheckBool = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Find = New System.Windows.Forms.TabPage()
        Me.Add = New System.Windows.Forms.TabPage()
        Me.Modify = New System.Windows.Forms.TabPage()
        Me.Extra = New System.Windows.Forms.TabPage()
        Me.MakeConnPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MakeConnServerName = New System.Windows.Forms.TextBox()
        Me.MakeConnServerType = New System.Windows.Forms.ComboBox()
        Me.MainView.SuspendLayout()
        Me.Home.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnHome
        '
        Me.BtnHome.FlatAppearance.BorderSize = 0
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Location = New System.Drawing.Point(-1, -1)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(150, 100)
        Me.BtnHome.TabIndex = 0
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.FlatAppearance.BorderSize = 0
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Location = New System.Drawing.Point(-1, 95)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(150, 100)
        Me.BtnFind.TabIndex = 1
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Location = New System.Drawing.Point(-1, 191)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(150, 100)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnModify
        '
        Me.BtnModify.FlatAppearance.BorderSize = 0
        Me.BtnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModify.Location = New System.Drawing.Point(-1, 288)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(150, 100)
        Me.BtnModify.TabIndex = 3
        Me.BtnModify.Text = "Modify"
        Me.BtnModify.UseVisualStyleBackColor = True
        '
        'BtnExtra
        '
        Me.BtnExtra.FlatAppearance.BorderSize = 0
        Me.BtnExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExtra.Location = New System.Drawing.Point(-1, 384)
        Me.BtnExtra.Name = "BtnExtra"
        Me.BtnExtra.Size = New System.Drawing.Size(150, 100)
        Me.BtnExtra.TabIndex = 4
        Me.BtnExtra.Text = "Extra"
        Me.BtnExtra.UseVisualStyleBackColor = True
        '
        'MainView
        '
        Me.MainView.Controls.Add(Me.Home)
        Me.MainView.Controls.Add(Me.Find)
        Me.MainView.Controls.Add(Me.Add)
        Me.MainView.Controls.Add(Me.Modify)
        Me.MainView.Controls.Add(Me.Extra)
        Me.MainView.Location = New System.Drawing.Point(146, -1)
        Me.MainView.Name = "MainView"
        Me.MainView.SelectedIndex = 0
        Me.MainView.Size = New System.Drawing.Size(842, 485)
        Me.MainView.TabIndex = 5
        '
        'Home
        '
        Me.Home.Controls.Add(Me.MakeConnServerType)
        Me.Home.Controls.Add(Me.MakeConnServerName)
        Me.Home.Controls.Add(Me.Label4)
        Me.Home.Controls.Add(Me.MakeConnPassword)
        Me.Home.Controls.Add(Me.Label3)
        Me.Home.Controls.Add(Me.WindowsAuthenticationCheckBool)
        Me.Home.Controls.Add(Me.MakeConnUsername)
        Me.Home.Controls.Add(Me.Label2)
        Me.Home.Controls.Add(Me.LocalServerCheckBool)
        Me.Home.Controls.Add(Me.Label1)
        Me.Home.Location = New System.Drawing.Point(4, 22)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(834, 459)
        Me.Home.TabIndex = 0
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'WindowsAuthenticationCheckBool
        '
        Me.WindowsAuthenticationCheckBool.AutoSize = True
        Me.WindowsAuthenticationCheckBool.Location = New System.Drawing.Point(329, 101)
        Me.WindowsAuthenticationCheckBool.Name = "WindowsAuthenticationCheckBool"
        Me.WindowsAuthenticationCheckBool.Size = New System.Drawing.Size(141, 17)
        Me.WindowsAuthenticationCheckBool.TabIndex = 6
        Me.WindowsAuthenticationCheckBool.Text = "Windows Authentication"
        Me.WindowsAuthenticationCheckBool.UseVisualStyleBackColor = True
        '
        'MakeConnUsername
        '
        Me.MakeConnUsername.Location = New System.Drawing.Point(85, 99)
        Me.MakeConnUsername.Name = "MakeConnUsername"
        Me.MakeConnUsername.Size = New System.Drawing.Size(212, 20)
        Me.MakeConnUsername.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'LocalServerCheckBool
        '
        Me.LocalServerCheckBool.AutoSize = True
        Me.LocalServerCheckBool.Location = New System.Drawing.Point(329, 21)
        Me.LocalServerCheckBool.Name = "LocalServerCheckBool"
        Me.LocalServerCheckBool.Size = New System.Drawing.Size(52, 17)
        Me.LocalServerCheckBool.TabIndex = 1
        Me.LocalServerCheckBool.Text = "Local"
        Me.LocalServerCheckBool.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server type"
        '
        'Find
        '
        Me.Find.Location = New System.Drawing.Point(4, 22)
        Me.Find.Name = "Find"
        Me.Find.Size = New System.Drawing.Size(834, 459)
        Me.Find.TabIndex = 1
        Me.Find.Text = "Find"
        Me.Find.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(4, 22)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(834, 459)
        Me.Add.TabIndex = 2
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Modify
        '
        Me.Modify.Location = New System.Drawing.Point(4, 22)
        Me.Modify.Name = "Modify"
        Me.Modify.Size = New System.Drawing.Size(834, 459)
        Me.Modify.TabIndex = 3
        Me.Modify.Text = "Modify"
        Me.Modify.UseVisualStyleBackColor = True
        '
        'Extra
        '
        Me.Extra.Location = New System.Drawing.Point(4, 22)
        Me.Extra.Name = "Extra"
        Me.Extra.Size = New System.Drawing.Size(834, 459)
        Me.Extra.TabIndex = 4
        Me.Extra.Text = "Extra"
        Me.Extra.UseVisualStyleBackColor = True
        '
        'MakeConnPassword
        '
        Me.MakeConnPassword.Location = New System.Drawing.Point(85, 125)
        Me.MakeConnPassword.Name = "MakeConnPassword"
        Me.MakeConnPassword.Size = New System.Drawing.Size(212, 20)
        Me.MakeConnPassword.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Server name"
        '
        'MakeConnServerName
        '
        Me.MakeConnServerName.Location = New System.Drawing.Point(85, 45)
        Me.MakeConnServerName.Name = "MakeConnServerName"
        Me.MakeConnServerName.Size = New System.Drawing.Size(212, 20)
        Me.MakeConnServerName.TabIndex = 10
        '
        'MakeConnServerType
        '
        Me.MakeConnServerType.Items.AddRange(New Object() {"MS SQL EXPRESS"})
        Me.MakeConnServerType.Location = New System.Drawing.Point(85, 18)
        Me.MakeConnServerType.Name = "MakeConnServerType"
        Me.MakeConnServerType.Size = New System.Drawing.Size(212, 21)
        Me.MakeConnServerType.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 481)
        Me.Controls.Add(Me.MainView)
        Me.Controls.Add(Me.BtnExtra)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnFind)
        Me.Controls.Add(Me.BtnHome)
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "DataBase Manager Tool"
        Me.MainView.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        Me.Home.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnFind As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnModify As Button
    Friend WithEvents BtnExtra As Button
    Friend WithEvents MainView As TabControl
    Friend WithEvents Home As TabPage
    Friend WithEvents Find As TabPage
    Friend WithEvents Add As TabPage
    Friend WithEvents Modify As TabPage
    Friend WithEvents Extra As TabPage
    Friend WithEvents LocalServerCheckBool As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WindowsAuthenticationCheckBool As CheckBox
    Friend WithEvents MakeConnUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MakeConnPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MakeConnServerType As ComboBox
    Friend WithEvents MakeConnServerName As TextBox
End Class

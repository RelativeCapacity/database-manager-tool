Imports System.Data.SqlClient

Public Class Main

    Public CONNECTION As SqlConnection

    ' Lines below allows the user to use the 'navigation panel' by using the buttons to open the corresponding tab

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        MainView.SelectTab(0)
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        MainView.SelectTab(1)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        MainView.SelectTab(2)
    End Sub

    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles BtnModify.Click
        MainView.SelectTab(3)
    End Sub

    Private Sub BtnExtra_Click(sender As Object, e As EventArgs) Handles BtnExtra.Click
        MainView.SelectTab(4)
    End Sub

    ' If connection is on a local server, it will be automatically filled in; Similar for user and password, af if it is used by Windows Authentication (not required)

    Private Sub LocalServerCheckBool_CheckedChanged(sender As Object, e As EventArgs) Handles LocalServerCheckBool.CheckedChanged
        If LocalServerCheckBool.Checked = True Then
            MakeConnServerName.Enabled = False

            ' If it is Microsot SQL Server Express as used for this project, it will autofill the servername, although in later releases it may be widely available of other
            ' database engine types.

            If MakeConnServerType.Text = "MS SQL EXPRESS" Then
                Dim ServerName As String = Environment.MachineName.ToUpper.ToString & "\" & "SQLEXPRESS"
                MakeConnServerName.Text = ServerName
            End If

            MakeConnServerType.Enabled = False
        Else
            MakeConnServerType.Enabled = True
            MakeConnServerName.Enabled = True
        End If
    End Sub

    Private Sub WindowsAuthenticationCheckBool_CheckedChanged(sender As Object, e As EventArgs) Handles WindowsAuthenticationCheckBool.CheckedChanged
        If WindowsAuthenticationCheckBool.Checked = True Then
            MakeConnUsername.Enabled = False
            MakeConnPassword.Enabled = False
        Else
            MakeConnUsername.Enabled = True
            MakeConnPassword.Enabled = True
        End If
    End Sub

    ' Upon clicking "Connect" start the connection to the database from the entered details

    Public ConnEstablished As Boolean = False ' By default, when program starts there are no open connections

    Private Sub MakeConnBtn_Click(sender As Object, e As EventArgs) Handles MakeConnBtn.Click
        Try
            Dim ConnInfo As New ConnectionInformation(MakeConnServerType,
                                                      MakeConnServerName,
                                                      MakeConnDatabase,
                                                      WindowsAuthenticationCheckBool,
                                                      MakeConnUsername,
                                                      MakeConnPassword)

            Dim ConnectionString As String = "Data Source=" & ConnInfo.NameOfServer & ";Initial Catalog=" & ConnInfo.Database

            If ConnInfo.WindowsAuthentication = True Then
                ConnectionString &= ";Integrated Security=SSPI;"
            Else
                ConnectionString &= ";User ID=" & ConnInfo.Username & ";Password=" & ConnInfo.Password & ";"
            End If

            CONNECTION = New SqlConnection(ConnectionString)

            CONNECTION.Open()
            ConnEstablished = True
        Catch ex As SqlException
            MsgBox(ex.Errors(0).ToString)
        End Try
    End Sub

    ' A database connection informnation collection dedicated class

    Public Class ConnectionInformation

        Inherits DBMT.Main

        Public Type As String
        Public NameOfServer As String ' Name <- Conflicts with another variable declared whilst creating a project

        Public WindowsAuthentication As Boolean
        Public Username As String
        Public Password As String

        Public Database As String

        Sub New(ByVal _Type,
                ByVal _Name,
                ByVal _Database,
                ByVal _WinAuth,
                ByRef _Username,
                ByRef _Password)

            Type = _Type.Text
            NameOfServer = _Name.Text
            Database = _Database.Text

            If _WinAuth.Checked = True Then
                WindowsAuthentication = True
            Else
                WindowsAuthentication = False

                _Username.Text = "WINDOWS AUTHENTICATION METHOD ENDORSED"
                _Password.Text = "WINDOWS AUTHENTICATION METHOD ENDORSED"
            End If

            If WindowsAuthentication = False Then
                Username = _Username.Text
                Password = _Password.Text
            End If
        End Sub
    End Class

    ' Events upon the application exiting, achieved by closing the main form

    Private Sub Main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' Connection must be closed to maintain server security and the load on the server
        Try
            CONNECTION.Close()
        Catch ex As Exception
        End Try
    End Sub

End Class
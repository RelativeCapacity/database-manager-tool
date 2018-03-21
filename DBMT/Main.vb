Public Class Main

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
        Else
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
End Class
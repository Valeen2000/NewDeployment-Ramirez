Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       

        If My.Settings.AppStat = "Trial Version" Then


            If My.Settings.LoadCount < 0 Then
                Form2.ShowDialog()
            End If
            Me.Text = My.Settings.AppStat & " : Count = > " &
            My.Settings.LoadCount
            My.Settings.LoadCount -= 1
            My.Settings.Save()

            Else
            Me.Text = My.Settings.AppStat
        End If


    End Sub
End Class

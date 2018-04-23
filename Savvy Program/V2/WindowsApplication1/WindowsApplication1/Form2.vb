Public Class Form2

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form4.Hide()



    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'BUTTON1 "TRY SOME EXAMPLES"' 
        'SHOW FORM3 AS DIALOG 
        Form3.ShowDialog()

      


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'BUTTON2 "BACK"'
        'Bring up From4

        Form4.Show()
        'HIDE FORM2 AS ME 
        Me.Hide()

    End Sub
End Class
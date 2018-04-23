Public Class Form1

    Private Sub PictureBox9_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseDown
        'TERMS MOUSE DOWN EVENTS 
        'Animatuion

        PictureBox9.Hide()
        PictureBox11.Show()
        PictureBox11.BringToFront()








    End Sub

    Private Sub PictureBox9_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseUp
        'TERMS MOUSE UP EVENTS 
        'Animation 

        PictureBox11.Hide()
        PictureBox9.Show()
        PictureBox9.BringToFront()

        'Show Terms main menu

        Terms_main_menu.ShowDialog()


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MAIN FORM PROPORTIES 
        'Set form size and autoscroll 


        Me.Size = New System.Drawing.Size(1029, 622)
        Me.AutoScroll = True

        'Hide picturebox buttons

        PictureBox11.Hide()


    End Sub

    Private Sub TermsAndFactorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TermsAndFactorsToolStripMenuItem.Click
        'TOOL STRIP 
        'Terms and factors show 

        Terms_main_menu.ShowDialog()

    End Sub
End Class

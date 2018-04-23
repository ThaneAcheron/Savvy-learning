Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MAIN FORM++ 
        'MAIN FOURM PROPORTIES AND GLITCH FIXES'
        'hide unused elements , Close previous Window "form2"'


        Form4.Hide()
        Form2.Hide()
        Button2.Hide()
        Button3.Hide()

        'show button1 to fix glitch Start glitch'

        Button1.Show()

        'Set All varibles to 0'

        ProgressBar1.Value = 0
        TextBox1.Text = ""
        Markinglabel.Text = ""

        'Wipe previous answer' 

        Label9.Text = ""
        Label10.Hide()




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'BUTTON #2 "continue'

        'Wipe previous answer' 

        Label9.Text = ""
        Label10.Hide()

        'Since Program is running on progressbar1 +5 to progress.bar1'

        ProgressBar1.Value = ProgressBar1.Value + 5

        'hide/show interface elements' 

        Button1.Show()
        Button2.Hide()
        'Retry'
        Button3.Hide()

        'Empty Textbox1 , marking label'

        TextBox1.Text = ""
        Markinglabel.Text = ""

        '!!!DISPLAY NEW QUESTIONS!!! on the value of progressbar1' 

        If ProgressBar1.Value = 5 Then
            Button1.Show()
            Label5.Text = "a - 2"
            Label8.Hide()
            Label7.Hide()
            Button2.Hide()

        End If

        If ProgressBar1.Value = 10 Then
            Label8.Hide()
            Label7.Hide()
            Label5.Text = "Y"
        End If

        If ProgressBar1.Value = 15 Then
            Label5.Text = "X + Y"
        End If




    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'BUTTON # 3 "Try Again 

        'show/Hide button button 1,2,3' 

        Button1.Show()
        Button2.Hide()
        Button3.Hide()



        'Show previous answer
        Label9.Text = TextBox1.Text
        Label10.Show()

        'empty textbox1 
        TextBox1.Text = ""

        'set marking label to "" 
        Markinglabel.Text = ""



    End Sub


    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'BUTTON # 1 "Next"' 
        'Question Marker'

        'Wipe previous answer' 

        Label9.Text = ""
        Label10.Hide()

        'Set proporties for correct/incorect labels with double If statment For 20 Questions' 

        If ProgressBar1.Value = 0 Then
            If TextBox1.Text = "2" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
                Button3.Hide()

            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'
                Button1.Hide()
                Button2.Show()
                Button3.Show()



            End If

        End If


        If ProgressBar1.Value = 5 Then
            If TextBox1.Text = "1" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()


            End If

        End If

        If ProgressBar1.Value = 10 Then
            If TextBox1.Text = "3" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()


            End If
        End If

        If ProgressBar1.Value = 15 Then
            If TextBox1.Text = "1" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()

            End If
        End If

        If ProgressBar1.Value = 20 Then
            If TextBox1.Text = "1" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()

               

            End If
        End If

        If ProgressBar1.Value = 25 Then
            If TextBox1.Text = "2" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()

               

            End If
        End If

        If ProgressBar1.Value = 30 Then
            If TextBox1.Text = "1" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()

              

            End If
        End If

        If ProgressBar1.Value = 35 Then
            If TextBox1.Text = "1" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()

              
            End If
        End If

        If ProgressBar1.Value = 40 Then
            If TextBox1.Text = "2" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()

               
            End If
        End If
        If ProgressBar1.Value = 45 Then
            If TextBox1.Text = "1" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()


            End If
        End If

        If ProgressBar1.Value = 50 Then
            If TextBox1.Text = "3" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()


            End If
        End If

        If ProgressBar1.Value = 55 Then
            If TextBox1.Text = "4" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()


            End If
        End If
        If ProgressBar1.Value = 60 Then
            If TextBox1.Text = "3" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()


            End If
        End If

        If ProgressBar1.Value = 65 Then
            If TextBox1.Text = "1" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()

               

            End If
        End If

        If ProgressBar1.Value = 70 Then
            If TextBox1.Text = "3" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()


            End If
        End If

        If ProgressBar1.Value = 75 Then
            If TextBox1.Text = "3" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()


            End If
        End If

        If ProgressBar1.Value = 80 Then
            If TextBox1.Text = "3" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()

               

            End If
        End If
        If ProgressBar1.Value = 85 Then
            If TextBox1.Text = "1" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()

             
            End If
        End If
        If ProgressBar1.Value = 90 Then
            If TextBox1.Text = "4" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()

              
            End If
        End If

        If ProgressBar1.Value = 95 Then
            If TextBox1.Text = "4" Then
                Markinglabel.Text = "correct"

                'Show/hide elements' 

                Button1.Hide()
                Button2.Show()
            Else
                'Show incorrect 

                Markinglabel.Text = "incorrect"

                'Else show Retry/continue/next button'
                'Re-try answer code'

                Button1.Hide()
                Button2.Show()
                Button3.Show()

            End If
        End If


    End Sub
End Class
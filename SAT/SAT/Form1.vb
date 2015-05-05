Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Idle.mp4"


    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        ProgressBar2.Increment(20)

        If AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Idle.mp4" Then
            PictureBox1.Visible = True
            Timer2.Enabled = True
            AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Right Auto.mp4"

        End If


    End Sub






    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseEnter
        ProgressBar2.Increment(20)
        If AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Idle.mp4" Then
            PictureBox1.Visible = True
            Timer2.Enabled = True
            AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Right Auto.mp4"

        End If


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Or AxWindowsMediaPlayer1.URL = "" Then
            PictureBox1.Visible = True
            Timer2.Enabled = True

            AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Idle.mp4"
        ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsWaiting Or AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsBuffering Then
            TextBox1.Text = TextBox1.Text & "hh"
        End If



    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(1)
        PictureBox1.Visible = True


        If ProgressBar1.Value = ProgressBar1.Maximum Then
            PictureBox1.Visible = False
            Timer2.Enabled = False
            ProgressBar1.Value = 0

        End If

    End Sub

    Private Sub Form1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        If AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Right Auto.mp4" Or AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Left.mp4" Then
            PictureBox1.Visible = True
            Timer2.Enabled = True
            AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Idle.mp4"

        End If
    End Sub
    Dim opt As MsgBoxResult
    Dim pn As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Visible = True

        RichTextBox1.Text = TextBox1.Text
        AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Speak.mp4"
        Timer2.Enabled = True
        Timer5.Enabled = True
        If RichTextBox1.Find("hi", RichTextBoxFinds.NoHighlight) >= 0 Or RichTextBox1.Find("hello", RichTextBoxFinds.NoHighlight) >= 0 Or RichTextBox1.Find("salut", RichTextBoxFinds.NoHighlight) >= 0 Then

            Label4.Text = "Hello Sir,How may I help you , Sir ?"
            Timer4.Enabled = True
Linea:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\how can i help you sir.mp3"

                ProgressBar3.Value = 100

            Else : GoTo Linea

            End If

        ElseIf RichTextBox1.Find("when", RichTextBoxFinds.NoHighlight) >= 0 Then
            PictureBox1.Visible = True

            RichTextBox1.Text = TextBox1.Text
            AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira When.mp4"
            Timer4.Enabled = True
lineb:
            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\whenm.mp3"

                ProgressBar3.Value = 100

            Else

                GoTo lineb


            End If

            Timer2.Enabled = True

            Label4.Text = "May be now !,But sorry sir,I don't have any firm idea about it.I'll forward your question to the Office.Can you give me your contact number so that We can call you to answer ?"
            If MsgBox("Do you wish to give your contact number ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                pn = InputBox("Ira :Please Type Your Phone Number Sir.", "Ira")
                Timer4.Enabled = True
linec:

                If ProgressBar3.Value = ProgressBar3.Maximum Then
                    AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Please Type Your Phone Number Sir (2).mp3"

                    ProgressBar3.Value = 100

                Else : GoTo linec

                End If
                TextBox1.Text = pn
                PictureBox1.Visible = True

                RichTextBox1.Text = TextBox1.Text
                AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Answer.mp4"
                Timer2.Enabled = True
                Timer4.Enabled = True
line1:

                If ProgressBar3.Value = ProgressBar3.Maximum Then
                    AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Thank You, Sir.mp3"

                    ProgressBar3.Value = 100

                Else
                    GoTo line1
                End If

                Label4.Text = "Thank You, Sir"
            End If
        ElseIf RichTextBox1.Find("when will test start", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
line2:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Soon Sir,Please wait while Invigilator Arrives.mp3"

                ProgressBar3.Value = 100
            Else
                GoTo line2


            End If
            Label4.Text = "Soon Sir,Please wait while Invigilator Arrives."

        ElseIf RichTextBox1.Find("what is your name", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
line3:


            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\My name is Ira, Sir. Intelligent Responsive Agent.mp3"

                ProgressBar3.Value = 100

            Else
                GoTo line3

            End If
            Label4.Text = "My name is Ira, Sir. Intelligent Responsive Agent."

        ElseIf RichTextBox1.Find("hobbies", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
line4:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\hobbies.mp3"

                ProgressBar3.Value = 100
            Else
                GoTo line4



            End If
            Label4.Text = "I like to Chat, I like to assist people like you and to solve queries."
        ElseIf RichTextBox1.Find("birthday", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
5:
            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\April 8th,2013, Sir.mp3"

                ProgressBar3.Value = 100
            Else

                GoTo 5

            End If
            Label4.Text = "April 8th,2013, Sir"
        ElseIf RichTextBox1.Find("girlfriend", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
6:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\I am a Virtual Agent, I can't be like that !.mp3"

                ProgressBar3.Value = 100
            Else
                GoTo 6



            End If
            Label4.Text = "I am a Virtual Agent, I can't be like that ! "
        ElseIf RichTextBox1.Find("boyfriend", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
7:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\I am a Virtual Agent, I can't be like that !.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 7


            End If
            Label4.Text = "I am a Virtual Agent, I can't be like that"
        ElseIf RichTextBox1.Find("made", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
8:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\I was made.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 8


            End If
            Label4.Text = "I was made by Sir Frances Van Andel and I respect him."
        ElseIf RichTextBox1.Find("call invigilator", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
9:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Yes Sir, I've called the Invigilator.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 9


            End If
            Label4.Text = "Yes Sir, I've called the Invigilator"

        ElseIf RichTextBox1.Find("friend", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
10:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\I love to make friends. I am your friend too, Sir.mp3"

                ProgressBar3.Value = 100
            Else : GoTo 10



            End If
            Label4.Text = "I love to make friends. I am your friend too, Sir"
        ElseIf RichTextBox1.Find("fuck", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
11:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Oh ! Please be calm sir, Don't use such language !.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 11


            End If
            Label4.Text = "Oh ! Please be calm sir, Don't use such language !"
        ElseIf RichTextBox1.Find("bitch", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
12:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\vulgar.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 12

            End If
            Label4.Text = "Oh ! I hate vulgar people."
        ElseIf RichTextBox1.Find("job", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
13:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\I am an Intelligent Responsive Agent.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 13


            End If
            Label4.Text = "I am an Intelligent Responsive Agent."
        ElseIf RichTextBox1.Find("do", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
14:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\My work.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 14


            End If
            Label4.Text = "My work is to answer queries and assist people, and I am doing that."
        ElseIf RichTextBox1.Find("hardwork", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
15:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Hard Work.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 15


            End If
            Label4.Text = "Hard Work is no doubt, key to success.I too like hard-working people."
        ElseIf RichTextBox1.Find("sleep", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
16:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Hehe! I don't sleep.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 16

            End If
            Label4.Text = "Hehe! I don't sleep. May be you need it Sir ?"
        ElseIf RichTextBox1.Find("talk", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
17:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\I am talking to you Sir.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 17


            End If
            Label4.Text = "I am talking to you Sir"
        ElseIf RichTextBox1.Find("come", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
18:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\I can't come to you but I can answer your queries.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 18


            End If
            Label4.Text = "I can't come to you but I can answer your queries"
        ElseIf RichTextBox1.Find("Dance", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
19:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\hehe ! I can't.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 19


            End If
            Label4.Text = "hehe ! I can't."
        ElseIf RichTextBox1.Find("Sing", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
20:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\I don't Sing at all.mp3"

                ProgressBar3.Value = 100

            Else : GoTo 20


            End If
            Label4.Text = "I don't Sing at all !,May be you Sir ?"
        ElseIf RichTextBox1.Find("shout", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
21:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\not now.mp3"


                ProgressBar3.Value = 100
            Else : GoTo 21


            End If
            Label4.Text = "Not Now Sir !, I listen and respond."
        ElseIf RichTextBox1.Find("close", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
22:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Press the cross button on top right, Sir.mp3"

                ProgressBar3.Value = 100


            Else : GoTo 22

            End If
            Label4.Text = "Press the cross button on top right, Sir"
        ElseIf RichTextBox1.Find("how are you", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
            Label4.Text = "I am fine, Sir. How are you ?"
        ElseIf RichTextBox1.Find("am fine", RichTextBoxFinds.NoHighlight) >= 0 Then
            Timer4.Enabled = True
            Label4.Text = "That's Nice."

        Else
            Timer4.Enabled = True
23:

            If ProgressBar3.Value = ProgressBar3.Maximum Then
                AxWindowsMediaPlayer2.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\I couldn't get you Sir.mp3"

                ProgressBar3.Value = 100
            Else : GoTo 23



            End If
            Label4.Text = "I couldn't get you Sir.May be changing the words help."

        End If

    End Sub


    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub



    Private Sub Form1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        PictureBox1.Visible = True
        Timer2.Enabled = True

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        ProgressBar2.Increment(20)
        If AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Idle.mp4" Or AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Right Auto.mp4" Then
            PictureBox1.Visible = True
            Timer2.Enabled = True
            AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Left.mp4"

        End If


    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If ProgressBar2.Value = ProgressBar2.Maximum And Label4.Text = "" Then
            ProgressBar2.Value = 0
            PictureBox1.Visible = True
            Timer2.Enabled = True
            AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira ReadAct.mp4"
            Label4.Text = "Eh !,Playing a Direction Game with me !"

        End If
    End Sub

    Private Sub Label6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label6.MouseMove
        If AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Idle.mp4" Or AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira ReadAct.mp4" Or AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Right Auto.mp4" Then
            PictureBox1.Visible = True
            Timer2.Enabled = True
            AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Left.mp4"

        End If

    End Sub

    Private Sub TextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter
        ProgressBar2.Increment(20)
        If AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Idle.mp4" Then
            PictureBox1.Visible = True
            Timer2.Enabled = True
            AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Right Auto.mp4"

        End If

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick


        ProgressBar3.Increment(20)
        If ProgressBar3.Value = ProgressBar3.Maximum Then
            Timer4.Enabled = False

        End If

    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        ProgressBar4.Increment(20)
        If ProgressBar4.Value = ProgressBar4.Maximum Then
            Timer5.Enabled = False
            PictureBox1.Visible = True
            AxWindowsMediaPlayer1.URL = ""

            ProgressBar4.Value = 0
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If InputBox("Enter Your SUMMER COURSE Username") = "AUS172" Then

            Me.Visible = False
            Form2.Visible = True

        End If

    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If AxWindowsMediaPlayer2.playState = WMPLib.WMPPlayState.wmppsStopped And AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Speak.mp4" Then
            PictureBox1.Visible = True
            Timer2.Enabled = True
            AxWindowsMediaPlayer1.URL = "C:\Users\Abhinandan\Documents\Visual Studio 2012\Projects\SAT\SAT\Resources\iRA\Ira Idle.mp4"

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class

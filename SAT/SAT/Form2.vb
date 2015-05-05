Public Class Form2
    Dim q As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer6.Enabled = False
        PictureBox1.Visible = True
        AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Answer.mp4"
        Timer2.Enabled = True
        q = LCase(RichTextBox1.Text)

        If RichTextBox1.Find("hi", RichTextBoxFinds.NoHighlight) >= 0 Or RichTextBox1.Find("hello", RichTextBoxFinds.NoHighlight) >= 0 Or RichTextBox1.Find("salut", RichTextBoxFinds.NoHighlight) >= 0 Then

            Label1.Text = "Hello Sir,How may I help you , Sir ?"


        ElseIf RichTextBox1.Find("when", RichTextBoxFinds.NoHighlight) >= 0 Then
            PictureBox1.Visible = True


            AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira When.mp4"
           
            Timer2.Enabled = True

            Label1.Text = "May be now !,But sorry sir,I don't have any firm idea about it.I'll forward your question to the Office.Can you give me your contact number so that We can call you to answer ?"
            Dim pn As String
            If MsgBox("Do you wish to give your contact number ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                pn = InputBox("Ira :Please Type Your Phone Number Sir.", "Ira")


                RichTextBox1.Text = pn
                PictureBox1.Visible = True


                AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Speak.mp4"
                Timer2.Enabled = True



                Label1.Text = "Thank You, Sir"
            End If
        ElseIf RichTextBox1.Find("when will test start", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "Soon Sir,Please wait while Invigilator Arrives."

        ElseIf RichTextBox1.Find("what is your name", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "My name is Ira, Sir. Intelligent Responsive Agent."

        ElseIf RichTextBox1.Find("hobbies", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I like to Chat, I like to assist people like you and to solve queries."
        ElseIf RichTextBox1.Find("birthday", RichTextBoxFinds.NoHighlight) >= 0 Then

            Label1.Text = "April 8th,2013, Sir"
        ElseIf RichTextBox1.Find("girlfriend", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I am a Virtual Agent, I can't be like that ! "
        ElseIf RichTextBox1.Find("boyfriend", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I am a Virtual Agent, I can't be like that"
        ElseIf RichTextBox1.Find("made", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I was made by Sir Frances Van Andel and I respect him."
        ElseIf RichTextBox1.Find("call", RichTextBoxFinds.NoHighlight) >= 0 Then
            PictureBox1.Visible = True
            AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Call Invigilator.mp4"
            Timer2.Enabled = True

            Label1.Text = "Yes Sir, I've called the Invigilator"
            SerialPort1.Open()
            SerialPort1.Close()


        ElseIf RichTextBox1.Find("friend", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I love to make friends. I am your friend too, Sir"
        ElseIf RichTextBox1.Find("fuck", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "Oh ! Please be calm sir, Don't use such language !"
        ElseIf RichTextBox1.Find("bitch", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "Oh ! I hate vulgar people."
        ElseIf RichTextBox1.Find("job", RichTextBoxFinds.NoHighlight) >= 0 Or RichTextBox1.Find("do", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I am an Intelligent Responsive Agent."
        ElseIf RichTextBox1.Find("do", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "My work is to answer queries and assist people, and I am doing that."
        ElseIf RichTextBox1.Find("hardwork", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "Hard Work is no doubt, key to success.I too like hard-working people."
        ElseIf RichTextBox1.Find("sleep", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "Hehe! I don't sleep. May be you need it Sir ?"
        ElseIf RichTextBox1.Find("talk", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I am talking to you Sir"
        ElseIf RichTextBox1.Find("come", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I can't come to you but I can answer your queries"
        ElseIf RichTextBox1.Find("Dance", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "hehe ! I can't."
        ElseIf RichTextBox1.Find("Sing", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I don't Sing at all !,May be you Sir ?"
        ElseIf RichTextBox1.Find("shout", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "Not Now Sir !, I listen and respond."
        ElseIf RichTextBox1.Find("close", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "Press the cross button on top right, Sir"
        ElseIf RichTextBox1.Find("how are you", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I am fine, Sir. Hope the same for you. How's the test going ?"
        ElseIf RichTextBox1.Find("what are you doing", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I am watching you giving the test, Sir. Any Queries ?"
        ElseIf RichTextBox1.Find("yes", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "Please tell me your queries, Sir."
        ElseIf RichTextBox1.Find("No", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "I am here to help you out any-time during the test, Sir."
        ElseIf RichTextBox1.Find("time", RichTextBoxFinds.NoHighlight) >= 0 Then


            Label1.Text = "Please see the timer on Top-Right of the Test Panel. Be aware of the time left. It would be nice if you complete the test within time, Sir."
        ElseIf RichTextBox1.Find("bor", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "There's nothing to get bored. Be a little bit Intuitive !"
        ElseIf RichTextBox1.Find("tough", RichTextBoxFinds.NoHighlight) >= 0 Or RichTextBox1.Find("difficult", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "There's nothing tough or difficult, Sir. We make them easy or tough. Be confident !"
        ElseIf RichTextBox1.Find("leave", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "You can always leave after submitting the test report, Sir."
        ElseIf RichTextBox1.Find("easy", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "Test is always easy, Sir."
        ElseIf RichTextBox1.Find("hindi", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "I know English and I am learning French, Sir."
        ElseIf RichTextBox1.Find("jour", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "Bon-jour Sir !"
        ElseIf RichTextBox1.Find("french", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "I am learning French, Sir."
        ElseIf RichTextBox1.Find("NFEC", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "I belong to NFEC, Sir."
        ElseIf RichTextBox1.Find("speak", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "My voice has been muted to avoid disturbances."
        ElseIf RichTextBox1.Find("queries", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "Yes, Any Queries, Sir?"
        ElseIf RichTextBox1.Find("Write Your Messages Here.", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "Hehe ! Please Write a Message Sir !"
        ElseIf RichTextBox1.Find("Q1", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "I don't find any errors, Sir. Call Invigilator for more help !"
        ElseIf RichTextBox1.Find("Q2", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "Oh! That's very easy ! Try it !"
        ElseIf RichTextBox1.Find("Q3", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "I don't find any errors, Sir Call Invigilator for more help !"
        ElseIf RichTextBox1.Find("Q4", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "Don't Confuse. Think Calmly, There are no errors."
        ElseIf RichTextBox1.Find("Q5", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "I don't find any errors, Sir."
        ElseIf RichTextBox1.Find("roll", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "Check Your roll no. on your Admit Card."
        ElseIf RichTextBox1.Find("registration", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "Check Your reg no. on your Admit Card."
        ElseIf RichTextBox1.Find("tell", RichTextBoxFinds.NoHighlight) >= 0 Then
            Label1.Text = "I can only tell the details of the test, I can't help you for the questions !"
        Else
            Label1.Text = "I couldn't get you Sir.May be changing the words help."
        End If

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Speak.mp4"

    End Sub
    Dim r As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            PictureBox1.Visible = True
            r = Math.Ceiling(Rnd() * 100)
            If Math.IEEERemainder(r, 2) = 0 Then
                AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Normal.mp4"
            Else
                AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Test see.mp4"
            End If

            timer2.enabled = True
           
        End If
       
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer2.Enabled = False
            ProgressBar1.Value = 0
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox1.Visible = True
        Timer6.Enabled = False
        AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Call Invigilator.mp4"

        Timer2.Enabled = True

        Label1.Text = "Yes Sir, I've called the Invigilator"

        SerialPort1.Open()

        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5)

        SerialPort1.Close()


    End Sub

    Dim gg As Integer = 0
    Dim hj As Integer = 0
    Dim hu As Integer = 0


    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label3.Text = Val(Label3.Text) + 1
       

        If Val(Label3.Text) >= 18 And gg <> 678 Then
            AxWindowsMediaPlayer2.URL = "F:\My Mem Card\programs\EAT\iRA\allthebest.mp3"
            gg = 678
            WebBrowser1.GoHome () 
        End If
        If Val(Label3.Text) >= 23 And hj <> 78 Then
            AxWindowsMediaPlayer2.URL = "F:\My Mem Card\programs\EAT\iRA\endtest.mp3"
            Label1.Text = "You Can Talk to me while giving the test. After You complete your test, Press the End Test Button. I'll submit your Report."
            hj = 78
        End If
        If Val(Label3.Text) >= 33 Then
            Timer3.Enabled = False
            Label3.Text = "0"
            AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Normal.mp4"
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True

        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Label4.Text = Val(Label4.Text) + 1
        If Val(Label4.Text) = 10 Then
            Label2.Text = "Press the End Test Button to Submit the test. If you have a doubt in any question, Type Q<Question Number> to Ira."
        End If
        If Val(Label4.Text) >= 60 Then
            Timer4.Enabled = False
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            Label4.Text = "0"
        End If
    End Sub
    Dim mon As Integer
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        PictureBox3.Visible = False
        PictureBox2.Visible = True

        Timer4.Enabled = True
        Label2.Text = "Yes, how may I help you ?"
        mon = Math.Ceiling(Rnd() * 100)
        If mon > 50 Then
            Label2.Text = "Acids give free H+ ions."
        ElseIf mon > 30 Then
            Label2.Text = "Decomposition rections are endothermic ,generally."
        Else
            Label2.Text = "Bile juice is used in emulsification of fats."

        End If

    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Visible = False
        PictureBox2.Visible = True

        Timer4.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Label2.Text = "Yes, how may I help you ?"
        mon = Math.Ceiling(Rnd() * 100)
        If mon > 50 Then
            Label2.Text = "Acids give free H+ ions."
        ElseIf mon > 30 Then
            Label2.Text = "Decomposition rections are endothermic ,generally."
        Else
            Label2.Text = "Bile juice is used in emulsification of fats."

        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If AxWindowsMediaPlayer2.playState = WMPLib.WMPPlayState.wmppsPlaying And (AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Normal.mp4" Or AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Idle.mp4" Or AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Test see.mp4") Then
            PictureBox1.Visible = True
            Timer2.Enabled = True
            AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Speak.mp4"
        End If
       
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If AxWindowsMediaPlayer2.playState = WMPLib.WMPPlayState.wmppsStopped And (AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Speak.mp4" Or AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira When.mp4" Or AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Speak.mp4" Or AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Answer.mp4") Then
            PictureBox1.Visible = True
            Timer2.Enabled = True
            AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Normal.mp4"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Are you Sure ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Shell("C:\Windows\system32\SnippingTool.exe")
            Label1.Text = "I've submitted your report Sir, I've also called the Invigilator."
            PictureBox1.Visible = True
            Timer6.Enabled = False
            AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Call Invigilator.mp4"

            Timer2.Enabled = True



            SerialPort1.Open()

            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(5)

            SerialPort1.Close()
            Button4.Visible = True
            TextBox1.Visible = True
            Button4.Enabled = True
            Button5.Visible = True
            Button5.Enabled = True
        End If

    End Sub
    Dim rank As Long
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        rank = Math.Ceiling(950.4132 * (90 - Val(TextBox1.Text)) + 1)
        If rank > 10 Then
            rank = rank + Math.Ceiling(Rnd() * 50)
        End If


        Label1.Text = "Your AI Rank is AIR " & rank

        PictureBox1.Visible = True
        Timer6.Enabled = False
        AxWindowsMediaPlayer1.URL = "F:\My Mem Card\programs\EAT\iRA\Ira Call Invigilator.mp4"

        Timer2.Enabled = True
        Label1.Text = "Your AI Rank is AIR " & rank
        Button4.Visible = False
        TextBox1.Visible = False
        Button3.Visible = False
        MsgBox("Please Note that the rank you see is an average of the ranks you score upto this time, since different candidates give exam at different times, this rank may vary if you check it later on.")
        MsgBox("You got " & Math.Ceiling(Val(TextBox1.Text) * 100 / 90) & " Out of 100")
        MsgBox("You got " & Math.Ceiling(Val(TextBox1.Text) * 100 / 90) & " Out of 100" & ".Rank is AIR " & rank)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If rank > 50000 Then
            MsgBox("5 Credits will be credited to your account soon !")
        ElseIf rank <= 50000 Then
            MsgBox("6 Credits will be credited to your account soon !")
        ElseIf rank <= 45000 Then
            MsgBox("7 Credits will be credited to your account soon !")
        ElseIf rank <= 40000 Then
            MsgBox("8 Credits will be credited to your account soon !")
        ElseIf rank <= 30000 Then
            MsgBox("15 Credits will be credited to your account soon !")
        ElseIf rank <= 20000 Then
            MsgBox("20 Credits will be credited to your account soon !")
        ElseIf rank <= 15000 Then
            MsgBox("30 Credits will be credited to your account soon !")
        ElseIf rank <= 10000 Then
            MsgBox("40 Credits will be credited to your account soon !")
        ElseIf rank <= 5000 Then
            MsgBox("50 Credits will be credited to your account soon !")
        ElseIf rank <= 2000 Then
            MsgBox("55 Credits will be credited to your account soon !")
        ElseIf rank <= 1000 Then
            MsgBox("60 Credits will be credited to your account soon !")
        ElseIf rank <= 500 Then
            MsgBox("70 Credits will be credited to your account soon !")
        ElseIf rank <= 100 Then
            MsgBox("100 Credits will be credited to your account soon !")
        ElseIf rank <= 10 Then
            MsgBox("500 Credits will be credited to your account soon !")
        Else
            MsgBox("No Credits Won !")


        End If
    End Sub
End Class
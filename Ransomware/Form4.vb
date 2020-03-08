Public Class Form4
    Dim RandomShit As New Random
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DesktopLocation = New Point(randomshit.next(1, 1000), randomshit.next(1, 500)) Then
            DesktopLocation = New Point(RandomShit.Next(1, 1000), RandomShit.Next(1, 500))
            DesktopLocation = New Point(RandomShit.Next(1, 2000), RandomShit.Next(1, 1000))
            DesktopLocation = New Point(RandomShit.Next(1, 2000), RandomShit.Next(1, 1000))
            DesktopLocation = New Point(RandomShit.Next(1, 3000), RandomShit.Next(1, 1000))
            DesktopLocation = New Point(RandomShit.Next(1, 3000), RandomShit.Next(1, 1000))
            DesktopLocation = New Point(RandomShit.Next(1, 4000), RandomShit.Next(1, 1000))
            DesktopLocation = New Point(RandomShit.Next(1, 4000), RandomShit.Next(1, 1000))
            DesktopLocation = New Point(RandomShit.Next(1, 5000), RandomShit.Next(1, 1000))
            DesktopLocation = New Point(RandomShit.Next(1, 5000), RandomShit.Next(1, 1000))
        Else
            DesktopLocation = New Point(randomshit.next(1, 1000), randomshit.next(1, 500))
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Show()

        MsgBox("System32.dll Error!", MsgBoxStyle.Critical)
        MsgBox("taskmgr.dll Not Found!", MsgBoxStyle.Critical)
        MsgBox("regedit.dll Error!", MsgBoxStyle.Critical)
        MsgBox("microsoft.dll Not Found!", MsgBoxStyle.Critical)
        MsgBox("dll.dll Error!", MsgBoxStyle.Critical)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Form1.Show()
        Form2.Show()
        Me.Show()
        Form4.Show()
        Form5.Show()
        Form6.Show()

        MsgBox("System32.dll Error!", MsgBoxStyle.Critical)
        MsgBox("taskmgr.dll Not Found!", MsgBoxStyle.Critical)
        MsgBox("regedit.dll Error!", MsgBoxStyle.Critical)
        MsgBox("microsoft.dll Not Found!", MsgBoxStyle.Critical)
        MsgBox("dll.dll Error!", MsgBoxStyle.Critical)
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class
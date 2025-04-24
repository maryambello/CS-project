Public Class Desktop
    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Please check and adjust it", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("It is the light that glows when the computer is turned on", "LED", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Check the System unit (CPU) if there is any light glowing", "Checking1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("If there is a LED and the computer is turned ON, but the the LED does not glow, then you are likely having problem within the system unit", "Checking2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Remove the power cable from the CPU, Open the CPU with your screwdriver, Gently remove the RAM while holding its edges, avoid toching the circuitory or chips, then clean the lower edge that is has gold color using a cotton dipped in petrol or spirit, and fix it back", "Troubleshooting1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("If it does not work, replace the RAM with another", "Toubleshooting2", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("If it still does not work, contact a technician", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Turn it OFF, Confirm if the HDD and it's connector is tightly connected to the motherboard, and turn it back ON", "Troubleshooting1")
        MessageBox.Show("If it still does not work, try installing another Operating System", "OS might be corrupted")
        MessageBox.Show("If the problem continues, then the problem root cause may be on the motherboard, contact a technician", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("It is likely that it is running slow due to incorrect setting of the time and date, press [ctrl + Alt + delete] simulteanously, and try correcting the date and time setting and restart it to check if the problem is solved.", "Why it may take long", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("If the time and date settings still remains incorrect, it means the back up battery is weak, replace it", "What it may not work2", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Suppose the date/time settings are correct but it still boots slow, try upgrading your RAM and check if your HDD memory is not almost filled, if yes free some space.", "Why it may run slow", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("If the RAM is upgraded and the HDD has enough space but still runs slow, it is possible that the operating system is affected by a malicious program, try installing another OS", "Why it may run slow", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("If problem still persist, it is likely the HDD is faulty, replace a HDD and install an OS", "What you can do", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("If the problem continues, then the problem root cause may be on the motherboard, contact a technician", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MessageBox.Show("The blue screen error writes an error code attached to the error message, to quickly identify the problem, copy the error code and run a search on it through 'GOOGLE'. Then correct the error.", "Checking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        MessageBox.Show("Otherwise, try troubleshooting by checking and replacing the RAM", "Troubleshooting1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Blue screen error can likely be caused by malfunction of the HDD, which can either mean that the OS is missing important files or HDD is faulty. diagnose the system by first installing another OS, otherwise, replace the HDD", "Troubleshoot2", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Occasionally, the backup bateery can also be source of the error, replace the backup battery if problem persist", "Troubleshoot3", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("If the problem continues, then the problem root cause may be on the motherboard, contact a technician", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub
End Class
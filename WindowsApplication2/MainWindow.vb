Public Class MainWindow
    Private Sub lblUserName_Click(sender As Object, e As EventArgs) Handles lblUserName.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userName As String = Nothing
        userName = InputBox("What is your name?", "Welcome", , , )
        lblUserName.Text = "Hello " & userName & ", what is your computer problem?"

    End Sub

    Private Sub btnFull_Click(sender As Object, e As EventArgs) Handles btnFull.Click
        Dim newForm As New Tutorial
        newForm.ShowDialog()
    End Sub



    Private Sub btbAboutMe_Click(sender As Object, e As EventArgs) Handles btbAboutMe.Click
        Dim newForm As New AboutMe
        newForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txt As String = txtsearch.Text
        txt = txt.ToLower()

        If txt = "computer not turning on" Or txt = "Computer turning on problem" Or txt = "laptop turning on problem" Or txt = "my laptop won't turn on" Or txt = "turning on problems" Or txt = "turning on problem" Or txt = "what do i  do if my computer wont turn on" Or txt = "what do i do if my computer doesnt turn on" Or txt = "what do i do if my laptop wont turn On" Or txt = "my laptop wont turn on" Then
            MessageBox.Show("You may need to check the following: 1. Check to see if the power adapter is functional so that to make sure there is power going to the system. 2. Remove the battery and fix it back to ensure that the battery is tightly connected to the motherboard. 3. Remove and RAM, clean it and fix it back or replace the RAM with another", "solution for: laptop won't turn on")

        ElseIf txt = "desktop turning on problem" Or txt = "my desktop won't turn on" Or txt = "turning on problems" Or txt = "desktop turning on problem" Or txt = "what do i  do if my desktop won't turn on" Or txt = "what do i do if my desktop doesn't turn on" Or txt = "what do i do if my desktop won't turn On" Or txt = "my desktop won't turn on" Then
            MessageBox.Show("You may need to check the following: 1. Check to see if the power adapter is functional so that to make sure there is power going to the system and make sure all cables are tightly connected. 2. Suppose the CPU is active but does not display on the monitor, you may need to check your VGA cable at the monitor and CPU terminals. 3. Remove and RAM, clean it and fix it back or replace the RAM with another", "Solution for: desktop won't turn on")
            MessageBox.Show("If that does not work, contact a technician", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf txt = "beep sound" Or txt = "my computer gives me a beep sound" Or txt = "beep sound problem" Or txt = "beep problem" Then
            MessageBox.Show("You may need to check the following: 1. For laptops, try turning it on with the AC adapter but without battery. 2. If that does not work, remove the AC adapter and the battery, press and hold the system turning On button and count to 20, then release and fix the AC adapter and the battery back and turn it on. 3. If it does not work, try cleaning the RAM or replace it.", "Solution for: Beep sound issues")
            MessageBox.Show("If all does not work, contact a technician", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf txt = "blue screen error" Or txt = "blue screen" Or txt = "what do i do when i get a blue screen error" Or txt = "blue screen problem" Or txt = "i get a blue screen error" Then
            MessageBox.Show("You may need to check the following: 1. Copy the error code that appears and google it to easily learn of the problem and what is needed to solve it. 2. Or simply check and replace your RAM. 3. If it still doesn't work, reinstall another OS. 4. If it continues, replace the HDD.", "Solution for: Blue screen error")
            MessageBox.Show("If all does not work, contact a technician", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf txt = "bootable device not found" Or txt = "my computer won't boot" Or txt = "my laptop won't boot" Or txt = "my desktop won't boot" Or txt = "my system writes bootable device not found" Or txt = "my computer won't boot" Or txt = "my system won't boot" Or txt = "i can not boot my computer" Then
            MessageBox.Show("You may need to check the following: 1.Turn it OFF, Confirm if the HDD and it's connector is tightly connected to the motherboard, and turn it back ON. 2. If it still does not work, try installing another Operating System, OS might be corrupted", "Troubleshooting")
            MessageBox.Show("If all does not work, contact a technician", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf txt = "slow booting" Or txt = "my system is slow" Or txt = "my computer is slow" Or txt = "slow turning on" Or txt = "take time before turning on" Or txt = "take a long time before booting" Or txt = "take a long time to boot" Or txt = "boots longer" Or txt = "boot problems" Or txt = "boot problem" Then
            MessageBox.Show("You may need to do the following: 1. It is likely that it is running slow due to incorrect setting of the time and date, press [ctrl + Alt + delete] simulteanously, and try correcting the date and time setting and restart it to check if the problem is solved. 2.If the time and date settings still remains incorrect, it means the back up battery is weak, replace it. 3. Suppose the date/time settings are correct but it still boots slow, try upgrading your RAM and check if your HDD memory is not almost filled, if yes free some space. 4. If the RAM is upgraded and the HDD has enough space but still runs slow, it is possible that the operating system is affected by a malicious program, try installing another OS. 5. If problem still persist, it is likely the HDD is faulty, replace a HDD and install an OS.", "Troubleshoot")
            MessageBox.Show("If all does not work, contact a technician", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            MessageBox.Show("Result Not found")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub


End Class
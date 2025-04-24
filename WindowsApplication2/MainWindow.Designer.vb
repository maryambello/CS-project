<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnFull = New System.Windows.Forms.Button()
        Me.btbAboutMe = New System.Windows.Forms.Button()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(226, 9)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(60, 13)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "User Name"
        '
        'btnFull
        '
        Me.btnFull.Location = New System.Drawing.Point(35, 254)
        Me.btnFull.Name = "btnFull"
        Me.btnFull.Size = New System.Drawing.Size(429, 23)
        Me.btnFull.TabIndex = 2
        Me.btnFull.Text = "Learn some basics"
        Me.btnFull.UseVisualStyleBackColor = True
        '
        'btbAboutMe
        '
        Me.btbAboutMe.Location = New System.Drawing.Point(35, 287)
        Me.btbAboutMe.Name = "btbAboutMe"
        Me.btbAboutMe.Size = New System.Drawing.Size(429, 23)
        Me.btbAboutMe.TabIndex = 5
        Me.btbAboutMe.Text = "About Me"
        Me.btbAboutMe.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(226, 115)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(222, 104)
        Me.lblNote.TabIndex = 6
        Me.lblNote.Text = resources.GetString("lblNote.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources.technician
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 229)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(229, 26)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(235, 20)
        Me.txtsearch.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(229, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 349)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.btbAboutMe)
        Me.Controls.Add(Me.btnFull)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainWindow"
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents btnFull As Button
    Friend WithEvents btbAboutMe As Button
    Friend WithEvents lblNote As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Button1 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tutorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tutorial))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEvents = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 143)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Some componets and their functionality", "1. Random Access Memory (RAM):", "RAM is a detachable volatile memory, ", "it temporary stores information and deletes it ", "when  there is no power. Without a RAM, the ", "system can not be turned On.", "", "", "2. Hard disk drive (HDD):", "HDD is a detachable permanent form of storage, all files and ", "application are stored or installed on the HDD.", "Without the HDD, the system can be turned ON ", "but it will not boot.", "", "", "3. CMOS and Battery Backup:", "The CMOS is a memory chip that houses ", "configuartion settings and it is powered by ", "the on board battery (i.e battery backup).", "Without the battery, the system may not ", "boot or will take a long time before it boots.", "The CMOS is a fixed chip while the battery ", "is deatachable", ""})
        Me.ListBox1.Location = New System.Drawing.Point(19, 239)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(276, 134)
        Me.ListBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 65)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "What will you need?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For this app, the two most important things needed " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1" &
    ". A screwdriver and a multimeter(optional)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. The knowlegde on how some compon" &
    "ents functions."
        '
        'btnEvents
        '
        Me.btnEvents.Location = New System.Drawing.Point(19, 380)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(276, 23)
        Me.btnEvents.TabIndex = 3
        Me.btnEvents.Text = "I have read and understand it"
        Me.btnEvents.UseVisualStyleBackColor = True
        '
        'Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 427)
        Me.Controls.Add(Me.btnEvents)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tutorial"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEvents As Button
End Class

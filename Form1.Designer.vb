<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Information = New System.Windows.Forms.Label()
        Me.Button_Informations = New System.Windows.Forms.Button()
        Me.More_Information = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Motto_Half = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Information
        '
        Me.Information.AutoSize = True
        Me.Information.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Information.Location = New System.Drawing.Point(112, 434)
        Me.Information.Name = "Information"
        Me.Information.Size = New System.Drawing.Size(0, 25)
        Me.Information.TabIndex = 0
        '
        'Button_Informations
        '
        Me.Button_Informations.Location = New System.Drawing.Point(354, 404)
        Me.Button_Informations.Name = "Button_Informations"
        Me.Button_Informations.Size = New System.Drawing.Size(172, 23)
        Me.Button_Informations.TabIndex = 1
        Me.Button_Informations.Text = "Want to know more?"
        Me.Button_Informations.UseVisualStyleBackColor = True
        '
        'More_Information
        '
        Me.More_Information.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.More_Information.Location = New System.Drawing.Point(118, 434)
        Me.More_Information.Name = "More_Information"
        Me.More_Information.Size = New System.Drawing.Size(618, 119)
        Me.More_Information.TabIndex = 2
        Me.More_Information.Text = "May 30, 2017" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ryan Park" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Start Time: 8:00 AM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more information, view the Fall" &
    " Marathon Facebook page."
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(369, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(157, 25)
        Me.Title.TabIndex = 6
        Me.Title.Text = "Fall Marathon"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 332)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Motto_Half
        '
        Me.Motto_Half.AutoSize = True
        Me.Motto_Half.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Motto_Half.Location = New System.Drawing.Point(370, 220)
        Me.Motto_Half.Name = "Motto_Half"
        Me.Motto_Half.Size = New System.Drawing.Size(467, 24)
        Me.Motto_Half.TabIndex = 11
        Me.Motto_Half.Text = "The halfway point only marks the end of the beginning."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 684)
        Me.Controls.Add(Me.Motto_Half)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.More_Information)
        Me.Controls.Add(Me.Button_Informations)
        Me.Controls.Add(Me.Information)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Information As Label
    Friend WithEvents Button_Informations As Button
    Friend WithEvents More_Information As Label
    Friend WithEvents Title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Motto_Half As Label
End Class

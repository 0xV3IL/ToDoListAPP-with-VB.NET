<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAbout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        pnlHeader = New Panel()
        lblApp = New Label()
        lblDesc = New Label()
        lblSeparator = New Label()
        lblAuthor = New Label()
        lblCopyright = New Label()
        lblSource = New Label()
        lnkGithub = New LinkLabel()
        btnOk = New Button()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        pnlHeader.Controls.Add(lblApp)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(420, 70)
        pnlHeader.TabIndex = 0
        ' 
        ' lblApp
        ' 
        lblApp.AutoSize = True
        lblApp.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblApp.ForeColor = Color.White
        lblApp.Location = New Point(16, 20)
        lblApp.Name = "lblApp"
        lblApp.Size = New Size(173, 25)
        lblApp.TabIndex = 0
        lblApp.Text = "ToDoList App v1.0"
        ' 
        ' lblDesc
        ' 
        lblDesc.Location = New Point(16, 86)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(388, 36)
        lblDesc.TabIndex = 1
        lblDesc.Text = "Aplikasi manajemen tugas dengan VB.NET + MySQL"
        ' 
        ' lblSeparator
        ' 
        lblSeparator.BorderStyle = BorderStyle.Fixed3D
        lblSeparator.Location = New Point(16, 134)
        lblSeparator.Name = "lblSeparator"
        lblSeparator.Size = New Size(388, 2)
        lblSeparator.TabIndex = 2
        ' 
        ' lblAuthor
        ' 
        lblAuthor.AutoSize = True
        lblAuthor.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblAuthor.Location = New Point(16, 148)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(198, 15)
        lblAuthor.TabIndex = 3
        lblAuthor.Text = "Dibuat oleh: Fikrah Fathoni Siregar"
        ' 
        ' lblCopyright
        ' 
        lblCopyright.AutoSize = True
        lblCopyright.Location = New Point(16, 172)
        lblCopyright.Name = "lblCopyright"
        lblCopyright.Size = New Size(265, 15)
        lblCopyright.TabIndex = 4
        lblCopyright.Text = "© 2026 Fikrah Fathoni Siregar. All rights reserved."
        ' 
        ' lblSource
        ' 
        lblSource.AutoSize = True
        lblSource.Location = New Point(16, 200)
        lblSource.Name = "lblSource"
        lblSource.Size = New Size(75, 15)
        lblSource.TabIndex = 5
        lblSource.Text = "Source code:"
        ' 
        ' lnkGithub
        ' 
        lnkGithub.AutoSize = True
        lnkGithub.Location = New Point(100, 200)
        lnkGithub.Name = "lnkGithub"
        lnkGithub.Size = New Size(114, 15)
        lnkGithub.TabIndex = 6
        lnkGithub.TabStop = True
        lnkGithub.Text = "https://github.com/"
        ' 
        ' btnOk
        ' 
        btnOk.Location = New Point(329, 238)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(75, 28)
        btnOk.TabIndex = 7
        btnOk.Text = "OK"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' FormAbout
        ' 
        AcceptButton = btnOk
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnOk
        ClientSize = New Size(420, 280)
        Controls.Add(btnOk)
        Controls.Add(lnkGithub)
        Controls.Add(lblSource)
        Controls.Add(lblCopyright)
        Controls.Add(lblAuthor)
        Controls.Add(lblSeparator)
        Controls.Add(lblDesc)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormAbout"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Tentang Aplikasi"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblApp As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblSource As Label
    Friend WithEvents lnkGithub As LinkLabel
    Friend WithEvents btnOk As Button
End Class
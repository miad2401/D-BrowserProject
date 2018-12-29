<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Favorites
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstFavorites = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnGoTo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFavorites
        '
        Me.lstFavorites.FormattingEnabled = True
        Me.lstFavorites.Location = New System.Drawing.Point(1, 1)
        Me.lstFavorites.Name = "lstFavorites"
        Me.lstFavorites.Size = New System.Drawing.Size(414, 290)
        Me.lstFavorites.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1, 298)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnGoTo
        '
        Me.btnGoTo.Location = New System.Drawing.Point(99, 298)
        Me.btnGoTo.Name = "btnGoTo"
        Me.btnGoTo.Size = New System.Drawing.Size(75, 23)
        Me.btnGoTo.TabIndex = 2
        Me.btnGoTo.Text = "GoTo"
        Me.btnGoTo.UseVisualStyleBackColor = True
        '
        'Favorites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 361)
        Me.Controls.Add(Me.btnGoTo)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstFavorites)
        Me.Name = "Favorites"
        Me.Text = "Bookmarks"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstFavorites As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnGoTo As Button
End Class

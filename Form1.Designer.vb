<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblLoadInfo = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.cmbUrl = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAddFav = New System.Windows.Forms.Button()
        Me.btnShowFav = New System.Windows.Forms.Button()
        Me.btnShowHistory = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLoadInfo
        '
        Me.lblLoadInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoadInfo.Font = New System.Drawing.Font("Ubuntu Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadInfo.Location = New System.Drawing.Point(102, 26)
        Me.lblLoadInfo.Name = "lblLoadInfo"
        Me.lblLoadInfo.Size = New System.Drawing.Size(136, 21)
        Me.lblLoadInfo.TabIndex = 6
        Me.lblLoadInfo.Text = "Loading"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(2, 86)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1360, 656)
        Me.WebBrowser1.TabIndex = 7
        Me.WebBrowser1.Url = New System.Uri("http://google.com", System.UriKind.Absolute)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 54)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1348, 29)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 26)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'cmbUrl
        '
        Me.cmbUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbUrl.FormattingEnabled = True
        Me.cmbUrl.Location = New System.Drawing.Point(102, 2)
        Me.cmbUrl.Name = "cmbUrl"
        Me.cmbUrl.Size = New System.Drawing.Size(625, 21)
        Me.cmbUrl.TabIndex = 10
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(846, 2)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(228, 20)
        Me.txtSearch.TabIndex = 11
        '
        'btnAddFav
        '
        Me.btnAddFav.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddFav.BackgroundImage = Global.Sandwhich.My.Resources.Resources.appbar_page_location_add
        Me.btnAddFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddFav.Location = New System.Drawing.Point(1238, 4)
        Me.btnAddFav.Name = "btnAddFav"
        Me.btnAddFav.Size = New System.Drawing.Size(50, 43)
        Me.btnAddFav.TabIndex = 15
        Me.btnAddFav.UseVisualStyleBackColor = True
        '
        'btnShowFav
        '
        Me.btnShowFav.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowFav.BackgroundImage = Global.Sandwhich.My.Resources.Resources.appbar_page_location
        Me.btnShowFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowFav.Location = New System.Drawing.Point(1294, 4)
        Me.btnShowFav.Name = "btnShowFav"
        Me.btnShowFav.Size = New System.Drawing.Size(49, 43)
        Me.btnShowFav.TabIndex = 14
        Me.btnShowFav.UseVisualStyleBackColor = True
        '
        'btnShowHistory
        '
        Me.btnShowHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowHistory.BackgroundImage = Global.Sandwhich.My.Resources.Resources.appbar_page_multiple
        Me.btnShowHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowHistory.Location = New System.Drawing.Point(1186, 3)
        Me.btnShowHistory.Name = "btnShowHistory"
        Me.btnShowHistory.Size = New System.Drawing.Size(46, 45)
        Me.btnShowHistory.TabIndex = 13
        Me.btnShowHistory.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackgroundImage = Global.Sandwhich.My.Resources.Resources.appbar_page_search
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(1080, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(47, 44)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHome.BackgroundImage = Global.Sandwhich.My.Resources.Resources.appbar_home_empty
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Location = New System.Drawing.Point(1133, 3)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(47, 45)
        Me.btnHome.TabIndex = 8
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        Me.btnForward.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForward.BackgroundImage = Global.Sandwhich.My.Resources.Resources.appbar_navigate_next
        Me.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnForward.Location = New System.Drawing.Point(51, 3)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(45, 45)
        Me.btnForward.TabIndex = 4
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackgroundImage = Global.Sandwhich.My.Resources.Resources.appbar_refresh
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Location = New System.Drawing.Point(791, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(50, 43)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackgroundImage = Global.Sandwhich.My.Resources.Resources.appbar_navigate_previous
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.Location = New System.Drawing.Point(2, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(43, 45)
        Me.btnBack.TabIndex = 3
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = Global.Sandwhich.My.Resources.Resources.appbar_page_arrow
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(733, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.btnAddFav)
        Me.Controls.Add(Me.btnShowFav)
        Me.Controls.Add(Me.btnShowHistory)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbUrl)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblLoadInfo)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "D-Browser"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblLoadInfo As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbUrl As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnShowHistory As System.Windows.Forms.Button
    Friend WithEvents btnShowFav As System.Windows.Forms.Button
    Friend WithEvents btnAddFav As System.Windows.Forms.Button

End Class

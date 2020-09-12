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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Jadde", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Eski 1. Jadde"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "")}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Yeni Cihangir Jaddesi", "", ""}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Video Server", "", ""}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Test Server")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstServer = New System.Windows.Forms.ListView()
        Me.Server = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SonKontrol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.kontrol = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstServer
        '
        Me.lstServer.AutoArrange = False
        Me.lstServer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstServer.CheckBoxes = True
        Me.lstServer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Server, Me.Status, Me.SonKontrol})
        Me.lstServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstServer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstServer.FullRowSelect = True
        Me.lstServer.GridLines = True
        ListViewGroup1.Header = "Jadde"
        ListViewGroup1.Name = "JADDE"
        Me.lstServer.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.lstServer.HideSelection = False
        ListViewItem1.Checked = True
        ListViewItem1.Group = ListViewGroup1
        ListViewItem1.StateImageIndex = 1
        ListViewItem1.Tag = "Eski 1. Jadde"
        ListViewItem1.ToolTipText = "95.211.99.145:4000"
        ListViewItem2.Group = ListViewGroup1
        ListViewItem2.StateImageIndex = 0
        ListViewItem2.Tag = "Yeni Cihangir Jaddesi"
        ListViewItem2.ToolTipText = "95.211.99.155:4000"
        ListViewItem3.Group = ListViewGroup1
        ListViewItem3.StateImageIndex = 0
        ListViewItem3.Tag = "Video Server"
        ListViewItem3.ToolTipText = "205.209.136.29:60000"
        ListViewItem4.Group = ListViewGroup1
        ListViewItem4.StateImageIndex = 0
        ListViewItem4.Tag = "Test Server"
        ListViewItem4.ToolTipText = "95.211.99.155:4000"
        Me.lstServer.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.lstServer.LabelWrap = False
        Me.lstServer.Location = New System.Drawing.Point(12, 27)
        Me.lstServer.MultiSelect = False
        Me.lstServer.Name = "lstServer"
        Me.lstServer.Size = New System.Drawing.Size(468, 177)
        Me.lstServer.TabIndex = 1
        Me.lstServer.UseCompatibleStateImageBehavior = False
        Me.lstServer.View = System.Windows.Forms.View.Details
        '
        'Server
        '
        Me.Server.Text = "Server"
        Me.Server.Width = 164
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 150
        '
        'SonKontrol
        '
        Me.SonKontrol.Text = "Son Kontrol"
        Me.SonKontrol.Width = 150
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(405, 210)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 31)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "&Baslat"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'kontrol
        '
        Me.kontrol.Interval = 30000
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Temizle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(324, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&Patchler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(495, 250)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lstServer)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "K.R.M - Server Status"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstServer As System.Windows.Forms.ListView
    Friend WithEvents Server As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents SonKontrol As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents kontrol As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class

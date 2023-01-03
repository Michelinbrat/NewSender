<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НастройкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EEPROMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FeedBar = New System.Windows.Forms.TrackBar()
        Me.PowerBar = New System.Windows.Forms.TrackBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tbPower = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnTestReader = New System.Windows.Forms.Button()
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DisplayPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.cbBauds = New System.Windows.Forms.ComboBox()
        Me.cbPortsList = New System.Windows.Forms.ComboBox()
        Me.rtbDisplay = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FeedBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowerBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 600)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1325, 17)
        Me.ProgressBar1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(280, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 67)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.НастройкиToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1325, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'НастройкиToolStripMenuItem
        '
        Me.НастройкиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EEPROMToolStripMenuItem})
        Me.НастройкиToolStripMenuItem.Name = "НастройкиToolStripMenuItem"
        Me.НастройкиToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.НастройкиToolStripMenuItem.Text = "Настройки"
        '
        'EEPROMToolStripMenuItem
        '
        Me.EEPROMToolStripMenuItem.Name = "EEPROMToolStripMenuItem"
        Me.EEPROMToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EEPROMToolStripMenuItem.Text = "EEPROM"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(48, 218)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(233, 20)
        Me.TextBox2.TabIndex = 12
        '
        'BtnSend
        '
        Me.BtnSend.Location = New System.Drawing.Point(289, 215)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(53, 22)
        Me.BtnSend.TabIndex = 13
        Me.BtnSend.Text = "Send"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(122, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 48)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FeedBar)
        Me.GroupBox2.Controls.Add(Me.PowerBar)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.tbPower)
        Me.GroupBox2.Location = New System.Drawing.Point(412, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 328)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Мощность и скорость"
        '
        'FeedBar
        '
        Me.FeedBar.Location = New System.Drawing.Point(111, 72)
        Me.FeedBar.Minimum = -10
        Me.FeedBar.Name = "FeedBar"
        Me.FeedBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.FeedBar.Size = New System.Drawing.Size(45, 241)
        Me.FeedBar.TabIndex = 15
        Me.FeedBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'PowerBar
        '
        Me.PowerBar.Location = New System.Drawing.Point(19, 72)
        Me.PowerBar.Minimum = -10
        Me.PowerBar.Name = "PowerBar"
        Me.PowerBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PowerBar.Size = New System.Drawing.Size(45, 241)
        Me.PowerBar.TabIndex = 14
        Me.PowerBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.Font = New System.Drawing.Font("a_LCDNova", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox1.Location = New System.Drawing.Point(106, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(50, 40)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbPower
        '
        Me.tbPower.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tbPower.BackColor = System.Drawing.SystemColors.InfoText
        Me.tbPower.Font = New System.Drawing.Font("a_LCDNova", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbPower.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.tbPower.Location = New System.Drawing.Point(14, 26)
        Me.tbPower.Name = "tbPower"
        Me.tbPower.ReadOnly = True
        Me.tbPower.Size = New System.Drawing.Size(50, 40)
        Me.tbPower.TabIndex = 12
        Me.tbPower.Text = "0"
        Me.tbPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 578)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1325, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'BtnTestReader
        '
        Me.BtnTestReader.Location = New System.Drawing.Point(682, 334)
        Me.BtnTestReader.Name = "BtnTestReader"
        Me.BtnTestReader.Size = New System.Drawing.Size(124, 43)
        Me.BtnTestReader.TabIndex = 19
        Me.BtnTestReader.Text = "TestReader"
        Me.BtnTestReader.UseVisualStyleBackColor = True
        '
        'BtnPause
        '
        Me.BtnPause.Location = New System.Drawing.Point(613, 281)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(116, 47)
        Me.BtnPause.TabIndex = 20
        Me.BtnPause.Text = "Pause"
        Me.BtnPause.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'DisplayPanel
        '
        Me.DisplayPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DisplayPanel.AutoSize = True
        Me.DisplayPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DisplayPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DisplayPanel.Location = New System.Drawing.Point(18, 561)
        Me.DisplayPanel.Name = "DisplayPanel"
        Me.DisplayPanel.Size = New System.Drawing.Size(0, 0)
        Me.DisplayPanel.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(937, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 548)
        Me.Panel1.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnConnect)
        Me.GroupBox1.Controls.Add(Me.cbBauds)
        Me.GroupBox1.Controls.Add(Me.cbPortsList)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 46)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Соединение"
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(195, 13)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(143, 25)
        Me.BtnConnect.TabIndex = 11
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'cbBauds
        '
        Me.cbBauds.FormattingEnabled = True
        Me.cbBauds.Items.AddRange(New Object() {"9600", "115200", "250000"})
        Me.cbBauds.Location = New System.Drawing.Point(117, 16)
        Me.cbBauds.Name = "cbBauds"
        Me.cbBauds.Size = New System.Drawing.Size(72, 21)
        Me.cbBauds.TabIndex = 10
        '
        'cbPortsList
        '
        Me.cbPortsList.FormattingEnabled = True
        Me.cbPortsList.Location = New System.Drawing.Point(6, 16)
        Me.cbPortsList.Name = "cbPortsList"
        Me.cbPortsList.Size = New System.Drawing.Size(105, 21)
        Me.cbPortsList.TabIndex = 9
        '
        'rtbDisplay
        '
        Me.rtbDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbDisplay.Location = New System.Drawing.Point(0, 447)
        Me.rtbDisplay.Name = "rtbDisplay"
        Me.rtbDisplay.Size = New System.Drawing.Size(931, 128)
        Me.rtbDisplay.TabIndex = 15
        Me.rtbDisplay.Text = ""
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 617)
        Me.Controls.Add(Me.rtbDisplay)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DisplayPanel)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.BtnTestReader)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "NewSender"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FeedBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowerBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnSend As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FeedBar As TrackBar
    Friend WithEvents PowerBar As TrackBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tbPower As TextBox
    Friend WithEvents НастройкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EEPROMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents BtnTestReader As Button
    Friend WithEvents BtnPause As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DisplayPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnConnect As Button
    Friend WithEvents cbBauds As ComboBox
    Friend WithEvents cbPortsList As ComboBox
    Friend WithEvents rtbDisplay As RichTextBox
End Class

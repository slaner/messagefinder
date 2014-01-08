<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MFMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MFMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstMessage = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDefinition = New System.Windows.Forms.TextBox()
        Me.CStyle = New System.Windows.Forms.RadioButton()
        Me.CSharpStyle = New System.Windows.Forms.RadioButton()
        Me.VbStyle = New System.Windows.Forms.RadioButton()
        Me.chkFindValue = New System.Windows.Forms.CheckBox()
        Me.DecFind = New System.Windows.Forms.RadioButton()
        Me.HexFind = New System.Windows.Forms.RadioButton()
        Me.panStyle = New System.Windows.Forms.Panel()
        Me.panFindMethod = New System.Windows.Forms.Panel()
        Me.panStyle.SuspendLayout()
        Me.panFindMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "찾을 메세지를 입력하세요:"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(9, 24)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(403, 21)
        Me.txtMessage.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "메세지 목록:"
        '
        'lstMessage
        '
        Me.lstMessage.FormattingEnabled = True
        Me.lstMessage.ItemHeight = 12
        Me.lstMessage.Location = New System.Drawing.Point(9, 73)
        Me.lstMessage.Name = "lstMessage"
        Me.lstMessage.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstMessage.Size = New System.Drawing.Size(403, 208)
        Me.lstMessage.Sorted = True
        Me.lstMessage.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "메세지 선언:"
        '
        'txtDefinition
        '
        Me.txtDefinition.BackColor = System.Drawing.Color.White
        Me.txtDefinition.Location = New System.Drawing.Point(9, 308)
        Me.txtDefinition.Multiline = True
        Me.txtDefinition.Name = "txtDefinition"
        Me.txtDefinition.ReadOnly = True
        Me.txtDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDefinition.Size = New System.Drawing.Size(403, 103)
        Me.txtDefinition.TabIndex = 6
        '
        'CStyle
        '
        Me.CStyle.AutoSize = True
        Me.CStyle.Checked = True
        Me.CStyle.Location = New System.Drawing.Point(1, 3)
        Me.CStyle.Name = "CStyle"
        Me.CStyle.Size = New System.Drawing.Size(59, 16)
        Me.CStyle.TabIndex = 7
        Me.CStyle.TabStop = True
        Me.CStyle.Text = "C/C++"
        Me.CStyle.UseVisualStyleBackColor = True
        '
        'CSharpStyle
        '
        Me.CSharpStyle.AutoSize = True
        Me.CSharpStyle.Location = New System.Drawing.Point(66, 3)
        Me.CSharpStyle.Name = "CSharpStyle"
        Me.CSharpStyle.Size = New System.Drawing.Size(38, 16)
        Me.CSharpStyle.TabIndex = 8
        Me.CSharpStyle.TabStop = True
        Me.CSharpStyle.Text = "C#"
        Me.CSharpStyle.UseVisualStyleBackColor = True
        '
        'VbStyle
        '
        Me.VbStyle.AutoSize = True
        Me.VbStyle.Location = New System.Drawing.Point(110, 3)
        Me.VbStyle.Name = "VbStyle"
        Me.VbStyle.Size = New System.Drawing.Size(90, 16)
        Me.VbStyle.TabIndex = 9
        Me.VbStyle.TabStop = True
        Me.VbStyle.Text = "VB/VB.NET"
        Me.VbStyle.UseVisualStyleBackColor = True
        '
        'chkFindValue
        '
        Me.chkFindValue.AutoSize = True
        Me.chkFindValue.Location = New System.Drawing.Point(1, 1)
        Me.chkFindValue.Name = "chkFindValue"
        Me.chkFindValue.Size = New System.Drawing.Size(64, 16)
        Me.chkFindValue.TabIndex = 4
        Me.chkFindValue.Text = "값 찾기"
        Me.chkFindValue.UseVisualStyleBackColor = True
        '
        'DecFind
        '
        Me.DecFind.AutoSize = True
        Me.DecFind.Checked = True
        Me.DecFind.Enabled = False
        Me.DecFind.Location = New System.Drawing.Point(71, 1)
        Me.DecFind.Name = "DecFind"
        Me.DecFind.Size = New System.Drawing.Size(59, 16)
        Me.DecFind.TabIndex = 10
        Me.DecFind.TabStop = True
        Me.DecFind.Text = "10진수"
        Me.DecFind.UseVisualStyleBackColor = True
        '
        'HexFind
        '
        Me.HexFind.AutoSize = True
        Me.HexFind.Enabled = False
        Me.HexFind.Location = New System.Drawing.Point(136, 1)
        Me.HexFind.Name = "HexFind"
        Me.HexFind.Size = New System.Drawing.Size(59, 16)
        Me.HexFind.TabIndex = 11
        Me.HexFind.TabStop = True
        Me.HexFind.Text = "16진수"
        Me.HexFind.UseVisualStyleBackColor = True
        '
        'panStyle
        '
        Me.panStyle.Controls.Add(Me.CStyle)
        Me.panStyle.Controls.Add(Me.CSharpStyle)
        Me.panStyle.Controls.Add(Me.VbStyle)
        Me.panStyle.Location = New System.Drawing.Point(211, 285)
        Me.panStyle.Name = "panStyle"
        Me.panStyle.Size = New System.Drawing.Size(201, 20)
        Me.panStyle.TabIndex = 12
        '
        'panFindMethod
        '
        Me.panFindMethod.Controls.Add(Me.HexFind)
        Me.panFindMethod.Controls.Add(Me.chkFindValue)
        Me.panFindMethod.Controls.Add(Me.DecFind)
        Me.panFindMethod.Location = New System.Drawing.Point(216, 3)
        Me.panFindMethod.Name = "panFindMethod"
        Me.panFindMethod.Size = New System.Drawing.Size(196, 18)
        Me.panFindMethod.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(421, 420)
        Me.Controls.Add(Me.panFindMethod)
        Me.Controls.Add(Me.panStyle)
        Me.Controls.Add(Me.txtDefinition)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstMessage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Message Finder"
        Me.panStyle.ResumeLayout(False)
        Me.panStyle.PerformLayout()
        Me.panFindMethod.ResumeLayout(False)
        Me.panFindMethod.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstMessage As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDefinition As System.Windows.Forms.TextBox
    Friend WithEvents CStyle As System.Windows.Forms.RadioButton
    Friend WithEvents CSharpStyle As System.Windows.Forms.RadioButton
    Friend WithEvents VbStyle As System.Windows.Forms.RadioButton
    Friend WithEvents chkFindValue As System.Windows.Forms.CheckBox
    Friend WithEvents DecFind As System.Windows.Forms.RadioButton
    Friend WithEvents HexFind As System.Windows.Forms.RadioButton
    Friend WithEvents panStyle As System.Windows.Forms.Panel
    Friend WithEvents panFindMethod As System.Windows.Forms.Panel

End Class

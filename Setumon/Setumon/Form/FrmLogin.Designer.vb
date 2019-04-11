<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits Setumon.BFrmSmall

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUserNm = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPassWd = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnChangePass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ユーザー名"
        '
        'TxtUserNm
        '
        Me.TxtUserNm.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtUserNm.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtUserNm.Location = New System.Drawing.Point(69, 45)
        Me.TxtUserNm.Name = "TxtUserNm"
        Me.TxtUserNm.Size = New System.Drawing.Size(346, 21)
        Me.TxtUserNm.TabIndex = 0
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(69, 207)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(144, 23)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "ログイン"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "パスワード"
        '
        'TxtPassWd
        '
        Me.TxtPassWd.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TxtPassWd.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtPassWd.Location = New System.Drawing.Point(68, 108)
        Me.TxtPassWd.Name = "TxtPassWd"
        Me.TxtPassWd.Size = New System.Drawing.Size(347, 21)
        Me.TxtPassWd.TabIndex = 1
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(271, 207)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(144, 23)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "キャンセル"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnChangePass
        '
        Me.BtnChangePass.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnChangePass.Location = New System.Drawing.Point(271, 135)
        Me.BtnChangePass.Name = "BtnChangePass"
        Me.BtnChangePass.Size = New System.Drawing.Size(144, 23)
        Me.BtnChangePass.TabIndex = 4
        Me.BtnChangePass.TabStop = False
        Me.BtnChangePass.Text = "パスワード設定"
        Me.BtnChangePass.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.BtnChangePass)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtPassWd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtUserNm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUserNm As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPassWd As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnChangePass As Button
End Class

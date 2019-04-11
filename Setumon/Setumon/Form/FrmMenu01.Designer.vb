<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu01
    Inherits Setumon.BFrmRegular

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
        Me.LblUserNm = New System.Windows.Forms.Label()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnNext01 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(1)
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ユーザー名："
        '
        'LblUserNm
        '
        Me.LblUserNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblUserNm.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblUserNm.Location = New System.Drawing.Point(115, 27)
        Me.LblUserNm.Name = "LblUserNm"
        Me.LblUserNm.Padding = New System.Windows.Forms.Padding(1)
        Me.LblUserNm.Size = New System.Drawing.Size(267, 21)
        Me.LblUserNm.TabIndex = 2
        Me.LblUserNm.Text = "ＮＮＮＮＮＮ"
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnQuit.Location = New System.Drawing.Point(115, 132)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(144, 23)
        Me.BtnQuit.TabIndex = 1
        Me.BtnQuit.Text = "戻る"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnNext01
        '
        Me.BtnNext01.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnNext01.Location = New System.Drawing.Point(115, 82)
        Me.BtnNext01.Name = "BtnNext01"
        Me.BtnNext01.Size = New System.Drawing.Size(144, 23)
        Me.BtnNext01.TabIndex = 0
        Me.BtnNext01.Text = "次へ"
        Me.BtnNext01.UseVisualStyleBackColor = True
        '
        'FrmMenu01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.BtnNext01)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.LblUserNm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMenu01"
        Me.Text = "設問システム Ver.1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblUserNm As Label
    Friend WithEvents BtnQuit As Button
    Friend WithEvents BtnNext01 As Button
End Class

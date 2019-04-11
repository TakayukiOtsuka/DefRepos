<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDmmy01
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
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnQuit.Location = New System.Drawing.Point(72, 48)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(144, 23)
        Me.BtnQuit.TabIndex = 4
        Me.BtnQuit.Text = "戻る"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'FrmDmmy01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.BtnQuit)
        Me.Name = "FrmDmmy01"
        Me.Text = "設問システム Ver.1.0"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnQuit As Button
End Class

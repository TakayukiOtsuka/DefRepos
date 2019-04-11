'*******************************************************************************
' ﾌﾟﾛｸﾞﾗﾑ名     : メニュー画面
' ｿｰｽﾌﾟﾛｸﾞﾗﾑ名  : FrmMenu01.vb
' 処理概要      : メニュー画面です。
' 作成          : 2019/04/05　T.otsuka(SoftCDC)　新規作成
'*******************************************************************************
Option Explicit On
Option Strict On

Public Class FrmMenu01

    ''' <summary>
    ''' フォームロード時
    ''' </summary>
    Private Sub FrmMenu01_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Debug.WriteLine("FrmMenu01 Called")

        'ユーザー名表示
        LblUserNm.Text = gUser.UserName

    End Sub


    ''' <summary>
    ''' 次へボタン押下時
    ''' </summary>
    Private Sub BtnNext01_Click(sender As Object, e As EventArgs) Handles BtnNext01.Click

        '自画面隠す
        Me.Hide()

        'メニュー画面表示
        Dim frm As New FrmDmmy01
        frm.ShowDialog(Me)

    End Sub


    ''' <summary>
    ''' 戻るボタン押下時
    ''' </summary>
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click

        '親画面表示
        Me.Owner.Show()

        '自画面閉じる
        IsMoveForm = True
        Me.Close()

    End Sub

End Class

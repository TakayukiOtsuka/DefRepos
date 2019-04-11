'*******************************************************************************
' ﾌﾟﾛｸﾞﾗﾑ名     : ダミー画面
' ｿｰｽﾌﾟﾛｸﾞﾗﾑ名  : FrmDmmy01.vb
' 処理概要      : ダミー画面です。
' 作成          : 2019/04/05　T.otsuka(SoftCDC)　新規作成
'*******************************************************************************
Option Explicit On
Option Strict On

Public Class FrmDmmy01

    ''' <summary>
    ''' フォームロード時
    ''' </summary>
    Private Sub FrmDmmy01_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Debug.WriteLine("FrmMenu01 Called")

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

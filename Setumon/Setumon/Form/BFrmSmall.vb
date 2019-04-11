'*******************************************************************************
' ﾌﾟﾛｸﾞﾗﾑ名     : ベースフォーム
' ｿｰｽﾌﾟﾛｸﾞﾗﾑ名  : BFrmSmall.vb
' 処理概要      : 各画面は当該クラスを派生して作成して下さい。
' 処理概要      : ログイン画面等の小さいフォームデザイン用
' 作成          : 2019/04/05　T.otsuka(SoftCDC)　新規作成
'*******************************************************************************
Option Explicit On
Option Strict On

Public Class BFrmSmall

    ''' <summary>
    ''' フォームロード時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BFrmSmall_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Debug.WriteLine("BFrmSmall Called")

    End Sub

End Class
'*******************************************************************************
' ﾌﾟﾛｸﾞﾗﾑ名     : 基底ベースフォーム
' ｿｰｽﾌﾟﾛｸﾞﾗﾑ名  : BFrmBase.vb
' 処理概要      : 基底ベースフォーム（共通機能の実装）
' 作成          : 2019/04/05　T.otsuka(SoftCDC)　新規作成
'*******************************************************************************
Option Explicit On
Option Strict On

Public Class BFrmBase

    ''' <summary>
    ''' 画面閉じ制御フラグ
    ''' </summary>
    ''' <remarks>
    ''' ウィンドウ「Ｘ」ボタンでアプリケーション終了させる仕掛け。
    ''' 画面遷移する場合で自画面をCloseする場合はこのフラグにＴＵＲＥをセットする。
    ''' セットしないとアプリケーション終了してしまうので注意。
    ''' </remarks>
    Protected IsMoveForm As Boolean = False


    ''' <summary>
    ''' フォームロード時
    ''' </summary>
    Private Sub BFrmBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Debug.WriteLine("BFrmBase Called")

        '画面閉じ制御フラグ初期化
        IsMoveForm = False

        'キャプション表示
        Me.Text = My.Resources.APP_NAME & " Ver." & My.Resources.APP_VERSION

    End Sub


    ''' <summary>
    ''' フォーム・閉じ中時
    ''' </summary>
    Private Sub BFrmBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If IsMoveForm = False Then

            'アプリケーション終了
            Application.Exit()

        End If

    End Sub

End Class
'*******************************************************************************
' ﾌﾟﾛｸﾞﾗﾑ名     : メッセージボックス表示クラス
' ｿｰｽﾌﾟﾛｸﾞﾗﾑ名  : MsgBoxUtil.vb
' 処理概要      : メッセージを表示します。
' 作成          : 2019/04/05　T.otsuka(SoftCDC)　新規作成
'*******************************************************************************
Option Explicit On
Option Strict On

Public Class MsgBoxUtil

    ''' <summary>
    ''' エラーメッセージ表示
    ''' </summary>
    ''' <param name="msg">メッセージ</param>
    ''' <param name="title">タイトル</param>
    ''' <returns>DialogResult型</returns>
    Public Shared Function ShowError(ByVal msg As String, ByVal title As String) As DialogResult

        Dim dlgRes As DialogResult

        'エラーメッセージ用
        dlgRes = MessageBox.Show(msg, title,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1)
        Return dlgRes

    End Function

    ''' <summary>
    ''' 警告メッセージ表示
    ''' </summary>
    ''' <param name="msg">メッセージ</param>
    ''' <param name="title">タイトル</param>
    ''' <returns>DialogResult型</returns>
    Public Shared Function ShowExclamation(ByVal msg As String, ByVal title As String) As DialogResult

        Dim dlgRes As DialogResult

        '注意メッセージ用
        dlgRes = MessageBox.Show(msg, title,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)
        Return dlgRes

    End Function


    ''' <summary>
    ''' 情報メッセージ表示
    ''' </summary>
    ''' <param name="msg">メッセージ</param>
    ''' <param name="title">タイトル</param>
    ''' <returns>DialogResult型</returns>
    Public Shared Function ShowInfo(ByVal msg As String, ByVal title As String) As DialogResult

        Dim dlgRes As DialogResult

        '情報メッセージ用
        dlgRes = MessageBox.Show(msg, title,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1)
        Return dlgRes

    End Function


    ''' <summary>
    ''' 確認メッセージ表示１
    ''' </summary>
    ''' <param name="msg">メッセージ</param>
    ''' <param name="title">タイトル</param>
    ''' <returns>DialogResult型</returns>
    Public Shared Function ShowQuestion(ByVal msg As String, ByVal title As String) As DialogResult

        Dim dlgRes As DialogResult

        'OkCancel形式の確認メッセージ用(DefaultButton.Button1)
        dlgRes = MessageBox.Show(msg, title,
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button1)
        Return dlgRes

    End Function


    ''' <summary>
    ''' 確認メッセージ表示２
    ''' </summary>
    ''' <param name="msg">メッセージ</param>
    ''' <param name="title">タイトル</param>
    ''' <returns>DialogResult型</returns>
    Public Shared Function ShowQuestion2(ByVal msg As String, ByVal title As String) As DialogResult

        Dim dlgRes As DialogResult

        'OkCancel形式の確認メッセージ用(DefaultButton.Button2)
        dlgRes = MessageBox.Show(msg, title,
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2)
        Return dlgRes

    End Function


End Class

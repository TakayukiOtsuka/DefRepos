'*******************************************************************************
' ﾌﾟﾛｸﾞﾗﾑ名     : ログイン画面
' ｿｰｽﾌﾟﾛｸﾞﾗﾑ名  : BFrmSmall.vb
' 処理概要      : ログイン処理を実施します。
' 作成          : 2019/04/05　T.otsuka(SoftCDC)　新規作成
'*******************************************************************************
Option Explicit On
Option Strict On

Public Class FrmLogin

#Region "定数変数定義"

    '元カーソル保持用
    Private preCursor As Cursor

#End Region


#Region "イベントプロシージャ定義"

    ''' <summary>
    ''' フォームロード時
    ''' </summary>
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Debug.WriteLine("FrmLogin Called")

        preCursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor

        '画面初期化
        InitLoad()

        Cursor.Current = preCursor


    End Sub

    ''' <summary>
    ''' フォーム表示時
    ''' </summary>
    Private Sub FrmLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        '初期フォーカスセット
        TxtUserNm.Focus()

    End Sub

    ''' <summary>
    ''' テキストコントロール共通・フォーカス時
    ''' </summary>
    Private Sub Text_Enter(sender As Object, e As EventArgs) Handles TxtUserNm.Enter, TxtPassWd.Enter

        Dim txt As TextBox = CType(sender, TextBox)

        'テキスト選択
        txt.SelectAll()

    End Sub

    ''' <summary>
    ''' テキストコントロール共通・キー押下時
    ''' </summary>
    Private Sub TxtUserNm_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles _
            TxtUserNm.KeyPress,
            TxtPassWd.KeyPress

        'これは例です！！！
        '数字以外は入力不可
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    ''' <summary>
    ''' テキストコントロール共通・キー押下時
    ''' </summary>
    Private Sub TxtUserNm_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) _
        Handles _
            TxtUserNm.PreviewKeyDown,
            TxtPassWd.PreviewKeyDown


        'エンターキー押下なら？
        If e.KeyCode = Keys.Enter Then

            'タブキー入力
            SendKeys.Send("{tab}")

        End If

    End Sub

    ''' <summary>
    ''' パスワード変更ボタン押下時
    ''' </summary>
    Private Sub BtnChangePass_Click(sender As Object, e As EventArgs) Handles BtnChangePass.Click

        'パスワード変更画面表示　todo

    End Sub

    ''' <summary>
    ''' ログインボタン押下時
    ''' </summary>
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        'ログイン処理成功？
        If LoginProc() = True Then

            '自画面隠す
            Me.Hide()

            'メニュー画面表示
            Dim frm As New FrmMenu01
            frm.ShowDialog(Me)

        End If

    End Sub

    ''' <summary>
    ''' キャンセルボタン押下時
    ''' </summary>
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        '終了
        'Application.Exit()
        Me.Close()


    End Sub

#End Region


#Region "メソッド定義"

    ''' <summary>
    ''' 画面初期化
    ''' </summary>
    Private Sub InitLoad()

        TxtUserNm.Text = String.Empty
        TxtPassWd.Text = String.Empty

    End Sub



    ''' <summary>
    ''' ログイン処理
    ''' </summary>
    ''' <returns>ＴＲＵＥ：成功</returns>
    Private Function LoginProc() As Boolean

        '入力チェック
        If InputCheck() = False Then
            Return False
        End If


        '認証処理　todo



        'ユーザー情報格納
        gUser.UserId = "001"
        gUser.UserName = TxtUserNm.Text


        Return True

    End Function


    ''' <summary>
    ''' 入力チェック処理
    ''' </summary>
    ''' <returns></returns>
    Private Function InputCheck() As Boolean

        'ユーザー名
        If String.IsNullOrWhiteSpace(TxtUserNm.Text) = True Then

            MsgBoxUtil.ShowError("ユーザー名を入力してください。", My.Resources.APP_NAME)
            TxtUserNm.Focus()
            Return False

        End If

        'パスワード
        If String.IsNullOrWhiteSpace(TxtPassWd.Text) = True Then

            MsgBoxUtil.ShowError("パスワードを入力してください。", My.Resources.APP_NAME)
            TxtPassWd.Focus()
            Return False

        End If


        Return True

    End Function


#End Region

End Class

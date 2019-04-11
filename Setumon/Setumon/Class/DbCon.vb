'*******************************************************************************
' ﾌﾟﾛｸﾞﾗﾑ名     : ＤＢ処理クラス（未テスト！！！）
' ｿｰｽﾌﾟﾛｸﾞﾗﾑ名  : DbCon.vb
' 処理概要      : ＤＢ処理のライブラリクラスです。
' 作成          : 2019/04/05　T.otsuka(SoftCDC)　新規作成
'*******************************************************************************
Option Explicit On
Option Strict On

Imports System.Data.SqlClient

Public Class DbCon

    ''' <summary>
    ''' ＤＢ接続オブジェクト
    ''' </summary>
    Private Con As SqlConnection = Nothing


    ''' <summary>
    ''' トランザクションオブジェクト
    ''' </summary>
    Dim Trn As SqlTransaction = Nothing


    ''' <summary>
    ''' ＤＢ接続状態
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property IsEnabled As Boolean

        Get

            If Con Is Nothing OrElse
               Con.State = ConnectionState.Broken OrElse
               Con.State = ConnectionState.Closed Then

                Return False

            Else

                Return True

            End If

        End Get

    End Property


    ''' <summary>
    ''' エラーメッセージ
    ''' </summary>
    ''' <returns></returns>
    Public Property ErrorMsg As String


    ''' <summary>
    ''' デフォルトコンストラクタ
    ''' </summary>
    Public Sub DbCon()

        'デフォルトの接続先でＤＢオープン
        DbOpen()

    End Sub


    ''' <summary>
    ''' ＤＢオープン＋１
    ''' </summary>
    ''' <returns>ＴＲＵＥ：成功</returns>
    ''' <remarks>
    ''' デフォルトの接続先でＤＢオープン
    ''' </remarks>
    Public Function DbOpen() As Boolean

        '戻り値
        Dim blnRtn As Boolean = True


        '接続文字列作成
        Const CONSTR_TMP As String = "Server={0}; Initial Catalog={1}; User ID={2}; Password={3};"
        Dim strCon As String =
            String.Format(
                CONSTR_TMP,
                My.Resources.DB_SERVER,
                My.Resources.DB_SERVICE,
                My.Resources.DB_USERID,
                My.Resources.DB_PASSWD)

        Try
            'ＤＢ接続
            DbClose()
            Con = New SqlConnection(strCon)
            Con.Open()
            ErrorMsg = String.Empty

        Catch ex As Exception

            blnRtn = False
            ErrorMsg = ex.Message

        End Try

        Return blnRtn

    End Function


    ''' <summary>
    ''' ＤＢオープン＋２
    ''' </summary>
    ''' <param name="server">サーバー名</param>
    ''' <param name="service">サービス名</param>
    ''' <param name="userId">ユーザーＩＤ</param>
    ''' <param name="passWd">パスワード</param>
    ''' <returns>ＴＲＵＥ：成功</returns>
    ''' <remarks>
    ''' 指定パラメタの接続先でＤＢオープン
    ''' </remarks>
    Public Function DbOpen(server As String, service As String, userId As String, passWd As String) As Boolean

        '戻り値
        Dim blnRtn As Boolean = True

        '接続文字列作成
        Const CONSTR_TMP As String = "Server={0}; Initial Catalog={1}; User ID={2}; Password={3};"
        Dim strCon As String =
            String.Format(
                CONSTR_TMP,
                server,
                service,
                userId,
                passWd)

        Try
            'ＤＢ接続
            DbClose()
            Con = New SqlConnection(strCon)
            Con.Open()
            ErrorMsg = String.Empty

        Catch ex As Exception

            blnRtn = False
            ErrorMsg = ex.Message

        End Try

        Return blnRtn

    End Function


    ''' <summary>
    ''' ＤＢクローズ
    ''' </summary>
    Public Sub DbClose()

        Try

            'トランザクションロールバック
            RollbackTrans()

            'コネクション解放
            If Not Con Is Nothing Then
                Con.Close()
                Con.Dispose()
                Con = Nothing
            End If

        Catch ex As Exception

            '特に何もしない

        Finally

            ErrorMsg = "DB Connection Closed"

        End Try

    End Sub


    ''' <summary>
    ''' トランザクション開始
    ''' </summary>
    ''' <returns>ＴＲＵＥ：成功</returns>
    Public Function BeginTrans() As Boolean

        '接続無効なら終了
        If IsEnabled = False Then Return False

        '戻り値
        Dim blnRtn As Boolean = True

        Try

            'トランザクションを開始
            Trn = Con.BeginTransaction()

        Catch ex As Exception

            blnRtn = False
            ErrorMsg = ex.Message

        End Try


        Return blnRtn

    End Function


    ''' <summary>
    ''' トランザクション・コミット
    ''' </summary>
    ''' <returns>ＴＲＵＥ：成功</returns>
    Public Function CommitTrans() As Boolean

        '接続無効なら終了
        If IsEnabled = False Then Return False

        'トランザクション開始されてないなら終了
        If Trn Is Nothing Then Return False

        '戻り値
        Dim blnRtn As Boolean = True

        Try

            'トランザクションをコミット
            Trn.Commit()

        Catch ex As Exception

            blnRtn = False
            ErrorMsg = ex.Message

        Finally

            'トランザクションオブジェクト解放
            Trn.Dispose()
            Trn = Nothing

        End Try

        Return blnRtn

    End Function


    ''' <summary>
    ''' トランザクション・ロールバック
    ''' </summary>
    ''' <returns>ＴＲＵＥ：成功</returns>
    Public Function RollbackTrans() As Boolean

        '接続無効なら終了
        If IsEnabled = False Then Return False

        'トランザクション開始されてないなら終了
        If Trn Is Nothing Then Return False


        '戻り値
        Dim blnRtn As Boolean = True

        Try

            'トランザクションをロールバック
            Trn.Rollback()

        Catch ex As Exception

            blnRtn = False
            ErrorMsg = ex.Message

        Finally

            'トランザクションオブジェクト解放
            Trn.Dispose()
            Trn = Nothing

        End Try

        Return blnRtn

    End Function


    ''' <summary>
    ''' 更新クエリ実行
    ''' </summary>
    ''' <param name="query">クエリ文字列</param>
    ''' <returns>成功：0以上（更新件数）　失敗：-1</returns>
    Public Function ExecNonQuery(ByVal query As String) As Integer

        '接続無効なら終了
        If IsEnabled = False Then Return -1

        '戻り値
        Dim iRtn As Integer = -1

        Try

            'クエリ実行
            Using cmd As New SqlCommand(query, Con)
                iRtn = cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception

            ErrorMsg = ex.Message

        End Try

        Return iRtn

    End Function


    ''' <summary>
    ''' 照会クエリ実行（スカラー値取得）
    ''' </summary>
    ''' <param name="query">クエリ文字列</param>
    ''' <returns>成功：Object型　失敗：Nothing</returns>
    Public Function ExecScalar(ByVal query As String) As Object

        '接続無効なら終了
        If IsEnabled = False Then Return Nothing

        '戻り値
        Dim objRtn As Object = Nothing

        Try

            'クエリ実行
            Using cmd As New SqlCommand(query, Con)
                objRtn = cmd.ExecuteScalar()
            End Using

        Catch ex As Exception

            ErrorMsg = ex.Message

        End Try

        Return objRtn

    End Function


    ''' <summary>
    ''' 照会クエリ実行（結果セット取得）
    ''' </summary>
    ''' <param name="query">クエリ文字列</param>
    ''' <returns>成功：DataTable型　失敗：Nothing</returns>
    Public Function ExecGetDataSet(ByVal query As String) As DataTable

        '接続無効なら終了
        If IsEnabled = False Then Return Nothing

        '戻り値
        Dim dtRtn As DataTable = Nothing

        Try

            'クエリ実行
            Using cmd As New SqlCommand(query, Con)

                Dim adp As SqlDataAdapter = New SqlDataAdapter(cmd)

                'DataSet型にセット
                Dim ds As New DataSet
                adp.Fill(ds)

                '戻り値DataTable型取得
                dtRtn = ds.Tables(0)

            End Using


        Catch ex As Exception

            ErrorMsg = ex.Message

        End Try


        Return dtRtn

    End Function


End Class


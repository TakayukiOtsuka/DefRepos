'*******************************************************************************
' ﾌﾟﾛｸﾞﾗﾑ名     : ユーザー情報クラス
' ｿｰｽﾌﾟﾛｸﾞﾗﾑ名  : UserInfo.vb
' 処理概要      : ユーザー情報を格納するクラス
'               : ユーザーマスタ＋権限マスタに相当する
' 作成          : 2019/04/05　T.otsuka(SoftCDC)　新規作成
'*******************************************************************************
Option Explicit On
Option Strict On

''' <summary>
''' ユーザー情報格納クラス
''' </summary>
Public Class UserInfo

#Region "メンバ定義"

    ''' <summary>
    ''' ユーザーＩＤ
    ''' </summary>
    ''' <returns></returns>
    Public Property UserId As String

    ''' <summary>
    ''' ユーザー名
    ''' </summary>
    ''' <returns></returns>
    Public Property UserName As String

    ''' <summary>
    ''' ユーザー権限情報
    ''' </summary>
    Public Permissions As List(Of UserPermission)

#End Region



#Region "メソッド定義"

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub UserInfo()

        '初期化
        UserId = String.Empty
        UserName = String.Empty
        Permissions = New List(Of UserPermission)

    End Sub

#End Region

End Class

'パスワード
'処理年
'処理年度
'処理期
'等級名
'政令コード
'職種コード
'作業コード
'級コード
'職種頭文字
'職種名
'作業名
'累積集リンク
'原稿案リンク
'累積集リンク07
'原稿案リンク07
'累積集フルパス
'原稿案フルパス
'サーバー名
'ＤＢ名
'ＤＢ名06
'ＤＢ名07
'変換元DBﾊﾟｽ
'共通問題NO
'専門選択１
'専門選択２
'専門選択３
'ログイン日時
'ログインフラグ
'パスワード変更日時
'ロックフラグ
'ID

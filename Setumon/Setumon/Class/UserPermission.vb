'*******************************************************************************
' ﾌﾟﾛｸﾞﾗﾑ名     : ユーザー権限クラス
' ｿｰｽﾌﾟﾛｸﾞﾗﾑ名  : UserInfo.vb
' 処理概要      : ユーザー権限情報を格納するクラス
'               : 権限マスタに相当する
' 作成          : 2019/04/05　T.otsuka(SoftCDC)　新規作成
'*******************************************************************************
Option Explicit On
Option Strict On

''' <summary>
''' ユーザー権限クラス
''' </summary>
Public Class UserPermission

#Region "メンバ定義"
    Private IdVal As Integer
    Private Kyoka01Val As String
    Private Kyoka02Val As String
    Private Kyoka03Val As String
    Private Kyoka04Val As String
    Private Kyoka05Val As String
    Private Kyoka55Val As String
    Private Kyoka06Val As String
    Private Kyoka90Val As String
    Private Kyoka91Val As String
    Private Kyoka92Val As String
    Private SyokusyuNmVal As String
    Private KyokaSyokusyuCdVal As String
    Private KyokaKyuuCdVal As String
    Private SeireiCdVal As String
#End Region

#Region "プロパティ定義"
    ''' <summary>
    ''' ID
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Id() As Integer
        Get
            Return IdVal
        End Get
    End Property

    ''' <summary>
    ''' 許可01
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Kyoka01() As String
        Get
            Return Kyoka01Val
        End Get
    End Property

    ''' <summary>
    '''  許可02
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Kyoka02() As String
        Get
            Return Kyoka02Val
        End Get
    End Property

    ''' <summary>
    ''' 許可03
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Kyoka03() As String
        Get
            Return Kyoka03Val
        End Get
    End Property

    ''' <summary>
    ''' 許可04
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Kyoka04() As String
        Get
            Return Kyoka04Val
        End Get
    End Property

    ''' <summary>
    ''' 許可05
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Kyoka05() As String
        Get
            Return Kyoka05Val
        End Get
    End Property

    ''' <summary>
    ''' 許可55
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Kyoka55() As String
        Get
            Return Kyoka55Val
        End Get
    End Property

    ''' <summary>
    ''' 許可06
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Kyoka06() As String
        Get
            Return Kyoka06Val
        End Get
    End Property

    ''' <summary>
    ''' 許可90
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Kyoka90() As String
        Get
            Return Kyoka90Val
        End Get
    End Property

    ''' <summary>
    ''' 許可91
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Kyoka91() As String
        Get
            Return Kyoka91Val
        End Get
    End Property

    ''' <summary>
    ''' 許可92
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Kyoka92() As String
        Get
            Return Kyoka92Val
        End Get
    End Property

    ''' <summary>
    ''' 職種名
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SyokusyuNm() As String
        Get
            Return SyokusyuNmVal
        End Get
    End Property

    ''' <summary>
    ''' 許可職種コード
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property KyokaSyokusyuCd() As String
        Get
            Return KyokaSyokusyuCdVal
        End Get
    End Property

    ''' <summary>
    ''' 許可級コード
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property KyokaKyuuCd() As String
        Get
            Return KyokaKyuuCdVal
        End Get
    End Property

    ''' <summary>
    ''' 政令コード
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SeireiCd() As String
        Get
            Return SeireiCdVal
        End Get
    End Property
#End Region

#Region "メソッド定義"

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub Permission()

        '初期化
        Kyoka01Val = String.Empty
        Kyoka01Val = String.Empty
        Kyoka02Val = String.Empty
        Kyoka03Val = String.Empty
        Kyoka04Val = String.Empty
        Kyoka05Val = String.Empty
        Kyoka55Val = String.Empty
        Kyoka06Val = String.Empty
        Kyoka90Val = String.Empty
        Kyoka91Val = String.Empty
        Kyoka92Val = String.Empty
        SyokusyuNmVal = String.Empty
        KyokaSyokusyuCdVal = String.Empty
        KyokaKyuuCdVal = String.Empty
        SeireiCdVal = String.Empty

    End Sub

#End Region

End Class

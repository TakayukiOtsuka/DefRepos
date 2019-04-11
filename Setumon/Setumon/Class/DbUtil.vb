'*******************************************************************************
' ﾌﾟﾛｸﾞﾗﾑ名     : ＤＢ処理ユーティリティクラス
' ｿｰｽﾌﾟﾛｸﾞﾗﾑ名  : DbUtil.vb
' 処理概要      : ＤＢ処理時に使う機能クラスです。
' 作成          : 2019/04/05　T.otsuka(SoftCDC)　新規作成
'*******************************************************************************
Option Explicit On
Option Strict On

Public Class DbUtil

    ''' <summary>
    ''' NULL値変換関数１
    ''' </summary>
    ''' <param name="param">値</param>
    ''' <returns>文字列</returns>
    ''' <remarks>DBの値がNullなら""を返す</remarks>
    Public Shared Function NtoB(ByVal param As Object) As String
        Try
            If IsDBNull(param) = True Then
                Return ""
            Else
                Return RTrim(CStr(param))
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function


    ''' <summary>
    ''' NULL値変換関数２
    ''' </summary>
    ''' <param name="param">値</param>
    ''' <returns>"0"文字</returns>
    ''' <remarks>DBの値がNullなら"0"を返す</remarks>
    Public Shared Function NtoZ(ByVal param As Object) As String
        Try
            If IsDBNull(param) = True Then
                Return "0"
            Else
                Return CStr(Integer.Parse(CStr(param)))
            End If
        Catch ex As Exception
            Return "0"
        End Try
    End Function


    ''' <summary>
    ''' NULL値変換関数３
    ''' </summary>
    ''' <param name="param">値</param>
    ''' <returns>文字列</returns>
    ''' <remarks>DBの値がNullならｽﾍﾟｰｽを返す</remarks>
    Public Shared Function NtoS(ByVal param As Object) As String
        Try
            If IsDBNull(param) = True Then
                Return " "
            Else
                Return Trim(CStr(param))
            End If
        Catch ex As Exception
            Return " "
        End Try
    End Function


    ''' <summary>
    ''' NULL値変換関数４
    ''' </summary>
    ''' <param name="param">値</param>
    ''' <returns>Double</returns>
    ''' <remarks>DBの値をDouble型で返す。Null等は0を返す。</remarks>
    Public Shared Function NtoDbl(ByVal param As Object) As Double
        If IsDBNull(param) = True Then Return 0
        If IsNumeric(CStr(param)) = False Then Return 0

        Return CDbl(CStr(param))
    End Function


    ''' <summary>
    '''  NULL値変換関数５
    ''' </summary>
    ''' <param name="param">値</param>
    ''' <returns>Long</returns>
    ''' <remarks>DBの値がNullなら長整数0を返す</remarks>
    Public Shared Function NtoLong(ByVal param As Object) As Long
        Dim wPara As String

        Try
            If IsDBNull(param) = True Then
                Return 0
            Else
                wPara = CStr(param)
                If IsNumeric(wPara) = True Then
                    Return CLng(wPara)
                Else
                    Return 0
                End If
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function


    ''' <summary>
    '''  NULL値変換関数６
    ''' </summary>
    ''' <param name="param">値</param>
    ''' <returns>Integer</returns>
    ''' <remarks>DBの値がNullなら整数0を返す</remarks>
    Public Shared Function NtoInt(ByVal param As Object) As Integer
        Dim wPara As String

        Try
            If IsDBNull(param) = True Then
                Return 0
            Else
                wPara = CStr(param)
                If IsNumeric(wPara) = True Then
                    Return CInt(wPara)
                Else
                    Return 0
                End If
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function


    ''' <summary>
    ''' 文字列をシングルクォートで括る
    ''' </summary>
    ''' <param name="param">String</param>
    ''' <returns>文字列</returns>
    ''' <remarks>文字列中に"'"があったら"''"にする</remarks>
    Public Shared Function WareQ(ByVal param As String) As String
        Return WareQ(param, "'")
    End Function


    ''' <summary>
    ''' 文字列を指定文字で括る
    ''' </summary>
    ''' <param name="param">文字列</param>
    ''' <param name="quote">括る指定文字</param>
    ''' <returns>文字列</returns>
    Public Shared Function WareQ(ByVal param As String, ByVal quote As String) As String
        Dim sValue As String
        sValue = param
        sValue = Replace(sValue, quote, quote & quote)
        Return quote & sValue & quote
    End Function


End Class

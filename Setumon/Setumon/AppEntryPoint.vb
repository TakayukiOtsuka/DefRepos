'*******************************************************************************
' ﾌﾟﾛｸﾞﾗﾑ名     : エントリポイント
' ｿｰｽﾌﾟﾛｸﾞﾗﾑ名  : AppEntryPoint.vb
' 処理概要      : システム起動処理を行う
' 作成          : 2019/04/05　T.otsuka(SoftCDC)　新規作成
'*******************************************************************************
Option Explicit On
Option Strict On

Public Class AppEntryPoint

    <STAThread()>
    Shared Sub Main()

        '多重起動の判定
        Dim strProccNm As String = Process.GetCurrentProcess().ProcessName
        If Process.GetProcessesByName(strProccNm).Length > 1 Then

            'エラーメッセージ
            MessageBox.Show(
                "すでに起動しています。",
                My.Resources.APP_NAME,
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1)

            '終了
            Return

        End If


        'ＤＢ接続チェック　todo

        'ファイル存在チェック　todo
        'If Dir(CStr(System.Windows.Forms.Application.StartupPath) & "\" & gINIFileName) = "" Then
        '    Return False
        'End If


        'ログイン画面表示
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New FrmLogin())

    End Sub

End Class

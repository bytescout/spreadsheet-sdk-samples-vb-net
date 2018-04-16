'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.IO

Module Module1

    Sub Main()

        Using spreadsheet As New Spreadsheet

            ' Load JSON string from file
            Dim jsonString As String = File.ReadAllText("sample.json")

            ' Import JSON
            spreadsheet.ImportFromJSON(jsonString)

            ' Save spreadsheet
            spreadsheet.SaveAsXLS("result.xls")

            ' Open the result file in default associated application
            Process.Start("result.xls")

        End Using

    End Sub

End Module

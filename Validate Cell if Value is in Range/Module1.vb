'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.IO

Module Module1

    Sub Main()
        ' Create new Spreadsheet
        Dim document As Spreadsheet = New Spreadsheet()
        document.LoadFromFile("Data.xls")

        ' Get worksheet by name
        Dim worksheet As Worksheet = document.Workbook.Worksheets.ByName("Sample")

        ' Minimum age
        Dim RangeMin As Integer = 10
        ' Maximum age
        Dim RangeMax As Integer = 19

        ' Spellcheck words
        For i As Integer = 1 To 7
            ' Set current cell
            Dim currentCell As Cell = worksheet.Cell(i, 1)

            ' Check current cell
            If System.Convert.ToInt32(currentCell.Value) < RangeMin Or System.Convert.ToInt32(currentCell.Value) > RangeMax Then
                ' Set fill pattern
                currentCell.FillPattern = Bytescout.Spreadsheet.Constants.PatternStyle.Solid

                ' Markup wrong cell by red color
                currentCell.FillPatternForeColor = System.Drawing.Color.Red
            End If
        Next


        ' remove output file if already exists
        If File.Exists("Output.xls") Then
            File.Delete("Output.xls")
        End If

        ' Save document
        document.SaveAs("Output.xls")

        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.xls")

    End Sub

End Module

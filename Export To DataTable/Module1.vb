'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Module Module1

    Sub Main()
        Dim inputFile As String = "PeriodicTableOfElementsSpreadsheet.xls"

        'Open and load spreadsheet
        Dim spreadsheet = New Spreadsheet()
        spreadsheet.LoadFromFile(inputFile)

        'Get the data from the spreadsheet
        Dim dt As DataTable = spreadsheet.ExportToDataTable()

        'Close spreadsheet
        spreadsheet.Close()

        'Display data in datatable
        For i As Integer = 0 To dt.Rows.Count - 1
            For j As Integer = 0 To dt.Columns.Count - 1

                Console.Write(dt.Rows(i)(j) + " ")
            Next
            Console.WriteLine()
        Next

        'Pause
        Console.ReadLine()
    End Sub

End Module

Imports System.Data.SqlClient
Imports Newtonsoft.Json

Public Class D_TDTransaction

    Public Function GetTableDetails(TranNo As String, TranDate As String, Accountnumber As String, Amount As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT * FROM TDTransaction "
            strSQL &= "WHERE TransactionNo = '" & TranNo & "' "
            strSQL &= "AND DATEPART(MONTH,TransactionDate) = DATEPART(MONTH,'" & TranDate & "') "
            strSQL &= "AND DATEPART(DAY,TransactionDate) = DATEPART(DAY,'" & TranDate & "') "
            strSQL &= "AND DATEPART(YEAR,TransactionDate) = DATEPART(YEAR,'" & TranDate & "') "
            strSQL &= "AND FKAccountNumberTransaction = '" & Accountnumber & "' "
            strSQL &= "AND Amount = '" & Amount & "' "

            dad = New SqlDataAdapter(strSQL, connection)
            dtb.Rows.Clear()
            dad.Fill(dtb)

            Return dtb
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        Finally
            dtb.Dispose()
            dad.Dispose()
            connection.Close()
        End Try

    End Function


    Public Function SetDataTableToClass(clsObject As M_TDTransaction, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear() '= MyDataTable.Rows(0).Item("")

                .TransactionNo = MyDataTable.Rows(0).Item("TransactionNo")
                .TransactionDate = MyDataTable.Rows(0).Item("TransactionDate")
                .FKAccountNumberTransaction = MyDataTable.Rows(0).Item("FKAccountNumberTransaction")
                .FKTransactionTypeCode = MyDataTable.Rows(0).Item("FKTransactionTypeCode")
                .Amount = MyDataTable.Rows(0).Item("Amount")
                .RunningBalance = MyDataTable.Rows(0).Item("RunningBalance")
                .TransactedBy = MyDataTable.Rows(0).Item("TransactedBy")
                .OverrideBy = MyDataTable.Rows(0).Item("OverrideBy")
                .StationName = MyDataTable.Rows(0).Item("StationName")
                .ReferenceNo = MyDataTable.Rows(0).Item("ReferenceNo")
                .IsPrintedPassbook = MyDataTable.Rows(0).Item("IsPrintedPassbook")
                .Particulars = MyDataTable.Rows(0).Item("Particulars")
                .TransactionTime = MyDataTable.Rows(0).Item("TransactionTime")
                .FKBranchIDTransaction = MyDataTable.Rows(0).Item("FKBranchIDTransaction")
                .AvgDailyBalanceTran = MyDataTable.Rows(0).Item("AvgDailyBalanceTran")
                .IsCancelled = MyDataTable.Rows(0).Item("IsCancelled")
                .AvailableBalance = MyDataTable.Rows(0).Item("AvailableBalance")
                .ParentTransactionNo = MyDataTable.Rows(0).Item("ParentTransactionNo")
            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try

    End Function
End Class

Imports System.Data.SqlClient
Imports Newtonsoft.Json
Public Class D_MortuaryDetails

    Public Function GetTableDetails(Accountnumber As String, TranNo As String, TranDate As String, Amount As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT TOP 1 * FROM MortuaryDetails "
            strSQL &= "WHERE FKCustomerIDAccount = '" & Accountnumber & "' "
            strSQL &= "AND TransactionNo = '" & TranNo & "' "
            strSQL &= "AND DATEPART(MONTH,TransactionDate) = DATEPART(MONTH,'" & TranDate & "') "
            strSQL &= "AND DATEPART(DAY,TransactionDate) = DATEPART(DAY,'" & TranDate & "') "
            strSQL &= "AND DATEPART(YEAR,TransactionDate) = DATEPART(YEAR,'" & TranDate & "') "
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


    Public Function SetDataTableToClass(clsObject As M_MortuaryDetails, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear() '= MyDataTable.Rows(0).Item("")

                .FKCustomerIDAccount = MyDataTable.Rows(0).Item("FKCustomerIDAccount")
                .TransactionNo = MyDataTable.Rows(0).Item("TransactionNo")
                .TransactionDate = MyDataTable.Rows(0).Item("TransactionDate")
                .TransactionTime = MyDataTable.Rows(0).Item("TransactionTime")
                .FKBranchIDTransaction = MyDataTable.Rows(0).Item("FKBranchIDTransaction")
                .FKTransactionTypeCode = MyDataTable.Rows(0).Item("FKTransactionTypeCode")
                .ReferenceNo = Common.CheckForDBNull(MyDataTable.Rows(0).Item("ReferenceNo"), Common.SystemTypeValue._String)
                .Remarks = MyDataTable.Rows(0).Item("Remarks")
                .Amount = MyDataTable.Rows(0).Item("Amount")
                .IsCancelled = MyDataTable.Rows(0).Item("IsCancelled")
                .StationName = MyDataTable.Rows(0).Item("StationName")
                .TransactedBy = MyDataTable.Rows(0).Item("TransactedBy")
                .OverrideBy = Common.CheckForDBNull(MyDataTable.Rows(0).Item("OverrideBy"), Common.SystemTypeValue._String)
                .row_version = MyDataTable.Rows(0).Item("row_version")
                .FKPolicyNumber = Common.CheckForDBNull(MyDataTable.Rows(0).Item("FKPolicyNumber"), Common.SystemTypeValue._String)
            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try

    End Function
End Class

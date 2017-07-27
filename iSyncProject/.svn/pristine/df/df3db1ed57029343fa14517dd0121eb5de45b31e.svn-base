Imports System.Data.SqlClient
Imports Newtonsoft.Json

Public Class D_LoanTranMaster
    Public Function GetTableDetails(Accountnumber As String, TranNo As String, TranDate As String, Amount As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT TOP 1 * FROM LoanTranMaster "
            strSQL &= "WHERE FKAccountNumberTransaction = '" & Accountnumber & "' "
            strSQL &= "and TransactionNo = '" & TranNo & "' "
            strSQL &= "AND DATEPART(MONTH,TransactionDate) = DATEPART(MONTH,'" & TranDate & "') "
            strSQL &= "AND DATEPART(DAY,TransactionDate) = DATEPART(DAY,'" & TranDate & "') "
            strSQL &= "AND DATEPART(YEAR,TransactionDate) = DATEPART(YEAR,'" & TranDate & "') "
            strSQL &= "and Amount = '" & Amount & "' "

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


    Public Function SetDataTableToClass(clsObject As M_LoanTranMaster, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear()

                .FKAccountNumberTransaction = MyDataTable.Rows(0).Item("FKAccountNumberTransaction")
                .TransactionNo = MyDataTable.Rows(0).Item("TransactionNo")
                .TransactionDate = MyDataTable.Rows(0).Item("TransactionDate")
                .Amount = MyDataTable.Rows(0).Item("Amount")
                .FKLNTransactionCodeTran = MyDataTable.Rows(0).Item("FKLNTransactionCodeTran")
                .Reference = Common.CheckForDBNull(MyDataTable.Rows(0).Item("Reference"), Common.SystemTypeValue._String)
                .PrinCredit = MyDataTable.Rows(0).Item("PrinCredit")
                .PrinDebit = MyDataTable.Rows(0).Item("PrinDebit")
                .InterestCredit = MyDataTable.Rows(0).Item("InterestCredit")
                .InterestDebit = MyDataTable.Rows(0).Item("InterestDebit")
                .PenaltyCredit = MyDataTable.Rows(0).Item("PenaltyCredit")
                .PenaltyDebit = MyDataTable.Rows(0).Item("PenaltyDebit")
                .RebateCredit = MyDataTable.Rows(0).Item("RebateCredit")
                .RebateDebit = MyDataTable.Rows(0).Item("RebateDebit")
                .OtherCredit = MyDataTable.Rows(0).Item("OtherCredit")
                .OtherDebit = MyDataTable.Rows(0).Item("OtherDebit")
                .Balance = MyDataTable.Rows(0).Item("Balance")
                .TransactedBy = MyDataTable.Rows(0).Item("TransactedBy")
                .ApprovedBy = MyDataTable.Rows(0).Item("ApprovedBy")
                .StationName = MyDataTable.Rows(0).Item("StationName")
                .Particulars = Common.CheckForDBNull(MyDataTable.Rows(0).Item("Particulars"), Common.SystemTypeValue._String)
                .FKBranchIDTransaction = MyDataTable.Rows(0).Item("FKBranchIDTransaction")
                .TransactionTime = MyDataTable.Rows(0).Item("TransactionTime")
                .IsCancelled = MyDataTable.Rows(0).Item("IsCancelled")
                .IncentiveDebit = Common.CheckForDBNull(MyDataTable.Rows(0).Item("IncentiveDebit"), Common.SystemTypeValue._Integer)
                .IncentiveCredit = Common.CheckForDBNull(MyDataTable.Rows(0).Item("IncentiveCredit"), Common.SystemTypeValue._Integer)
                .PaymentChange = Common.CheckForDBNull(MyDataTable.Rows(0).Item("PaymentChange"), Common.SystemTypeValue._Integer)
                .DisbursementType = MyDataTable.Rows(0).Item("DisbursementType")
                .Lacking = MyDataTable.Rows(0).Item("Lacking")
                .IsWalkin = MyDataTable.Rows(0).Item("IsWalkin")
            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try

    End Function
End Class

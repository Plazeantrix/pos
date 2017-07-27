Imports System.Data.SqlClient
Imports Newtonsoft.Json
Public Class D_SavingsAccount
    Public Function GetTableDetails(ByVal AccountNumber As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT TOP 1 * FROM SavingsAccount "
            strSQL &= "WHERE ACCOUNTNUMBER = '" & AccountNumber & "' "

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


    Public Function SetDataTableToClass(clsObject As M_SavingsAccount, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear() '= MyDataTable.Rows(0).Item("")

                .AccountNumber = MyDataTable.Rows(0).Item("AccountNumber")
                .FKCustomerIDAccount = MyDataTable.Rows(0).Item("FKCustomerIDAccount")
                .AccountName = MyDataTable.Rows(0).Item("AccountName")
                .FKSAProductIDAccount = MyDataTable.Rows(0).Item("FKSAProductIDAccount")
                .AccountStatus = MyDataTable.Rows(0).Item("AccountStatus")
                .FKBranchIDAccount = MyDataTable.Rows(0).Item("FKBranchIDAccount")
                .FKOwnerCode = MyDataTable.Rows(0).Item("FKOwnerCode")
                .LastTransactionDate = MyDataTable.Rows(0).Item("LastTransactionDate")
                .LastInterestPostDate = MyDataTable.Rows(0).Item("LastInterestPostDate")
                .LastInterestAccrualDate = MyDataTable.Rows(0).Item("LastInterestAccrualDate")
                .AccruedInterest = MyDataTable.Rows(0).Item("AccruedInterest")
                .InterestRate = MyDataTable.Rows(0).Item("InterestRate")
                .OpeningDate = MyDataTable.Rows(0).Item("OpeningDate")
                .OpenedBy = MyDataTable.Rows(0).Item("OpenedBy")
                .Balance = MyDataTable.Rows(0).Item("Balance")
                .HoldBalance = MyDataTable.Rows(0).Item("HoldBalance")
                .AvgDailyBalance = MyDataTable.Rows(0).Item("AvgDailyBalance")
                .ATMCardNo = MyDataTable.Rows(0).Item("ATMCardNo")
                .PassbookNo = MyDataTable.Rows(0).Item("PassbookNo")
                .PassbookLineNo = MyDataTable.Rows(0).Item("PassbookLineNo")
                .ATAAcctNumber = MyDataTable.Rows(0).Item("ATAAcctNumber")
                .LastDormancyDate = MyDataTable.Rows(0).Item("LastDormancyDate")
                .MaintaininBalCounter = MyDataTable.Rows(0).Item("MaintaininBalCounter")
                .CompoundedInterest = MyDataTable.Rows(0).Item("CompoundedInterest")
                .AIPLastMonth = MyDataTable.Rows(0).Item("AIPLastMonth")
                .AIP = MyDataTable.Rows(0).Item("AIP")
                .RowVersion = MyDataTable.Rows(0).Item("RowVersion")
            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try

    End Function
End Class

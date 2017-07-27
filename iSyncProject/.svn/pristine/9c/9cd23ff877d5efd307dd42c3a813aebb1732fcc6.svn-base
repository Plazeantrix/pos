Imports System.Data.SqlClient
Imports Newtonsoft.Json

Public Class D_ShareAccount

    Public Function GetTableDetails(ByVal MyAccountNumber As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT TOP 1 * FROM SHAREACCOUNT "
            strSQL &= "WHERE ACCOUNTNUMBER = '" & MyAccountNumber & "' "

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


    Public Function SetDataTableToClass(clsObject As M_ShareAccount, MyDataTable As DataTable) As String
        Try

            With clsObject
                .Clear()

                .AccountNumber = MyDataTable.Rows(0).Item("AccountNumber")
                .FKCustomerIDAccount = MyDataTable.Rows(0).Item("FKCustomerIDAccount")
                .FKSCProductIDAccount = MyDataTable.Rows(0).Item("FKSCProductIDAccount")
                .AccountStatus = MyDataTable.Rows(0).Item("AccountStatus")
                .FKBranchIDAccount = MyDataTable.Rows(0).Item("FKBranchIDAccount")
                .FKOwnerCode = MyDataTable.Rows(0).Item("FKOwnerCode")
                .NoOfShares = MyDataTable.Rows(0).Item("NoOfShares")
                .TotalSubscription = MyDataTable.Rows(0).Item("TotalSubscription")
                .LastTransactionDate = MyDataTable.Rows(0).Item("LastTransactionDate")
                .LastInterestPostDate = MyDataTable.Rows(0).Item("LastInterestPostDate")
                .LastInterestAccrualDate = MyDataTable.Rows(0).Item("LastInterestAccrualDate")
                .AccruedInterest = MyDataTable.Rows(0).Item("AccruedInterest")
                .InterestRate = MyDataTable.Rows(0).Item("InterestRate")
                .OpeningDate = MyDataTable.Rows(0).Item("OpeningDate")
                .OpenedBy = MyDataTable.Rows(0).Item("OpenedBy")
                .Balance = MyDataTable.Rows(0).Item("Balance")
                .HoldBalance = MyDataTable.Rows(0).Item("HoldBalance")
                .CumShareMonth = MyDataTable.Rows(0).Item("CumShareMonth")
                .PassbookNo = MyDataTable.Rows(0).Item("PassbookNo")
                .AvgDailyBalance = MyDataTable.Rows(0).Item("AvgDailyBalance")
                .PassbookLineNo = MyDataTable.Rows(0).Item("PassbookLineNo")
                .MonthAccruedInterest = MyDataTable.Rows(0).Item("MonthAccruedInterest")
                .TotalAccruedInterest = MyDataTable.Rows(0).Item("TotalAccruedInterest")
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

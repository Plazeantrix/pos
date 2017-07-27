Imports System.Data.SqlClient
Imports Newtonsoft.Json

Public Class D_TdAccount

    Public Function GetTableDetails(ByVal AccountNumber As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT TOP 1 * FROM TDAccount "
            strSQL &= "WHERE AccountNumber = '" & AccountNumber & "' "

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


    Public Function SetDataTableToClass(clsObject As M_TdAccount, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear() '= MyDataTable.Rows(0).Item("")

                .AccountNumber = MyDataTable.Rows(0).Item("AccountNumber")
                .FKCustomerIDAccount = MyDataTable.Rows(0).Item("FKCustomerIDAccount")
                .AccountName = MyDataTable.Rows(0).Item("AccountName")
                .FKTDProductIDAccount = MyDataTable.Rows(0).Item("FKTDProductIDAccount")
                .AccountStatus = MyDataTable.Rows(0).Item("AccountStatus")
                .FKBranchIDAccount = MyDataTable.Rows(0).Item("FKBranchIDAccount")
                .FKOwnerCode = MyDataTable.Rows(0).Item("FKOwnerCode")
                .LastTransactionDate = MyDataTable.Rows(0).Item("LastTransactionDate")
                .LastInterestPostDate = MyDataTable.Rows(0).Item("LastInterestPostDate")
                .LastInterestAccrualDate = MyDataTable.Rows(0).Item("LastInterestAccrualDate")
                .OpeningDate = MyDataTable.Rows(0).Item("OpeningDate")
                .OpeningAmount = MyDataTable.Rows(0).Item("OpeningAmount")
                .TermStartDate = MyDataTable.Rows(0).Item("TermStartDate")
                .OpenedBy = MyDataTable.Rows(0).Item("OpenedBy")
                .Balance = MyDataTable.Rows(0).Item("Balance")
                .HoldBalance = MyDataTable.Rows(0).Item("HoldBalance")
                .PassbookNo = MyDataTable.Rows(0).Item("PassbookNo")
                .PassbookLineNo = MyDataTable.Rows(0).Item("PassbookLineNo")
                .MaturityDate = MyDataTable.Rows(0).Item("MaturityDate")
                .CTDNumber = MyDataTable.Rows(0).Item("CTDNumber")
                .Term = MyDataTable.Rows(0).Item("Term")
                .TermInMonths = MyDataTable.Rows(0).Item("TermInMonths")
                .TermInterest = MyDataTable.Rows(0).Item("TermInterest")
                .PreviousTerm = MyDataTable.Rows(0).Item("PreviousTerm")
                .PreviousTermInterest = MyDataTable.Rows(0).Item("PreviousTermInterest")
                .ActualDaysRolled = MyDataTable.Rows(0).Item("ActualDaysRolled")
                .PreviousInterestPostDate = MyDataTable.Rows(0).Item("PreviousInterestPostDate")
                .RowVersion = MyDataTable.Rows(0).Item("RowVersion")
                .IsInstallment = MyDataTable.Rows(0).Item("IsInstallment")
                .IsInstallmentClosed = MyDataTable.Rows(0).Item("IsInstallmentClosed")
                .DateInstClosed = MyDataTable.Rows(0).Item("DateInstClosed")
                .AIP = MyDataTable.Rows(0).Item("AIP")
                .AIPLastMonth = MyDataTable.Rows(0).Item("AIPLastMonth")
                .CompoundedTermInt = MyDataTable.Rows(0).Item("CompoundedTermInt")
            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try
    End Function
End Class

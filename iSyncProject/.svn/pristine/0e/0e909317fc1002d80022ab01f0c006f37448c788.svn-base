Imports System.Data.SqlClient
Imports Newtonsoft.Json
Public Class D_MortuaryHeader

    Public Function GetTableDetails(ByVal AccountNumber As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT TOP 1 * FROM MortuaryHEADER "
            strSQL &= "WHERE FKCustomerIDAccount = '" & AccountNumber & "' "

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


    Public Function SetDataTableToClass(clsObject As M_MortuaryHeader, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear() '= MyDataTable.Rows(0).Item("")

                .FKCustomerIDAccount = MyDataTable.Rows(0).Item("FKCustomerIDAccount")
                .FKBranchIDAccount = MyDataTable.Rows(0).Item("FKBranchIDAccount")
                .FKProductID = MyDataTable.Rows(0).Item("FKProductID")
                .MortuaryStatus = MyDataTable.Rows(0).Item("MortuaryStatus")
                .PreviousMortuaryStatus = MyDataTable.Rows(0).Item("PreviousMortuaryStatus")
                .LastTransactionDate = MyDataTable.Rows(0).Item("LastTransactionDate")
                .LastStartDate = MyDataTable.Rows(0).Item("LastStartDate")
                .DateEnrolled = MyDataTable.Rows(0).Item("DateEnrolled")
                .OpenedBy = MyDataTable.Rows(0).Item("OpenedBy")
                .CoverageStartDate = MyDataTable.Rows(0).Item("CoverageStartDate")
                .CoverageEndDate = MyDataTable.Rows(0).Item("CoverageEndDate")
                .Premium = MyDataTable.Rows(0).Item("Premium")
                .PolicyNumber = MyDataTable.Rows(0).Item("PolicyNumber")
                .SavingsAccountNumber = Common.CheckForDBNull(MyDataTable.Rows(0).Item("SavingsAccountNumber"), Common.SystemTypeValue._String)
                .MonthUsedUp = MyDataTable.Rows(0).Item("MonthUsedUp")
                .TotalMonthUsedUp = MyDataTable.Rows(0).Item("TotalMonthUsedUp")
                .UsedDays = MyDataTable.Rows(0).Item("UsedDays")
                .CauseOfDeath = MyDataTable.Rows(0).Item("CauseOfDeath")
                .DateDied = MyDataTable.Rows(0).Item("DateDied")
                .AutoDeductPRD = MyDataTable.Rows(0).Item("AutoDeductPRD")
                .AutoDeductSavings = MyDataTable.Rows(0).Item("AutoDeductSavings")
                .AutoDeductLoans = MyDataTable.Rows(0).Item("AutoDeductLoans")
                .row_version = MyDataTable.Rows(0).Item("row_version")
                .IsWreathClaimed = MyDataTable.Rows(0).Item("IsWreathClaimed")
                .WreathCashAmount = MyDataTable.Rows(0).Item("WreathCashAmount")
                .DeathAidAmountClaimed = MyDataTable.Rows(0).Item("DeathAidAmountClaimed")
            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try
    End Function
End Class

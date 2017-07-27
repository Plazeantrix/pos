Imports System.Data.SqlClient
Imports Newtonsoft.Json


Public Class D_LoanProtectionAccount
    Public Function GetTableDetails(ByVal AccountNumber As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT TOP 1 * FROM LoanProtectionAccount "
            strSQL &= "WHERE FKACCOUNTNUMBER = '" & AccountNumber & "' "

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


    Public Function SetDataTableToClass(clsObject As M_LoanProtectionAccount, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear()

                .FKAccountNumber = MyDataTable.Rows(0).Item("FKAccountNumber")
                .FKCustomerID = MyDataTable.Rows(0).Item("FKCustomerID")
                .FKProtectionTypeID = MyDataTable.Rows(0).Item("FKProtectionTypeID")
                .AmountPremium = MyDataTable.Rows(0).Item("AmountPremium")
                .AccountStatus = MyDataTable.Rows(0).Item("AccountStatus")
                .Commission = MyDataTable.Rows(0).Item("Commission")
                .Rebate = MyDataTable.Rows(0).Item("Rebate")
                .DailyFactor = MyDataTable.Rows(0).Item("DailyFactor")
                .TermInMonths = MyDataTable.Rows(0).Item("TermInMonths")
                .TermInDays = MyDataTable.Rows(0).Item("TermInDays")
                .DateStarted = MyDataTable.Rows(0).Item("DateStarted")
                .MaturityDate = MyDataTable.Rows(0).Item("MaturityDate")
                .DateTerminated = MyDataTable.Rows(0).Item("DateTerminated")
                .DateClaimed = MyDataTable.Rows(0).Item("DateClaimed")
                .DateClosed = MyDataTable.Rows(0).Item("DateClosed")
                .Remarks = MyDataTable.Rows(0).Item("Remarks")
                .IsTerminated = MyDataTable.Rows(0).Item("IsTerminated")
                .IsClaimed = MyDataTable.Rows(0).Item("IsClaimed")
                .PolicyNo = MyDataTable.Rows(0).Item("PolicyNo")
                .PolicyDateModified = MyDataTable.Rows(0).Item("PolicyDateModified")
                .PolicyModifiedBy = Common.CheckForDBNull(MyDataTable.Rows(0).Item("PolicyModifiedBy"), Common.SystemTypeValue._String)
            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try

    End Function
End Class

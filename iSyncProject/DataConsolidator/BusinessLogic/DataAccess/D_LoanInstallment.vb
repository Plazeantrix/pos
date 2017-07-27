Imports System.Data.SqlClient
Imports Newtonsoft.Json


Public Class D_LoanInstallment
    Public Function GetTableDetails(ByVal AccountNumber As String, ByVal INSTLLMENTNUM As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT * FROM dbo.LoanInstallment "
            strSQL &= "WHERE FKAccountNumberInst = '" & AccountNumber & "' "
            strSQL &= "AND InstallmentNumber = '" & INSTLLMENTNUM & "' "
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


    Public Function SetDataTableToClass(clsObject As M_LoanInstallment, MyDataTable As DataTable) As String

        Try
            With clsObject
                .Clear()

                .FKAccountNumberInst = MyDataTable.Rows(0).Item("FKAccountNumberInst")
                .InstallmentNumber = MyDataTable.Rows(0).Item("InstallmentNumber")
                .Status = MyDataTable.Rows(0).Item("Status")
                .DueDate = MyDataTable.Rows(0).Item("DueDate")
                .RepayAmount = MyDataTable.Rows(0).Item("RepayAmount")
                .PrincipalPayable = MyDataTable.Rows(0).Item("PrincipalPayable")
                .InterestPayable = MyDataTable.Rows(0).Item("InterestPayable")
                .PrincipalBalance = MyDataTable.Rows(0).Item("PrincipalBalance")
                .PrincipalPaid = MyDataTable.Rows(0).Item("PrincipalPaid")
                .InterestPaid = MyDataTable.Rows(0).Item("InterestPaid")
                .IsIntPaid = MyDataTable.Rows(0).Item("IsIntPaid")
                .IsPenPaid = MyDataTable.Rows(0).Item("IsPenPaid")
                .PenaltyComp = MyDataTable.Rows(0).Item("PenaltyComp")
                .PenaltyPaid = MyDataTable.Rows(0).Item("PenaltyPaid")
                .RebateAmount = MyDataTable.Rows(0).Item("RebateAmount")
                .RebatePosted = MyDataTable.Rows(0).Item("RebatePosted")
                .RebateDate = MyDataTable.Rows(0).Item("RebateDate")
            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try

    End Function
End Class

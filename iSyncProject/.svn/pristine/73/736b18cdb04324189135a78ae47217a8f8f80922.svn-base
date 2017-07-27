Imports System.Data.SqlClient
Imports Newtonsoft.Json

Public Class D_GLBalance

    Public Function GetTableDetails(ByVal MyGlcode As String, MyTranDate As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT * FROM dbo.GLBalance "
            strSQL &= " WHERE FKAccountCodeGLBal = '" & MyGlcode & "' "
            strSQL &= "AND DATEPART(MONTH,TransactionDate) = DATEPART(MONTH,'" & MyTranDate & "') "
            strSQL &= "AND DATEPART(DAY,TransactionDate) = DATEPART(DAY,'" & MyTranDate & "') "
            strSQL &= "AND DATEPART(YEAR,TransactionDate) = DATEPART(YEAR,'" & MyTranDate & "') "
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


    Public Function SetDataTableToClass(clsObject As M_GLBalance, MyDataTable As DataTable) As String

        Try
            With clsObject
                .Clear()

                .TransactionDate = MyDataTable.Rows(0).Item("TransactionDate")
                .FKBranchIDGLBal = MyDataTable.Rows(0).Item("FKBranchIDGLBal")
                .FKAccountCodeGLBal = MyDataTable.Rows(0).Item("FKAccountCodeGLBal")
                .BeginningBalance = MyDataTable.Rows(0).Item("BeginningBalance")
                .DebitAmount = MyDataTable.Rows(0).Item("DebitAmount")
                .CreditAmount = MyDataTable.Rows(0).Item("CreditAmount")
                .EndingBalance = MyDataTable.Rows(0).Item("EndingBalance")
                .PostedBy = MyDataTable.Rows(0).Item("PostedBy")
                .DatePosted = MyDataTable.Rows(0).Item("DatePosted")
            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try
      
    End Function
End Class

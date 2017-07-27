Imports System.Data.SqlClient
Imports Newtonsoft.Json


Public Class D_ClientDependents2

    Public Function GetTableDetails(ByVal DepId As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT * FROM dbo.clientDependents2 "
            strSQL &= "WHERE fkDEPENDENTSID = " & DepId & " "

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


    Public Function SetDataTableToClass(clsObject As M_ClientDependents2, MyDataTable As DataTable) As String

        Try
            With clsObject
                .Clear()
                .fkDependentsID = MyDataTable.Rows(0).Item("fkDependentsID")
                .depCID = MyDataTable.Rows(0).Item("depCID")
                .civilstatus = MyDataTable.Rows(0).Item("civilstatus")
                .typeofmem = MyDataTable.Rows(0).Item("typeofmem")
                .isdeceased = MyDataTable.Rows(0).Item("isdeceased")
                .occupation = MyDataTable.Rows(0).Item("occupation")
                .BranchId = "001" 'Change Here..Temporary Only
            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try
       

    End Function
End Class

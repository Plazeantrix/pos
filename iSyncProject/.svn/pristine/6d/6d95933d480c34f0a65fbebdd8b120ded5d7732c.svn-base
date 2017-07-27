Imports System.Data.SqlClient
Imports Newtonsoft.Json


Public Class D_LoanComakerAccount

    Public Function GetTableDetails(ByVal AccountNumber As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT * FROM dbo.LoanComakerAccount "
            strSQL &= "WHERE FKACCOUNTNUMBERCOMAKER = '" & AccountNumber & "' "

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


    Public Function SetDataTableToClass(clsObject As M_LoanComakerAccount, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear()

                .FKAccountNumberComaker = MyDataTable.Rows(0).Item("FKAccountNumberComaker")
                .FKCoMakerID = MyDataTable.Rows(0).Item("FKCoMakerID")
                .Flag = Common.CheckForDBNull(MyDataTable.Rows(0).Item("Flag"), Common.SystemTypeValue._Bit)

            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try
    End Function
End Class

Imports System.Data.SqlClient
Imports Newtonsoft.Json
Public Class D_EmploymentHistory
    Public Function GetTableDetails(ByVal CID As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT TOP 1 * FROM EmploymentHistory "
            strSQL &= "WHERE FKCustomerIDEmp = '" & CID & "' " ''<<----- CHANGED TO CID

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


    Public Function SetDataTableToClass(clsObject As M_EmploymentHistory, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear()
                .CompanyAddress = MyDataTable.Rows(0).Item("CompanyAddress")
                .CompanyName = MyDataTable.Rows(0).Item("CompanyName")
                .CompanyPhone = MyDataTable.Rows(0).Item("CompanyPhone")
                .Employer = MyDataTable.Rows(0).Item("Employer")
                .EmpPosition = MyDataTable.Rows(0).Item("EmpPosition")
                .FKCustomerIDEmp = MyDataTable.Rows(0).Item("FKCustomerIDEmp")
                .FKJobType = MyDataTable.Rows(0).Item("FKJobType")
                .FKOccupationType = MyDataTable.Rows(0).Item("FKOccupationType")
                .Salary = MyDataTable.Rows(0).Item("Salary")
                .YearsInService = MyDataTable.Rows(0).Item("YearsInService")

            End With
            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try



    End Function
End Class

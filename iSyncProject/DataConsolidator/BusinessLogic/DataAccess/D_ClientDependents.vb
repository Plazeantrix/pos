Imports System.Data.SqlClient
Imports Newtonsoft.Json


Public Class D_ClientDependents
    Public Function GetTableDetails(ByVal DepID As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT * FROM dbo.ClientDependents "
            strSQL &= "WHERE DependentsID = " & DepID & " "

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


    Public Function SetDataTableToClass(clsObject As M_ClientDependents, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear()
                .DependentsID = MyDataTable.Rows(0).Item("DependentsID")
                .FKCustomerIDDep = MyDataTable.Rows(0).Item("FKCustomerIDDep")
                .DepLastName = MyDataTable.Rows(0).Item("DepLastName")
                .DepFirstName = MyDataTable.Rows(0).Item("DepFirstName")
                .DepMiddleName = MyDataTable.Rows(0).Item("DepMiddleName")
                .Relationship = MyDataTable.Rows(0).Item("Relationship")
                .Gender = MyDataTable.Rows(0).Item("Gender")
                .Birthdate = MyDataTable.Rows(0).Item("Birthdate")
                .Profession = MyDataTable.Rows(0).Item("Profession")
                .IsBeneficiary = MyDataTable.Rows(0).Item("IsBeneficiary")
                .IsDependent = MyDataTable.Rows(0).Item("IsDependent")
                .IsGuardian = MyDataTable.Rows(0).Item("IsGuardian")
                .BranchID = Left(.FKCustomerIDDep, 3)
            End With
            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try
       


    End Function
End Class

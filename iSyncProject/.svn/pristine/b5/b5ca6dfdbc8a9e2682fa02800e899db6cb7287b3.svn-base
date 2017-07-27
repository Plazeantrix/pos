Imports System.Data.SqlClient
Imports Newtonsoft.Json

Public Class D_Customer
    Public Function GetTableDetails(ByVal CID As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT * FROM CUSTOMER "
            strSQL &= "WHERE CUSTOMERID = '" & CID & "' "

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


    Public Function SetDataTableToClass(clsObject As M_Customer, MyDataTable As DataTable) As String

        Try

       
        With clsObject
            .Clear()

            .CustomerID = MyDataTable.Rows(0).Item("CustomerID")
            .BranchID = MyDataTable.Rows(0).Item("BranchID")
            .CustomerType = MyDataTable.Rows(0).Item("CustomerType")
            .TypeOfMembeship = MyDataTable.Rows(0).Item("TypeOfMembeship")
            .MemberShipStatus = MyDataTable.Rows(0).Item("MemberShipStatus")
            .DateOfMembership = MyDataTable.Rows(0).Item("DateOfMembership")
            .LastName = MyDataTable.Rows(0).Item("LastName")
            .FirstName = MyDataTable.Rows(0).Item("FirstName")
            .MiddleName = MyDataTable.Rows(0).Item("MiddleName")
            .MiddleName = MyDataTable.Rows(0).Item("MiddleName")
            .DateOfBirth = MyDataTable.Rows(0).Item("DateOfBirth")
            .Gender = MyDataTable.Rows(0).Item("Gender")
            .CivilStatus = MyDataTable.Rows(0).Item("CivilStatus")
            .IdenficationType = MyDataTable.Rows(0).Item("IdenficationType")
            .IdentificationNumber = MyDataTable.Rows(0).Item("IdentificationNumber")
                '.IDPicture = ""
                '.Signature = ""
            .CreatedBy = MyDataTable.Rows(0).Item("CreatedBy")
                .DateCreated = MyDataTable.Rows(0).Item("DateCreated")
                .IdentificationType = MyDataTable.Rows(0).Item("IdentificationType2")
            .IdentificationType2 = MyDataTable.Rows(0).Item("IdentificationType2")
            .IdentificationNumber2 = MyDataTable.Rows(0).Item("IdentificationNumber2")
            .DateOfRegistration = MyDataTable.Rows(0).Item("DateOfRegistration")
            .PrimaryContactPerson = MyDataTable.Rows(0).Item("PrimaryContactPerson")
            .SecondaryContactPerson = MyDataTable.Rows(0).Item("SecondaryContactPerson")
            .Remarks = MyDataTable.Rows(0).Item("Remarks")
            .TrackNumber = MyDataTable.Rows(0).Item("TrackNumber")
            .FKGroupCode = MyDataTable.Rows(0).Item("FKGroupCode")
            .FKAddressCode = MyDataTable.Rows(0).Item("FKAddressCode")
            .PlaceOfBirth = MyDataTable.Rows(0).Item("PlaceOfBirth")
            .FKTypeOfResidence = MyDataTable.Rows(0).Item("FKTypeOfResidence")
            .NumHousehold = MyDataTable.Rows(0).Item("NumHousehold")
            .FKReligion = MyDataTable.Rows(0).Item("FKReligion")
                .ChildInSchool = MyDataTable.Rows(0).Item("ChildInSchool")

                .ParentAddress = Common.CheckForDBNull(MyDataTable.Rows(0).Item("ParentAddress"), Common.SystemTypeValue._String)

            .row_version = MyDataTable.Rows(0).Item("row_version")
        End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw

        End Try


    End Function


   


End Class

﻿Imports System.Data.SqlClient
Imports Newtonsoft.Json

Public Class D_CustomerAddress
    Public Function GetTableDetails(ByVal INDEX As String, ByVal CID As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT TOP 1 * FROM CustomerAddress "
            strSQL &= "WHERE AddressID = " & Trim(INDEX) & " AND FKCustomerIDAdd = '" & Trim(CID) & "'"

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


    Public Function SetDataTableToClass(clsObject As M_CustomerAddress, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear()
                .AddressType = MyDataTable.Rows(0).Item("AddressType")
                .Barangay = MyDataTable.Rows(0).Item("Barangay")
                .CellNumber = MyDataTable.Rows(0).Item("CellNumber")
                .EmaiAdd = MyDataTable.Rows(0).Item("EmaiAdd")
                .FKCustomerIDAdd = MyDataTable.Rows(0).Item("FKCustomerIDAdd")
                .IsMailingAddress = MyDataTable.Rows(0).Item("IsMailingAddress")
                .PhoneNumber = MyDataTable.Rows(0).Item("PhoneNumber")
                .Purok = MyDataTable.Rows(0).Item("Purok")
                .Street = MyDataTable.Rows(0).Item("Street")
                .TownCity = MyDataTable.Rows(0).Item("TownCity")

            End With
            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try



    End Function
End Class

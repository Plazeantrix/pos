Imports System.Data.SqlClient
Imports Newtonsoft.Json


Public Class D_LoanAccount
    Public Function GetTableDetails(ByVal AccountNumber As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT top 1 * FROM dbo.LoanAccount "
            strSQL &= "WHERE ACCOUNTNUMBER = '" & AccountNumber & "' "

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

    


    Public Function SetDataTableToClass(clsObject As M_LoanAccount, MyDataTable As DataTable) As String
        Try
            With clsObject
                .Clear()

                .AccountNumber = MyDataTable.Rows(0).Item("AccountNumber")
                .FKBranchIDAccount = MyDataTable.Rows(0).Item("FKBranchIDAccount")
                .FKCustomerIDLoan = MyDataTable.Rows(0).Item("FKCustomerIDLoan")
                .FKLoanProductIDAcct = MyDataTable.Rows(0).Item("FKLoanProductIDAcct")
                .LoanCount = MyDataTable.Rows(0).Item("LoanCount")
                .ModeOfTerm = MyDataTable.Rows(0).Item("ModeOfTerm")
                .NumberOfTerm = MyDataTable.Rows(0).Item("NumberOfTerm")
                .MaturityDate = MyDataTable.Rows(0).Item("MaturityDate")
                .PayFrequency = MyDataTable.Rows(0).Item("PayFrequency")
                .Principal = MyDataTable.Rows(0).Item("Principal")
                .ServiceCharge = MyDataTable.Rows(0).Item("ServiceCharge")
                .InterestDeducted = MyDataTable.Rows(0).Item("InterestDeducted")
                .OtherCharge = MyDataTable.Rows(0).Item("OtherCharge")
                .Retention = MyDataTable.Rows(0).Item("Retention")
                .NetProceeds = MyDataTable.Rows(0).Item("NetProceeds")
                .InterestRate = MyDataTable.Rows(0).Item("InterestRate")
                .AnnualDivisor = MyDataTable.Rows(0).Item("AnnualDivisor")
                .Interest = MyDataTable.Rows(0).Item("Interest")
                .PrincipalBalance = MyDataTable.Rows(0).Item("PrincipalBalance")
                .InterestBalance = MyDataTable.Rows(0).Item("InterestBalance")
                .AccountStatus = MyDataTable.Rows(0).Item("AccountStatus")
                .DisbursedDate = MyDataTable.Rows(0).Item("DisbursedDate")
                .FKTypeOfBorrowerID = MyDataTable.Rows(0).Item("FKTypeOfBorrowerID")
                .FKTypeOfTermID = MyDataTable.Rows(0).Item("FKTypeOfTermID")
                .FKTypeOfEcoActivityID = MyDataTable.Rows(0).Item("FKTypeOfEcoActivityID")
                .FKTypeOfIntrateID = MyDataTable.Rows(0).Item("FKTypeOfIntrateID")
                .FKTypeSizeOfFirmID = MyDataTable.Rows(0).Item("FKTypeSizeOfFirmID")
                .FKTypeOfSecurityID = MyDataTable.Rows(0).Item("FKTypeOfSecurityID")
                .FKTypeOfLoanID = MyDataTable.Rows(0).Item("FKTypeOfLoanID")
                .FKTypeOfPurposeID = MyDataTable.Rows(0).Item("FKTypeOfPurposeID")


                .RenewalCount = Common.CheckForDBNull(MyDataTable.Rows(0).Item("RenewalCount"), "0")

                .RestructureCount = Common.CheckForDBNull(MyDataTable.Rows(0).Item("RestructureCount"), "0")
                .Notes = MyDataTable.Rows(0).Item("Notes")
                .LoanVoucherNumber = Common.CheckForDBNull(MyDataTable.Rows(0).Item("LoanVoucherNumber"), Common.SystemTypeValue._String)
                .LoanCheckNumber = Common.CheckForDBNull(MyDataTable.Rows(0).Item("LoanCheckNumber"), Common.SystemTypeValue._String)
                .ReleaseType = MyDataTable.Rows(0).Item("ReleaseType")
                .FKLoanOffUserName = MyDataTable.Rows(0).Item("FKLoanOffUserName")
                .CreatedBy = MyDataTable.Rows(0).Item("CreatedBy")
                .CreatedDate = MyDataTable.Rows(0).Item("CreatedDate")

                .VerifiedBy = Common.CheckForDBNull(MyDataTable.Rows(0).Item("VerifiedBy"), Common.SystemTypeValue._String)
             

                .VerifiedDate = Common.CheckForDBNull(MyDataTable.Rows(0).Item("VerifiedDate"), Common.SystemTypeValue._String)


                .ApprovedBy = Common.CheckForDBNull(MyDataTable.Rows(0).Item("ApprovedBy"), Common.SystemTypeValue._String)

                .ApprovedDate = Common.CheckForDBNull(MyDataTable.Rows(0).Item("ApprovedDate"), Common.SystemTypeValue._String)
                .RowVersion = MyDataTable.Rows(0).Item("RowVersion")
                .LastTransactionDate = Common.CheckForDBNull(MyDataTable.Rows(0).Item("LastTransactionDate"), Common.SystemTypeValue._String)
                .Insurance = MyDataTable.Rows(0).Item("Insurance")
                .Cycle = Common.CheckForDBNull(MyDataTable.Rows(0).Item("Cycle"), Common.SystemTypeValue._String)
                .DepositPortion = Common.CheckForDBNull(MyDataTable.Rows(0).Item("DepositPortion"), Common.SystemTypeValue._String)
                .LastWorkDate = Common.CheckForDBNull(MyDataTable.Rows(0).Item("LastWorkDate"), Common.SystemTypeValue._String)
                .StopIntComp = MyDataTable.Rows(0).Item("StopIntComp")
                .MortuaryPremium = MyDataTable.Rows(0).Item("MortuaryPremium")
                .SADepositPortionAccount = Common.CheckForDBNull(MyDataTable.Rows(0).Item("SADepositPortionAccount"), Common.SystemTypeValue._String)
                .ExistLoanDues = MyDataTable.Rows(0).Item("ExistLoanDues")
                .StopPenaltyComp = Common.CheckForDBNull(MyDataTable.Rows(0).Item("StopPenaltyComp"), Common.SystemTypeValue._String)
                .TWChangeAccount = Common.CheckForDBNull(MyDataTable.Rows(0).Item("TWChangeAccount"), Common.SystemTypeValue._String)
            End With

            Return JsonConvert.SerializeObject(clsObject)
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        End Try
    End Function
End Class

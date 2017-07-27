Public Class M_LoanAccount
    Private _AccountNumber As String = ""
    Private _FKBranchIDAccount As String = ""
    Private _FKCustomerIDLoan As String = ""
    Private _FKLoanProductIDAcct As String = ""
    Private _LoanCount As String = 0
    Private _ModeOfTerm As String = ""
    Private _NumberOfTerm As String = 0
    Private _MaturityDate As String = Nothing
    Private _PayFrequency As String = ""
    Private _Principal As String = 0
    Private _ServiceCharge As String = 0
    Private _InterestDeducted As String = 0
    Private _OtherCharge As String = 0
    Private _Retention As String = 0
    Private _NetProceeds As String = 0
    Private _InterestRate As String = 0
    Private _AnnualDivisor As String = 0
    Private _Interest As String = 0
    Private _PrincipalBalance As String = 0
    Private _InterestBalance As String = 0
    Private _AccountStatus As String = ""
    Private _DisbursedDate As String = Nothing
    Private _FKTypeOfBorrowerID As String = ""
    Private _FKTypeOfTermID As String = ""
    Private _FKTypeOfEcoActivityID As String = ""
    Private _FKTypeOfIntrateID As String = ""
    Private _FKTypeSizeOfFirmID As String = ""
    Private _FKTypeOfSecurityID As String = ""
    Private _FKTypeOfLoanID As String = ""
    Private _FKTypeOfPurposeID As String = ""
    Private _RenewalCount As String = 0
    Private _RestructureCount As String = 0
    Private _Notes As String = ""
    Private _LoanVoucherNumber As String = ""
    Private _LoanCheckNumber As String = ""
    Private _ReleaseType As String = 0
    Private _FKLoanOffUserName As String = ""
    Private _CreatedBy As String = ""
    Private _CreatedDate As String = Nothing
    Private _VerifiedBy As String = ""
    Private _VerifiedDate As String = Nothing
    Private _ApprovedBy As String = ""
    Private _ApprovedDate As String = Nothing
    Private _RowVersion As String = Nothing
    Private _LastTransactionDate As String = Nothing
    Private _Insurance As String = 0
    Private _Cycle As String = 0
    Private _DepositPortion As String = 0
    Private _LastWorkDate As String = Nothing
    Private _StopIntComp As String = False
    Private _MortuaryPremium As String = 0
    Private _SADepositPortionAccount As String = ""
    Private _ExistLoanDues As String = 0
    Private _StopPenaltyComp As String = False
    Private _TWChangeAccount As String = ""

    Public Sub Clear()
        _AccountNumber = ""
        _FKBranchIDAccount = ""
        _FKCustomerIDLoan = ""
        _FKLoanProductIDAcct = ""
        _LoanCount = 0
        _ModeOfTerm = ""
        _NumberOfTerm = 0
        _MaturityDate = Nothing
        _PayFrequency = ""
        _Principal = 0
        _ServiceCharge = 0
        _InterestDeducted = 0
        _OtherCharge = 0
        _Retention = 0
        _NetProceeds = 0
        _InterestRate = 0
        _AnnualDivisor = 0
        _Interest = 0
        _PrincipalBalance = 0
        _InterestBalance = 0
        _AccountStatus = ""
        _DisbursedDate = Nothing
        _FKTypeOfBorrowerID = ""
        _FKTypeOfTermID = ""
        _FKTypeOfEcoActivityID = ""
        _FKTypeOfIntrateID = ""
        _FKTypeSizeOfFirmID = ""
        _FKTypeOfSecurityID = ""
        _FKTypeOfLoanID = ""
        _FKTypeOfPurposeID = ""
        _RenewalCount = 0
        _RestructureCount = 0
        _Notes = ""
        _LoanVoucherNumber = ""
        _LoanCheckNumber = ""
        _ReleaseType = 0
        _FKLoanOffUserName = ""
        _CreatedBy = ""
        _CreatedDate = Nothing
        _VerifiedBy = ""
        _VerifiedDate = Nothing
        _ApprovedBy = ""
        _ApprovedDate = Nothing
        _RowVersion = Nothing
        _LastTransactionDate = Nothing
        _Insurance = 0
        _Cycle = 0
        _DepositPortion = 0
        _LastWorkDate = Nothing
        _StopIntComp = False
        _MortuaryPremium = 0
        _SADepositPortionAccount = ""
        _ExistLoanDues = 0
        _StopPenaltyComp = False
        _TWChangeAccount = ""
    End Sub

    Public Property AccountNumber() As String
        Get
            Return Common.CleanInput(_AccountNumber)

        End Get
        Set(ByVal value As String)
            _AccountNumber = value
        End Set
    End Property

    Public Property FKBranchIDAccount() As String
        Get
            Return Common.CleanInput(_FKBranchIDAccount)
        End Get
        Set(ByVal value As String)
            _FKBranchIDAccount = value
        End Set
    End Property

    Public Property FKCustomerIDLoan() As String
        Get
            Return Common.CleanInput(_FKCustomerIDLoan)
        End Get
        Set(ByVal value As String)
            _FKCustomerIDLoan = value
        End Set
    End Property

    Public Property FKLoanProductIDAcct() As String
        Get
            Return Common.CleanInput(_FKLoanProductIDAcct)
        End Get
        Set(ByVal value As String)
            _FKLoanProductIDAcct = value
        End Set
    End Property

    Public Property LoanCount() As String
        Get
            Return Common.CleanInput(_LoanCount)
        End Get
        Set(ByVal value As String)
            _LoanCount = value
        End Set
    End Property

    Public Property ModeOfTerm() As String
        Get
            Return Common.CleanInput(_ModeOfTerm)
        End Get
        Set(ByVal value As String)
            _ModeOfTerm = value
        End Set
    End Property

    Public Property NumberOfTerm() As String
        Get
            Return Common.CleanInput(_NumberOfTerm)
        End Get
        Set(ByVal value As String)
            _NumberOfTerm = value
        End Set
    End Property

    Public Property MaturityDate() As String
        Get
            Return Common.CleanInput(_MaturityDate)
        End Get
        Set(ByVal value As String)
            _MaturityDate = value
        End Set
    End Property

    Public Property PayFrequency() As String
        Get
            Return Common.CleanInput(_PayFrequency)
        End Get
        Set(ByVal value As String)
            _PayFrequency = value
        End Set
    End Property

    Public Property Principal() As String
        Get
            Return _Principal
        End Get
        Set(ByVal value As String)
            _Principal = value
        End Set
    End Property

    Public Property ServiceCharge() As String
        Get
            Return _ServiceCharge
        End Get
        Set(ByVal value As String)
            _ServiceCharge = value
        End Set
    End Property

    Public Property InterestDeducted() As String
        Get
            Return _InterestDeducted
        End Get
        Set(ByVal value As String)
            _InterestDeducted = value
        End Set
    End Property

    Public Property OtherCharge() As String
        Get
            Return _OtherCharge
        End Get
        Set(ByVal value As String)
            _OtherCharge = value
        End Set
    End Property

    Public Property Retention() As String
        Get
            Return _Retention
        End Get
        Set(ByVal value As String)
            _Retention = value
        End Set
    End Property

    Public Property NetProceeds() As String
        Get
            Return _NetProceeds
        End Get
        Set(ByVal value As String)
            _NetProceeds = value
        End Set
    End Property

    Public Property InterestRate() As String
        Get
            Return _InterestRate
        End Get
        Set(ByVal value As String)
            _InterestRate = value
        End Set
    End Property

    Public Property AnnualDivisor() As String
        Get
            Return _AnnualDivisor
        End Get
        Set(ByVal value As String)
            _AnnualDivisor = value
        End Set
    End Property

    Public Property Interest() As String
        Get
            Return _Interest
        End Get
        Set(ByVal value As String)
            _Interest = value
        End Set
    End Property

    Public Property PrincipalBalance() As String
        Get
            Return _PrincipalBalance
        End Get
        Set(ByVal value As String)
            _PrincipalBalance = value
        End Set
    End Property

    Public Property InterestBalance() As String
        Get
            Return _InterestBalance
        End Get
        Set(ByVal value As String)
            _InterestBalance = value
        End Set
    End Property

    Public Property AccountStatus() As String
        Get
            Return Common.CleanInput(_AccountStatus)
        End Get
        Set(ByVal value As String)
            _AccountStatus = value
        End Set
    End Property

    Public Property DisbursedDate() As String
        Get
            Return Common.CleanInput(_DisbursedDate)
        End Get
        Set(ByVal value As String)
            _DisbursedDate = value
        End Set
    End Property

    Public Property FKTypeOfBorrowerID() As String
        Get
            Return Common.CleanInput(_FKTypeOfBorrowerID)
        End Get
        Set(ByVal value As String)
            _FKTypeOfBorrowerID = value
        End Set
    End Property

    Public Property FKTypeOfTermID() As String
        Get
            Return Common.CleanInput(_FKTypeOfTermID)
        End Get
        Set(ByVal value As String)
            _FKTypeOfTermID = value
        End Set
    End Property

    Public Property FKTypeOfEcoActivityID() As String
        Get
            Return Common.CleanInput(_FKTypeOfEcoActivityID)
        End Get
        Set(ByVal value As String)
            _FKTypeOfEcoActivityID = value
        End Set
    End Property

    Public Property FKTypeOfIntrateID() As String
        Get
            Return Common.CleanInput(_FKTypeOfIntrateID)
        End Get
        Set(ByVal value As String)
            _FKTypeOfIntrateID = value
        End Set
    End Property

    Public Property FKTypeSizeOfFirmID() As String
        Get
            Return Common.CleanInput(_FKTypeSizeOfFirmID)
        End Get
        Set(ByVal value As String)
            _FKTypeSizeOfFirmID = value
        End Set
    End Property

    Public Property FKTypeOfSecurityID() As String
        Get
            Return Common.CleanInput(_FKTypeOfSecurityID)
        End Get
        Set(ByVal value As String)
            _FKTypeOfSecurityID = value
        End Set
    End Property

    Public Property FKTypeOfLoanID() As String
        Get
            Return Common.CleanInput(_FKTypeOfLoanID)
        End Get
        Set(ByVal value As String)
            _FKTypeOfLoanID = value
        End Set
    End Property

    Public Property FKTypeOfPurposeID() As String
        Get
            Return Common.CleanInput(_FKTypeOfPurposeID)
        End Get
        Set(ByVal value As String)
            _FKTypeOfPurposeID = value
        End Set
    End Property

    Public Property RenewalCount() As String
        Get
            Return _RenewalCount
        End Get
        Set(ByVal value As String)
            _RenewalCount = value
        End Set
    End Property

    Public Property RestructureCount() As String
        Get
            Return _RestructureCount
        End Get
        Set(ByVal value As String)
            _RestructureCount = value
        End Set
    End Property

    Public Property Notes() As String
        Get
            Return Common.CleanInput(_Notes)
        End Get
        Set(ByVal value As String)
            _Notes = value
        End Set
    End Property

    Public Property LoanVoucherNumber() As String
        Get
            Return Common.CleanInput(_LoanVoucherNumber)
        End Get
        Set(ByVal value As String)
            _LoanVoucherNumber = value
        End Set
    End Property

    Public Property LoanCheckNumber() As String
        Get
            Return Common.CleanInput(_LoanCheckNumber)
        End Get
        Set(ByVal value As String)
            _LoanCheckNumber = value
        End Set
    End Property

    Public Property ReleaseType() As String
        Get
            Return _ReleaseType
        End Get
        Set(ByVal value As String)
            _ReleaseType = value
        End Set
    End Property

    Public Property FKLoanOffUserName() As String
        Get
            Return Common.CleanInput(_FKLoanOffUserName)
        End Get
        Set(ByVal value As String)
            _FKLoanOffUserName = value
        End Set
    End Property

    Public Property CreatedBy() As String
        Get
            Return Common.CleanInput(_CreatedBy)
        End Get
        Set(ByVal value As String)
            _CreatedBy = value
        End Set
    End Property

    Public Property CreatedDate() As String
        Get
            Return Common.CleanInput(_CreatedDate)
        End Get
        Set(ByVal value As String)
            _CreatedDate = value
        End Set
    End Property

    Public Property VerifiedBy() As String
        Get
            Return Common.CleanInput(_VerifiedBy)
        End Get
        Set(ByVal value As String)
            _VerifiedBy = value
        End Set
    End Property

    Public Property VerifiedDate() As String
        Get
            Return Common.CleanInput(_VerifiedDate)
        End Get
        Set(ByVal value As String)
            _VerifiedDate = value
        End Set
    End Property

    Public Property ApprovedBy() As String
        Get
            Return Common.CleanInput(_ApprovedBy)
        End Get
        Set(ByVal value As String)
            _ApprovedBy = value
        End Set
    End Property

    Public Property ApprovedDate() As String
        Get
            Return Common.CleanInput(_ApprovedDate)
        End Get
        Set(ByVal value As String)
            _ApprovedDate = value
        End Set
    End Property

    Public Property RowVersion() As String
        Get
            Return Common.CleanInput(_RowVersion)
        End Get
        Set(ByVal value As String)
            _RowVersion = value
        End Set
    End Property

    Public Property LastTransactionDate() As String
        Get
            Return Common.CleanInput(_LastTransactionDate)
        End Get
        Set(ByVal value As String)
            _LastTransactionDate = value
        End Set
    End Property

    Public Property Insurance() As String
        Get
            Return _Insurance
        End Get
        Set(ByVal value As String)
            _Insurance = value
        End Set
    End Property

    Public Property Cycle() As String
        Get
            Return _Cycle
        End Get
        Set(ByVal value As String)
            _Cycle = value
        End Set
    End Property

    Public Property DepositPortion() As String
        Get
            Return _DepositPortion
        End Get
        Set(ByVal value As String)
            _DepositPortion = value
        End Set
    End Property

    Public Property LastWorkDate() As String
        Get
            Return Common.CleanInput(_LastWorkDate)
        End Get
        Set(ByVal value As String)
            _LastWorkDate = value
        End Set
    End Property

    Public Property StopIntComp() As String
        Get
            Return _StopIntComp
        End Get
        Set(ByVal value As String)
            _StopIntComp = value
        End Set
    End Property

    Public Property MortuaryPremium() As String
        Get
            Return _MortuaryPremium
        End Get
        Set(ByVal value As String)
            _MortuaryPremium = value
        End Set
    End Property

    Public Property SADepositPortionAccount() As String
        Get
            Return Common.CleanInput(_SADepositPortionAccount)
        End Get
        Set(ByVal value As String)
            _SADepositPortionAccount = value
        End Set
    End Property

    Public Property ExistLoanDues() As String
        Get
            Return _ExistLoanDues
        End Get
        Set(ByVal value As String)
            _ExistLoanDues = value
        End Set
    End Property

    Public Property StopPenaltyComp() As String
        Get
            Return _StopPenaltyComp
        End Get
        Set(ByVal value As String)
            _StopPenaltyComp = value
        End Set
    End Property

    Public Property TWChangeAccount() As String
        Get
            Return Common.CleanInput(_TWChangeAccount)
        End Get
        Set(ByVal value As String)
            _TWChangeAccount = value
        End Set
    End Property


End Class

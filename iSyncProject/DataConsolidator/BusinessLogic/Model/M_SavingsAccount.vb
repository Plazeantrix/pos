Public Class M_SavingsAccount
    Private _AccountNumber As String = ""
    Private _FKCustomerIDAccount As String = ""
    Private _AccountName As String = ""
    Private _FKSAProductIDAccount As String = ""
    Private _AccountStatus As String = ""
    Private _FKBranchIDAccount As String = ""
    Private _FKOwnerCode As Byte = 0
    Private _LastTransactionDate As String = Nothing
    Private _LastInterestPostDate As String = Nothing
    Private _LastInterestAccrualDate As String = Nothing
    Private _AccruedInterest As Decimal = 0
    Private _InterestRate As Decimal = 0
    Private _OpeningDate As String = Nothing
    Private _OpenedBy As String = ""
    Private _Balance As Decimal = 0
    Private _HoldBalance As Decimal = 0
    Private _AvgDailyBalance As Decimal = 0
    Private _ATMCardNo As String = ""
    Private _PassbookNo As String = ""
    Private _PassbookLineNo As Byte = 0
    Private _ATAAcctNumber As String = ""
    Private _LastDormancyDate As Date = Nothing
    Private _MaintaininBalCounter As Byte = 0
    Private _CompoundedInterest As Decimal = 0
    Private _AIPLastMonth As Decimal = 0
    Private _AIP As Decimal = 0
    Private _RowVersion As String = Nothing

    Public Sub Clear()
        _AccountNumber = ""
        _FKCustomerIDAccount = ""
        _AccountName = ""
        _FKSAProductIDAccount = ""
        _AccountStatus = ""
        _FKBranchIDAccount = ""
        _FKOwnerCode = 0
        _LastTransactionDate = Nothing
        _LastInterestPostDate = Nothing
        _LastInterestAccrualDate = Nothing
        _AccruedInterest = 0
        _InterestRate = 0
        _OpeningDate = Nothing
        _OpenedBy = ""
        _Balance = 0
        _HoldBalance = 0
        _AvgDailyBalance = 0
        _ATMCardNo = ""
        _PassbookNo = ""
        _PassbookLineNo = 0
        _ATAAcctNumber = ""
        _LastDormancyDate = Nothing
        _MaintaininBalCounter = 0
        _CompoundedInterest = 0
        _AIPLastMonth = 0
        _AIP = 0
        _RowVersion = Nothing
    End Sub

    Public Property AccountNumber() As String
        Get
            Return _AccountNumber
        End Get
        Set(ByVal value As String)
            _AccountNumber = value
        End Set
    End Property

    Public Property FKCustomerIDAccount() As String
        Get
            Return _FKCustomerIDAccount
        End Get
        Set(ByVal value As String)
            _FKCustomerIDAccount = value
        End Set
    End Property

    Public Property AccountName() As String
        Get
            Return _AccountName
        End Get
        Set(ByVal value As String)
            _AccountName = value
        End Set
    End Property

    Public Property FKSAProductIDAccount() As String
        Get
            Return _FKSAProductIDAccount
        End Get
        Set(ByVal value As String)
            _FKSAProductIDAccount = value
        End Set
    End Property

    Public Property AccountStatus() As String
        Get
            Return _AccountStatus
        End Get
        Set(ByVal value As String)
            _AccountStatus = value
        End Set
    End Property

    Public Property FKBranchIDAccount() As String
        Get
            Return _FKBranchIDAccount
        End Get
        Set(ByVal value As String)
            _FKBranchIDAccount = value
        End Set
    End Property

    Public Property FKOwnerCode() As Byte
        Get
            Return _FKOwnerCode
        End Get
        Set(ByVal value As Byte)
            _FKOwnerCode = value
        End Set
    End Property

    Public Property LastTransactionDate() As String
        Get
            Return _LastTransactionDate
        End Get
        Set(ByVal value As String)
            _LastTransactionDate = value
        End Set
    End Property

    Public Property LastInterestPostDate() As String
        Get
            Return _LastInterestPostDate
        End Get
        Set(ByVal value As String)
            _LastInterestPostDate = value
        End Set
    End Property

    Public Property LastInterestAccrualDate() As String
        Get
            Return _LastInterestAccrualDate
        End Get
        Set(ByVal value As String)
            _LastInterestAccrualDate = value
        End Set
    End Property

    Public Property AccruedInterest() As Decimal
        Get
            Return _AccruedInterest
        End Get
        Set(ByVal value As Decimal)
            _AccruedInterest = value
        End Set
    End Property

    Public Property InterestRate() As Decimal
        Get
            Return _InterestRate
        End Get
        Set(ByVal value As Decimal)
            _InterestRate = value
        End Set
    End Property

    Public Property OpeningDate() As String
        Get
            Return _OpeningDate
        End Get
        Set(ByVal value As String)
            _OpeningDate = value
        End Set
    End Property

    Public Property OpenedBy() As String
        Get
            Return _OpenedBy
        End Get
        Set(ByVal value As String)
            _OpenedBy = value
        End Set
    End Property

    Public Property Balance() As Decimal
        Get
            Return _Balance
        End Get
        Set(ByVal value As Decimal)
            _Balance = value
        End Set
    End Property

    Public Property HoldBalance() As Decimal
        Get
            Return _HoldBalance
        End Get
        Set(ByVal value As Decimal)
            _HoldBalance = value
        End Set
    End Property

    Public Property AvgDailyBalance() As Decimal
        Get
            Return _AvgDailyBalance
        End Get
        Set(ByVal value As Decimal)
            _AvgDailyBalance = value
        End Set
    End Property

    Public Property ATMCardNo() As String
        Get
            Return _ATMCardNo
        End Get
        Set(ByVal value As String)
            _ATMCardNo = value
        End Set
    End Property

    Public Property PassbookNo() As String
        Get
            Return _PassbookNo
        End Get
        Set(ByVal value As String)
            _PassbookNo = value
        End Set
    End Property

    Public Property PassbookLineNo() As Byte
        Get
            Return _PassbookLineNo
        End Get
        Set(ByVal value As Byte)
            _PassbookLineNo = value
        End Set
    End Property

    Public Property ATAAcctNumber() As String
        Get
            Return _ATAAcctNumber
        End Get
        Set(ByVal value As String)
            _ATAAcctNumber = value
        End Set
    End Property

    Public Property LastDormancyDate() As String
        Get
            Return _LastDormancyDate
        End Get
        Set(ByVal value As String)
            _LastDormancyDate = value
        End Set
    End Property

    Public Property MaintaininBalCounter() As Byte
        Get
            Return _MaintaininBalCounter
        End Get
        Set(ByVal value As Byte)
            _MaintaininBalCounter = value
        End Set
    End Property

    Public Property CompoundedInterest() As Decimal
        Get
            Return _CompoundedInterest
        End Get
        Set(ByVal value As Decimal)
            _CompoundedInterest = value
        End Set
    End Property

    Public Property AIPLastMonth() As Decimal
        Get
            Return _AIPLastMonth
        End Get
        Set(ByVal value As Decimal)
            _AIPLastMonth = value
        End Set
    End Property

    Public Property AIP() As Decimal
        Get
            Return _AIP
        End Get
        Set(ByVal value As Decimal)
            _AIP = value
        End Set
    End Property

    Public Property RowVersion() As String
        Get
            Return _RowVersion
        End Get
        Set(ByVal value As String)
            _RowVersion = value
        End Set
    End Property


End Class

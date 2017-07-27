Public Class M_ShareAccount
    Private _AccountNumber As String = ""
    Private _FKCustomerIDAccount As String = ""
    Private _FKSCProductIDAccount As String = ""
    Private _AccountStatus As String = ""
    Private _FKBranchIDAccount As String = ""
    Private _FKOwnerCode As Byte = 0
    Private _NoOfShares As Integer = 0
    Private _TotalSubscription As Decimal = 0
    Private _LastTransactionDate As String = Nothing
    Private _LastInterestPostDate As String = Nothing
    Private _LastInterestAccrualDate As String = Nothing
    Private _AccruedInterest As Decimal = 0
    Private _InterestRate As Decimal = 0
    Private _OpeningDate As Date = Nothing
    Private _OpenedBy As String = ""
    Private _Balance As Decimal = 0
    Private _HoldBalance As Decimal = 0
    Private _CumShareMonth As Decimal = 0
    Private _PassbookNo As String = ""
    Private _AvgDailyBalance As Decimal = 0
    Private _PassbookLineNo As Byte = 0
    Private _MonthAccruedInterest As Decimal = 0
    Private _TotalAccruedInterest As Decimal = 0
    Private _RowVersion As String = Nothing

    Public Sub Clear()
        _AccountNumber = ""
        _FKCustomerIDAccount = ""
        _FKSCProductIDAccount = ""
        _AccountStatus = ""
        _FKBranchIDAccount = ""
        _FKOwnerCode = 0
        _NoOfShares = 0
        _TotalSubscription = 0
        _LastTransactionDate = Nothing
        _LastInterestPostDate = Nothing
        _LastInterestAccrualDate = Nothing
        _AccruedInterest = 0
        _InterestRate = 0
        _OpeningDate = Nothing
        _OpenedBy = ""
        _Balance = 0
        _HoldBalance = 0
        _CumShareMonth = 0
        _PassbookNo = ""
        _AvgDailyBalance = 0
        _PassbookLineNo = 0
        _MonthAccruedInterest = 0
        _TotalAccruedInterest = 0
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

    Public Property FKSCProductIDAccount() As String
        Get
            Return _FKSCProductIDAccount
        End Get
        Set(ByVal value As String)
            _FKSCProductIDAccount = value
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

    Public Property NoOfShares() As Integer
        Get
            Return _NoOfShares
        End Get
        Set(ByVal value As Integer)
            _NoOfShares = value
        End Set
    End Property

    Public Property TotalSubscription() As Decimal
        Get
            Return _TotalSubscription
        End Get
        Set(ByVal value As Decimal)
            _TotalSubscription = value
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

    Public Property CumShareMonth() As Decimal
        Get
            Return _CumShareMonth
        End Get
        Set(ByVal value As Decimal)
            _CumShareMonth = value
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

    Public Property AvgDailyBalance() As Decimal
        Get
            Return _AvgDailyBalance
        End Get
        Set(ByVal value As Decimal)
            _AvgDailyBalance = value
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

    Public Property MonthAccruedInterest() As Decimal
        Get
            Return _MonthAccruedInterest
        End Get
        Set(ByVal value As Decimal)
            _MonthAccruedInterest = value
        End Set
    End Property

    Public Property TotalAccruedInterest() As Decimal
        Get
            Return _TotalAccruedInterest
        End Get
        Set(ByVal value As Decimal)
            _TotalAccruedInterest = value
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

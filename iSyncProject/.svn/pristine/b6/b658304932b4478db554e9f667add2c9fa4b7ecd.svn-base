Public Class M_SATransaction
    Private _TransactionNo As Long = 0
    Private _TransactionDate As String = Nothing
    Private _FKAccountNumberTransaction As String = ""
    Private _TransactionTime As String = Nothing
    Private _FKBranchIDTransaction As String = ""
    Private _FKTransactionTypeCode As String = ""
    Private _ReferenceNo As String = ""
    Private _Particulars As String = ""
    Private _IsPrintedPassbook As Boolean = False
    Private _Amount As Decimal = 0
    Private _RunningBalance As Decimal = 0
    Private _IsCancelled As Boolean = False
    Private _StationName As String = ""
    Private _TransactedBy As String = ""
    Private _OverrideBy As String = ""
    Private _AvgDailyBalanceTran As Decimal = 0
    Private _AvailableBalance As Decimal = 0

    Public Sub Clear()
        _TransactionNo = 0
        _TransactionDate = Nothing
        _FKAccountNumberTransaction = ""
        _TransactionTime = Nothing
        _FKBranchIDTransaction = ""
        _FKTransactionTypeCode = ""
        _ReferenceNo = ""
        _Particulars = ""
        _IsPrintedPassbook = False
        _Amount = 0
        _RunningBalance = 0
        _IsCancelled = False
        _StationName = ""
        _TransactedBy = ""
        _OverrideBy = ""
        _AvgDailyBalanceTran = 0
        _AvailableBalance = 0
    End Sub

    Public Property TransactionNo() As Long
        Get
            Return _TransactionNo
        End Get
        Set(ByVal value As Long)
            _TransactionNo = value
        End Set
    End Property

    Public Property TransactionDate() As String
        Get
            Return _TransactionDate
        End Get
        Set(ByVal value As String)
            _TransactionDate = value
        End Set
    End Property

    Public Property FKAccountNumberTransaction() As String
        Get
            Return _FKAccountNumberTransaction
        End Get
        Set(ByVal value As String)
            _FKAccountNumberTransaction = value
        End Set
    End Property

    Public Property TransactionTime() As String
        Get
            Return _TransactionTime
        End Get
        Set(ByVal value As String)
            _TransactionTime = value
        End Set
    End Property

    Public Property FKBranchIDTransaction() As String
        Get
            Return _FKBranchIDTransaction
        End Get
        Set(ByVal value As String)
            _FKBranchIDTransaction = value
        End Set
    End Property

    Public Property FKTransactionTypeCode() As String
        Get
            Return _FKTransactionTypeCode
        End Get
        Set(ByVal value As String)
            _FKTransactionTypeCode = value
        End Set
    End Property

    Public Property ReferenceNo() As String
        Get
            Return Common.CleanInput(_ReferenceNo)
        End Get
        Set(ByVal value As String)
            _ReferenceNo = value
        End Set
    End Property

    Public Property Particulars() As String
        Get
            Return Common.CleanInput(_Particulars)
        End Get
        Set(ByVal value As String)
            _Particulars = value
        End Set
    End Property

    Public Property IsPrintedPassbook() As Boolean
        Get
            Return _IsPrintedPassbook
        End Get
        Set(ByVal value As Boolean)
            _IsPrintedPassbook = value
        End Set
    End Property

    Public Property Amount() As Decimal
        Get
            Return _Amount
        End Get
        Set(ByVal value As Decimal)
            _Amount = value
        End Set
    End Property

    Public Property RunningBalance() As Decimal
        Get
            Return _RunningBalance
        End Get
        Set(ByVal value As Decimal)
            _RunningBalance = value
        End Set
    End Property

    Public Property IsCancelled() As Boolean
        Get
            Return _IsCancelled
        End Get
        Set(ByVal value As Boolean)
            _IsCancelled = value
        End Set
    End Property

    Public Property StationName() As String
        Get
            Return _StationName
        End Get
        Set(ByVal value As String)
            _StationName = value
        End Set
    End Property

    Public Property TransactedBy() As String
        Get
            Return _TransactedBy
        End Get
        Set(ByVal value As String)
            _TransactedBy = value
        End Set
    End Property

    Public Property OverrideBy() As String
        Get
            Return _OverrideBy
        End Get
        Set(ByVal value As String)
            _OverrideBy = value
        End Set
    End Property

    Public Property AvgDailyBalanceTran() As Decimal
        Get
            Return _AvgDailyBalanceTran
        End Get
        Set(ByVal value As Decimal)
            _AvgDailyBalanceTran = value
        End Set
    End Property

    Public Property AvailableBalance() As Decimal
        Get
            Return _AvailableBalance
        End Get
        Set(ByVal value As Decimal)
            _AvailableBalance = value
        End Set
    End Property


End Class

Public Class M_LoanTranMaster
    Private _FKAccountNumberTransaction As String = ""
    Private _TransactionNo As Decimal = 0
    Private _TransactionDate As Date = Nothing
    Private _Amount As Decimal = 0
    Private _FKLNTransactionCodeTran As String = ""
    Private _Reference As String = ""
    Private _PrinCredit As Decimal = 0
    Private _PrinDebit As Decimal = 0
    Private _InterestCredit As Decimal = 0
    Private _InterestDebit As Decimal = 0
    Private _PenaltyCredit As Decimal = 0
    Private _PenaltyDebit As Decimal = 0
    Private _RebateCredit As Decimal = 0
    Private _RebateDebit As Decimal = 0
    Private _OtherCredit As Decimal = 0
    Private _OtherDebit As Decimal = 0
    Private _Balance As Decimal = 0
    Private _TransactedBy As String = ""
    Private _ApprovedBy As String = ""
    Private _StationName As String = ""
    Private _Particulars As String = ""
    Private _FKBranchIDTransaction As String = ""
    Private _TransactionTime As Date = Nothing
    Private _IsCancelled As Boolean = False
    Private _IncentiveDebit As Decimal = 0
    Private _IncentiveCredit As Decimal = 0
    Private _PaymentChange As Decimal = 0
    Private _DisbursementType As Byte = 0
    Private _Lacking As Decimal = 0
    Private _IsWalkin As Boolean = False

    Public Sub Clear()
        _FKAccountNumberTransaction = ""
        _TransactionNo = 0
        _TransactionDate = Nothing
        _Amount = 0
        _FKLNTransactionCodeTran = ""
        _Reference = ""
        _PrinCredit = 0
        _PrinDebit = 0
        _InterestCredit = 0
        _InterestDebit = 0
        _PenaltyCredit = 0
        _PenaltyDebit = 0
        _RebateCredit = 0
        _RebateDebit = 0
        _OtherCredit = 0
        _OtherDebit = 0
        _Balance = 0
        _TransactedBy = ""
        _ApprovedBy = ""
        _StationName = ""
        _Particulars = ""
        _FKBranchIDTransaction = ""
        _TransactionTime = Nothing
        _IsCancelled = False
        _IncentiveDebit = 0
        _IncentiveCredit = 0
        _PaymentChange = 0
        _DisbursementType = 0
        _Lacking = 0
        _IsWalkin = False
    End Sub

    Public Property FKAccountNumberTransaction() As String
        Get
            Return _FKAccountNumberTransaction
        End Get
        Set(ByVal value As String)
            _FKAccountNumberTransaction = value
        End Set
    End Property

    Public Property TransactionNo() As Decimal
        Get
            Return _TransactionNo
        End Get
        Set(ByVal value As Decimal)
            _TransactionNo = value
        End Set
    End Property

    Public Property TransactionDate() As Date
        Get
            Return _TransactionDate
        End Get
        Set(ByVal value As Date)
            _TransactionDate = value
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

    Public Property FKLNTransactionCodeTran() As String
        Get
            Return _FKLNTransactionCodeTran
        End Get
        Set(ByVal value As String)
            _FKLNTransactionCodeTran = value
        End Set
    End Property

    Public Property Reference() As String
        Get
            Return Common.CleanInput(_Reference)
        End Get
        Set(ByVal value As String)
            _Reference = value
        End Set
    End Property

    Public Property PrinCredit() As Decimal
        Get
            Return _PrinCredit
        End Get
        Set(ByVal value As Decimal)
            _PrinCredit = value
        End Set
    End Property

    Public Property PrinDebit() As Decimal
        Get
            Return _PrinDebit
        End Get
        Set(ByVal value As Decimal)
            _PrinDebit = value
        End Set
    End Property

    Public Property InterestCredit() As Decimal
        Get
            Return _InterestCredit
        End Get
        Set(ByVal value As Decimal)
            _InterestCredit = value
        End Set
    End Property

    Public Property InterestDebit() As Decimal
        Get
            Return _InterestDebit
        End Get
        Set(ByVal value As Decimal)
            _InterestDebit = value
        End Set
    End Property

    Public Property PenaltyCredit() As Decimal
        Get
            Return _PenaltyCredit
        End Get
        Set(ByVal value As Decimal)
            _PenaltyCredit = value
        End Set
    End Property

    Public Property PenaltyDebit() As Decimal
        Get
            Return _PenaltyDebit
        End Get
        Set(ByVal value As Decimal)
            _PenaltyDebit = value
        End Set
    End Property

    Public Property RebateCredit() As Decimal
        Get
            Return _RebateCredit
        End Get
        Set(ByVal value As Decimal)
            _RebateCredit = value
        End Set
    End Property

    Public Property RebateDebit() As Decimal
        Get
            Return _RebateDebit
        End Get
        Set(ByVal value As Decimal)
            _RebateDebit = value
        End Set
    End Property

    Public Property OtherCredit() As Decimal
        Get
            Return _OtherCredit
        End Get
        Set(ByVal value As Decimal)
            _OtherCredit = value
        End Set
    End Property

    Public Property OtherDebit() As Decimal
        Get
            Return _OtherDebit
        End Get
        Set(ByVal value As Decimal)
            _OtherDebit = value
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

    Public Property TransactedBy() As String
        Get
            Return _TransactedBy
        End Get
        Set(ByVal value As String)
            _TransactedBy = value
        End Set
    End Property

    Public Property ApprovedBy() As String
        Get
            Return _ApprovedBy
        End Get
        Set(ByVal value As String)
            _ApprovedBy = value
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

    Public Property Particulars() As String
        Get
            Return Common.CleanInput(_Particulars)
        End Get
        Set(ByVal value As String)
            _Particulars = value
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

    Public Property TransactionTime() As Date
        Get
            Return _TransactionTime
        End Get
        Set(ByVal value As Date)
            _TransactionTime = value
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

    Public Property IncentiveDebit() As Decimal
        Get
            Return _IncentiveDebit
        End Get
        Set(ByVal value As Decimal)
            _IncentiveDebit = value
        End Set
    End Property

    Public Property IncentiveCredit() As Decimal
        Get
            Return _IncentiveCredit
        End Get
        Set(ByVal value As Decimal)
            _IncentiveCredit = value
        End Set
    End Property

    Public Property PaymentChange() As Decimal
        Get
            Return _PaymentChange
        End Get
        Set(ByVal value As Decimal)
            _PaymentChange = value
        End Set
    End Property

    Public Property DisbursementType() As Byte
        Get
            Return _DisbursementType
        End Get
        Set(ByVal value As Byte)
            _DisbursementType = value
        End Set
    End Property

    Public Property Lacking() As Decimal
        Get
            Return _Lacking
        End Get
        Set(ByVal value As Decimal)
            _Lacking = value
        End Set
    End Property

    Public Property IsWalkin() As Boolean
        Get
            Return _IsWalkin
        End Get
        Set(ByVal value As Boolean)
            _IsWalkin = value
        End Set
    End Property


End Class

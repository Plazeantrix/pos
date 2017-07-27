Public Class M_TdAccount
    Private _AccountNumber As String = ""
    Private _FKCustomerIDAccount As String = ""
    Private _AccountName As String = ""
    Private _FKTDProductIDAccount As String = ""
    Private _AccountStatus As String = ""
    Private _FKBranchIDAccount As String = ""
    Private _FKOwnerCode As Byte = 0
    Private _LastTransactionDate As String = Nothing
    Private _LastInterestPostDate As String = Nothing
    Private _LastInterestAccrualDate As String = Nothing
    Private _OpeningDate As String = Nothing
    Private _OpeningAmount As Decimal = 0
    Private _TermStartDate As String = Nothing
    Private _OpenedBy As String = ""
    Private _Balance As Decimal = 0
    Private _HoldBalance As Decimal = 0
    Private _PassbookNo As String = ""
    Private _PassbookLineNo As Byte = 0
    Private _MaturityDate As String = Nothing
    Private _CTDNumber As String = ""
    Private _Term As Short = 0
    Private _TermInMonths As Short = 0
    Private _TermInterest As Decimal = 0
    Private _PreviousTerm As Short = 0
    Private _PreviousTermInterest As Decimal = 0
    Private _ActualDaysRolled As Decimal = 0
    Private _PreviousInterestPostDate As String = Nothing
    Private _RowVersion As String = Nothing
    Private _IsInstallment As Boolean = False
    Private _IsInstallmentClosed As Boolean = False
    Private _DateInstClosed As String = Nothing
    Private _AIP As Decimal = 0
    Private _AIPLastMonth As Decimal = 0
    Private _CompoundedTermInt As Decimal = 0

    Public Sub Clear()
        _AccountNumber = ""
        _FKCustomerIDAccount = ""
        _AccountName = ""
        _FKTDProductIDAccount = ""
        _AccountStatus = ""
        _FKBranchIDAccount = ""
        _FKOwnerCode = 0
        _LastTransactionDate = Nothing
        _LastInterestPostDate = Nothing
        _LastInterestAccrualDate = Nothing
        _OpeningDate = Nothing
        _OpeningAmount = 0
        _TermStartDate = Nothing
        _OpenedBy = ""
        _Balance = 0
        _HoldBalance = 0
        _PassbookNo = ""
        _PassbookLineNo = 0
        _MaturityDate = Nothing
        _CTDNumber = ""
        _Term = 0
        _TermInMonths = 0
        _TermInterest = 0
        _PreviousTerm = 0
        _PreviousTermInterest = 0
        _ActualDaysRolled = 0
        _PreviousInterestPostDate = Nothing
        _RowVersion = Nothing
        _IsInstallment = False
        _IsInstallmentClosed = False
        _DateInstClosed = Nothing
        _AIP = 0
        _AIPLastMonth = 0
        _CompoundedTermInt = 0
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

    Public Property FKTDProductIDAccount() As String
        Get
            Return _FKTDProductIDAccount
        End Get
        Set(ByVal value As String)
            _FKTDProductIDAccount = value
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

    Public Property OpeningDate() As String
        Get
            Return _OpeningDate
        End Get
        Set(ByVal value As String)
            _OpeningDate = value
        End Set
    End Property

    Public Property OpeningAmount() As Decimal
        Get
            Return _OpeningAmount
        End Get
        Set(ByVal value As Decimal)
            _OpeningAmount = value
        End Set
    End Property

    Public Property TermStartDate() As String
        Get
            Return _TermStartDate
        End Get
        Set(ByVal value As String)
            _TermStartDate = value
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

    Public Property MaturityDate() As String
        Get
            Return _MaturityDate
        End Get
        Set(ByVal value As String)
            _MaturityDate = value
        End Set
    End Property

    Public Property CTDNumber() As String
        Get
            Return _CTDNumber
        End Get
        Set(ByVal value As String)
            _CTDNumber = value
        End Set
    End Property

    Public Property Term() As Short
        Get
            Return _Term
        End Get
        Set(ByVal value As Short)
            _Term = value
        End Set
    End Property

    Public Property TermInMonths() As Short
        Get
            Return _TermInMonths
        End Get
        Set(ByVal value As Short)
            _TermInMonths = value
        End Set
    End Property

    Public Property TermInterest() As Decimal
        Get
            Return _TermInterest
        End Get
        Set(ByVal value As Decimal)
            _TermInterest = value
        End Set
    End Property

    Public Property PreviousTerm() As Short
        Get
            Return _PreviousTerm
        End Get
        Set(ByVal value As Short)
            _PreviousTerm = value
        End Set
    End Property

    Public Property PreviousTermInterest() As Decimal
        Get
            Return _PreviousTermInterest
        End Get
        Set(ByVal value As Decimal)
            _PreviousTermInterest = value
        End Set
    End Property

    Public Property ActualDaysRolled() As Decimal
        Get
            Return _ActualDaysRolled
        End Get
        Set(ByVal value As Decimal)
            _ActualDaysRolled = value
        End Set
    End Property

    Public Property PreviousInterestPostDate() As String
        Get
            Return _PreviousInterestPostDate
        End Get
        Set(ByVal value As String)
            _PreviousInterestPostDate = value
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

    Public Property IsInstallment() As Boolean
        Get
            Return _IsInstallment
        End Get
        Set(ByVal value As Boolean)
            _IsInstallment = value
        End Set
    End Property

    Public Property IsInstallmentClosed() As Boolean
        Get
            Return _IsInstallmentClosed
        End Get
        Set(ByVal value As Boolean)
            _IsInstallmentClosed = value
        End Set
    End Property

    Public Property DateInstClosed() As String
        Get
            Return _DateInstClosed
        End Get
        Set(ByVal value As String)
            _DateInstClosed = value
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

    Public Property AIPLastMonth() As Decimal
        Get
            Return _AIPLastMonth
        End Get
        Set(ByVal value As Decimal)
            _AIPLastMonth = value
        End Set
    End Property

    Public Property CompoundedTermInt() As Decimal
        Get
            Return _CompoundedTermInt
        End Get
        Set(ByVal value As Decimal)
            _CompoundedTermInt = value
        End Set
    End Property


End Class

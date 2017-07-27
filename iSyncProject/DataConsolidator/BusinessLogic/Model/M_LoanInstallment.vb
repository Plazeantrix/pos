Public Class M_LoanInstallment
    Private _FKAccountNumberInst As String = ""
    Private _InstallmentNumber As Short = 0
    Private _Status As Boolean = False
    Private _DueDate As Date = Nothing
    Private _RepayAmount As Decimal = 0
    Private _PrincipalPayable As Decimal = 0
    Private _InterestPayable As Decimal = 0
    Private _PrincipalBalance As Decimal = 0
    Private _PrincipalPaid As Decimal = 0
    Private _InterestPaid As Decimal = 0
    Private _IsIntPaid As Boolean = False
    Private _IsPenPaid As Boolean = False
    Private _PenaltyComp As Decimal = 0
    Private _PenaltyPaid As Decimal = 0
    Private _RebateAmount As Decimal = 0
    Private _RebatePosted As Boolean = False
    Private _RebateDate As Date = Nothing

    Public Sub Clear()
        _FKAccountNumberInst = ""
        _InstallmentNumber = 0
        _Status = False
        _DueDate = Nothing
        _RepayAmount = 0
        _PrincipalPayable = 0
        _InterestPayable = 0
        _PrincipalBalance = 0
        _PrincipalPaid = 0
        _InterestPaid = 0
        _IsIntPaid = False
        _IsPenPaid = False
        _PenaltyComp = 0
        _PenaltyPaid = 0
        _RebateAmount = 0
        _RebatePosted = False
        _RebateDate = Nothing
    End Sub

    Public Property FKAccountNumberInst() As String
        Get
            Return _FKAccountNumberInst
        End Get
        Set(ByVal value As String)
            _FKAccountNumberInst = value
        End Set
    End Property

    Public Property InstallmentNumber() As Short
        Get
            Return _InstallmentNumber
        End Get
        Set(ByVal value As Short)
            _InstallmentNumber = value
        End Set
    End Property

    Public Property Status() As Boolean
        Get
            Return _Status
        End Get
        Set(ByVal value As Boolean)
            _Status = value
        End Set
    End Property

    Public Property DueDate() As Date
        Get
            Return _DueDate
        End Get
        Set(ByVal value As Date)
            _DueDate = value
        End Set
    End Property

    Public Property RepayAmount() As Decimal
        Get
            Return _RepayAmount
        End Get
        Set(ByVal value As Decimal)
            _RepayAmount = value
        End Set
    End Property

    Public Property PrincipalPayable() As Decimal
        Get
            Return _PrincipalPayable
        End Get
        Set(ByVal value As Decimal)
            _PrincipalPayable = value
        End Set
    End Property

    Public Property InterestPayable() As Decimal
        Get
            Return _InterestPayable
        End Get
        Set(ByVal value As Decimal)
            _InterestPayable = value
        End Set
    End Property

    Public Property PrincipalBalance() As Decimal
        Get
            Return _PrincipalBalance
        End Get
        Set(ByVal value As Decimal)
            _PrincipalBalance = value
        End Set
    End Property

    Public Property PrincipalPaid() As Decimal
        Get
            Return _PrincipalPaid
        End Get
        Set(ByVal value As Decimal)
            _PrincipalPaid = value
        End Set
    End Property

    Public Property InterestPaid() As Decimal
        Get
            Return _InterestPaid
        End Get
        Set(ByVal value As Decimal)
            _InterestPaid = value
        End Set
    End Property

    Public Property IsIntPaid() As Boolean
        Get
            Return _IsIntPaid
        End Get
        Set(ByVal value As Boolean)
            _IsIntPaid = value
        End Set
    End Property

    Public Property IsPenPaid() As Boolean
        Get
            Return _IsPenPaid
        End Get
        Set(ByVal value As Boolean)
            _IsPenPaid = value
        End Set
    End Property

    Public Property PenaltyComp() As Decimal
        Get
            Return _PenaltyComp
        End Get
        Set(ByVal value As Decimal)
            _PenaltyComp = value
        End Set
    End Property

    Public Property PenaltyPaid() As Decimal
        Get
            Return _PenaltyPaid
        End Get
        Set(ByVal value As Decimal)
            _PenaltyPaid = value
        End Set
    End Property

    Public Property RebateAmount() As Decimal
        Get
            Return _RebateAmount
        End Get
        Set(ByVal value As Decimal)
            _RebateAmount = value
        End Set
    End Property

    Public Property RebatePosted() As Boolean
        Get
            Return _RebatePosted
        End Get
        Set(ByVal value As Boolean)
            _RebatePosted = value
        End Set
    End Property

    Public Property RebateDate() As Date
        Get
            Return _RebateDate
        End Get
        Set(ByVal value As Date)
            _RebateDate = value
        End Set
    End Property


End Class

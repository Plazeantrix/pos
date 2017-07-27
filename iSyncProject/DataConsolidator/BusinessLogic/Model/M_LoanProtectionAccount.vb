Public Class M_LoanProtectionAccount
    Private _FKAccountNumber As String = ""
    Private _FKCustomerID As String = ""
    Private _FKProtectionTypeID As String = ""
    Private _AmountPremium As Decimal = 0
    Private _AccountStatus As Short = 0
    Private _Commission As Decimal = 0
    Private _Rebate As Decimal = 0
    Private _DailyFactor As Decimal = 0
    Private _TermInMonths As Short = 0
    Private _TermInDays As Short = 0
    Private _DateStarted As String = Nothing
    Private _MaturityDate As String = Nothing
    Private _DateTerminated As String = Nothing
    Private _DateClaimed As String = Nothing
    Private _DateClosed As String = Nothing
    Private _Remarks As String = ""
    Private _IsTerminated As Boolean = False
    Private _IsClaimed As Boolean = False
    Private _PolicyNo As String = ""
    Private _PolicyDateModified As String = Nothing
    Private _PolicyModifiedBy As String = ""

    Public Sub Clear()
        _FKAccountNumber = ""
        _FKCustomerID = ""
        _FKProtectionTypeID = ""
        _AmountPremium = 0
        _AccountStatus = 0
        _Commission = 0
        _Rebate = 0
        _DailyFactor = 0
        _TermInMonths = 0
        _TermInDays = 0
        _DateStarted = Nothing
        _MaturityDate = Nothing
        _DateTerminated = Nothing
        _DateClaimed = Nothing
        _DateClosed = Nothing
        _Remarks = ""
        _IsTerminated = False
        _IsClaimed = False
        _PolicyNo = ""
        _PolicyDateModified = Nothing
        _PolicyModifiedBy = ""
    End Sub

    Public Property FKAccountNumber() As String
        Get
            Return _FKAccountNumber
        End Get
        Set(ByVal value As String)
            _FKAccountNumber = value
        End Set
    End Property

    Public Property FKCustomerID() As String
        Get
            Return _FKCustomerID
        End Get
        Set(ByVal value As String)
            _FKCustomerID = value
        End Set
    End Property

    Public Property FKProtectionTypeID() As String
        Get
            Return _FKProtectionTypeID
        End Get
        Set(ByVal value As String)
            _FKProtectionTypeID = value
        End Set
    End Property

    Public Property AmountPremium() As Decimal
        Get
            Return _AmountPremium
        End Get
        Set(ByVal value As Decimal)
            _AmountPremium = value
        End Set
    End Property

    Public Property AccountStatus() As Short
        Get
            Return _AccountStatus
        End Get
        Set(ByVal value As Short)
            _AccountStatus = value
        End Set
    End Property

    Public Property Commission() As Decimal
        Get
            Return _Commission
        End Get
        Set(ByVal value As Decimal)
            _Commission = value
        End Set
    End Property

    Public Property Rebate() As Decimal
        Get
            Return _Rebate
        End Get
        Set(ByVal value As Decimal)
            _Rebate = value
        End Set
    End Property

    Public Property DailyFactor() As Decimal
        Get
            Return _DailyFactor
        End Get
        Set(ByVal value As Decimal)
            _DailyFactor = value
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

    Public Property TermInDays() As Short
        Get
            Return _TermInDays
        End Get
        Set(ByVal value As Short)
            _TermInDays = value
        End Set
    End Property

    Public Property DateStarted() As String
        Get
            Return _DateStarted
        End Get
        Set(ByVal value As String)
            _DateStarted = value
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

    Public Property DateTerminated() As String
        Get
            Return _DateTerminated
        End Get
        Set(ByVal value As String)
            _DateTerminated = value
        End Set
    End Property

    Public Property DateClaimed() As String
        Get
            Return _DateClaimed
        End Get
        Set(ByVal value As String)
            _DateClaimed = value
        End Set
    End Property

    Public Property DateClosed() As String
        Get
            Return _DateClosed
        End Get
        Set(ByVal value As String)
            _DateClosed = value
        End Set
    End Property

    Public Property Remarks() As String
        Get
            Return _Remarks
        End Get
        Set(ByVal value As String)
            _Remarks = value
        End Set
    End Property

    Public Property IsTerminated() As Boolean
        Get
            Return _IsTerminated
        End Get
        Set(ByVal value As Boolean)
            _IsTerminated = value
        End Set
    End Property

    Public Property IsClaimed() As Boolean
        Get
            Return _IsClaimed
        End Get
        Set(ByVal value As Boolean)
            _IsClaimed = value
        End Set
    End Property

    Public Property PolicyNo() As String
        Get
            Return _PolicyNo
        End Get
        Set(ByVal value As String)
            _PolicyNo = value
        End Set
    End Property

    Public Property PolicyDateModified() As String
        Get
            Return _PolicyDateModified
        End Get
        Set(ByVal value As String)
            _PolicyDateModified = value
        End Set
    End Property

    Public Property PolicyModifiedBy() As String
        Get
            Return _PolicyModifiedBy
        End Get
        Set(ByVal value As String)
            _PolicyModifiedBy = value
        End Set
    End Property


End Class

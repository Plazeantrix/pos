Public Class M_GLBalance
    Private _TransactionDate As String = Nothing
    Private _FKBranchIDGLBal As String = ""
    Private _FKAccountCodeGLBal As String = ""
    Private _BeginningBalance As Decimal = 0
    Private _DebitAmount As Decimal = 0
    Private _CreditAmount As Decimal = 0
    Private _EndingBalance As Decimal = 0
    Private _PostedBy As String = ""
    Private _DatePosted As String = Nothing

    Public Sub Clear()
        _TransactionDate = Nothing
        _FKBranchIDGLBal = ""
        _FKAccountCodeGLBal = ""
        _BeginningBalance = 0
        _DebitAmount = 0
        _CreditAmount = 0
        _EndingBalance = 0
        _PostedBy = ""
        _DatePosted = Nothing
    End Sub

    Public Property TransactionDate() As String
        Get
            Return _TransactionDate
        End Get
        Set(ByVal value As String)
            _TransactionDate = value
        End Set
    End Property

    Public Property FKBranchIDGLBal() As String
        Get
            Return _FKBranchIDGLBal
        End Get
        Set(ByVal value As String)
            _FKBranchIDGLBal = value
        End Set
    End Property

    Public Property FKAccountCodeGLBal() As String
        Get
            Return _FKAccountCodeGLBal
        End Get
        Set(ByVal value As String)
            _FKAccountCodeGLBal = value
        End Set
    End Property

    Public Property BeginningBalance() As Decimal
        Get
            Return _BeginningBalance
        End Get
        Set(ByVal value As Decimal)
            _BeginningBalance = value
        End Set
    End Property

    Public Property DebitAmount() As Decimal
        Get
            Return _DebitAmount
        End Get
        Set(ByVal value As Decimal)
            _DebitAmount = value
        End Set
    End Property

    Public Property CreditAmount() As Decimal
        Get
            Return _CreditAmount
        End Get
        Set(ByVal value As Decimal)
            _CreditAmount = value
        End Set
    End Property

    Public Property EndingBalance() As Decimal
        Get
            Return _EndingBalance
        End Get
        Set(ByVal value As Decimal)
            _EndingBalance = value
        End Set
    End Property

    Public Property PostedBy() As String
        Get
            Return _PostedBy
        End Get
        Set(ByVal value As String)
            _PostedBy = value
        End Set
    End Property

    Public Property DatePosted() As String
        Get
            Return _DatePosted
        End Get
        Set(ByVal value As String)
            _DatePosted = value
        End Set
    End Property


End Class

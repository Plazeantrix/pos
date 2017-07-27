Public Class M_ClientDependents2
    Private _fkDependentsID As Decimal = 0
    Private _depCID As String = ""
    Private _civilstatus As String = ""
    Private _typeofmem As String = ""
    Private _isdeceased As String = ""
    Private _occupation As String = ""
    Private _BranchID As String = ""

    Public Sub Clear()
        _fkDependentsID = 0
        _depCID = ""
        _civilstatus = ""
        _typeofmem = ""
        _isdeceased = ""
        _occupation = ""
        _BranchID = ""
    End Sub

    Public Property fkDependentsID() As Decimal
        Get
            Return _fkDependentsID
        End Get
        Set(ByVal value As Decimal)
            _fkDependentsID = value
        End Set
    End Property

    Public Property depCID() As String
        Get
            Return _depCID
        End Get
        Set(ByVal value As String)
            _depCID = value
        End Set
    End Property

    Public Property civilstatus() As String
        Get
            Return _civilstatus
        End Get
        Set(ByVal value As String)
            _civilstatus = value
        End Set
    End Property

    Public Property typeofmem() As String
        Get
            Return _typeofmem
        End Get
        Set(ByVal value As String)
            _typeofmem = value
        End Set
    End Property

    Public Property isdeceased() As String
        Get
            Return _isdeceased
        End Get
        Set(ByVal value As String)
            _isdeceased = value
        End Set
    End Property

    Public Property occupation() As String
        Get
            Return _occupation
        End Get
        Set(ByVal value As String)
            _occupation = value
        End Set
    End Property

    Public Property BranchId() As String
        Get
            Return _BranchID
        End Get
        Set(ByVal value As String)
            _BranchID = value
        End Set
    End Property


End Class

Public Class M_CustomerAddress
    Private _FKCustomerIDAdd As String = ""
    Private _AddressType As String = ""
    Private _Street As String = ""
    Private _Purok As String = ""
    Private _Barangay As String = ""
    Private _TownCity As String = ""
    Private _PhoneNumber As String = ""
    Private _CellNumber As String = ""
    Private _EmaiAdd As String = ""
    Private _IsMailingAddress As String = ""

    Public Sub Clear()
        _FKCustomerIDAdd = ""
        _AddressType = "0"
        _Street = ""
        _Purok = ""
        _Barangay = ""
        _TownCity = "0"
        _PhoneNumber = ""
        _CellNumber = ""
        _EmaiAdd = ""
        _IsMailingAddress = ""
    End Sub

    Public Property FKCustomerIDAdd() As String
        Get
            Return _FKCustomerIDAdd
        End Get
        Set(ByVal value As String)
            _FKCustomerIDAdd = value
        End Set
    End Property

    Public Property AddressType() As String
        Get
            Return _AddressType
        End Get
        Set(ByVal value As String)
            _AddressType = value
        End Set
    End Property

    Public Property Street() As String
        Get
            Return Common.CleanInput(_Street)
        End Get
        Set(ByVal value As String)
            _Street = value
        End Set
    End Property

    Public Property Purok() As String
        Get
            Return Common.CleanInput(_Purok)
        End Get
        Set(ByVal value As String)
            _Purok = value
        End Set
    End Property

    Public Property Barangay() As String
        Get
            Return Common.CleanInput(_Barangay)
        End Get
        Set(ByVal value As String)
            _Barangay = value
        End Set
    End Property

    Public Property TownCity() As String
        Get
            Return Common.CleanInput(_TownCity)
        End Get
        Set(ByVal value As String)
            _TownCity = value
        End Set
    End Property

    Public Property PhoneNumber() As String
        Get
            Return Common.CleanInput(_PhoneNumber)
        End Get
        Set(ByVal value As String)
            _PhoneNumber = value
        End Set
    End Property

    Public Property CellNumber() As String
        Get
            Return Common.CleanInput(_CellNumber)
        End Get
        Set(ByVal value As String)
            _CellNumber = value
        End Set
    End Property

    Public Property EmaiAdd() As String
        Get
            Return Common.CleanInput(_EmaiAdd)
        End Get
        Set(ByVal value As String)
            _EmaiAdd = value
        End Set
    End Property

    Public Property IsMailingAddress() As String
        Get
            Return Common.CleanInput(_IsMailingAddress)
        End Get
        Set(ByVal value As String)
            _IsMailingAddress = value
        End Set
    End Property


End Class

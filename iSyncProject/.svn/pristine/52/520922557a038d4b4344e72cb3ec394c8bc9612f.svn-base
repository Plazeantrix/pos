Imports System.Text.RegularExpressions

Public Class M_Customer
    Private _CustomerID As String = ""
    Private _BranchID As String = ""
    Private _CustomerType As Byte = 0
    Private _TypeOfMembeship As Byte = 0
    Private _MemberShipStatus As Byte = 0
    Private _DateOfMembership As String = Nothing
    Private _LastName As String = ""
    Private _FirstName As String = ""
    Private _MiddleName As String = ""
    Private _CompanyName As String = ""
    Private _DateOfBirth As String = Nothing
    Private _Gender As Byte = 0
    Private _CivilStatus As Byte = 0
    Private _IdenficationType As Byte = 0
    Private _IdentificationNumber As String = ""
    Private _IDPicture As String = ""
    Private _Signature As String = ""
    Private _CreatedBy As String = ""
    Private _DateCreated As Date = Nothing
    Private _IdentificationType2 As Byte = 0
    Private _IdentificationNumber2 As String = ""
    Private _DateOfRegistration As Date = Nothing
    Private _PrimaryContactPerson As String = ""
    Private _SecondaryContactPerson As String = ""
    Private _Remarks As String = ""
    Private _TrackNumber As String = ""
    Private _FKGroupCode As String = ""
    Private _FKAddressCode As String = ""
    Private _PlaceOfBirth As String = ""
    Private _FKTypeOfResidence As Byte = 0
    Private _NumHousehold As Byte = 0
    Private _FKReligion As Byte = 0
    Private _ChildInSchool As Byte = 0
    Private _ParentAddress As String = ""
    Private _row_version As String = Nothing
    Private _IdentificationType As Byte = 0

    Public Sub Clear()
        _CustomerID = ""
        _BranchID = ""
        _CustomerType = 0
        _TypeOfMembeship = 0
        _MemberShipStatus = 0
        _DateOfMembership = Nothing
        _LastName = ""
        _FirstName = ""
        _MiddleName = ""
        _CompanyName = ""
        _DateOfBirth = Nothing
        _Gender = 0
        _CivilStatus = 0
        _IdenficationType = 0
        _IdentificationNumber = ""
        _IDPicture = ""
        _Signature = ""
        _CreatedBy = ""
        _DateCreated = Nothing
        _IdentificationType2 = 0
        _IdentificationNumber2 = ""
        _DateOfRegistration = Nothing
        _PrimaryContactPerson = ""
        _SecondaryContactPerson = ""
        _Remarks = ""
        _TrackNumber = ""
        _FKGroupCode = ""
        _FKAddressCode = ""
        _PlaceOfBirth = ""
        _FKTypeOfResidence = 0
        _NumHousehold = 0
        _FKReligion = 0
        _ChildInSchool = 0
        _ParentAddress = ""
        _row_version = Nothing
    End Sub

    Public Property CustomerID() As String
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As String)
            _CustomerID = value
        End Set
    End Property

    Public Property BranchID() As String
        Get
            Return _BranchID
        End Get
        Set(ByVal value As String)
            _BranchID = value
        End Set
    End Property

    Public Property CustomerType() As Byte
        Get
            Return _CustomerType
        End Get
        Set(ByVal value As Byte)
            _CustomerType = value
        End Set
    End Property

    Public Property TypeOfMembeship() As Byte
        Get
            Return _TypeOfMembeship
        End Get
        Set(ByVal value As Byte)
            _TypeOfMembeship = value
        End Set
    End Property

    Public Property MemberShipStatus() As Byte
        Get
            Return _MemberShipStatus
        End Get
        Set(ByVal value As Byte)
            _MemberShipStatus = value
        End Set
    End Property

    Public Property DateOfMembership() As String
        Get
            Return _DateOfMembership
        End Get
        Set(ByVal value As String)
            _DateOfMembership = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return CleanInput(_LastName)
        End Get
        Set(ByVal value As String)
            _LastName = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return CleanInput(_FirstName)
        End Get
        Set(ByVal value As String)
            _FirstName = value
        End Set
    End Property

    Public Property MiddleName() As String
        Get
            Return CleanInput(_MiddleName)
        End Get
        Set(ByVal value As String)
            _MiddleName = value
        End Set
    End Property

    Public Property CompanyName() As String
        Get
            Return CleanInput(_CompanyName)
        End Get
        Set(ByVal value As String)
            _CompanyName = value
        End Set
    End Property

    Public Property DateOfBirth() As String
        Get
            Return _DateOfBirth
        End Get
        Set(ByVal value As String)
            _DateOfBirth = value
        End Set
    End Property

    Public Property Gender() As Byte
        Get
            Return _Gender
        End Get
        Set(ByVal value As Byte)
            _Gender = value
        End Set
    End Property

    Public Property CivilStatus() As Byte
        Get
            Return _CivilStatus
        End Get
        Set(ByVal value As Byte)
            _CivilStatus = value
        End Set
    End Property

    Public Property IdenficationType() As Byte
        Get
            Return CleanInput(_IdenficationType)
        End Get
        Set(ByVal value As Byte)
            _IdenficationType = value
        End Set
    End Property

    Public Property IdentificationNumber() As String
        Get
            Return CleanInput(_IdentificationNumber)
        End Get
        Set(ByVal value As String)
            _IdentificationNumber = value
        End Set
    End Property

    Public Property IDPicture() As String
        Get
            Return _IDPicture
        End Get
        Set(ByVal value As String)
            _IDPicture = value
        End Set
    End Property

    Public Property Signature() As String
        Get
            Return _Signature
        End Get
        Set(ByVal value As String)
            _Signature = value
        End Set
    End Property

    Public Property CreatedBy() As String
        Get
            Return _CreatedBy
        End Get
        Set(ByVal value As String)
            _CreatedBy = value
        End Set
    End Property

    Public Property DateCreated() As String
        Get
            Return _DateCreated
        End Get
        Set(ByVal value As String)
            _DateCreated = value
        End Set
    End Property

    Public Property IdentificationType2() As Byte
        Get
            Return CleanInput(_IdentificationType2)
        End Get
        Set(ByVal value As Byte)
            _IdentificationType2 = value
        End Set
    End Property

    Public Property IdentificationType() As Byte
        Get
            Return CleanInput(_IdentificationType)
        End Get
        Set(ByVal value As Byte)
            _IdentificationType = value
        End Set
    End Property

    Public Property IdentificationNumber2() As String
        Get
            Return CleanInput(_IdentificationNumber2)

        End Get
        Set(ByVal value As String)
            _IdentificationNumber2 = value
        End Set
    End Property

    Public Property DateOfRegistration() As String
        Get
            Return _DateOfRegistration
        End Get
        Set(ByVal value As String)
            _DateOfRegistration = value
        End Set
    End Property


    Private Function CleanInput(ByVal strInput As String) As String
        Dim a As String
        Dim b As String
        Dim c As String
        Dim d As String


        a = Regex.Replace(strInput, "\r\n", " ")
        b = Regex.Replace(a, "\t", " ")
        c = Regex.Replace(b, "\""", " ")
        d = Regex.Replace(c, "\\", " ")
        Return d

    End Function
    Public Property PrimaryContactPerson() As String
        Get

            Return CleanInput(_PrimaryContactPerson)
            'Return _PrimaryContactPerson
        End Get
        Set(ByVal value As String)
            _PrimaryContactPerson = value
        End Set
    End Property

    Public Property SecondaryContactPerson() As String
        Get

            Return CleanInput(_SecondaryContactPerson)

            'Return _SecondaryContactPerson
        End Get
        Set(ByVal value As String)
            _SecondaryContactPerson = value
        End Set
    End Property

    Public Property Remarks() As String
        Get

            Return CleanInput(_Remarks)
            'Return _Remarks.Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ").Replace("\r\n\t", "")

        End Get
        Set(ByVal value As String)
            _Remarks = value
        End Set
    End Property

    Public Property TrackNumber() As String
        Get
            Return _TrackNumber
        End Get
        Set(ByVal value As String)
            _TrackNumber = value
        End Set
    End Property

    Public Property FKGroupCode() As String
        Get
            Return _FKGroupCode
        End Get
        Set(ByVal value As String)
            _FKGroupCode = value
        End Set
    End Property

    Public Property FKAddressCode() As String
        Get
            Return _FKAddressCode
        End Get
        Set(ByVal value As String)
            _FKAddressCode = value
        End Set
    End Property

    Public Property PlaceOfBirth() As String
        Get
            Return CleanInput(_PlaceOfBirth)
        End Get
        Set(ByVal value As String)
            _PlaceOfBirth = value
        End Set
    End Property

    Public Property FKTypeOfResidence() As Byte
        Get
            Return _FKTypeOfResidence
        End Get
        Set(ByVal value As Byte)
            _FKTypeOfResidence = value
        End Set
    End Property

    Public Property NumHousehold() As Byte
        Get
            Return _NumHousehold
        End Get
        Set(ByVal value As Byte)
            _NumHousehold = value
        End Set
    End Property

    Public Property FKReligion() As Byte
        Get
            Return _FKReligion
        End Get
        Set(ByVal value As Byte)
            _FKReligion = value
        End Set
    End Property

    Public Property ChildInSchool() As Byte
        Get
            Return _ChildInSchool
        End Get
        Set(ByVal value As Byte)
            _ChildInSchool = value
        End Set
    End Property

    Public Property ParentAddress() As String
        Get
            Return CleanInput(_ParentAddress)
        End Get
        Set(ByVal value As String)
            _ParentAddress = value
        End Set
    End Property

    Public Property row_version() As String
        Get
            Return _row_version
        End Get
        Set(ByVal value As String)
            _row_version = value
        End Set
    End Property


End Class

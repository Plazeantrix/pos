﻿Public Class M_EmploymentHistory
    Private _FKCustomerIDEmp As String = ""
    Private _CompanyName As String = ""
    Private _EmpPosition As String = ""
    Private _Salary As String = ""
    Private _YearsInService As String = ""
    Private _CompanyAddress As String = ""
    Private _CompanyPhone As String = ""
    Private _FKJobType As String = ""
    Private _FKOccupationType As Integer = 0
    Private _Employer As String = ""

    Public Sub Clear()
        _FKCustomerIDEmp = ""
        _CompanyName = ""
        _EmpPosition = ""
        _Salary = "0"
        _YearsInService = "0"
        _CompanyAddress = ""
        _CompanyPhone = ""
        _FKJobType = "0"
        _FKOccupationType = 0
        _Employer = ""
    End Sub

    Public Property FKCustomerIDEmp() As String
        Get
            Return _FKCustomerIDEmp
        End Get
        Set(ByVal value As String)
            _FKCustomerIDEmp = value
        End Set
    End Property

    Public Property CompanyName() As String
        Get
            Return Common.CleanInput(_CompanyName)
        End Get
        Set(ByVal value As String)
            _CompanyName = value
        End Set
    End Property

    Public Property EmpPosition() As String
        Get
            Return Common.CleanInput(_EmpPosition)
        End Get
        Set(ByVal value As String)
            _EmpPosition = value
        End Set
    End Property

    Public Property Salary() As String
        Get
            Return _Salary
        End Get
        Set(ByVal value As String)
            _Salary = value
        End Set
    End Property

    Public Property YearsInService() As String
        Get
            Return _YearsInService
        End Get
        Set(ByVal value As String)
            _YearsInService = value
        End Set
    End Property

    Public Property CompanyAddress() As String
        Get
            Return Common.CleanInput(_CompanyAddress)
        End Get
        Set(ByVal value As String)
            _CompanyAddress = value
        End Set
    End Property

    Public Property CompanyPhone() As String
        Get
            Return _CompanyPhone
        End Get
        Set(ByVal value As String)
            _CompanyPhone = value
        End Set
    End Property

    Public Property FKJobType() As String
        Get
            Return _FKJobType
        End Get
        Set(ByVal value As String)
            _FKJobType = value
        End Set
    End Property

    Public Property FKOccupationType() As Integer
        Get
            Return _FKOccupationType
        End Get
        Set(ByVal value As Integer)
            _FKOccupationType = value
        End Set
    End Property

    Public Property Employer() As String
        Get
            Return _Employer
        End Get
        Set(ByVal value As String)
            _Employer = value
        End Set
    End Property



End Class

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Common
    Public Shared ThrownLocation As String = ""
    Public Shared ThrownLineNumber As String = ""
    Public Shared SetActiveTime As Boolean = False




    Public Shared Function GetConnection() As SqlConnection
        Dim connectionString As String = ""

        connectionString = "Data Source=" & System.Configuration.ConfigurationManager.AppSettings.Get("DataSource") & ";"
        connectionString &= "User ID=sa;"
        connectionString &= "Password=" & System.Configuration.ConfigurationManager.AppSettings.Get("Password") & ";"
        connectionString &= "Initial Catalog=" & System.Configuration.ConfigurationManager.AppSettings.Get("InitialCatalog") & ";"
        connectionString &= "Connect Timeout=90;"

        Return New SqlConnection(connectionString)

    End Function


    Public Function GetPendings(ByVal pTableName As String) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT TOP 1 * FROM _ISync_Details "
            strSQL &= "WHERE ISSUCCESSFULSYNC = 0 "
            strSQL &= "AND ProcessTableName='" & pTableName & "'"

            dad = New SqlDataAdapter(strSQL, connection)
            dtb.Rows.Clear()
            dad.Fill(dtb)

            Return dtb
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
        Finally
            dtb.Dispose()
            dad.Dispose()
            connection.Close()
        End Try




    End Function

    Public Function GetCountPendings(ByVal pstrTable As String) As Integer
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT COUNT(*) AS 'CNT' FROM _ISync_Details "
            strSQL &= "WHERE ISSUCCESSFULSYNC = 0 "
            strSQL &= "AND ProcessTableName='" & pstrTable & "' "

            'strSQL = "SELECT COUNT(*) AS 'CNT' FROM ("
            'strSQL &= "SELECT TOP 50 * FROM _ISync_Details "
            'strSQL &= "WHERE ISSUCCESSFULSYNC = 0 "
            'strSQL &= "AND ProcessTableName='" & pstrTable & "' "
            'strSQL &= ")SDSAD "

            dad = New SqlDataAdapter(strSQL, connection)
            dtb.Rows.Clear()
            dad.Fill(dtb)

            If dtb.Rows.Count > 0 Then
                Return dtb.Rows(0).Item("CNT")
            Else
                Return 0
            End If


        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw

        Finally
            dtb.Dispose()
            dad.Dispose()
            connection.Close()
        End Try




    End Function



    Public Function SetUpdateStatus(ByVal Indexid As String) As Boolean
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String = ""

        Dim cmd1 As SqlCommand

        Try
            connection.Open()

            'strSQL = "UPDATE _ISYNC_DETAILS "
            'strSQL &= "SET ISSUCCESSFULSYNC = 1, "
            'strSQL &= " DATEPROCESSSYNC = '" & Now & "' "
            'strSQL &= "WHERE INDEXID = " & Indexid & " "

            strSQL = "Delete dbo.[_ISync_Details] "
            strSQL &= " WHERE INDEXID = " & Indexid & " "
            strSQL &= " AND IsSuccessfulSync = 0 "
            strSQL &= " AND DateProcessSync = '01/01/1900'"

            cmd1 = New SqlCommand(strSQL, connection)
            cmd1.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Common.ThrownLocation = Me.GetType().Name
            Common.ThrownLineNumber = Common.GetLineNumber(ex)
            Throw
            Return False
        Finally
            cmd1.Dispose()
            connection.Close()
        End Try

    End Function



    Public Shared Function GetLineNumber(ByVal ex As Exception)
        Dim lineNumber As Int32 = 0
        Const lineSearch As String = ":line "
        Dim index = ex.StackTrace.LastIndexOf(lineSearch)
        If index <> -1 Then
            Dim lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length)
            If Int32.TryParse(lineNumberText, lineNumber) Then
            End If
        End If
        Return lineNumber
    End Function



    Public Sub PromptMessage(MyExMessage As String, MyLocationMessage As String, MyLineNumberLocation As String)
        MessageBox.Show(MyExMessage & vbNewLine & vbNewLine & _
                             "  Location: " & MyLocationMessage & vbNewLine & _
                             "  LineNumber: " & MyLineNumberLocation)

        ThrownLocation = ""
        ThrownLineNumber = ""
    End Sub










    Public Function GetCentralSettings(ByVal pDate As Date) As DataTable
        Dim connection As SqlConnection = Common.GetConnection
        Dim strSQL As String
        Dim dtb As New DataTable
        Dim dad As SqlDataAdapter

        Try
            connection.Open()

            strSQL = "SELECT TOP 1 * FROM dbo.CentralSettings WHERE branchcode = " & DefaultBranchCode & " AND ISIP1USE = 1 OR ISIP2USE = 1 "

            dad = New SqlDataAdapter(strSQL, connection)
            dtb.Rows.Clear()
            dad.Fill(dtb)

            Return dtb

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

    End Function


    Enum SystemTypeValue
        _String
        _Integer
        _Date
        _Bit
    End Enum


    Public Shared Function CheckForDBNull(ByVal MyValue As Object, MyDataType As SystemTypeValue) As String

        If MyDataType = SystemTypeValue._String Then

            If MyValue Is DBNull.Value Then
                Return ""
            Else
                Return MyValue
            End If

        ElseIf MyDataType = SystemTypeValue._Integer Then

            If MyValue Is DBNull.Value Then
                Return 0
            Else
                Return MyValue
            End If

        ElseIf MyDataType = SystemTypeValue._Date Then

            If MyValue Is DBNull.Value Then
                Return "01/01/1900"
            Else
                Return MyValue
            End If

        ElseIf MyDataType = SystemTypeValue._Bit Then

            If MyValue Is DBNull.Value Then
                Return 0
            Else
                Return MyValue
            End If

        End If


    End Function



    Public Shared Function ProcessSetActiveTime() As String




        Common.SetActiveTime = False
        Return Now
    End Function


    Public Shared Function CleanInput(ByVal strInput As String) As String
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


End Class

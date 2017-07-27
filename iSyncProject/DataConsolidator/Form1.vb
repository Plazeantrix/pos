Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form1

    '    Public frms As New FrmWaitingBox




    '    Private Sub StartProcess()

    '        ''--------------- Connect to Central Server -------------------
    '        If ConnectToDataBase(1) = False Then
    '            Exit Sub
    '        End If


    '        ''-------------------- Get current data from branch ------------------------

    '        Dim MyCommon As New Common


    '        Dim BRANCHpARAM As DataTable '= MyCommon.GetCentralSettings

    '        If BRANCHpARAM.Rows.Count > 0 Then

    '            bRANCHCODE = Trim(BRANCHpARAM.Rows(0).Item("bRANCHCODE"))
    '            bRANCHNAME = Trim(BRANCHpARAM.Rows(0).Item("bRANCHNAME"))

    '            XLOCATION = Trim(BRANCHpARAM.Rows(0).Item("XLOCATION"))
    '            YLOCATION = Trim(BRANCHpARAM.Rows(0).Item("YLOCATION"))

    '            IP1 = Trim(BRANCHpARAM.Rows(0).Item("IP1"))
    '            ISIP1PRIMARY = Trim(BRANCHpARAM.Rows(0).Item("ISIP1PRIMARY"))
    '            ISIP1USE = Trim(BRANCHpARAM.Rows(0).Item("ISIP1USE"))

    '            IP2 = Trim(BRANCHpARAM.Rows(0).Item("IP2"))
    '            ISIP2PRIMARY = Trim(BRANCHpARAM.Rows(0).Item("ISIP2PRIMARY"))
    '            ISIP2USE = Trim(BRANCHpARAM.Rows(0).Item("ISIP2USE"))

    '            MYINITIALCATALOG = Trim(BRANCHpARAM.Rows(0).Item("MyInitalCatalog"))
    '            MYPW = Trim(BRANCHpARAM.Rows(0).Item("MYPW"))

    '            CONNECTEVERY = Trim(BRANCHpARAM.Rows(0).Item("CONNECTEVERY"))
    '            CONNECTSTARTON = Trim(BRANCHpARAM.Rows(0).Item("CONNECTSTARTON"))
    '            CONNECTENDON = Trim(BRANCHpARAM.Rows(0).Item("CONNECTENDON"))


    '            Me.Location = New Point(XLOCATION, YLOCATION) ''<<<<< SET FORM LOCATION

    '            Call SetText_lbltimerCount(CONNECTEVERY)      ''<<<<< SET TIMER COUNT DOWN

    '            If CanSystemStart() = False Then Exit Sub ''<<<< CHECK TIME

    '            If PingIpAddress() = True Then                  ''<<<<<TRY TO PING IP ADDRESS OF BRANCH
    '                Call SetText_lblIP(Connection.FINALcONNECTIONiP)
    '                Call SetText_lblIPName(Connection.bRANCHNAME)

    '                If ConnectToDataBase(2) = False Then Exit Sub ''<<<< CONNECT TO BRANCH

    '                For x = 1 To 15

    '                    ProgressBar1.Maximum = 15

    '                    Dim lastdate As DateTime = GetLastBranchUpdateDate(Connection.bRANCHCODE, x)
    '                    Dim BrachLastUpdateDate As String = Format(lastdate, "yyyy-MM-dd HH:mm")

    '                    Dim BranchTimeDate As String = GetbranchServerTime() ''<<<< Get time from branch

    '                    ProgressBar1.Value = x
    '                    If GetDataSetFromBranch(x, BrachLastUpdateDate) = True Then   ''<<<<< SET TABLE DATATABLE
    '                        If ProcessInsertData(x, CustomerTableDataset) = True Then
    '                            Call UpdateBranchLastTransaction(x, Connection.bRANCHCODE, BranchTimeDate)
    '                        Else

    '                        End If



    '                        Dim percent As Decimal = (x / ProgressBar1.Maximum) * 100
    '                        Dim finpercent As String = Decimal.Round(percent, 2, MidpointRounding.AwayFromZero) & " %"
    '                        Call SetText_lblProgressPercent1(finpercent)
    '                        Application.DoEvents()


    '                    Else  ''<<<<< SET TABLE DATATABLE

    '                    End If


    '                Next


    '                Timer2.Start()


    '            Else '' <<<< CANNOT PING IP ADDRESS
    '                Call SetText_lblIP("X")
    '                Call SetText_lblIPName("X")
    '            End If

    '        Else

    '        End If


    '    End Sub


    '#Region "Set Text"
    '    Delegate Sub SetTextCallback(text As String)
    '    Public Sub SetText_lblIP(ByVal text As String)
    '        If lblIP.InvokeRequired Then
    '            Dim d As New SetTextCallback(AddressOf SetText_lblIP)
    '            Me.Invoke(d, New Object() {[text]})
    '        Else
    '            lblIP.Text = [text]
    '        End If
    '        Application.DoEvents()
    '    End Sub

    '    Public Sub SetText_lblIPName(ByVal text As String)
    '        If lblIPName.InvokeRequired Then
    '            Dim d As New SetTextCallback(AddressOf SetText_lblIPName)
    '            Me.Invoke(d, New Object() {[text]})
    '        Else
    '            lblIPName.Text = [text]
    '        End If
    '        Application.DoEvents()
    '    End Sub

    '    Public Sub SetText_lbltimerCount(ByVal text As String)
    '        If lbltimerCount.InvokeRequired Then
    '            Dim d As New SetTextCallback(AddressOf SetText_lbltimerCount)
    '            Me.Invoke(d, New Object() {[text]})
    '        Else
    '            lbltimerCount.Text = [text]
    '        End If
    '        Application.DoEvents()
    '    End Sub

    '    Public Sub SetText_lblProgressPercent1(ByVal text As String)
    '        If lblProgressPercent1.InvokeRequired Then
    '            Dim d As New SetTextCallback(AddressOf SetText_lblProgressPercent1)
    '            Me.Invoke(d, New Object() {[text]})
    '        Else
    '            lblProgressPercent1.Text = [text]
    '        End If
    '        Application.DoEvents()
    '    End Sub
    '    Public Sub SetText_lblProgressPercent2(ByVal text As String)
    '        If lblProgressPercent2.InvokeRequired Then
    '            Dim d As New SetTextCallback(AddressOf SetText_lblProgressPercent2)
    '            Me.Invoke(d, New Object() {text})
    '        Else
    '            lblProgressPercent2.Text = text
    '        End If
    '        Application.DoEvents()

    '    End Sub

    '    Public Sub SetText_lblStatus(ByVal text As String)
    '        If lblStatus.InvokeRequired Then
    '            Dim d As New SetTextCallback(AddressOf SetText_lblStatus)
    '            Me.Invoke(d, New Object() {[text]})
    '        Else
    '            lblStatus.Text = [text]
    '        End If
    '        Application.DoEvents()
    '    End Sub

    '    Public Sub SetText_lblLocation(ByVal text As String)
    '        If lblLocation.InvokeRequired Then
    '            Dim d As New SetTextCallback(AddressOf SetText_lblLocation)
    '            Me.Invoke(d, New Object() {[text]})
    '        Else
    '            lblLocation.Text = [text]
    '        End If
    '        Application.DoEvents()
    '    End Sub


    '#End Region




    '    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    End Sub
End Class

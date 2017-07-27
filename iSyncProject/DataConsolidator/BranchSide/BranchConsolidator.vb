Imports Newtonsoft.Json

Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Linq
Imports Newtonsoft.Json.Linq
Imports System.Collections.Generic
Imports System.Web.Script.Serialization
Imports System.Text


Public Class v

    Private MyCommon As New Common

    Private ApiUri As String = "http://192.168.161.248/webfinancials/web/api/"

    Private flagClientProfileUpload As Boolean = True
    Private flagClientDependentsUpload As Boolean = True
    Private flagGLBalanceUpload As Boolean = True
    Private flagSLBAlanceUpload As Boolean = True
    Private flagLoanAccountUpload As Boolean = True
    Private flagLoanLedgerUpload As Boolean = True
    Private flagSavingsAccountUpload As Boolean = True
    Private flagSavingsLedgerUpload As Boolean = True
    Private flagShareAccountUpload As Boolean = True
    Private flagShareLedgerUpload As Boolean = True
    Private flagTDAccountUpload As Boolean = True
    Private flagTDLegerUpload As Boolean = True
    Private flagMortuaryAccountUpload As Boolean = True
    Private flagMortuaryDetailsUpload As Boolean = True
    Private flagHPPAccountUpload As Boolean = True
    Private flagEmpHistoryAccountUpload As Boolean = True
    Private flagCustomerAddressUpload As Boolean = True
    Private flagLPPUpload As Boolean = True

    Private Sub BranchConsolidator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False '' settings for background Workere
        Me.Location = New Point(100, 100) ''<< SET FORM LOCATION
        Me.Text = "iSync v:" & Me.GetType.Assembly.GetName.Version.ToString()


        Common.SetActiveTime = True
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'BackgroundWorker1.RunWorkerAsync()
        'BackgroundWorker2.RunWorkerAsync()
        'BackgroundWorker3.RunWorkerAsync()
        'BackgroundWorker4.RunWorkerAsync()
        'BackgroundWorker5.RunWorkerAsync()
        'BackgroundWorker6.RunWorkerAsync()
        'BackgroundWorker7.RunWorkerAsync()
        'BackgroundWorker8.RunWorkerAsync()
        'BackgroundWorker9.RunWorkerAsync()
        'BackgroundWorker10.RunWorkerAsync()
        'BackgroundWorker11.RunWorkerAsync()
        'BackgroundWorker12.RunWorkerAsync()
        'BackgroundWorker13.RunWorkerAsync()
        'BackgroundWorker14.RunWorkerAsync()
    End Sub

    Private Sub StartGeneralProcess()


    End Sub


#Region "Process"
    Function ProcessClientDependents(MyIdentifier As String, IndexId As String) As Boolean
        Dim ClientDependentsAccess As New D_ClientDependents
        Dim ClientDependentscls As New M_ClientDependents
        Dim ClientDependentsDataTable As DataTable = Nothing

        '----------- get customer datails ---------------
        Try


            Dim client As New HttpClient()

            client.BaseAddress = New Uri(ApiUri)

            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            ClientDependentsDataTable = ClientDependentsAccess.GetTableDetails(MyIdentifier)

            If ClientDependentsDataTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = ClientDependentsAccess.SetDataTableToClass(ClientDependentscls, ClientDependentsDataTable)


                '-------------- insert to API --------------------

                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()



                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                    New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                }



                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("client-info/update-dependent", contents).Result



                '-------------- if insert is ok: update STATUS ------------
                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

                pairs.Clear()



            ElseIf ClientDependentsDataTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf ClientDependentsDataTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If


            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessClientDependents2(MyIdentifier As String, IndexId As String) As Boolean
        Dim ClientDependents2Access As New D_ClientDependents2
        Dim ClientDependents2cls As New M_ClientDependents2
        Dim ClientDependents2DataTable As DataTable = Nothing

        '----------- get customer datails ---------------
        Try

            Dim client As New HttpClient()

            client.BaseAddress = New Uri(ApiUri)

            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))


            ClientDependents2DataTable = ClientDependents2Access.GetTableDetails(MyIdentifier)

            If ClientDependents2DataTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = ClientDependents2Access.SetDataTableToClass(ClientDependents2cls, ClientDependents2DataTable)

                '-------------- insert to API --------------------

                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                     New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                 }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("client-info/update-dependent2", contents).Result


                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------

                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

                pairs.Clear()


            ElseIf ClientDependents2DataTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf ClientDependents2DataTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessGlBalance(MyIdentifier As String, IndexId As String) As Boolean
        Dim GlBalanceAccess As New D_GLBalance
        Dim GlBalancecls As New M_GLBalance
        Dim GlBalanceDataTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)

        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try
            '----------- split identifier by | -----------------
            Dim strArr() As String
            Dim GlCode As String = ""
            Dim Trandate As String = ""

            strArr = MyIdentifier.Split("|")
            GlCode = Trim(strArr(0))
            Trandate = Trim(strArr(1))

            '----------- get customer datails ---------------
            GlBalanceDataTable = GlBalanceAccess.GetTableDetails(GlCode, Trandate)

            If GlBalanceDataTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = GlBalanceAccess.SetDataTableToClass(GlBalancecls, GlBalanceDataTable)


                '-------------- insert to API --------------------

                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                       New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                   }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-general-led-balance", contents).Result


                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------

                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

                pairs.Clear()


            ElseIf GlBalanceDataTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf GlBalanceDataTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessInsuranceAccount(MyIdentifier As String, IndexId As String) As Boolean
        Dim InsuranceAccountAccess As New D_InsuranceAccount
        Dim InsuranceAccountcls As New M_InsuranceAccount
        Dim InsuranceAccountDataTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try
            '----------- split identifier by | -----------------


            '----------- get customer datails ---------------
            InsuranceAccountDataTable = InsuranceAccountAccess.GetTableDetails(MyIdentifier)

            If InsuranceAccountDataTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = InsuranceAccountAccess.SetDataTableToClass(InsuranceAccountcls, InsuranceAccountDataTable)


                '-------------- insert to API --------------------

                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-hpp-account", contents).Result


                '-------------- if insert is ok: update STATUS ------------
                'MyCommon.SetUpdateStatus(IndexId)
                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If
            ElseIf InsuranceAccountDataTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf InsuranceAccountDataTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessLoanAccount(MyIdentifier As String, IndexId As String) As Boolean
        Dim LoanAccountAccess As New D_LoanAccount
        Dim LoanAccountcls As New M_LoanAccount
        Dim LoanAccountTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)

        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try
            '----------- split identifier by | -----------------


            '----------- get customer datails ---------------
            LoanAccountTable = LoanAccountAccess.GetTableDetails(MyIdentifier)

            If LoanAccountTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = LoanAccountAccess.SetDataTableToClass(LoanAccountcls, LoanAccountTable)


                '-------------- insert to API --------------------

                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-loan-account", contents).Result

                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------

                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

            ElseIf LoanAccountTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf LoanAccountTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessLoanComakerAccount(MyIdentifier As String, IndexId As String) As Boolean
        Dim LoanComakerAccountAccess As New D_LoanComakerAccount
        Dim LoanComakerAccountcls As New M_LoanComakerAccount
        Dim LoanComakerAccountTable As DataTable = Nothing
        Try
            '----------- split identifier by | -----------------

            '----------- get customer datails ---------------
            LoanComakerAccountTable = LoanComakerAccountAccess.GetTableDetails(MyIdentifier)

            If LoanComakerAccountTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = LoanComakerAccountAccess.SetDataTableToClass(LoanComakerAccountcls, LoanComakerAccountTable)


                '-------------- insert to API --------------------

                'MsgBox(MyJsonString)
                RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                RichTextBox1.SelectionStart = RichTextBox1.TextLength
                RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------
                MyCommon.SetUpdateStatus(IndexId)
            ElseIf LoanComakerAccountTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf LoanComakerAccountTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessLoanInstallment(MyIdentifier As String, IndexId As String) As Boolean
        Dim LoanInstallmentAccess As New D_LoanInstallment
        Dim LoanInstallmentcls As New M_LoanInstallment
        Dim LoanInstallmentTable As DataTable = Nothing
        Try
            '----------- split identifier by | -----------------
            Dim strArr() As String
            Dim MyAccountNumber As String = ""
            Dim InstallNumber As String = ""

            strArr = MyIdentifier.Split("|")
            MyAccountNumber = Trim(strArr(0))
            InstallNumber = Trim(strArr(1))

            '----------- get customer datails ---------------
            LoanInstallmentTable = LoanInstallmentAccess.GetTableDetails(MyAccountNumber, InstallNumber)

            If LoanInstallmentTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = LoanInstallmentAccess.SetDataTableToClass(LoanInstallmentcls, LoanInstallmentTable)


                '-------------- insert to API --------------------

                'MsgBox(MyJsonString)
                RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                RichTextBox1.SelectionStart = RichTextBox1.TextLength
                RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------
                MyCommon.SetUpdateStatus(IndexId)
            ElseIf LoanInstallmentTable.Rows.Count = 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf LoanInstallmentTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessLoanProtectionAccount(MyIdentifier As String, IndexId As String) As Boolean
        Dim LoanProtectionAccountAccess As New D_LoanProtectionAccount
        Dim LoanProtectionAccountcls As New M_LoanProtectionAccount
        Dim LoanProtectionAccountTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try
            '----------- split identifier by | -----------------

            '----------- get customer datails ---------------
            LoanProtectionAccountTable = LoanProtectionAccountAccess.GetTableDetails(MyIdentifier)

            If LoanProtectionAccountTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = LoanProtectionAccountAccess.SetDataTableToClass(LoanProtectionAccountcls, LoanProtectionAccountTable)


                '-------------- insert to API --------------------
                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-loan-protect-account", contents).Result



                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------
                'MyCommon.SetUpdateStatus(IndexId)

                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

            ElseIf LoanProtectionAccountTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf LoanProtectionAccountTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessLoanTranMaster(MyIdentifier As String, IndexId As String) As Boolean
        Dim LoanTranMasterAccess As New D_LoanTranMaster
        Dim LoanTranMastercls As New M_LoanTranMaster
        Dim LoanTranMasterTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))


        Try
            '----------- split identifier by | -----------------
            Dim strArr() As String
            Dim Accountnumber As String = ""
            Dim TranNo As String = ""
            Dim TranDate As String = ""
            Dim Amount As String = ""

            strArr = MyIdentifier.Split("|")
            Accountnumber = Trim(strArr(0))
            TranNo = Trim(strArr(1))
            TranDate = Trim(strArr(2))
            Amount = Trim(strArr(3))

            '----------- get customer datails ---------------
            LoanTranMasterTable = LoanTranMasterAccess.GetTableDetails(Accountnumber, TranNo, TranDate, Amount)

            If LoanTranMasterTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = LoanTranMasterAccess.SetDataTableToClass(LoanTranMastercls, LoanTranMasterTable)


                '-------------- insert to API --------------------
                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }

                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-loan-tran-ledger", contents).Result



                ''MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------
                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

            ElseIf LoanTranMasterTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf LoanTranMasterTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessMortuaryDetails(MyIdentifier As String, IndexId As String) As Boolean
        Dim MortuaryDetailsAccess As New D_MortuaryDetails
        Dim MortuaryDetailscls As New M_MortuaryDetails
        Dim MortuaryDetailsTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try
            '----------- split identifier by | -----------------
            Dim strArr() As String
            Dim Accountnumber As String = ""
            Dim TranNo As String = ""
            Dim TranDate As String = ""
            Dim Amount As String = ""

            strArr = MyIdentifier.Split("|")
            Accountnumber = Trim(strArr(0))
            TranNo = Trim(strArr(1))
            TranDate = Trim(strArr(2))
            Amount = Trim(strArr(3))

            '----------- get customer datails ---------------
            MortuaryDetailsTable = MortuaryDetailsAccess.GetTableDetails(Accountnumber, TranNo, TranDate, Amount)

            If MortuaryDetailsTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = MortuaryDetailsAccess.SetDataTableToClass(MortuaryDetailscls, MortuaryDetailsTable)


                '-------------- insert to API --------------------

                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-mortuary-detail", contents).Result

                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------
                'MyCommon.SetUpdateStatus(IndexId)
                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If


            ElseIf MortuaryDetailsTable.Rows.Count = 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf MortuaryDetailsTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessMortuaryHeader(MyIdentifier As String, IndexId As String) As Boolean
        Dim MortuaryHeaderAccess As New D_MortuaryHeader
        Dim MortuaryHeadercls As New M_MortuaryHeader
        Dim MortuaryHeaderTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try

            '----------- get customer datails ---------------
            MortuaryHeaderTable = MortuaryHeaderAccess.GetTableDetails(MyIdentifier)

            If MortuaryHeaderTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = MortuaryHeaderAccess.SetDataTableToClass(MortuaryHeadercls, MortuaryHeaderTable)


                '-------------- insert to API --------------------



                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                                    }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-mortuary-header", contents).Result

                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------
                'MyCommon.SetUpdateStatus(IndexId)
                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If


            ElseIf MortuaryHeaderTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf MortuaryHeaderTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessSATransaction(MyIdentifier As String, IndexId As String) As Boolean
        Dim SATransactionAccess As New D_SATransaction
        Dim SATransactioncls As New M_SATransaction
        Dim SATransactionTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))


        Try
            '----------- split identifier by | -----------------
            Dim strArr() As String
            Dim TranNo As String = ""
            Dim TranDate As String = ""
            Dim Accountnumber As String = ""
            Dim Amount As String = ""

            strArr = MyIdentifier.Split("|")
            TranNo = Trim(strArr(0))
            TranDate = Trim(strArr(1))
            Accountnumber = Trim(strArr(2))
            Amount = Trim(strArr(3))

            '----------- get customer datails ---------------
            SATransactionTable = SATransactionAccess.GetTableDetails(TranNo, TranDate, Accountnumber, Amount)

            If SATransactionTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = SATransactionAccess.SetDataTableToClass(SATransactioncls, SATransactionTable)


                '-------------- insert to API --------------------

                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-savings-transaction", contents).Result


                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------
                'MyCommon.SetUpdateStatus(IndexId)


                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

            ElseIf SATransactionTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf SATransactionTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessSavingsAccount(MyIdentifier As String, IndexId As String) As Boolean
        Dim SavingsAccountAccess As New D_SavingsAccount
        Dim SavingsAccountcls As New M_SavingsAccount
        Dim SavingsAccountTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
        Try

            '----------- get customer datails ---------------
            SavingsAccountTable = SavingsAccountAccess.GetTableDetails(MyIdentifier)

            If SavingsAccountTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = SavingsAccountAccess.SetDataTableToClass(SavingsAccountcls, SavingsAccountTable)


                '-------------- insert to API --------------------

                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }

                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-savings-account", contents).Result

                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------
                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

            ElseIf SavingsAccountTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf SavingsAccountTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessShareTransaction(MyIdentifier As String, IndexId As String) As Boolean
        Dim ShareTransactionAccess As New D_ShareTransaction
        Dim ShareTransactioncls As New M_ShareTransaction
        Dim ShareTransactionTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try
            '----------- split identifier by | -----------------
            Dim strArr() As String
            Dim TranNo As String = ""
            Dim TranDate As String = ""
            Dim Accountnumber As String = ""
            Dim Amount As String = ""

            strArr = MyIdentifier.Split("|")
            TranNo = Trim(strArr(0))
            TranDate = Trim(strArr(1))
            Accountnumber = Trim(strArr(2))
            Amount = Trim(strArr(3))

            '----------- get customer datails ---------------
            ShareTransactionTable = ShareTransactionAccess.GetTableDetails(TranNo, TranDate, Accountnumber, Amount)

            If ShareTransactionTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = ShareTransactionAccess.SetDataTableToClass(ShareTransactioncls, ShareTransactionTable)


                '-------------- insert to API --------------------

                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-share-transaction", contents).Result

                ''MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------
                'MyCommon.SetUpdateStatus(IndexId)

                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If
            ElseIf ShareTransactionTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf ShareTransactionTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function



    Function ProcessTDAccount(MyIdentifier As String, IndexId As String) As Boolean
        Dim TDAccountAccess As New D_TdAccount
        Dim TDAccountcls As New M_TdAccount
        Dim TDAccountTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try

            '----------- get customer datails ---------------
            TDAccountTable = TDAccountAccess.GetTableDetails(MyIdentifier)

            If TDAccountTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = TDAccountAccess.SetDataTableToClass(TDAccountcls, TDAccountTable)


                '-------------- insert to API --------------------

                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()


                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-time-dep-account", contents).Result


                '-------------- if insert is ok: update STATUS ------------
                'MyCommon.SetUpdateStatus(IndexId)

                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

            ElseIf TDAccountTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf TDAccountTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessSlBalance(MyIdentifier As String, IndexId As String) As Boolean
        Dim SlBalanceAccess As New D_SLBalance
        Dim SlBalancecls As New M_SLBalance
        Dim SlBalanceTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)

        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try
            '---------------------- SPLIT --------------------
            Dim strArr() As String
            Dim SLCode As String = ""
            Dim Trandate As String = ""

            strArr = MyIdentifier.Split("|")
            Trandate = Trim(strArr(0))
            SLCode = Trim(strArr(1))
            '----------- get customer datails ---------------
            SlBalanceTable = SlBalanceAccess.GetTableDetails(SLCode, Trandate)

            If SlBalanceTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = SlBalanceAccess.SetDataTableToClass(SlBalancecls, SlBalanceTable)


                '-------------- insert to API --------------------

                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                       New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                   }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-subsidiary-led-balance", contents).Result

                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------

                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

            ElseIf SlBalanceTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf SlBalanceTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function

    Function ProcessTDTransaction(MyIdentifier As String, IndexId As String) As Boolean
        Dim TDTransactionAccess As New D_TDTransaction
        Dim TDTransactioncls As New M_TDTransaction
        Dim TDTransactionTable As DataTable = Nothing

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try
            '----------- split identifier by | -----------------
            Dim strArr() As String
            Dim TranNo As String = ""
            Dim TranDate As String = ""
            Dim Accountnumber As String = ""
            Dim Amount As String = ""

            strArr = MyIdentifier.Split("|")
            TranNo = Trim(strArr(0))
            TranDate = Trim(strArr(1))
            Accountnumber = Trim(strArr(2))
            Amount = Trim(strArr(3))

            '----------- get customer datails ---------------
            TDTransactionTable = TDTransactionAccess.GetTableDetails(TranNo, TranDate, Accountnumber, Amount)

            If TDTransactionTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = TDTransactionAccess.SetDataTableToClass(TDTransactioncls, TDTransactionTable)


                '-------------- insert to API --------------------

                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-time-dep-transaction", contents).Result


                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()

                '-------------- if insert is ok: update STATUS ------------
                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If
            ElseIf TDTransactionTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf TDTransactionTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function


    Function ProcessShareAccount(MyIdentifier As String, IndexId As String) As Boolean
        Dim ShareAccountAccess As New D_ShareAccount
        Dim ShareAccountcls As New M_ShareAccount
        Dim ShareAccountDataTable As DataTable = Nothing
        Dim MyJsonString As String = ""

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try
            '----------- get customer datails ---------------
            ShareAccountDataTable = ShareAccountAccess.GetTableDetails(MyIdentifier)

            If ShareAccountDataTable.Rows.Count = 1 Then

                MyJsonString = ShareAccountAccess.SetDataTableToClass(ShareAccountcls, ShareAccountDataTable)

                '-------------- insert to API --------------------

                'MsgBox(MyJsonString)


                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }


                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-share-account", contents).Result


                '-------------- if insert is ok: update STATUS ------------
                'MyCommon.SetUpdateStatus(IndexId)
                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

            ElseIf ShareAccountDataTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf ShareAccountDataTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If
            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try

    End Function

    Function ProcessCustomer(MyIdentifier As String, IndexId As String) As Boolean
        Dim CustomerAccess As New D_Customer
        Dim Customercls As New M_Customer
        Dim CustomerDataTable As DataTable = Nothing

        '----------- split identifier by | -----------------
        'Dim strArr() As String
        'Dim MyCid As String = ""

        'strArr = MyIdentifier.Split("|")
        'MyCid = Trim(strArr(0))

        '----------- get customer datails ---------------

        Dim paramList As New JArray



        'Dim handler = New WebRequestHandler

        'handler.ClientCertificateOptions = ClientCertificateOption.Automatic
        'handler.PreAuthenticate = True

        Dim client As New HttpClient()

        client.BaseAddress = New Uri(ApiUri)

        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))



        Try


            CustomerDataTable = CustomerAccess.GetTableDetails(MyIdentifier)

            If CustomerDataTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = CustomerAccess.SetDataTableToClass(Customercls, CustomerDataTable)



                '-------------- insert to API --------------------

                'Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                '    New KeyValuePair(Of String, String)("CustomerID", CustomerDataTable.Rows(0).Item("CustomerID")), _
                '    New KeyValuePair(Of String, String)("BranchID", CustomerDataTable.Rows(0).Item("BranchID")), _
                '    New KeyValuePair(Of String, String)("CustomerType", CustomerDataTable.Rows(0).Item("CustomerType")), _
                '    New KeyValuePair(Of String, String)("TypeOfMembeship", CustomerDataTable.Rows(0).Item("TypeOfMembeship")), _
                '    New KeyValuePair(Of String, String)("MemberShipStatus", CustomerDataTable.Rows(0).Item("MemberShipStatus")), _
                '    New KeyValuePair(Of String, String)("DateOfMembership", CustomerDataTable.Rows(0).Item("DateOfMembership")), _
                '    New KeyValuePair(Of String, String)("LastName", CustomerDataTable.Rows(0).Item("LastName")), _
                '    New KeyValuePair(Of String, String)("FirstName", CustomerDataTable.Rows(0).Item("FirstName")), _
                '    New KeyValuePair(Of String, String)("MiddleName", CustomerDataTable.Rows(0).Item("MiddleName")), _
                '    New KeyValuePair(Of String, String)("CompanyName", CustomerDataTable.Rows(0).Item("CompanyName")), _
                '    New KeyValuePair(Of String, String)("DateOfBirth", CustomerDataTable.Rows(0).Item("DateOfBirth")), _
                '    New KeyValuePair(Of String, String)("Gender", CustomerDataTable.Rows(0).Item("Gender")), _
                '    New KeyValuePair(Of String, String)("CivilStatus", CustomerDataTable.Rows(0).Item("CivilStatus")), _
                '    New KeyValuePair(Of String, String)("IdenficationType", CustomerDataTable.Rows(0).Item("IdenficationType")), _
                '    New KeyValuePair(Of String, String)("IdentificationNumber", CustomerDataTable.Rows(0).Item("IdentificationNumber")), _
                '    New KeyValuePair(Of String, String)("CreatedBy", CustomerDataTable.Rows(0).Item("CreatedBy")), _
                '    New KeyValuePair(Of String, String)("DateCreated", CustomerDataTable.Rows(0).Item("DateCreated")), _
                '    New KeyValuePair(Of String, String)("IdentificationType2", CustomerDataTable.Rows(0).Item("IdentificationType2")), _
                '    New KeyValuePair(Of String, String)("IdentificationNumber2", CustomerDataTable.Rows(0).Item("IdentificationNumber2")), _
                '    New KeyValuePair(Of String, String)("DateOfRegistration", CustomerDataTable.Rows(0).Item("DateOfRegistration")), _
                '    New KeyValuePair(Of String, String)("PrimaryContactPerson", CustomerDataTable.Rows(0).Item("PrimaryContactPerson")), _
                '    New KeyValuePair(Of String, String)("SecondaryContactPerson", CustomerDataTable.Rows(0).Item("SecondaryContactPerson")), _
                '    New KeyValuePair(Of String, String)("Remarks", CustomerDataTable.Rows(0).Item("Remarks")), _
                '    New KeyValuePair(Of String, String)("TrackNumber", CustomerDataTable.Rows(0).Item("TrackNumber")), _
                '    New KeyValuePair(Of String, String)("FKGroupCode", CustomerDataTable.Rows(0).Item("FKGroupCode")), _
                '    New KeyValuePair(Of String, String)("FKAddressCode", CustomerDataTable.Rows(0).Item("FKAddressCode")), _
                '    New KeyValuePair(Of String, String)("PlaceOfBirth", CustomerDataTable.Rows(0).Item("PlaceOfBirth")), _
                '    New KeyValuePair(Of String, String)("FKTypeOfResidence", CustomerDataTable.Rows(0).Item("FKTypeOfResidence")), _
                '    New KeyValuePair(Of String, String)("NumHousehold", CustomerDataTable.Rows(0).Item("NumHousehold")), _
                '    New KeyValuePair(Of String, String)("FKReligion", CustomerDataTable.Rows(0).Item("FKReligion")), _
                '    New KeyValuePair(Of String, String)("ChildInSchool", CustomerDataTable.Rows(0).Item("ChildInSchool")), _
                '    New KeyValuePair(Of String, String)("ParentAddress", IIf(IsDBNull(CustomerDataTable.Rows(0).Item("ParentAddress")), "", CustomerDataTable.Rows(0).Item("ParentAddress"))), _
                '    New KeyValuePair(Of String, String)("row_version", CustomerDataTable.Rows(0).Item("row_version")) _
                '}

                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                        New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                    }



                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("client-info/update-client", contents).Result



                ''  MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()


                '-------------- if insert is ok: update STATUS ------------

                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

                pairs.Clear()


            ElseIf CustomerDataTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf CustomerDataTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If



            Return True

        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        Finally
            CustomerDataTable.Dispose()
        End Try

    End Function

#End Region

    Private Sub ProcessSyncClient()

        Dim Dt_pendings As DataTable = Nothing
        Dim PendingCount As Integer = 0

        PendingCount = MyCommon.GetCountPendings("CUSTOMER")

        If PendingCount = 0 Then Exit Sub

        Me.txtClientProfileTotal.Text = PendingCount

        For a = 1 To PendingCount

            If Len(RichTextBox1.Text) >= 500000 Then RichTextBox1.Clear()


            If Common.SetActiveTime = True Then Call Common.ProcessSetActiveTime()

            Dt_pendings = Nothing
            Dt_pendings = MyCommon.GetPendings("CUSTOMER")

            If Dt_pendings.Rows.Count > 0 Then
                Dim TableToProcess As String = ""
                Dim TableIdentifier As String = ""
                Dim IndexId As String = ""

                IndexId = Dt_pendings.Rows(0).Item("INDEXID").ToString ''<< Contains Indexid
                TableToProcess = Dt_pendings.Rows(0).Item("PROCESSTABLENAME").ToString.ToUpper ''<< Contails Table Name
                TableIdentifier = Dt_pendings.Rows(0).Item("DATAIDENTIFIER").ToString ''<< Contains Table FK's

                Select Case TableToProcess

                    Case "CUSTOMER"
                        If ProcessCustomer(TableIdentifier, IndexId) = False Then Exit Sub
                    Case Else
                        MsgBox("NOT DEFINED: " & TableToProcess)
                        Exit Sub
                End Select
            Else
                'No data found
            End If

            Me.txtClientProfileUploaded.Text = a
            Application.DoEvents()

        Next


    End Sub

    Private Sub ProcessSyncDependent()

        Dim Dt_pendings As DataTable = Nothing
        Dim PendingCount As Integer = 0

        PendingCount = MyCommon.GetCountPendings("CLIENTDEPENDENTS")

        If PendingCount = 0 Then Exit Sub

        Me.txtDependentsTotal.Text = PendingCount

        For a = 1 To PendingCount

            If Len(RichTextBox1.Text) >= 500000 Then RichTextBox1.Clear()


            If Common.SetActiveTime = True Then Call Common.ProcessSetActiveTime()

            Dt_pendings = Nothing
            Dt_pendings = MyCommon.GetPendings("CLIENTDEPENDENTS")

            If Dt_pendings.Rows.Count > 0 Then
                Dim TableToProcess As String = ""
                Dim TableIdentifier As String = ""
                Dim IndexId As String = ""

                IndexId = Dt_pendings.Rows(0).Item("INDEXID").ToString ''<< Contains Indexid
                TableToProcess = Dt_pendings.Rows(0).Item("PROCESSTABLENAME").ToString.ToUpper ''<< Contails Table Name
                TableIdentifier = Dt_pendings.Rows(0).Item("DATAIDENTIFIER").ToString ''<< Contains Table FK's

                Select Case TableToProcess

                    Case "CLIENTDEPENDENTS"
                        If ProcessClientDependents(TableIdentifier, IndexId) = False Then Exit Sub
                    Case Else
                        MsgBox("NOT DEFINED: " & TableToProcess)
                        Exit Sub
                End Select
            Else
                'No data found
            End If

            Me.txtDependentsUploaded.Text = a
            Application.DoEvents()

        Next


    End Sub

    Private Sub ProcessSyncGLBalance()

        Dim Dt_pendings As DataTable = Nothing
        Dim PendingCount As Integer = 0

        PendingCount = MyCommon.GetCountPendings("GLBALANCE")

        If PendingCount = 0 Then Exit Sub

        Me.txtGLBalanceTotal.Text = PendingCount

        For a = 1 To PendingCount

            If Len(RichTextBox1.Text) >= 500000 Then RichTextBox1.Clear()


            If Common.SetActiveTime = True Then Call Common.ProcessSetActiveTime()

            Dt_pendings = Nothing
            Dt_pendings = MyCommon.GetPendings("GLBALANCE")

            If Dt_pendings.Rows.Count > 0 Then
                Dim TableToProcess As String = ""
                Dim TableIdentifier As String = ""
                Dim IndexId As String = ""

                IndexId = Dt_pendings.Rows(0).Item("INDEXID").ToString ''<< Contains Indexid
                TableToProcess = Dt_pendings.Rows(0).Item("PROCESSTABLENAME").ToString.ToUpper ''<< Contails Table Name
                TableIdentifier = Dt_pendings.Rows(0).Item("DATAIDENTIFIER").ToString ''<< Contains Table FK's

                Select Case TableToProcess

                    Case "GLBALANCE"
                        If ProcessGlBalance(TableIdentifier, IndexId) = False Then Exit Sub
                    Case Else
                        MsgBox("NOT DEFINED: " & TableToProcess)
                        Exit Sub
                End Select
            Else
                'No data found
            End If

            Me.txtGLBalanceUploaded.Text = a
            Application.DoEvents()

        Next


    End Sub

    Private Sub ProcessSyncSLBalance()

        Dim Dt_pendings As DataTable = Nothing
        Dim PendingCount As Integer = 0

        PendingCount = MyCommon.GetCountPendings("SLBALANCE")

        If PendingCount = 0 Then Exit Sub

        Me.txtSLBalanceTotal.Text = PendingCount

        For a = 1 To PendingCount

            If Len(RichTextBox1.Text) >= 500000 Then RichTextBox1.Clear()


            If Common.SetActiveTime = True Then Call Common.ProcessSetActiveTime()

            Dt_pendings = Nothing
            Dt_pendings = MyCommon.GetPendings("SLBALANCE")

            If Dt_pendings.Rows.Count > 0 Then
                Dim TableToProcess As String = ""
                Dim TableIdentifier As String = ""
                Dim IndexId As String = ""

                IndexId = Dt_pendings.Rows(0).Item("INDEXID").ToString ''<< Contains Indexid
                TableToProcess = Dt_pendings.Rows(0).Item("PROCESSTABLENAME").ToString.ToUpper ''<< Contails Table Name
                TableIdentifier = Dt_pendings.Rows(0).Item("DATAIDENTIFIER").ToString ''<< Contains Table FK's

                Select Case TableToProcess

                    Case "SLBALANCE"
                        If ProcessSlBalance(TableIdentifier, IndexId) = False Then Exit Sub
                    Case Else
                        MsgBox("NOT DEFINED: " & TableToProcess)
                        Exit Sub
                End Select
            Else
                'No data found
            End If

            Me.txtSLBalanceUploaded.Text = a
            Application.DoEvents()

        Next


    End Sub

    Function ProcessEmploymentHistory(MyIdentifier As String, IndexId As String) As Boolean

        Dim EmploymentHistoryAccess As New D_EmploymentHistory
        Dim EmploymentHistoryCls As New M_EmploymentHistory
        Dim EmploymentHistoryDataTable As DataTable = Nothing

        '----------- get customer datails ---------------
        Try


            Dim client As New HttpClient()

            client.BaseAddress = New Uri(ApiUri)

            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))


            EmploymentHistoryDataTable = EmploymentHistoryAccess.GetTableDetails(MyIdentifier)

            If EmploymentHistoryDataTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = EmploymentHistoryAccess.SetDataTableToClass(EmploymentHistoryCls, EmploymentHistoryDataTable)

                '-------------- insert to API --------------------

                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()



                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                    New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                }



                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-employment-history", contents).Result



                '-------------- if insert is ok: update STATUS ------------
                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

                pairs.Clear()



            ElseIf EmploymentHistoryDataTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf EmploymentHistoryDataTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If


            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function



    Function ProcessCustomerAddress(MyIdentifier As String, IndexId As String) As Boolean


        Dim CustomerAddressAccess As New D_CustomerAddress
        Dim CustomerAddressCls As New M_CustomerAddress
        Dim CustomerAddressDataTable As DataTable = Nothing

        '----------- get customer datails ---------------
        Try


            Dim client As New HttpClient()

            client.BaseAddress = New Uri(ApiUri)

            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))



            Dim strArr() As String
            Dim iNDEX As String = ""
            Dim CID As String = ""

            strArr = MyIdentifier.Split("|")
            iNDEX = Trim(strArr(0))
            CID = Trim(strArr(1))


            CustomerAddressDataTable = CustomerAddressAccess.GetTableDetails(iNDEX, CID)

            If CustomerAddressDataTable.Rows.Count = 1 Then

                Dim MyJsonString As String = ""


                MyJsonString = CustomerAddressAccess.SetDataTableToClass(CustomerAddressCls, CustomerAddressDataTable)

                '-------------- insert to API --------------------

                'MsgBox(MyJsonString)
                'RichTextBox1.Text = RichTextBox1.Text & MyJsonString & vbNewLine
                'RichTextBox1.SelectionStart = RichTextBox1.TextLength
                'RichTextBox1.ScrollToCaret()



                Dim pairs = New List(Of KeyValuePair(Of String, String))() From { _
                    New KeyValuePair(Of String, String)("json-data", MyJsonString) _
                }



                Dim contents = New FormUrlEncodedContent(pairs)

                Dim response = client.PostAsync("data-update/update-customer-address", contents).Result



                '-------------- if insert is ok: update STATUS ------------
                If response.IsSuccessStatusCode = True Then
                    MyCommon.SetUpdateStatus(IndexId)
                Else
                    RichTextBox1.Text = RichTextBox1.Text & response.ReasonPhrase & vbNewLine
                    RichTextBox1.SelectionStart = RichTextBox1.TextLength
                    RichTextBox1.ScrollToCaret()
                End If

                pairs.Clear()



            ElseIf CustomerAddressDataTable.Rows.Count > 1 Then ''<< MORE THAN 1 ROW 
                MsgBox("MORE THAN 1 RECORD")
                Return False

            ElseIf CustomerAddressDataTable.Rows.Count = 0 Then '' NO RECORD FETCHED
                MsgBox("NO RECORD FROM DB")
                Return False
            End If


            Return True
        Catch ex As Exception
            Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
            Return False
        End Try
    End Function



    Private Sub ProcessSync(ByRef pTxtTotal As TextBox, ByRef pTxtUploaded As TextBox, ByVal pTableName As String)

        Dim Dt_pendings As DataTable = Nothing
        Dim PendingCount As Integer = 0

        PendingCount = MyCommon.GetCountPendings(pTableName)

        If PendingCount = 0 Then Exit Sub

        'Me.txtSLBalanceTotal.Text = PendingCount

        pTxtTotal.Text = PendingCount

        For a = 1 To PendingCount
            ' For a = 1 To 2

            If Len(RichTextBox1.Text) >= 8999 Then RichTextBox1.Clear()

            If Common.SetActiveTime = True Then
                Dim UpdateTime As String = Common.ProcessSetActiveTime()
                Label27.Text = UpdateTime
            End If


            Dt_pendings = Nothing
            Dt_pendings = MyCommon.GetPendings(pTableName)

            If Dt_pendings.Rows.Count > 0 Then

                Dim TableToProcess As String = ""
                Dim TableIdentifier As String = ""
                Dim IndexId As String = ""

                IndexId = Dt_pendings.Rows(0).Item("INDEXID").ToString ''<< Contains Indexid
                TableToProcess = Dt_pendings.Rows(0).Item("PROCESSTABLENAME").ToString.ToUpper ''<< Contails Table Name
                TableIdentifier = Dt_pendings.Rows(0).Item("DATAIDENTIFIER").ToString ''<< Contains Table FK's

                Try

                    Select Case TableToProcess
                        Case "CLIENTDEPENDENTS"
                            ' flagClientDependentsUpload = False
                            If ProcessClientDependents(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "CLIENTDEPENDENTS2"
                            If ProcessClientDependents2(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "CUSTOMER"
                            ' flagClientProfileUpload = False
                            If ProcessCustomer(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "GLBALANCE"
                            ' flagGLBalanceUpload = False
                            If ProcessGlBalance(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "LOANACCOUNT"
                            ' flagLoanAccountUpload = False
                            If ProcessLoanAccount(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "LOANTRANMASTER"
                            ' flagLoanLedgerUpload = False
                            If ProcessLoanTranMaster(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "SAVINGSACCOUNT"
                            ' flagSavingsAccountUpload = False
                            If ProcessSavingsAccount(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "SATRANSACTION"
                            ' flagSavingsLedgerUpload = False
                            If ProcessSATransaction(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "SHAREACCOUNT"
                            ' flagShareAccountUpload = False
                            If ProcessShareAccount(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "SHARETRANSACTION"
                            ' flagShareLedgerUpload = False
                            If ProcessShareTransaction(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "TDACCOUNT"
                            ' flagTDAccountUpload = False
                            If ProcessTDAccount(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "TDTRANSACTION"
                            ' flagTDLegerUpload = False
                            If ProcessTDTransaction(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "MORTUARYHEADER"
                            ' flagMortuaryAccountUpload = False
                            If ProcessMortuaryHeader(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "MORTUARYDETAILS"
                            ' flagMortuaryDetailsUpload = False
                            If ProcessMortuaryDetails(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "LOANPROTECTIONACCOUNT"
                            ' flagLPPUpload = False
                            If ProcessLoanProtectionAccount(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "INSURANCEACCOUNT"
                            If ProcessInsuranceAccount(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "SLBALANCE"
                            '  flagSLBAlanceUpload = False
                            If ProcessSlBalance(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "EMPLOYMENTHISTORY"
                            ' flagEmpHistoryAccountUpload = False
                            If ProcessEmploymentHistory(TableIdentifier, IndexId) = False Then Exit Sub
                        Case "CUSTOMERADDRESS"
                            '  flagCustomerAddressUpload = False
                            If ProcessCustomerAddress(TableIdentifier, IndexId) = False Then Exit Sub
                            'Case "LOANCOMAKERACCOUNT"

                            '    If ProcessLoanComakerAccount(TableIdentifier, IndexId) = False Then Exit Sub
                            'Case "LOANINSTALLMENT"

                            '    If ProcessLoanInstallment(TableIdentifier, IndexId) = False Then Exit Sub


                        Case Else
                            MsgBox("NOT DEFINED: " & TableToProcess)
                            Exit Sub
                    End Select

                Catch ex As Exception
                    Call MyCommon.PromptMessage(ex.Message, Common.ThrownLocation, Common.ThrownLineNumber)
                End Try


            Else
                'No data found
            End If

            pTxtUploaded.Text = a
            Application.DoEvents()

        Next

        flagClientProfileUpload = True
        flagClientDependentsUpload = True
        flagGLBalanceUpload = True
        flagSLBAlanceUpload = True
        flagLoanAccountUpload = True
        flagLoanLedgerUpload = True
        flagSavingsAccountUpload = True
        flagSavingsLedgerUpload = True
        flagShareAccountUpload = True
        flagShareLedgerUpload = True
        flagTDAccountUpload = True
        flagTDLegerUpload = True
        flagMortuaryAccountUpload = True
        flagMortuaryDetailsUpload = True
        flagHPPAccountUpload = True
        flagEmpHistoryAccountUpload = True
        flagCustomerAddressUpload = True
        flagLPPUpload = True

    End Sub



    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        'Call ProcessSyncClient()
        Call ProcessSync(txtClientProfileTotal, txtClientProfileUploaded, "CUSTOMER")

        ''-------------- Get Latest on que ---------------
        'Dim Dt_pendings As DataTable = Nothing
        'Dim PendingCount As Integer = 0



        'PendingCount = MyCommon.GetCountPendings("INSURANCEACCOUNT")

        'If PendingCount = 0 Then Exit Sub

        'Label1.Text = PendingCount


        'For a = 1 To PendingCount


        '    If Len(RichTextBox1.Text) >= 500000 Then RichTextBox1.Clear()


        '    If Common.SetActiveTime = True Then Call Common.ProcessSetActiveTime()


        '    Dt_pendings = Nothing
        '    Dt_pendings = MyCommon.GetPendings("INSURANCEACCOUNT")

        '    If Dt_pendings.Rows.Count > 0 Then
        '        Dim TableToProcess As String = ""
        '        Dim TableIdentifier As String = ""
        '        Dim IndexId As String = ""

        '        IndexId = Dt_pendings.Rows(0).Item("INDEXID").ToString ''<< Contains Indexid
        '        TableToProcess = Dt_pendings.Rows(0).Item("PROCESSTABLENAME").ToString.ToUpper ''<< Contails Table Name
        '        TableIdentifier = Dt_pendings.Rows(0).Item("DATAIDENTIFIER").ToString ''<< Contains Table FK's

        '        Select Case TableToProcess
        '            Case "CLIENTDEPENDENTS"
        '                If ProcessClientDependents(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "CLIENTDEPENDENTS2"
        '                If ProcessClientDependents2(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "CUSTOMER"
        '                If ProcessCustomer(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "GLBALANCE"
        '                If ProcessGlBalance(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "LOANACCOUNT"
        '                If ProcessLoanAccount(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "LOANTRANMASTER"
        '                If ProcessLoanTranMaster(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "SAVINGSACCOUNT"
        '                If ProcessSavingsAccount(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "SATRANSACTION"
        '                If ProcessSATransaction(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "SHAREACCOUNT"
        '                If ProcessShareAccount(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "SHARETRANSACTION"
        '                If ProcessShareTransaction(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "TDACCOUNT"
        '                If ProcessTDAccount(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "TDTRANSACTION"
        '                If ProcessTDTransaction(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "MORTUARYHEADER"
        '                If ProcessMortuaryHeader(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "MORTUARYDETAILS"
        '                If ProcessMortuaryDetails(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "LOANPROTECTIONACCOUNT"
        '                If ProcessLoanProtectionAccount(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "INSURANCEACCOUNT"
        '                If ProcessInsuranceAccount(TableIdentifier, IndexId) = False Then Exit Sub
        '            Case "SLBALANCE"
        '                If ProcessSlBalance(TableIdentifier, IndexId) = False Then Exit Sub
        '                'Case "LOANCOMAKERACCOUNT"
        '                '    If ProcessLoanComakerAccount(TableIdentifier, IndexId) = False Then Exit Sub
        '                'Case "LOANINSTALLMENT"
        '                'If ProcessLoanInstallment(TableIdentifier, IndexId) = False Then Exit Sub




        '            Case Else
        '                MsgBox("NOT DEFINED: " & TableToProcess)
        '                Exit Sub
        '        End Select
        '    Else
        '        'No data found
        '    End If

        '    Label2.Text = a
        '    Application.DoEvents()

        'Next
    End Sub

    Private Sub Timer_setActivetime_Tick(sender As Object, e As EventArgs) Handles Timer_setActivetime.Tick
        Common.SetActiveTime = True ''<< var to set active time every 30 mins
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        'Call ProcessSyncDependent()
        Call ProcessSync(txtDependentsTotal, txtDependentsUploaded, "CLIENTDEPENDENTS")
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Call ProcessSync(txtGLBalanceTotal, txtGLBalanceUploaded, "GLBALANCE")
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        Call ProcessSync(txtSLBalanceTotal, txtSLBalanceUploaded, "SLBALANCE")
    End Sub

    Private Sub BackgroundWorker5_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker5.DoWork
        Call ProcessSync(txtLoanAccountTotal, txtLoanAccountUploaded, "LOANACCOUNT")
    End Sub

    Private Sub BackgroundWorker6_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker6.DoWork
        Call ProcessSync(txtLoanLedgerTotal, txtLoanLedgerUploaded, "LOANTRANMASTER")
    End Sub

    Private Sub BackgroundWorker7_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker7.DoWork
        Call ProcessSync(txtSavingsAccountTotal, txtSavingsAccountUploaded, "SAVINGSACCOUNT")
    End Sub

    Private Sub BackgroundWorker8_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker8.DoWork
        Call ProcessSync(txtSavingsLedgerTotal, txtSavingsLedgerUploaded, "SATRANSACTION")
    End Sub

    Private Sub BackgroundWorker9_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker9.DoWork
        Call ProcessSync(txtShareAccountTotal, txtShareAccountUploaded, "SHAREACCOUNT")
    End Sub

    Private Sub BackgroundWorker10_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker10.DoWork
        Call ProcessSync(txtShareLedgerTotal, txtShareLedgerUploaded, "SHARETRANSACTION")
    End Sub

    Private Sub BackgroundWorker11_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker11.DoWork
        Call ProcessSync(txtTDAccountsTotal, txtTDAccountsUploaded, "TDACCOUNT")
    End Sub

    Private Sub BackgroundWorker12_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker12.DoWork
        Call ProcessSync(txtTDLedgerTotal, txtTDLedgerUploaded, "TDTRANSACTION")
    End Sub

    Private Sub BackgroundWorker13_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker13.DoWork
        Call ProcessSync(txtMortuaryTotal, txtMortuaryUploaded, "MORTUARYHEADER")
    End Sub

    Private Sub BackgroundWorker14_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker14.DoWork
        Call ProcessSync(txtHPPTotal, txtHPPUploaded, "INSURANCEACCOUNT")
    End Sub

    Private Sub timerClientProfile_Tick(sender As Object, e As EventArgs) Handles timerClientProfile.Tick
        If flagClientProfileUpload = True And Not BackgroundWorker1.IsBusy Then
            ' Call BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerDependents_Tick(sender As Object, e As EventArgs) Handles timerDependents.Tick
        If flagClientDependentsUpload = True And Not BackgroundWorker2.IsBusy Then
            ' BackgroundWorker2.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerGLBalance_Tick(sender As Object, e As EventArgs) Handles timerGLBalance.Tick
        If flagGLBalanceUpload = True And Not BackgroundWorker3.IsBusy Then
            ' BackgroundWorker3.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerSLBalance_Tick(sender As Object, e As EventArgs) Handles timerSLBalance.Tick
        If flagSLBAlanceUpload = True And Not BackgroundWorker4.IsBusy Then
            ' BackgroundWorker4.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerLoanAccount_Tick(sender As Object, e As EventArgs) Handles timerLoanAccount.Tick
        If flagLoanAccountUpload = True And Not BackgroundWorker5.IsBusy Then
            ' BackgroundWorker5.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerLoanLedger_Tick(sender As Object, e As EventArgs) Handles timerLoanLedger.Tick
        If flagLoanLedgerUpload = True And Not BackgroundWorker6.IsBusy Then
            'BackgroundWorker6.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerSavingsAccount_Tick(sender As Object, e As EventArgs) Handles timerSavingsAccount.Tick
        If flagSavingsAccountUpload = True And Not BackgroundWorker7.IsBusy Then
            '  BackgroundWorker7.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerSavingsLedger_Tick(sender As Object, e As EventArgs) Handles timerSavingsLedger.Tick
        If flagSavingsLedgerUpload = True And Not BackgroundWorker8.IsBusy Then
            '  BackgroundWorker8.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerShareAccount_Tick(sender As Object, e As EventArgs) Handles timerShareAccount.Tick
        If flagShareAccountUpload = True And Not BackgroundWorker9.IsBusy Then
            ' BackgroundWorker9.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerShareLedger_Tick(sender As Object, e As EventArgs) Handles timerShareLedger.Tick
        If flagShareLedgerUpload = True And Not BackgroundWorker10.IsBusy Then
            ' BackgroundWorker10.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerTDAccount_Tick(sender As Object, e As EventArgs) Handles timerTDAccount.Tick
        If flagTDAccountUpload = True And Not BackgroundWorker11.IsBusy Then
            '  BackgroundWorker11.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerTDLedger_Tick(sender As Object, e As EventArgs) Handles timerTDLedger.Tick
        If flagTDLegerUpload = True And Not BackgroundWorker12.IsBusy Then
            '  BackgroundWorker12.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerMortuaryAccount_Tick(sender As Object, e As EventArgs) Handles timerMortuaryAccount.Tick
        If flagMortuaryAccountUpload = True And Not BackgroundWorker13.IsBusy Then
            '  BackgroundWorker13.RunWorkerAsync()
        End If
    End Sub

    Private Sub timerHPP_Tick(sender As Object, e As EventArgs) Handles timerHPP.Tick
        If flagHPPAccountUpload = True And Not BackgroundWorker14.IsBusy Then
            '  BackgroundWorker14.RunWorkerAsync()
        End If
    End Sub

 
    Private Sub timerEmpHistory_Tick(sender As Object, e As EventArgs) Handles timerEmpHistory.Tick
        If flagEmpHistoryAccountUpload = True And Not BackgroundWorker15.IsBusy Then
            '   BackgroundWorker15.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker15_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker15.DoWork
        Call ProcessSync(txtEmpHistoryTotal, txtEmpHistoryUploaded, "EMPLOYMENTHISTORY")
    End Sub

    Private Sub timerCustAddress_Tick(sender As Object, e As EventArgs) Handles timerCustAddress.Tick
        If flagCustomerAddressUpload = True And Not BackgroundWorker16.IsBusy Then
            '  BackgroundWorker16.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker16_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker16.DoWork
        Call ProcessSync(txtCustAddressTotal, txtCustAddressUploaded, "CUSTOMERADDRESS")
    End Sub

    Private Sub timerLPP_Tick(sender As Object, e As EventArgs) Handles timerLPP.Tick
        If flagLPPUpload = True And Not BackgroundWorker17.IsBusy Then
            'BackgroundWorker17.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker17_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker17.DoWork
        Call ProcessSync(txtLoanProtectionTotal, txtLoanProtectionUploaded, "LOANPROTECTIONACCOUNT")
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        BackgroundWorker2.RunWorkerAsync()

        RichTextBox1.Text = RichTextBox1.Text & " running bg2" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        BackgroundWorker3.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg3" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        BackgroundWorker4.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg4" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker4_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker4.RunWorkerCompleted
        BackgroundWorker5.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg5" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker5_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker5.RunWorkerCompleted
        BackgroundWorker6.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg6" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker6_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker6.RunWorkerCompleted
        BackgroundWorker7.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg7" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker7_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker7.RunWorkerCompleted
        BackgroundWorker8.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg8" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker8_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker8.RunWorkerCompleted
        BackgroundWorker9.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg9" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker9_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker9.RunWorkerCompleted
        BackgroundWorker10.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg10" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker10_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker10.RunWorkerCompleted
        BackgroundWorker11.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg11" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker12_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker12.RunWorkerCompleted
        BackgroundWorker13.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg13" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker13_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker13.RunWorkerCompleted
        BackgroundWorker14.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg14" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker14_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker14.RunWorkerCompleted
        BackgroundWorker15.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg15" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker15_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker15.RunWorkerCompleted
        BackgroundWorker16.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg16" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker17_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker17.RunWorkerCompleted

        timer_wait.Start()


       
    End Sub

    Private Sub BackgroundWorker11_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker11.RunWorkerCompleted
        BackgroundWorker12.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg12" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub BackgroundWorker16_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker16.RunWorkerCompleted
        BackgroundWorker17.RunWorkerAsync()
        RichTextBox1.Text = RichTextBox1.Text & " running bg17" & vbNewLine
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        If Len(RichTextBox1.Text) >= 8999 Then
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub BW_ClearPendings_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_ClearPendings.DoWork

    End Sub

    Private Sub timer_wait_Tick(sender As Object, e As EventArgs) Handles timer_wait.Tick

        If Label29.Text <= 0 Then
            Label29.Text = Label29.Tag
            timer_wait.Stop()

            BackgroundWorker1.RunWorkerAsync()
            RichTextBox1.Text = RichTextBox1.Text & " running bg1" & vbNewLine
            RichTextBox1.SelectionStart = RichTextBox1.TextLength
            RichTextBox1.ScrollToCaret()
        Else
            Label29.Text = Label29.Text - 1

            If Common.SetActiveTime = True Then
                Dim UpdateTime As String = Common.ProcessSetActiveTime()
                Label27.Text = UpdateTime
            End If

        End If

    End Sub
End Class
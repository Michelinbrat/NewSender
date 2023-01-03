Module Dev1

    Public CommandsArray(1) As String
    Public Pause As Boolean = False
    Public CommandCounter As Long
    Public Const GoHome As String = "G0 X0 Y0 F10000"
    Public Timertick As Integer
    Public Responses() As String


    Public Enum MessageType
        Incoming = 0
        Outgoing = 1
        SysMsg = 2
    End Enum

        Public Function CheckSum(ByVal indata As String) As Byte
        Dim i As Long
        CheckSum = 0
        For i = 1 To Len(indata)
            CheckSum = CheckSum Xor Asc(indata(i - 1))
        Next
        Return CheckSum
    End Function
    Public Function ChangePowerFeed(instring As String, SetPower As Int32, SetFeed As Int32) As String
        'instring = "G01 X662.724 Y340.62 S44 F520 P40 L60000 B1 D0"
        MainForm.ProgressBar1.Value = 50
        'Dim CorrectedCommand As String
        Dim CurrentPower, CurrentFeed As String
        Dim SepPos As Int32
        Dim Fpos, SPos As Int32

        SPos = instring.IndexOf("S")
        SepPos = instring.IndexOf(" ", SPos)
        CurrentPower = instring.Substring(SPos + 1, SepPos - SPos)


        Fpos = instring.IndexOf("F")
        SepPos = instring.IndexOf(" ", Fpos)
        CurrentFeed = instring.Substring(Fpos + 1, SepPos - Fpos)

        Dim CorrectedCommand As String = instring.Replace("S" & CurrentPower, "S" & SetPower & " ")

        CorrectedCommand = CorrectedCommand.Replace("F" & CurrentFeed, "F" & SetFeed & " ")

        'MsgBox("Power = " & NewPower)
        'MsgBox("Feed = " & CurrentFeed)

        MsgBox(CorrectedCommand)
        Return CorrectedCommand
    End Function

        Public Function SetOutString(ByVal N As Long, ByVal GcodeS As String) As String
        Dim i As Long '= 1
        Dim str As String = Nothing
        For i = 0 To Len(GcodeS) - 1
            If GcodeS(i) = ";" Or GcodeS(i) = vbCrLf Then Exit For Else str += GcodeS(i)
        Next i
        SetOutString = "N" & N & " " & str & "*" & CheckSum("N" & N & " " & str)
        Return SetOutString
    End Function

    Public Function SendCommandWithAnswer(N As Long, Command As String) As String
        Dim answ As String
        Dim NString As String
        NString = SetOutString(N, Command)

        MainForm.SerialPort1.WriteLine(NString)
            Display(NString, MessageType.Outgoing)

        If MainForm.SerialPort1.BytesToRead > 0 Then
            answ = MainForm.SerialPort1.ReadLine

            Display(answ, MessageType.Incoming) 'Command & " -> " & 
        Else answ = "No data to display"
        End If
        Return answ
    End Function

    Public Sub Display(ByVal instring As String, msgtype As MessageType)
        If instring Is Nothing Then Exit Sub
        If msgtype = MessageType.Incoming Then MainForm.rtbDisplay.SelectionColor = Color.Green
        If msgtype = MessageType.Outgoing Then MainForm.rtbDisplay.SelectionColor = Color.Blue
        If msgtype = MessageType.SysMsg Then MainForm.rtbDisplay.SelectionColor = Color.Chocolate
        instring += vbCrLf

        With MainForm.rtbDisplay
            .AppendText(instring)
            .ScrollToCaret()
        End With
        Console.WriteLine(instring)
    End Sub
    Public Sub MakeCommandsArray()
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\PIP\!!!Резать\Виктория.g")
        Dim stringReader As String
        Dim Nstrings As Integer = 1

        Do

            stringReader = fileReader.ReadLine()
            If Left(stringReader, 1) <> ";" Then
                CommandsArray(Nstrings) = stringReader
                Nstrings += 1
            End If
            ReDim Preserve CommandsArray(Nstrings)
        Loop Until stringReader = Nothing
        MsgBox(Nstrings)
        ' MsgBox("The first line of the file is " & stringReader)
    End Sub
    Public Sub SendCommands()
        SendCommandWithAnswer(1, "M110 N" & CommandCounter)
        CommandCounter += 1
        Dim n As ULong
        'Dim FormattedAnswer As String

        Dim answer, tempansw As String
        Try
            Do
                If Pause = False Then
                    'For n = 1 To UBound(CommandsArray)
                    Display(CommandCounter, 2)
                    MainForm.Label1.Text = CommandCounter
                    answer = SendCommandWithAnswer(CommandCounter, CommandsArray(n))

                    If answer = "ok" Then n += 1 : CommandCounter += 1

                    If answer.Contains("Error") Then
                        'tempansw = MainForm.SerialPort1.ReadLine 'Reading Error line
                        tempansw = MainForm.SerialPort1.ReadLine 'Reading Resend: 
                        Display(tempansw, 0)
                        Int64.TryParse(answer.Substring(answer.LastIndexOf(":") + 1), CommandCounter)
                        Display(CommandCounter, 0)
                        tempansw = MainForm.SerialPort1.ReadLine 'Reading ok
                        Display(tempansw, 0)
                        CommandCounter += 1

                    End If

                End If
                    Loop Until n = UBound(CommandsArray) 'Or answer = "wait"
                    ' Next n


                    Catch TimeoutException As Exception
        End Try

    End Sub
    Function Send()

    End Function
    Function AnswerType(ByVal instr As String) As String ' Выделяем тип ответа для корректировки номера строки или повторной отправки строки на устройство
        If instr = "ok" Then Return instr
        If instr.Contains("Resend") Or instr.Contains("rs") Then
            Dim ValStr As String = instr.Substring(instr.LastIndexOf(":") + 1)
            Return "R;" & ValStr
        End If
        If instr.Contains("Error:Line Number") Then
            Dim ValStr As String = instr.Substring(instr.LastIndexOf(":") + 1)
            Return "L;" & ValStr
        End If
        If instr.Contains("echo:busy: processing") Then Return "B"

        Return ""
    End Function
End Module

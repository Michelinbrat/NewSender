Imports System.IO.Ports
Imports System.Text

Module Comport
    Public OpenPortName As String
    Public OpenPortBaudrate As String
    Public ComportReader As System.IO.Stream
    Public Sub PortSetup(name As String, baudrate As String)
        With MainForm.SerialPort1
            .BaudRate = baudrate
            .PortName = name
            .DtrEnable = True
            .RtsEnable = True
            .Parity = Parity.None
            .DataBits = 8
            .StopBits = 1
            .ReadTimeout = 1000
            .WriteTimeout = 1000
            .ReadBufferSize = 1024
            .WriteBufferSize = 1024
            .Handshake = Handshake.XOnXOff
        End With
        'ComportReader = MainForm.SerialPort1.BaseStream
    End Sub

    Public Sub PortsList()
        For Each portName In My.Computer.Ports.SerialPortNames
            MainForm.cbPortsList.Items.Add(portName)
        Next
    End Sub
    Public Sub Connect()
        Dim buffer As New StringBuilder
        'MainForm.SerialPort1.Open()
        Dim line As String

        Do
            line = MainForm.SerialPort1.ReadLine()
            If line Is Nothing Then
                Exit Do
            Else
                buffer.AppendLine(line)
                MainForm.rtbDisplay.AppendText(line & vbCrLf)
            End If
        Loop Until line Is Nothing
        ' MainForm.SerialPort1.Close()
    End Sub
    Public Sub Connect2()

        ' ComportReader.BeginRead(128, 34, 66)
        'MainForm.SerialPort1.BaseStream

    End Sub


    Function RecieveSerialData() As String
        ' Receive strings from a serial port.
        Dim returnStr As String = ""

        'Dim com1 As IO.Ports.SerialPort = Nothing
        Try
            'com1 = My.Computer.Ports.OpenSerialPort("COM5")
            'MainForm.SerialPort1.Open()
            'com1.ReadTimeout = 100
            Do
                Dim Incoming As String = MainForm.SerialPort1.ReadLine()

                If Incoming Is Nothing Then
                    Display(" empty", 1)
                    Exit Do
                Else
                    returnStr = Incoming & vbCrLf
                    Display(returnStr, 1)
                End If
            Loop
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            ' If MainForm.SerialPort1.IsOpen Then MainForm.SerialPort1.Close()
        End Try

        Return returnStr
    End Function
    Public Sub Readport()
        Dim answer As String
        Try
            Do
                answer = MainForm.SerialPort1.ReadLine()
                Display(answer, 0)
            Loop Until answer = Nothing
        Catch TimeoutException As Exception
            Display("Timeout", 0)


        End Try
    End Sub
End Module

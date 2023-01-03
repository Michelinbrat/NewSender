Imports System.Reflection
Public Class MainForm
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        SerialPort1.Close()
    End Sub
    Private AutoConnect As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChangePowerFeed("G01 X662.724 Y340.62 S55 F420 P40 L60000 B1 D0", 32, 800)
    End Sub

    Private Sub PowerBar_Scroll(sender As Object, e As EventArgs)
        tbPower.Text = CStr(PowerBar.Value)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim assem As Assembly = GetType(MainForm).Assembly
        Dim assemName As AssemblyName = assem.GetName()
        Dim ver As Version = assemName.Version
        Text = "NewSender " & ver.ToString

        PortsList()

        cbPortsList.Text = My.Settings.LastPort
        cbBauds.Text = My.Settings.LastBaud
        OpenPortName = cbPortsList.Text
        OpenPortBaudrate = cbBauds.Text
        BtnConnect.Text = "Соединить"
        PortSetup(OpenPortName, OpenPortBaudrate)


    End Sub

    Private Sub BtnConnect_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub CbPortsList_SelectedIndexChanged(sender As Object, e As EventArgs)
        OpenPortName = cbPortsList.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        SerialPort1.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Readport()
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        SendCommandWithAnswer(CommandCounter, TextBox2.Text)
        CommandCounter += 1
        Label1.Text = CommandCounter
    End Sub

    Private Sub BtnTestReader_Click(sender As Object, e As EventArgs) Handles BtnTestReader.Click
        MakeCommandsArray()
        SendCommands()
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        If Pause = True Then
            Pause = False
        Else
            Pause = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timertick += 1
    End Sub




    Private Sub StartConnect()
        My.Settings.LastPort = cbPortsList.Text
        My.Settings.LastBaud = cbBauds.Text
        OpenPortName = cbPortsList.Text
        OpenPortBaudrate = cbBauds.Text


        If SerialPort1.IsOpen = True Then
            SerialPort1.DiscardInBuffer()
            SerialPort1.DiscardOutBuffer()

            SerialPort1.Close()
            BtnConnect.Text = "Соединить"
            Display("Порт " & OpenPortName & " закрыт", 2)
            'Display(SerialPort1.IsOpen, 1)
            Exit Sub
        End If
        If SerialPort1.IsOpen = False Then 'Если порт закрыт
            PortSetup(OpenPortName, OpenPortBaudrate)
            SerialPort1.Open()
            SerialPort1.DiscardInBuffer()
            SerialPort1.DiscardOutBuffer()
            BtnConnect.Text = "Отсоединить"
            Display("Порт " & OpenPortName & " открыт", 2)
            'Connect2()
        End If

        Display(SerialPort1.IsOpen, 1)
        ToolStripStatusLabel1.Text = "Serial port opened"
        If SerialPort1.IsOpen Then

            Readport()

        End If
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        StartConnect()
    End Sub
End Class

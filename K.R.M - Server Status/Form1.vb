Imports System.Net.Sockets

Public Class Form1

    Dim aIP As New Dictionary(Of String, String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aIP.Add("Eski 1. Jadde", "95.173.175.7:27015")
        aIP.Add("Yeni Cihangir Jaddesi", "31.210.119.69:4000")
        ' aIP.Add("Video Server", "205.209.136.29:60000")
        '  aIP.Add("Test Server", "31.210.119.67:4000")
    End Sub

    Public Function CheckServer(ByVal ip As String)
        Dim TcpClient As New System.Net.Sockets.TcpClient()
        Dim ipport As String() = ip.Split(":")

        Try
            TcpClient.Connect(ipport(0), ipport(1))
        Catch ex As Exception
            CheckServer = False
        End Try

        If TcpClient.Connected Then
            Dim networkStream As NetworkStream = TcpClient.GetStream()
            Dim bytes(TcpClient.ReceiveBufferSize) As Byte
            If networkStream.CanRead = True Then
                Try
                    networkStream.Read(bytes, 0, (1))
                    CheckServer = True
                Catch ex As Exception
                    CheckServer = False
                End Try
            Else
                CheckServer = False
            End If
        Else
            CheckServer = False
        End If
        TcpClient.Close()
    End Function

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        On Error Resume Next
        If btnStart.Text() = "&Baslat" Then
            btnStart.Text() = "&Durdur"
            kontrol.Enabled() = True
            Dim Item As ListViewItem
            For Each Item In lstServer.CheckedItems()
                If CheckServer(aIP(Item.Text())) Then
                    Item.SubItems(1).Text() = "Online"
                    Item.UseItemStyleForSubItems = False
                    Item.SubItems(1).BackColor() = Color.WhiteSmoke
                    Item.SubItems(1).ForeColor() = Color.Green()
                Else
                    Item.SubItems(1).Text() = "Offline"
                    Item.UseItemStyleForSubItems = False
                    Item.SubItems(1).BackColor() = Color.WhiteSmoke
                    Item.SubItems(1).ForeColor() = Color.Red()
                End If
                Item.SubItems(2).Text() = TimeOfDay
            Next
        Else
            btnStart.Text() = "&Baslat"
            kontrol.Enabled() = False
        End If
    End Sub

    Private Sub kontrol_Tick(sender As Object, e As EventArgs) Handles kontrol.Tick
        Dim Item As ListViewItem
        Dim Login As Boolean
        Dim Played As Integer
        Dim Status As Boolean

        kontrol.Enabled() = False
        Login = CheckServer(aIP("Eski 1. Jadde"))
        Played = 0
        For Each Item In lstServer.CheckedItems()
            Status = CheckServer(aIP(Item.Text()))
            If Status Then
                If Item.SubItems(1).Text() = "Offline" Then
                    If Item.Text() = "Eski 1. Jadde" Then
                        If lstServer.CheckedItems().Count = 1 And Played <> 1 Then
                            Played = 2
                        End If
                    Else
                        If Login And Played <> 1 Then
                            Played = 2
                        End If
                    End If

                    Item.SubItems(1).Text() = "Online"
                    Item.UseItemStyleForSubItems = False
                    Item.SubItems(1).BackColor() = Color.WhiteSmoke
                    Item.SubItems(1).ForeColor() = Color.Green()
                End If
            Else
                If Item.SubItems(1).Text() = "Online" Then
                    If Item.Text() = "Eski 1. Jadde" Then
                        Played = 1
                    Else
                        If Played = 0 Then
                            Played = 3
                        End If
                    End If

                    Item.SubItems(1).Text() = "Offline"
                    Item.UseItemStyleForSubItems = False
                    Item.SubItems(1).BackColor() = Color.WhiteSmoke
                    Item.SubItems(1).ForeColor() = Color.Red()
                End If
            End If
            If Played = 1 Or Played = 3 Then
                Playsound(False)
            Else
                If Played = 2 Then
                    Playsound(True)
                End If
            End If

            Item.SubItems(2).Text() = TimeOfDay
        Next
        kontrol.Enabled() = True
    End Sub

    Private Sub Playsound(ByVal online As Boolean)
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class

Imports System.Net.NetworkInformation

Module Module1
    Sub Main()
        Dim interfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()

        For Each ni As NetworkInterface In interfaces
            ' Filtra solo interfaces que estén activas y sean Ethernet o Wi-Fi
            If ni.OperationalStatus = OperationalStatus.Up AndAlso
               (ni.NetworkInterfaceType = NetworkInterfaceType.Ethernet OrElse
                ni.NetworkInterfaceType = NetworkInterfaceType.Wireless80211) Then

                Dim macAddress As String = BitConverter.ToString(ni.GetPhysicalAddress().GetAddressBytes())
                Console.WriteLine("MAC: " & macAddress)
            End If
        Next

        Console.ReadLine()
    End Sub
End Module
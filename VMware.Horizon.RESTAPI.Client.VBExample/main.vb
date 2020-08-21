Module main

    Sub Main()
        Dim Client = New HorizonRESTClient("https://connectionserver.domain.local/rest")
        Client.Logon("username", "password", "domain")
        Dim farms = Client.Inventory.ListFarms()

    End Sub

End Module

Module main

    Sub Main()
        Dim Client = New HorizonRESTClient("https://ConnectionServer.domain.local/rest")
        Client.Logon("username", "password", "domain")

        Dim farms = Client.Monitoring.ListFarmMonitors()

        'List all rdsh servers health
        Dim RDSHServers = Client.Monitoring.ListRDSServerMonitors()

        'list all connection servers health
        Dim ConnectionServers = Client.Monitoring.ListConnectionServerMonitors()


        ' demo the ability to refresh
        Client.TryRefreshSession()

        Dim pools = Client.Inventory.ListDesktopPools()

        ' get information about the first pool
        Dim pool = Client.Inventory.GetDesktopPool(pools(0).Id)

        'pull active sessions
        Dim sessions = Client.Inventory.ListSessionInfo()

        ' log out when complete
        Client.LogOut()
    End Sub

End Module

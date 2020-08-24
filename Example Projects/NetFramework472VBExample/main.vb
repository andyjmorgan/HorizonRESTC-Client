Imports VMware.Horizon.RESTAPI.Client

Module main

    Sub Main()

        Dim Client = New HorizonRESTClient("https://ConnectionServer.Domain.local/rest")
        Client.Logon("UserName", "Password", "Domain")

        ' list all farms health
        Dim farms = Client.Monitoring.ListFarmMonitors()
        Console.WriteLine("Farms: {0}", farms.Count)

        ' list all rdsh servers health
        Dim RDSHServers = Client.Monitoring.ListRDSServerMonitors()
        Console.WriteLine("RDSHServers: {0}", RDSHServers.Count)

        'list all connection servers health
        Dim ConnectionServers = Client.Monitoring.ListConnectionServerMonitors()
        Console.WriteLine("ConnectionServers: {0}", ConnectionServers.Count)

        ' demo the ability to refresh
        Client.RefreshToken()

        Dim Pools = Client.Inventory.ListDesktopPools()
        Console.WriteLine("pools: {0}", Pools.Count)

        ' get information about the first pool
        Dim Pool = Client.Inventory.GetDesktopPool(Pools(0).Id)
        Console.WriteLine("First Pool: {0}", Pool.DisplayName)

        ' pull active sessions
        Dim Sessions = Client.Inventory.ListSessionInfo()
        Console.WriteLine("sessions: {0}", Sessions.Count)

        ' log out when complete
        Client.LogOut()
        Console.ReadLine()
    End Sub

End Module

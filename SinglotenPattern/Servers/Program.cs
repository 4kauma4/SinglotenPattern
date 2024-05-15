using System;

class Program
{
    static void Main()
    {

        ServersSingl servers = ServersSingl.Instance;


        Console.WriteLine(servers.AddServer("http://example.com"));//true
        Console.WriteLine(servers.AddServer("https://example.com"));// true
        Console.WriteLine(servers.AddServer("ftp://example.com"));// false
        Console.WriteLine(servers.AddServer("https://example.com"));// дупликат - false


        Console.WriteLine("HTTP servers:");
        foreach (var server in servers.GetHttpServers())
        {
            Console.WriteLine(server);
        }
        
        Console.WriteLine("HTTPS servers:");
        foreach (var server in servers.GetHttpsServers())
        {
            Console.WriteLine(server);
        }
    }
}

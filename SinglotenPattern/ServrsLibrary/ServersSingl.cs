using System;
using System.Collections.Generic;
using System.Linq;

public class ServersSingl
{
    private HashSet<string> servers = new HashSet<string>();
    private static readonly Lazy<ServersSingl> lazy = new Lazy<ServersSingl>(() => new ServersSingl());

    public static ServersSingl Instance => lazy.Value;

    private ServersSingl() { } 


    public bool AddServer(string serverUrl) // проверка на http or https
    {

        if (string.IsNullOrWhiteSpace(serverUrl) ||
            (!serverUrl.StartsWith("http://") && !serverUrl.StartsWith("https://")))
        {
            return false;
        }


        return servers.Add(serverUrl); // возврат bool pyfxtybz
    }


    public List<string> GetHttpServers() // url серверов с http
    {
        return servers.Where(url => url.StartsWith("http://")).ToList();
    }


    public List<string> GetHttpsServers() // url серверов с https
    {
        return servers.Where(url => url.StartsWith("https://")).ToList();
    }
}

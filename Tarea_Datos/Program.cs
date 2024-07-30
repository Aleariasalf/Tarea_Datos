using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Timers;
using System.Threading;

namespace Tarea_Datos 
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread serverThread = new Thread(new ThreadStart(StartServer));
            serverThread.Start();

            Thread.Sleep(1000);

            Client client = new Client();
            client.Start_client();
        }
        
        static void StartServer() 
        {
            Server server = new Server();
            server.Start_server();
        }
        
    }
}

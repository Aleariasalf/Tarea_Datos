using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Tarea_Datos
{
    public class Client
    {
        public void Start_client()
        {
            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("192.168.0.100"), 5550);

            listen.Connect(connect);

            byte[] enviar_info = new byte[100];
            string data;
            Console.WriteLine("Ingrese su mensaje");

            data = Console.ReadLine();

            enviar_info = Encoding.Default.GetBytes(data);

            listen.Send(enviar_info);

            Console.ReadKey();

        }
    }
}
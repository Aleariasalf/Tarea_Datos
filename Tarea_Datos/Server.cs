using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Tarea_Datos
{
    public class Server
    {
        public void Start_server() 
        {
            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket conexion;
            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("192.168.0.100"), 5550);

            listen.Bind(connect);
            listen.Listen(10);


            conexion = listen.Accept();
            Console.WriteLine("Conexion establecida correctamente");

            byte[] recibir_info = new byte[100];
            string data = "";
            int array_size = 0;

            array_size = conexion.Receive(recibir_info, 0, recibir_info.Length, 0);
            Array.Resize(ref recibir_info, array_size);
            data = Encoding.Default.GetString(recibir_info);

            Console.WriteLine("Mensaje recibido: {0}", data);
            Console.ReadKey();



        }

    }
    
}

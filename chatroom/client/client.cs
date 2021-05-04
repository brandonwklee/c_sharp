using System;
using System.Net;
using System.Net.Sockets;

namespace client
{ 
    class client { 

        public static void runClient() { 
            Console.WriteLine("ip address:");
            String address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("port address:");
            int port = Int32.Parse(Console.ReadLine());
            try { 
                TcpClient socket = new TcpClient(address, port);
                Console.WriteLine("Server found!");
                readThread read = new readThread(socket, this);
                read.run();
            }
            catch {

            }
        }

        public static void Main(String[] args) { 
            runClient();
        }
    }
}
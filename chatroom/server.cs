using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace chatroom
{ 
    public class server
    {
       public int port {get; set;} 

       public server(int port) 
       {
           this.port = port;
       }

       //HashSet<clientHandler> allClientHandlers = new HashSet<clientHandler>();
       HashSet<String> allClientNames = new HashSet<String>();
       
        public void run() { 
            Console.WriteLine("Press Enter to shut the server down");
            Console.WriteLine();
            Console.WriteLine("Searching for connections...");
            while (true) { 
                try { 
                    IPAddress address = IPAddress.Parse("127.0.0.1");
                    TcpListener server = new TcpListener(address, port);
                    while (true) {
                        TcpClient socket = server.AcceptTcpClient();
                        var clientHandler = new clientHandler(socket, this);
                        allClientHandlers.Add(clientHandler);
                        clientHandler.run();
                    }
                }
                catch (Exception e) { 
                    Console.WriteLine("Error occured: {0}", e.ToString());
                }
                Console.ReadLine(); 
                break;
            }
         }
       public static void Main(String[] args) { 
           var chatroomServer = new server(8888);
           chatroomServer.run();
        }
    }
}
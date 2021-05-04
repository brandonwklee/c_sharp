using System;
using System.Net;
using System.Net.Sockets;

namespace client
{ 
    class readThread { 
        public TcpClient socket {get; set;}
        public client client {get; set;}

        public readThread(TcpClient socket, client client) { 
            this.socket = socket;
            this.client = client;
            try { 
                NetworkStream stream = socket.GetStream();
            }
            catch (Exception e) { 
                Console.WriteLine(e);
            }
        }

        public void run() { 
            while (true) { 
                try { 
                    
                }
                catch { 

                }
            }
        }
    }
}
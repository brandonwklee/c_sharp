using System;

namespace chatroom
{ 
    class clientHandler { 
        public static int port { get; set;}
        public static server server { get; set;}

        public clientHandler(int port, server server) { 
            this.port = port;
            this.server = server;
        }

        public static void run() {
            try { 
                Console.WriteLine("Connection found!");
                
            }
            catch { 
                
            }
        }
    }
}
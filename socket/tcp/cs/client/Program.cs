using System.Net;
using System.Net.Sockets;

Socket s = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
s.Connect("127.0.0.1", 12345);

StreamWriter wr = new StreamWriter(new NetworkStream(s));
wr.WriteLine("Hello from TCP C# client");

wr.Flush();
s.Close();

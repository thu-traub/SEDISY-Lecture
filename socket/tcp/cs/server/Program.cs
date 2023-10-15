using System.Collections;
using System.Net;
using System.Net.Sockets;

Socket s = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
IPAddress adr =  IPAddress.Any;
IPEndPoint p = new(adr, 12345);

s.Bind(p);
s.Listen(5);

System.Console.WriteLine("TCP C# server: waiting for connections");
Socket cl = s.Accept();

StreamReader rd = new StreamReader(new NetworkStream(cl));
string? data = rd.ReadLine();
System.Console.WriteLine(data);
rd.Close();
s.Close();

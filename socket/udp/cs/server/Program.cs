using System.Net;
using System.Net.Sockets;
using System.Text;

Socket s = new(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
IPAddress adr =  IPAddress.Any;
IPEndPoint p = new(adr, 12345);
s.Bind(p);

byte[]data = new byte[200];

System.Console.WriteLine("UDP C# server: waiting for packets");
int n = s.Receive(data);
String l = Encoding.UTF8.GetString(data, 0, n);
System.Console.WriteLine(l);

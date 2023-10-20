using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

internal class Program
{
    private static void Main(string[] args)
    {
        Stopwatch w = new();
        w.Start();

        List<Thread> tl = new();
        for (int i = 0; i < 10; i++)
        {
            Thread t = new(()=>{

                Socket s = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new(IPAddress.Parse("127.0.0.1"), 9000);

                //System.Console.WriteLine("connect");
                s.Connect(ep);
                //System.Console.WriteLine("connection established");
                using (NetworkStream ns = new(s))
                using (StreamReader rd = new(ns))
                {
                    string? time = rd.ReadLine();
                    System.Console.WriteLine(time);
                }

            });
            t.Start();
            tl.Add(t);
        }

        tl.ForEach(t=>t.Join());
        w.Stop();
        System.Console.WriteLine("Elapsed time = "+w.ElapsedMilliseconds);
    }
}
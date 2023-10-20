using System.Net;
using System.Net.Sockets;

internal class Program
{
    private static void HandleClient(Socket cl)
    {
        using (NetworkStream ns = new(cl))
        using (StreamReader rd = new(ns))
        using (StreamWriter wr = new(ns)) {
            string time = System.DateTime.Now.ToString();
            //Thread.Sleep(2000);
            wr.WriteLine(time);
            wr.Flush();
        }
        cl.Close();        
    }
    private static void Main(string[] args)
    {
        Socket s = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint ep = new(0, 9000);
        s.Bind(ep);
        s.Listen(10);

         try
        {
            while (true) {
                Socket cl = s.Accept();
                HandleClient(cl);
            }
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}
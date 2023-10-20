using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata;

internal class Program
{
    private static async void HandleClientAsync(Socket cl)
    {
        using (NetworkStream ns = new(cl))
        using (StreamReader rd = new(ns))
        using (StreamWriter wr = new(ns)) {
            string time = System.DateTime.Now.ToString();
            //Thread.Sleep(2000);
            //await Task.Delay(2000);
            await wr.WriteLineAsync(time);
            await wr.FlushAsync();
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
                HandleClientAsync(cl);
            }
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}
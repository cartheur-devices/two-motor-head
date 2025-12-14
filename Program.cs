using System;
using System.Threading.Tasks;

namespace Head.Controller
{
    public class Program
    {
        async static Task Main()
        {
            Console.WriteLine("Hello, World!");
            await Task.CompletedTask;
        }
    }
}

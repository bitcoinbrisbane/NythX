using System;
using NythX.Client;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NythX.Client.Auth client = new Auth();
            var response = client.Login("0x0000000000000000000000000000000000000000", "").Result;
            Console.WriteLine(response);
        }
    }
}
using System;
using Microsoft.Owin.Hosting;
using Owin;

namespace Configurados
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Art.PrintLogo();
            Console.ResetColor();

            using (WebApp.Start("http://+:9999", app => app.UseNancy()))
            {
                Console.WriteLine("Ready");
                Console.ReadLine();
            }
        }
    }
}

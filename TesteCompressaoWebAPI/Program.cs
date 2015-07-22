using System;
using Microsoft.Owin.Hosting;

namespace TesteCompressaoWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:55042/"))
            {
                Console.WriteLine(
                    "Serviço de consulta de produtos em execução...");
                Console.WriteLine(
                    "Pressione qualquer tecla para encerrar este processo...");

                Console.ReadKey();
            }
        }
    }
}
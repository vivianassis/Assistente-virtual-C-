using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Como é seu nome?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Oi, {name}, como você tá hoje? Espero que bem! {Environment.NewLine}Eu sou Lila, sua assistente virtual! {Environment.NewLine}{Environment.NewLine}Hoje é dia {currentDate:d}. São {currentDate:t}h! {Environment.NewLine}Não se atrase, ok?{Environment.NewLine}{Environment.NewLine}Tenha um ótimo dia! :D");

Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);
        }
    }
}

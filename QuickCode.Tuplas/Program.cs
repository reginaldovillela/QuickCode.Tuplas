using System;

namespace QuickCode.Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuplas = new ExemploTuplas();

            // Exemplo Um
            tuplas.ExemploUm();

            // Exemplo Dois
            tuplas.ExemploDois();

            // Exemplo Três
            tuplas.ExemploTres();

            // Exemplo Quatro
            tuplas.ExemploQuatro();

            // Exemplo Cinco
            tuplas.ExemploCinco();

            // Exemplo Seis
            var carroSeis = tuplas.ExemploSeis();
            Console.WriteLine($"Marca: {carroSeis.Item1}");
            Console.WriteLine($"Modelo: {carroSeis.Item2}");

            // Exemplo Sete
            var carroSete = tuplas.ExemploSete();
            Console.WriteLine($"Marca: {carroSete.Marca}");
            Console.WriteLine($"Modelo: {carroSete.Modelo}");

            var (Marca, Modelo) = tuplas.ExemploSete();
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");

            Console.ReadKey();
        }
    }
}

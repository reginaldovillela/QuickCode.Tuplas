using System;

namespace QuickCode.Tuplas
{
    public class ExemploTuplas
    {
        public void ExemploUm()
        {
            var carro = ("Porsche", "911 GT3 RS");

            Console.WriteLine($"Marca: {carro.Item1}");
            Console.WriteLine($"Modelo: {carro.Item2}");
        }

        public void ExemploDois()
        {
            var carro = (Marca: "Ferrari", Modelo: "458 Italia");

            Console.WriteLine($"Marca: {carro.Marca}");
            Console.WriteLine($"Modelo: {carro.Modelo}");
        }

        public void ExemploTres()
        {
            (string, string) carro = ("Audi", "R8 Coupé V10");

            Console.WriteLine($"Marca: {carro.Item1}");
            Console.WriteLine($"Modelo: {carro.Item2}");
        }

        public void ExemploQuatro()
        {
            (string Marca, string Modelo) carro = ("Mercedes-Benz", "SLS AMG");

            Console.WriteLine($"Marca: {carro.Marca}");
            Console.WriteLine($"Modelo: {carro.Modelo}");
        }

        public void ExemploCinco()
        {
            (string Marca, string Modelo) = ("Bugatti", "Veyron");

            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }

        public (string, string) ExemploSeis()
        {
            return ("Pagani", "Huayra");
        }

        public (string Marca, string Modelo) ExemploSete()
        {
            return ("Koenigsegg", "Agera S");
        }
    }
}

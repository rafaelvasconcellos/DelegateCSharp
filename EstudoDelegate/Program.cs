using System;

namespace EstudoDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();
            calculadora.Executar();


            Console.ReadKey();
        }
    }

    public class Calculadora
    {
        delegate double Multiplicador(double valor);
        delegate double MultiplicadorCustomizado(double valor, int multiplicador);

        public double Duplicar(double valor)
        {
            return valor * 2;
        }

        public double Triplicar(double valor)
        {
            return valor * 3;
        }

        public void Executar()
        {
            Multiplicador multiplicador = Duplicar;
            Console.WriteLine(multiplicador(7.5));

            var quadrado = AoQuadrado(10);
            Console.WriteLine(quadrado);

            var quintuplo = MultiplicaXPorY(10, 5);
            Console.WriteLine(quintuplo);
        }

        Multiplicador AoQuadrado = delegate (double input)
        {
            return input * input;
        };

        MultiplicadorCustomizado MultiplicaXPorY = (double valor, int multiplicador) =>
        {
           return valor * multiplicador;
        };
    }
}

using System;

namespace ListaPOOex12
{

    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triang;

            triang = new Triangulo();

            Console.Write("Informe o 1° valor: ");
            triang.setValor1(double.Parse(Console.ReadLine()));

            Console.Write("Informe o 2° valor: ");
            triang.setValor2(double.Parse(Console.ReadLine()));

            Console.Write("Informe o 3° valor: ");
            triang.setValor3(double.Parse(Console.ReadLine()));

            triang.verificarTring();

            
        }
    }
}

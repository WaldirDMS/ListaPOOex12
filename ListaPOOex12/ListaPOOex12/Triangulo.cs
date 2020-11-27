using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPOOex12
{
    class Triangulo
    {
        private double valor1;
        private double valor2;
        private double valor3;

        public void setValor1(double p)
        {
            valor1 = p;
        }

        public void setValor2(double p)
        {
            valor2 = p;
        }

        public void setValor3(double p)
        {
            valor3 = p;
        }

        public void verificarTring()
        {
            if (valor1 + valor2 > valor3 || valor1 + valor3 > valor2 || valor2 + valor3 > valor1)
            {
                Console.WriteLine("É um triangulo");
            }

            else
            {
                Console.WriteLine("Não é um triangulo");
            }

            if (valor1 == valor2 && valor2 == valor3)
            {
                Console.WriteLine("É um triangulo equilatero");
            }

            else
            {
                if (valor1 == valor2 || valor1 == valor3 || valor2 == valor3)
                {
                    Console.WriteLine("É um triangulo isoceles");
                }

                else
                {
                    Console.WriteLine("É um triangulo escaleno");
                }
            }






        }
    }
}

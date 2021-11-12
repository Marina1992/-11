using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Разработать структуру для решения линейного уравнения 0=kx+b. 
             * Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. Для решения уравнения предусмотреть метод Root. 
             * Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.  */
            Equation equation1 = new Equation { k = 1, b = 2};


            equation1.k = 1; 
            equation1.b = 2;
            
            equation1.Root();
            Console.ReadKey();
        }

        struct Equation
        {

            public double k;
            public double b;
           

            public void Root()
            {
                double x = -b / k;
                Console.WriteLine("Решение линейного уравнения 0=kx+b с заданными значениями k и b ,  x имеет знаение {0}", x);
            }


        }
    }
}

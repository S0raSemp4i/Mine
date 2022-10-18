using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class Logicos
    {
        public Logicos()
        {
            Console.WriteLine("Bienvenutos a mi Programa xD, solo queria usar un constructor");
        }

        public int Age()
        {
            int n1 = 2022;
            Console.WriteLine("Escribe tu Año de Nacimiento:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int Edad = n1 - n2;

            Console.WriteLine($"Tu edad es: {Edad}");

            Console.ReadKey();

            return Edad;
        }

        public int Prim()
        {
            int i, par = 0;

            for (i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    par++;
                }
            }

            Console.ReadKey();

            return par;
        }

        public int ImPar()
        {
            int i, impar = 0;
            for (i = 1; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                    impar++;
                }
            }

            Console.ReadKey();

            return impar;
        }
    }
}

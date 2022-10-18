using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {


        static void Main(string[] args)
        {
            Logicos logico = new Logicos();
            NoLogicos etrin = new NoLogicos();

            int opt;
            bool bandera = false;

            do
            {
            Console.WriteLine("***** EJERCICIOS *****");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Ejercicio 4");
            Console.WriteLine("5. Ejercicio 5");
            Console.WriteLine("6. Ejercicio 6");
            Console.WriteLine("7. Ejercicio 7");
            Console.WriteLine("8. Ejercicio 8");
            Console.WriteLine("9. Ejercicio 9");
            Console.WriteLine("10. Ejercicio 10");
            Console.WriteLine("11. Ejercicio 11");
            Console.WriteLine("12. Ejercicio 12");
            Console.WriteLine("13. Ejercicio 13");
            Console.WriteLine("14. Ejercicio 14");
            Console.WriteLine("15. Ejercicio 15");
            Console.WriteLine("16. Ejercicio 16");
            Console.Write("Elige cual ejercicio desea ejecutar: ");
            opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.Clear();
                        logico.Age();
                        break;
                    case 2:
                        Console.Clear();
                        logico.Prim();
                        break;
                    case 3:
                        Console.Clear();
                        logico.ImPar();
                        break;
                    case 4:
                        Console.Clear();
                        etrin.Carac();
                        break;
                    case 5:
                        Console.Clear();
                        etrin.Frase();
                        break;
                    case 6:
                        Console.Clear();
                        etrin.Malarga();
                        break;
                    case 7:
                        Console.Clear();
                        etrin.uplow();
                        break;
                    case 8:
                        Console.Clear();
                        etrin.many();
                        break;
                    case 9:
                        Console.Clear();
                        etrin.outspace();
                        break;
                    case 10:
                        Console.Clear();
                        etrin.space();
                        break;
                }

            } while (bandera != false);
        }
    }
}

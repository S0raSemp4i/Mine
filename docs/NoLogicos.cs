using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class NoLogicos
    {
        public NoLogicos()
        {
            Console.WriteLine("Solo queria usar otro constructor XD");
        }

        public void Carac()
        {
            string p1;
            Console.WriteLine("Escriba una Palabra: ");
            p1 = Console.ReadLine();

            Console.WriteLine("La palabra {0} tiene: {1}",p1, p1.Length);

            Console.ReadKey();
        }

        public void Frase()
        {
            string quote;
            char x;

            Console.WriteLine("Escribe una Frase: ");
            quote = Console.ReadLine();
            Console.WriteLine("Si quiere saber si esta frase lleva alguna letra pongala aqui: ");
            x = Convert.ToChar(Console.ReadLine());
            foreach (char letra in quote)
            {
                if(x == letra)
                {
                    Console.WriteLine("Esa letra si esta en la Frase");
                    break;
                }
                else
                {
                    Console.WriteLine("Esa Letra no esta en la Frase...");
                }
            }
            Console.ReadKey();
            
        }

        public void Malarga()
        {
            string Conlaletra;
            string Sinlaletra;
            Console.Write("Escribe una frase: ");
            Conlaletra = Console.ReadLine();
            Console.Write("Escriba la letra que desea sacar de la frase: ");
            Sinlaletra = Console.ReadLine();
            string a = Conlaletra.Replace(Sinlaletra, string.Empty);
            if (a != Sinlaletra)
            {
                Console.WriteLine("Esta letra no esta en la Frase!");
                Console.WriteLine("La Frase es: {0}", Conlaletra);
            }
            else
            {
                Console.WriteLine("Con la letra: {0}", Conlaletra);
                Console.WriteLine("Sin la letra: {0}", Sinlaletra);
            }




            Console.ReadKey();
        }

        public void uplow()
        {
            string full;
            string up;
            string low;

            Console.WriteLine("Escriba una frase: ");
            full = Console.ReadLine();

            up = full.ToUpper();
            low = full.ToLower();

            Console.WriteLine("En Mayuscula: {0}", up);
            Console.WriteLine("En Minuscula: {0}", low);


            Console.ReadKey();
        }

        public void many()
        {
            string diga;
            char c;
            int count = 0;
            Console.WriteLine("Escriba algo: ");
            diga = Console.ReadLine();
            Console.WriteLine("Escriba la letra que quiere saber cuantas veces se repite: ");
            c = Convert.ToChar(Console.ReadLine());
            foreach (char a in diga)
            {
                if (a == c)
                {
                    count++;
                }
            }
            Console.WriteLine("Se repite: {0}", count, "veces!");

            Console.ReadKey();
        }

        public void outspace()
        {

            string conEspacio;
            string conEspacio2;
            Console.Write("Escribe una frase: ");
            conEspacio = Console.ReadLine();
            Console.Write("Escribe otra frase con espacio al final, al inicio o en ambos lado: ");
            conEspacio2 = Console.ReadLine();

            Console.WriteLine("Antes: ");
            Console.WriteLine("Con espacios: {0}", conEspacio);
            Console.WriteLine("Con espacios: {0}", conEspacio2);

            Console.WriteLine("");

            Console.WriteLine("Despues");
            string a = conEspacio.Replace(" ", string.Empty);
            Console.WriteLine(a);
            Console.WriteLine(conEspacio2.Trim());


            Console.ReadKey();
        }

        public void space()
        {
            string algo;
            Console.Write("Escribe una frase: ");
            algo = Console.ReadLine();
            Console.WriteLine("");

            string[] alguito = algo.Split(' ');

            foreach(var pra in alguito)
            {

                Console.WriteLine(pra);
            }

            Console.ReadKey();
        }


    }
}

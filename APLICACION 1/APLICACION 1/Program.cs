using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dato = new char[15];
            char buscar;
            char[,] mat = new char[5, 15];
            dato[0] = 'a';





            for (int f = 0; f < 15; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.WriteLine("Ingrese nombre,apellido,correo,dirrecion y numero");

                    mat[c, f] = char.Parse(Console.ReadLine());


                }

                Console.WriteLine("-------------------------");

                for (int x = 0; x <= 14; x++) ;
                {
                    int x = 0;
                    Console.WriteLine(dato[x]);

                }

                Console.WriteLine("-------------------------");
                Console.Write("ingrese Contacto a buscar ");
                buscar = char.Parse(Console.ReadLine());

                for (int z = 0; z <= 14; z++)
                {
                    if (dato[z] == buscar)
                    {
                        Console.Write("dato" + buscar + "encontrado");
                    }


                }


                Console.ReadKey();
            }

        }
    }
}
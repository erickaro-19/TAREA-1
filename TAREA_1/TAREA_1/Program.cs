using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_1
{ 
class Program
{
    static void Main(string[] args)
    {
        char[] dato = new char[10];
        char buscar;


        //dato[0] = "a";

        for (int i = 0; i <= 9; i++)
        {
            Console.WriteLine("i: " + i);
            Console.Write("Ingrese una letra:");
            dato[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("-----------------");

        for (int x = 0; x < 9; x++)
        {
            Console.WriteLine(dato[x]);

        }
        Console.WriteLine("--------------------------");

        Console.Write("ingrese caracter a buscar:");
        buscar = char.Parse(Console.ReadLine());

        for (int z = 0; z <= 9; z++)
        {
            if (dato[z] == buscar)
            {
                Console.Write("dato" + buscar + " encontrado");
            }

            Console.ReadKey();

        }


    }

}
}
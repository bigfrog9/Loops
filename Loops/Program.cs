using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops");
            Console.WriteLine();

            int[] ammo = new int[8];
            ammo[0] = 10;
            ammo[1] = 4;
            ammo[2] = 16;
            ammo[3] = 2;
            ammo[4] = 90;
            ammo[5] = 110;
            ammo[6] = 95;
            ammo[7] = 80;


            int start = 0;
            int end = 7;
            int count = start;

            

            while (count <= end)
            {
                Console.WriteLine("Weapon: " + count +" Ammo: " + ammo[count] );
                count = count + 1;
            }

            Console.ReadKey(true);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] intarray = new int[3] {10, 20,30};
            //if the lenth of the array is not known ARRAYINT.LENGHT can be used.
            for (int i = 0; i < intarray.Length;i++)
            // for (int =0; i<=2; i++)
            {
                Console.WriteLine(intarray[i]);
            }
            Console.ReadLine();
            //fix this*/

        string[] namen = new string[4] { "mik", "bik", "vik", "cik" };
            for (int i=0; i<=4; i++)
            {
                Console.WriteLine(namen[i]);
            }
            Console.ReadLine();

        }
    }
}

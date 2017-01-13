using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class ReverseArray
    {
        private static int i;
        static void Main(string[] args)
        {
            /*Да се дефинира масив, като стойностите да се прочитат от командния ред.
             * След това тези стойности в масива да се изведат в обратен ред*/
           int[] array = { 1, 2, 3, 4, 5 };
           int length = array.Length;// length = 5
           int[] reversed = new int[length];
            
                for (int index = 0; index < length; index++)
                    {
                    reversed[length - index - 1] = array[index];
                    }
            // Print the reversed array
                    for (int index = 0; index < length; index++)
                        {
                            Console.Write(reversed[index] + " ");
                        }
                    Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
     class PrintArray
    {
        public static void PrintElements(int[] intarr)      //Method or function
        {
            Console.WriteLine("Displaying integer Array Elements without Generic method");
            foreach(int element in intarr)                  //Printing each element in array 
            {
                Console.WriteLine(element);
            }
        }

        public static void PrintElements(double[] doublearr)        //Method overloading .......by changing datatype
        {
            Console.WriteLine("Displaying double Array Elements without Generic method");
            foreach (double element in doublearr)
            {
                Console.WriteLine(element);
            }
        }

        public static void PrintElements(char[] chararr)        //Method overloading .......by changing datatype
        {
            Console.WriteLine("Displaying charactor Array Elements without Generic method");
            foreach (char element in chararr)
            {
                Console.Write(element);
            }
        }
    }
}

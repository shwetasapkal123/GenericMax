using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
     class UsingGenericMethod
    {
        public static void PrintElements<T>(T[] intarr)     //Generic Method Syntax
        {
            Console.WriteLine("Displaying integer array using Generic Method");
            foreach(var element in intarr)          //var take any dataypes
            {
                Console.WriteLine(element);
            }
        }
    }
}

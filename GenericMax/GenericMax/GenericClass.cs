using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
     class GenericClass<T>
    {
        public T[] arr;

        public GenericClass(T[] arr)
        {
            this.arr = arr;
        }

        public void PrintElements()
        {
            Console.WriteLine("Displaying Array Elements Using Generic Class");
            foreach (T item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}

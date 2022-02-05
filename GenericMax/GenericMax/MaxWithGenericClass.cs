using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
     class MaxWithGenericClass<T> where T:IComparable
    {
        public T first, second, third;

        public MaxWithGenericClass(T first,T second,T third)                // Paramaterized Constructor
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public static T FindMaxValueoutOfThree(T first, T second, T third)
        {
            //result will be either 0 or 1 or -1
            //-1 for lesser value, 1 for greater value, 0 for equal value
            int res = first.CompareTo(second);
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("Either 2 or 3 numbers having same or equal value");
                return default;                                                                   //for string
            }
        }

        public void MaxTest()                                                                     //Method for constructor
        {
            //FindMaxValueoutOfThree(first, second, third);
            Console.WriteLine("{0} is max", FindMaxValueoutOfThree(first, second, third));
        }
    }
}

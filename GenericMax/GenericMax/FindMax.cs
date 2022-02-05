using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
     class FindMax
    {
        public static int FindMaxValueoutOfThree(int first,int second,int third)
        {
            //result will be either 0 or 1 or -1
            //-1 for lesser value, 1 for greater value, 0 for equal value
            int res=first.CompareTo(second);    
            if(first.CompareTo(second)>0 && first.CompareTo(third)>0)
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
                return 0;                                                                   //for integer 
            }
        }

        public static double FindMaxValueoutOfThree(double first, double second, double third)
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
                return 0.0;                                                                   //for integer 
            }
        }

        public static string FindMaxValueoutOfThree(string first, string second, string third)
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
                return null;                                                                   //for string
            }
        }
    }
}

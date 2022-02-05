using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
     class Program
    {
        static void Main(string[] args)                                     //Main Function
        {
            double[] arrdouble = { 12.11, 13.12, 14.13, 15.14, 16.15 };     //Defining double arr value in arrdouble variable
            int[] arr = { 10, 20, 30, 40 };                                 //Defining integer Array Value in arr variable
            char[] arrchar = { 's', 'h', 'w', 'e', 't', 'a' };
            int x = 20, y = 30, z = 40;
            double a = 11.22, b = 22.33, c = 33.44;
            string s = "ab", ss = "abb", sss = "abaa";

            Console.WriteLine("Choose program to execute");
            Console.WriteLine("1.print array element without generic concept\n2.displaying array element using generic method concept.\n3.Generic class concept for printing an array\n4.find max value\n5.find max value using generic class\n6.exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    PrintArray.PrintElements(arr);                                  //Calling static method to display Array element
                    PrintArray.PrintElements(arrdouble);
                    PrintArray.PrintElements(arrchar);
                    break;
                case 2:
                    Console.WriteLine("\nGeneric Method");
                    UsingGenericMethod.PrintElements<int>(arr);                     //Calling generic method for integer datatype
                    UsingGenericMethod.PrintElements<double>(arrdouble);            //for double datatype
                    UsingGenericMethod.PrintElements<char>(arrchar);                //for charactor datatype
                    break;
                case 3:
                    Console.WriteLine("Generic Class Concept");
                    GenericClass<int> genericclass = new GenericClass<int>(arr);    //object created for constructor
                    genericclass.PrintElements();                                   //Calling constructor Method

                    GenericClass<double> genericclass1 = new GenericClass<double>(arrdouble);
                    genericclass1.PrintElements();

                    GenericClass<char> genericclass2 = new GenericClass<char>(arrchar);
                    genericclass2.PrintElements();

                    new GenericClass<int>(arr).PrintElements();                        //Calling Constructor by another way to reduce lines of code
                    new GenericClass<double>(arrdouble).PrintElements();
                    new GenericClass<char>(arrchar).PrintElements();
                    break;
                case 4:
                    Console.WriteLine("Max value");
                    if(FindMax.FindMaxValueoutOfThree(x,y,z)!=0)
                    Console.WriteLine("{0} is Maximum out of {1},{2},{3}", FindMax.FindMaxValueoutOfThree(x, y, z),x,y,z);
                    if(FindMax.FindMaxValueoutOfThree(a, b, c) != 0)
                    Console.WriteLine("{0} is Maximum out of {1},{2},{3}", FindMax.FindMaxValueoutOfThree(a, b, c), a,b, c);
                    if (FindMax.FindMaxValueoutOfThree(s, ss, sss) != null)
                    Console.WriteLine("{0} is Maximum out of {1},{2},{3}", FindMax.FindMaxValueoutOfThree(s, ss, sss), s, ss, sss);
                    break;
                case 5:
                    new MaxWithGenericClass<int>(x, y, z).MaxTest();
                    //Console.WriteLine("{0} is maximum number", new MaxWithGenericClass<int>(x, y, z).MaxTest());
                    break;
                case 6:
                    break;
                default:
                    break;
            }  
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
//            Console.WriteLine("Hello World!");

            // Keep the console window open in debug mode.
            string s = "Hello Extension Methods";
            int i = s.WordCount();
            Console.WriteLine("Word count from "+s+" is= "+i);
            string s1 = null;
            string s2 = "";
            string s3 = "a";
            string s4 = "null";
            bool result = s1.IsNullOrEmpty();
            bool result1 = s2.IsNullOrEmpty();
            bool result2 = s3.IsNullOrEmpty();
            bool result3 = s4.IsNullOrEmpty();
            Console.WriteLine("s1 is " + s1 + " and result is= " + result);
            Console.WriteLine("s2 is " + s2 + " and result is= " + result1);
            Console.WriteLine("s3 is " + s3 + " and result is= " + result2);
            Console.WriteLine("s4 is " + s4 + " and result is= " + result3);
            double area = MyExtensions.
                AreaTriangle(5.0, 12.0, 16.0);
            /// try
           // {
                Console.WriteLine("Area is = " + area);

            area = MyExtensions.
               AreaTriangle(5.0, 12.0, 4.0);


            Console.WriteLine("Area is = " + area);
            area = MyExtensions.
               AreaTriangle(-5.0, -12.0, 16.0);
            /// try
            // {
            Console.WriteLine("Area is = " + area);
            //}
            //catch(MyExceptions.InvalidTriangleException e)
            // {
            //   Console.WriteLine(e.ToString());
            // }
            int num1 = 60, num2 = 42;
            List<int> resdiv1=MyExtensions.FindDivisors(num1);
            Console.Write("\nPositive divisors for "+num1+ " are =");
            resdiv1.ForEach(Print);
            List<int> resdiv2 = MyExtensions.FindDivisors(num2);
            Console.Write("\nPositive divisors for " + num2 + " are =");
            resdiv2.ForEach(Print);

            List<int> inputArr = new List<int> { 1, 1, 2, 4, 5, 6, 7, 3, 4, 2 };
            List<int> res=MyExtensions.FindMostCommon(inputArr);
            Console.Write("\nMost frequent element in the list ");
            inputArr.ForEach(Print);
            Console.Write(" are = ");
            res.ForEach(Print);
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();

        }
        private static void Print(int s)
        {
            Console.Write(s+" ");
        }
    }
}

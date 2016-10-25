using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExceptions;

namespace ExtensionMethods
{
    public static class MyExtensions
    {

        // to countwords in the string
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        //to see if string is null or empty
        public static bool IsNullOrEmpty(this string s)
        {
            return s == null || s.Length == 0;
        }

        // calculate area of triangle
        public static double AreaTriangle(double a, double b, double c)
        {
            double area = 0.0;

            try {
                if (a > 0 && b > 0 && c > 0) {

                    if ((a + b) > c && (b + c) > a && (a + c) > b)
                    {

                        double s = (a + b + c) / 2;
                        //Console.WriteLine("Perimeter= "+ s);
                        area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                        // Console.WriteLine("Area in the function is = " + area);
                        //put to two decimal places
                        area = Math.Round(area, 2);
                        return area;

                    }
                    else
                    {
                        throw new InvalidTriangleException("Please check sides again.", a, b, c);

                    }
                }
                else {

                    throw new InvalidTriangleException("All sides must be positive.", a, b, c);

                }
            }
            catch (InvalidTriangleException e)
            {
                Console.WriteLine(e.ToString());
                return -1.0;
            }

        }

        //find positive divisor of a number

        public static List<int> FindDivisors(int num){

            List<int> li = new List<int>();
            if(num < 0)
            {
                throw new ArgumentException(String.Format("Number should be positive", num),
                                    "num");
            }
            for (int i=1; i<=num; i++)
            {
                if(num % i == 0)
                {
                    li.Add(i);
                }
            }
            return li;
        }

        // find most frequent elements in the list

        public static List<int> FindMostCommon(List<int> li){

            int[] arr = li.ToArray();
            var map = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (map.ContainsKey(num))
                {
                    int m;
                    if(map.TryGetValue(num, out m))
                        map[num]=m + 1;
                }
                else
                {
                    map.Add(num, 1);
                }
            }

            int max = 0;
            foreach (var pair in map)
            {
              //  Console.WriteLine(pair.Key + "/" + pair.Value);
                if (max < pair.Value)
                {
                    max = pair.Value;
                }

            }

            //Console.WriteLine("Max=" +max);
            List<int> res= new List<int>();
            foreach (var pair in map)
            {
             //   Console.WriteLine(pair.Key + "/" + pair.Value);
                if (max == pair.Value)
                {
                   res.Add(pair.Key);
            //        Console.WriteLine(pair.Key+" added");
                }

            }
          /* Console.WriteLine("Printing res values inside");
            res.ForEach(delegate (int num)
            {
                Console.WriteLine(num);
            });
            */
             return res;
        }

    }
}

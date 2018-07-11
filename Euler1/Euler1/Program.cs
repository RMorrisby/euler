using System;
using System.Collections;

//Solution for Project Euler problem 1

namespace Euler1
{
    class Program
    {
        public static void p(Object s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            p("Log test");

            var limit = 1000;
            ArrayList matches = new ArrayList();
            var sum = 0;

            for (int i = 1; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    //p(i);
                    matches.Add(i);
                }
            }

            foreach (int v in matches)
            {
                sum += v;
            }

            p($"Sum of {limit} is {sum}");
        }
    }
}

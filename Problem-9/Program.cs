using System;

namespace Problem_9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Problem9(1000));

        }

        private static int Problem9(int sum)
        {
            int a;
            int b = 0;
            int c = 0;
            bool soultionFound = false;

            for (a = 1; a < 1000; a++)
            {
                for (b = 2; b < a; b++)
                {
                    c = sum - a - b;
                    if (a * a + b * b == c * c)
                    {
                        soultionFound = true;
                        break;
                    }
                }

                if (soultionFound)
                {
                    break;
                }
            }

            return a * b * c;
        }
    }
}

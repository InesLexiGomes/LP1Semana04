using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the number of the special sequence: ");
            int num = int.Parse(Console.ReadLine());
            num = GetSpecial(num);
            Console.WriteLine(num);
        }
        private static int GetSpecial(int n)
        {
            int res;
            if (n == 0)
            {
                res = 0;
            }
            else if (n == 1)
            {
                res = 1;
            }
            else
            {
                res = GetSpecial(n-1) + 2* GetSpecial(n-2);
            }
            return res;
        }
    }
}

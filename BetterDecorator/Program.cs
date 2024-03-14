using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = args[0];
            char dec = char.Parse(args[1]);
            int i = int.Parse(args[2]);
            s = Decor(s,dec,i);
            Console.WriteLine(s);
        }
        private static string Decor ( string s , char dec, int i)
        {
            for (int j = 0; j < i; j++ )
            {
                s = $"{dec}{s}{dec}";
            }
        
        return s;
        }

    }
}

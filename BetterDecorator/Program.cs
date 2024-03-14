using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// Executa o principal, e chama os outros.
        /// </summary>
        /// <param name="args">string, char, int</param>
        static void Main(string[] args)
        {
            string s = args[0];
            char dec = char.Parse(args[1]);
            int i = int.Parse(args[2]);
            s = Decor(s,dec,i);
            Console.WriteLine(s);
        }
        /// <summary>
        /// Adiciona caracteres um certo numero de vezes.
        /// </summary>
        /// <param name="s"> string </param>
        /// <param name="dec"> char </param>
        /// <param name="i"> int </param>
        /// <returns></returns>
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

using System;
using System.Linq;

namespace p03_TextFilter
{
    class p03_TextFilter
    {
        static void Main(string[] args)
        {
            var bannWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var text = Console.ReadLine();

            for (int i = 0; i < bannWords.Length; i++)
            {
                if (text.Contains(bannWords[i]))
                {
                    text = text.Replace(bannWords[i], new string('*', bannWords[i].Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}

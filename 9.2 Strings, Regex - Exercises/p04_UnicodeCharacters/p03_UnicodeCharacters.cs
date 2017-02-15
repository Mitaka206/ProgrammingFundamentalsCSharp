using System;
using System.Text;

namespace p04_UnicodeCharacters
{
    class p03_UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            Console.WriteLine(GetUnicodeString(text));
            
        }
        public static string GetUnicodeString(string s)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }

            return sb.ToString();
        }

    }
}

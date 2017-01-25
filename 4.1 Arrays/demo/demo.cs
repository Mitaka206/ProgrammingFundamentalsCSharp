using System;

namespace demo
{
    class demo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string x = string.Empty;
            string element = string.Empty;
            for (int i = 0; i < n; i++)
            {
                element = int.Parse(Console.ReadLine()).ToString();
                x = element;
            }
            for (int i = x.Length - 1; i >= 0; i--)
            {
                Console.Write(element);
            }   
        }
    }
}

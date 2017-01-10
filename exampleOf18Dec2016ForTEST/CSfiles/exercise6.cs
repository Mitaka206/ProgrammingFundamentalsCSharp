using System;

namespace exercises6
{
    public class exercises6
    {
        public static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            char miss = char.Parse(Console.ReadLine());

            int count = 0;

            for ( char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        if (i!=miss && j!=miss && k!=miss)
                        {
                            count++;
                            Console.Write("{0}{1}{2} ",i,j,k);

                        }
                    }
                }
            }
            Console.Write("{0}", count);
        }
    }
}

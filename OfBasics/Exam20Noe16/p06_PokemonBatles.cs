using System;

namespace PokemonBatles
{
    public class PokemonBatles
    {
        public static void Main(string[] args)
        {
            int pokemon1 = int.Parse(Console.ReadLine());
            int pokemon2 = int.Parse(Console.ReadLine());
            int stopGame = int.Parse(Console.ReadLine());

            int stop = 0;

            for (int i = 1; i <= pokemon1; i++)
            {
                for (int j = 1; j <= pokemon2; j++)
                {
                    stop++;
                    if (stop<=stopGame)
                    {
                        Console.Write("({0} <-> {1}) ", i, j);
                        
                    }
                    else
                    {
                        break;
                    }
                    
                }

            }
        }
    }
}

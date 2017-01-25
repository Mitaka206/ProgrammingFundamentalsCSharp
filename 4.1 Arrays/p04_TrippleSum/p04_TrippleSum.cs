using System;

namespace p04_TrippleSum
{
    class p04_TrippleSum
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int[] numbers = new int[input.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);

            }
            bool isFaundSum = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] == numbers[k])
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            isFaundSum = true;
                            break;
                        }
                    }
                }
            }
            if (!isFaundSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}

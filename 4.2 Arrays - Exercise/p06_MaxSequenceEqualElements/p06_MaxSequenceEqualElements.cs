using System;
using System.Linq;

namespace p06_MaxSequenceEqualElements
{
    class p06_MaxSequenceEqualElements
    {
        public static void Main()
        {
            int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();//new int[] { 2, 1, 1, 1, 1, 2, 3, 3, 2, 2, 2, 1 };*/

            int[] max = seq.Select((n, i) => new { Value = n, Index = i })
            .OrderBy(s => s.Value)
            .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
            .GroupBy(s => new { s.Value, s.Diff })
            .OrderByDescending(g => g.Count())
            .First()
            .Select(f => f.Value)
            .ToArray();

            Console.Write(string.Join(" ", max));
        }
    }
}

        //static void Main(string[] args)
        //{
        //    //===================--------From Telerik--------===========================
        //    //Write a program that finds the maximal sequence of equal elements in an array.
        //    //Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

        //    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();//{ 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };//hard coding

        //    int counter = 1, 
        //        maxCounter = 1, 
        //        maxElement = input[0]; //In case of just one element in the array the first element is the winner, that's why the initial value is the one of the first element.

        //    int element = input[0]; //The element we compare with. It's the first element of the array with index 0.

        //    //Find the maximal sequence of equal elements in the array
        //    for (int i = 1; i < input.Length; i++) //The cycle starts the comparison from the second memeber of the sequence with index 1.
        //    {
        //        if (input[i] == element)
        //        {
        //            counter++;
        //            if (counter > maxCounter)//Note! If there are 2 or more sequences of equal lenghts by checking with ">" the output will be the first sequence. If we check with ">=" we'll get the last one.
        //            {
        //                maxCounter = counter;
        //                maxElement = element;
        //            }
        //        }
        //        else
        //        {
        //            counter = 1;
        //            element = input[i];
        //        }
        //    }

        //    for (int j = 1; j <= maxCounter; j++)
        //    {
        //        Console.Write($"{maxElement} ");
        //    }
        //}
    }
}

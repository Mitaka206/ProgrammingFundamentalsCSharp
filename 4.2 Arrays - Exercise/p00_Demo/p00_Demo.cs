using System;
using System.Linq;

namespace p00_Demo
{
    class p00_Demo
    {
        static void Main(string[] args)
        {
            int[] seq = new int[] { 1, 2, 3 };
            int[] seq2 = new int[] { 4, 5, 6, 7 };

            var concatA = seq.Concat(seq2);//reurn 1,2,3,4,5,6,7

            var containsA = seq.Contains(3);//return true or false by Value

            int[] seqEmty = new int[] { };
            var defIfEmpty = seqEmty.DefaultIfEmpty();// return 0

            int[] seqMore = new int[] { 1, 2, 3, 3, 3, 5, 2, 10, 4, 8 };
            var distinctValues = seqMore.Distinct();//return unique values

            var elementAtOrDef = seq.ElementAtOrDefault(2);//return elemen in [2] -> 3
            var elementAtOrDefNO = seq.ElementAtOrDefault(-1);//return elemen in [-1] -> 0

            var elementAt = seq.ElementAt(1);//return Exeption if [-5/-4/11]

            var exeptValues = seqMore.Except(seq);// return 5,10,4,8 !is Notcontains in seq


            string[] strings = new string[] { "fasdfa", "stamat", "iiiii" };
            var firsInArr = strings.First(a => a.Equals("stamat"));//return first element -> "stamat"


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_HandsOfCards
{
    class p05_HandsOfCards
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var playerScore = new Dictionary<string, int>();

            while (input != "JOKER")
            {
                string names = input.Split().Take(1).ToString();

                var cards = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                ScoreOfCards(cards);


                input = Console.ReadLine();
            }
        }

        private static void ScoreOfCards(string[] cards)
        {
            string[] firstOfCard = new string[cards.Length];
            string[] secondOfCard = new string[cards.Length];
            
                for (int i = 0; i < cards.Length; i++)
                {
                    firstOfCard[i] = cards[i].Substring(cards[i].Length - 2, 1);
                }

                for (int i = 0; i < cards.Length; i++)
                {
                    secondOfCard[i] = cards[i].Substring(cards[i].Length - 1, 1);

                }
            return ;
        }
        private static int TypeSum(string v)
        {
            int typePower = 0;
            switch (v)
            {
                case "S":
                    typePower += 4;
                    break;
                case "H":
                    typePower += 3;
                    break;
                case "D":
                    typePower += 2;
                    break;
                case "C":
                    typePower += 1;
                    break;
                default:
                    break;
            }
            return typePower;
        }

        private static int PowerSum(string v)
        {
            int cardPower = 0;
            switch (v)
            {
                case "1":
                    cardPower += 1;
                    break;
                case "2":
                    cardPower += 2;
                    break;
                case "3":
                    cardPower += 3;
                    break;
                case "4":
                    cardPower += 4;
                    break;
                case "5":
                    cardPower += 5;
                    break;
                case "6":
                    cardPower += 6;
                    break;
                case "7":
                    cardPower += 7;
                    break;
                case "8":
                    cardPower += 8;
                    break;
                case "9":
                    cardPower += 9;
                    break;
                case "10":
                    cardPower += 10;
                    break;
                case "J":
                    cardPower += 11;
                    break;
                case "Q":
                    cardPower += 12;
                    break;
                case "K":
                    cardPower += 13;
                    break;
                case "A":
                    cardPower += 14;
                    break;
                default:
                    break;
            }
            return cardPower;

        }
    }
}

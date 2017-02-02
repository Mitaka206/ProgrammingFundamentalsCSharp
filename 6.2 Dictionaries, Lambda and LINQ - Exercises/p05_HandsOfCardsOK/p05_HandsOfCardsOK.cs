using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_HandsOfCardsOK
{
    class p05_HandsOfCardsOK
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> playersAndCards = new Dictionary<string, List<string>>();

            while (input != "JOKER")
            {
                string[] actions = input.Split(':').ToArray();
                string name = actions[0];
                List<string> cardsInHand = actions[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                .ToList();

                if (!playersAndCards.ContainsKey(name))
                {
                    playersAndCards.Add(name, new List<string>());
                }

                playersAndCards[name].AddRange(cardsInHand);

                input = Console.ReadLine();
            }

            PlayerScores(playersAndCards);
        }

        private static void PlayerScores(Dictionary<string, List<string>> cards)
        {
            foreach (var item in cards)
            {
                string name = item.Key;

                List<string> playerCards = item.Value;
                int score = 0;

                playerCards = playerCards.Distinct().ToList();

                foreach (var card in playerCards)
                {
                    string cardType = card.Substring(0, card.Length - 1);

                    int power = PowerOfCards(cardType);

                    int color = ColorOfCards(card[card.Length - 1]);

                    score += power * color;
                }

                Console.WriteLine($"{name}: {score}");
            }
        }

        static int ColorOfCards(char colors)
        {
            int type = 0;

            switch (colors)
            {
                case 'S':
                    type = 4; break;
                case 'H':
                    type = 3; break;
                case 'D':
                    type = 2; break;
                case 'C':
                    type = 1; break;
            }

            return type;
        }

        static int PowerOfCards(string input)
        {
            int power = 0;

            switch (input)
            {
                case "J":
                    power += 11;
                    break;
                case "Q":
                    power += 12;
                    break;
                case "K":
                    power += 13;
                    break;
                case "A":
                    power += 14;
                    break;
                default:
                    power = int.Parse(input);
                    break;
            }

            return power;
        }
    }

}


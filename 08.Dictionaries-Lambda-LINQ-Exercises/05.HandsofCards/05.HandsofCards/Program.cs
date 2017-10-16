using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HandsofCards
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> result = new Dictionary<string, int>();
            Dictionary<string, string> data = new Dictionary<string, string>();

            while (input != "JOKER")
            {
                string[] inputArr = input.Split(':').ToArray();
                string name = inputArr[0];

                if (!data.ContainsKey(name))
                {
                    data.Add(name, inputArr[1]);
                }
                else
                {
                    data[name] += inputArr[1];
                }

                input = Console.ReadLine();
            }

            foreach (var item in data)
            {
                List<string> playerCards = new List<string>();
                playerCards = item.Value
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToList();

                int sumOfHand = 0;

                foreach (var card in playerCards)
                {
                    sumOfHand += CardPoints(card);
                }

                if (!result.ContainsKey(item.Key))
                {
                    result.Add(item.Key, sumOfHand);
                }
                else
                {
                    result[item.Key] += sumOfHand;
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }

        private static int CardPoints(string card)
        {
            string power = card[0].ToString();
            string type = card[card.Length - 1].ToString();

            if (power == "1")
            {
                power = "10";
            }

            int powerNumber = 0;
            int typeNumber = 0;
            bool checkPower = int.TryParse(power, out powerNumber);

            if (!checkPower)
            {
                switch (power)
                {
                    case "J":
                        powerNumber = 11;
                        break;

                    case "Q":
                        powerNumber = 12;
                        break;

                    case "K":
                        powerNumber = 13;
                        break;

                    case "A":
                        powerNumber = 14;
                        break;
                }
            }

            switch (type)
            {
                case "S":
                    typeNumber = 4;
                    break;

                case "H":
                    typeNumber = 3;
                    break;

                case "D":
                    typeNumber = 2;
                    break;

                case "C":
                    typeNumber = 1;
                    break;
            }

            int cardPoints = powerNumber * typeNumber;
            return cardPoints;
        }
    }
}
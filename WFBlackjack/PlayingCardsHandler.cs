using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBlackjack
{
    public class PlayingCardsHandler
    {
        /// <summary>
        /// Returns 52 standart french cards
        /// </summary>
        /// <returns></returns>
        public static List<PlayingCard> GetSetOfCards()
        {
            List<PlayingCard> setOfCards = new List<PlayingCard>();

            string[] suits = new string[]
            {
                "clubs", "diamonds", "hearts", "spades"
            };

            string[] pos = new string[]
            {
                "jack", "queen", "king", "ace"
            };

            string[] posCapitilized = new string[]
            {
                "Jack", "Queen", "King", "Ace"
            };

            for (int i = 2; i <= 10; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    setOfCards.Add(new PlayingCard()
                    {
                        Name = $"{i} of {suits[j]}",
                        ResourceName = $"_{i}_of_{suits[j]}",
                        ValueOfCard = i
                    });
                }
            }

            for (int i = 0; i < pos.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    var cardObj = new PlayingCard()
                    {
                        Name = $"{posCapitilized[i]} of {suits[j]}",
                        ResourceName = $"{pos[i]}_of_{suits[j]}",
                        ValueOfCard = 10
                    };

                    if (pos[i] == "ace")
                    {
                        cardObj.ValueOfCard = 11;
                    }

                    setOfCards.Add(cardObj);
                }
            }

            return setOfCards;
        }


        public static void Shuffle<T>(List<T> cards)
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
    }
}

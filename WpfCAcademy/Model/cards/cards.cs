using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfCAcademy.Model.cards
{
    class cards : iCards
    {
        enum special : Byte { none = 0, joker }
        static Random r = new Random();
        List<card> Deck = new List<card>();
        public void addCard(card Card)
        {
            Deck.Insert(Deck.Count, Card);
            return;
        }

        public void createDefaultDeck()
        {
            Boolean special = new bool();
            special = false;
            char[] suits = { '\u2660', '\u2665', '\u2666', '\u2663' }; //Spades,  Hearts, Diamonds, Clubs
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    addCard(new card(new Suit(suits[i], 15 * (i + 1)), new Mark(values[j], j + 1), special));
                }

            }
        }

        internal void Clear()
        {
            Deck.Clear();
        }

        public List<card> shuffleAlternative()
        {
            var newDeck = new List<card>();
            var deckCount = Deck.Count;
            var shuffleinnerCounter = r.Next(deckCount);
            for (int i = 0; i < shuffleinnerCounter; i++)
            {
                var halfADeck = Deck.Count / 2;
                do
                {
                    for (int j = 0; j < r.Next(deckCount/10); j++)
                    {

                    }
                } while (Deck.Count>0);
                Deck = newDeck;
            }
            return newDeck;
        }
        public List<card> shuffle()
        {
            var deckCount = Deck.Count;
            for (int n = Deck.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                card tempn = Deck.ElementAt(n);
                Deck.RemoveAt(n);
                card tempk = Deck.ElementAt(k);
                Deck.RemoveAt(k);
                Deck.Insert(deckCount - 2, tempk);
                Deck.Insert(deckCount - 1, tempn);
            }
            return Deck;
        }

        public Dictionary<int, List<card>> deal(int players, int cardsToDealForEachPlayer, Boolean dealerGetsOneMore = false)
        {
            Dictionary<int, List<card>> returnValues = new Dictionary<int, List<card>>();

            for (int j = 0; j <= players; j++)
            {
                returnValues.Add(j, new List<card>());
            }

            int cardsDealt = 0;
            for (int i = 0; i < cardsToDealForEachPlayer; i++)
            {
                for (int j = 0; j < players; j++)
                {
                    returnValues.ElementAt(j).Value.Add(Deck.ElementAt(cardsDealt));
                    ++cardsDealt;
                }
            }
            if (dealerGetsOneMore)
            {//assumes dealer @0
                returnValues.ElementAt(0).Value.Insert(cardsToDealForEachPlayer + 1, Deck.ElementAt(cardsDealt));
                ++cardsDealt;
            }
            for (int i = cardsDealt; i < Deck.Count; i++)
            {
                returnValues.ElementAt(players).Value.Insert(i, Deck.ElementAt(i));
            }
            for (int j = 0; j < players; j++)
            {
                returnValues.ElementAt(j).Value.Sort();
            }
            return returnValues;
        }

        public string ConverToString(List<card> deck)
        {
            StringBuilder sb = new StringBuilder();
            Boolean isFirst = true;
            Suit oldSuit = new Suit();
            foreach (card Card in deck)
            {
                if (!isFirst)
                {
                    sb.Append(", ");
                }
                if (oldSuit.value == 0)
                {
                    oldSuit.value = Card.suite.value;
                }
                if (oldSuit.value != Card.suite.value)
                {
                    oldSuit.value = Card.suite.value;
                    sb.Append("\n");
                }
                sb.Append(Card.ToString());
                isFirst = false;


            }
            return sb.ToString();
        }
    }
}

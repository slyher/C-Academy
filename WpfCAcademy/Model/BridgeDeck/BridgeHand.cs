using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCAcademy.Model.cards;

namespace WpfCAcademy.Model.BridgeDeck
{
    public class BridgeHand : cards.cards
    {
        enum ValuedCardValues : int { J = 1, Q, K, A };
        public List<card> Hand = new List<card>();
        public BridgeHand(List<card> Hand)
        {
            this.Hand = Hand;
        }

        public int CountHandPoints()
        {
            var Points = 0;
            foreach (var Card in Hand)
            {
                foreach (var MarkPoint in Enum.GetNames(typeof(ValuedCardValues)))
                {
                    if (MarkPoint.ToString().Equals(Card.mark.ToString()))
                    {
                        Points += (int)Enum.Parse(typeof(ValuedCardValues), Card.mark.ToString());
                    }
                }
            }
            return Points;
        }

        public int GetLengthOfLongestSuite()
        {
            Dictionary<Suit, int> Length = new Dictionary<Suit, int>();
            foreach (var Card in Hand)
            {
                if (Length.ContainsKey(Card.suite))
                {
                    Length[Card.suite]++;
                }
                else
                {
                    Length.Add(Card.suite, 1);
                }
            }
            return Length.Values.Max();
        }
        public Suit GetSuitOfLongestSuite()
        {
            // return new Suit();
            throw new NotImplementedException();
        }

    }
}

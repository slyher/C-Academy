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
            foreach (var Card in this.Hand)
            {
                foreach (var MarkPoint in Enum.GetNames(typeof(Mark)).ToList<string>())
                {
                    if (MarkPoint.ToString().Equals(Card.mark))
                    {
                        Points += (int)Enum.Parse(typeof(Mark), Card.mark.ToString());
                    }
                }
            }
            return Points;
        }

        public int GetLengthOfLongestSuite()
        {
            return 0;
        }
        public Suit GetSuitOfLongestSuite()
        {
            return new Suit();
        }

    }
}

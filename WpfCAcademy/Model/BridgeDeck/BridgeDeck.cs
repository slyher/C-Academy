using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCAcademy.Model.cards;

namespace WpfCAcademy.Model.BridgeDeck
{
    class BridgeDeck : cards.cards
    {
        public List<BridgeHand> Hands = new List<BridgeHand>();
        public BridgeDeck() { }
        public void AddHands(Dictionary<int, List<card>> Deck)
        {
            for (int i = 0; i < Deck.Count(); i++)
            {
                Hands.Add(new BridgeHand(Deck[i]));
            }
        }

        public string ConverToString(BridgeHand Hand)
        {
            return base.ConverToString(Hand.Hand);
        }
        internal new void Clear()
        {
            Deck.Clear();
            Hands.Clear();
        }
    }
}

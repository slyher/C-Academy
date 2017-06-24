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
        public List<card> Hand = new List<card>();
        public BridgeHand(List<card> Hand) {
            this.Hand = Hand;
        }

        public int CountHandPoints() {
            throw new NotImplementedException();
            return 42;
        }
    }
}

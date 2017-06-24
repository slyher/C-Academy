using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCAcademy.Model.BridgeDeck
{
    class BridgeDeck: cards.cards
    {
        public List<BridgeHand> Hands = new List<BridgeHand>();
    }
}

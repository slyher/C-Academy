using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCAcademy.Model.cards
{
    interface iCards
    {
        List <card> shuffle();
        Dictionary<int, List<card>> deal(int players, int cardsToDealForEachPlayer, Boolean dealerGetsOneMore = false);
    }
}

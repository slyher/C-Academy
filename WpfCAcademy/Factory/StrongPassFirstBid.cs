using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCAcademy.Model.BridgeDeck;


namespace WpfCAcademy.Factory
{
    class StrongPassFirstBid
    {
        const int LowerLimItForOpeningBid = 12;
        const int LengthOfSuiteToBid = 5;
        const string LowestSuite = "Club";
        const string passBid = "pass";
        public static string PredictFirstBid(BridgeHand Hand)
        {
            if (Hand.CountHandPoints() >= LowerLimItForOpeningBid
                && Hand.GetLengthOfLongestSuite() >= LengthOfSuiteToBid)
            {
                return passBid;
            }
            return "1" + SuiteFactory.getSuitBuCommonName(LowestSuite);
        }
    }
}

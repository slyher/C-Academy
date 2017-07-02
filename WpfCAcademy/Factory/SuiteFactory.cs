using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCAcademy.Model.cards;

namespace WpfCAcademy.Factory
{
    class SuiteFactory
    {
        private static Dictionary<string, Suit> SuiteMap = new Dictionary<string, Suit>();
        public static Suit NewSuite(char suit, int value, string CommonName)
        {
            Suit NewSuite;
            if (SuiteMap.TryGetValue(CommonName, out NewSuite))
            {
                return NewSuite;
            }
            NewSuite = new Suit(suit, value, CommonName);
            SuiteMap.Add(CommonName, NewSuite);
            return NewSuite;
        }

        public static Suit getSuitBuCommonName(string CommonName)
        {
            Suit Suite;
            if (SuiteMap.TryGetValue(CommonName, out Suite))
            {
                return Suite;
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCAcademy.Model.cards
{
    public class Suit : IComparable<Suit>
    {
        public string CommonName { get; set; }
        protected char suit { get; set; }
        public Int32 value { get; set; }

        public Suit()
        {
            suit = ' ';
            value = 0;
            CommonName = "0";
        }
        public Suit(char suit, int value)
        {
            this.suit = suit;
            this.value = value;
            CommonName = value.ToString();
        }
        public Suit(char suit, int value, string CommonName)
        {
            this.suit = suit;
            this.value = value;
            this.CommonName = CommonName;
        }
        public int CompareTo(Suit other)
        {
            if (other == null) { return 1; }
            return value.CompareTo(other.value);
        }
        public override string ToString()
        {
            return suit.ToString();
        }
    }
}

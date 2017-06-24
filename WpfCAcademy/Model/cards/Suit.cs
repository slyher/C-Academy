using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCAcademy.Model.cards
{
    public class Suit : IComparable<Suit>
    {
        enum siuts : Int32 { club = 1, diamond, heart, spade }
        protected char suit { get; set; }
        public Int32 value { get; set; }

        public Suit() {
            suit = ' ';
            value = 0;
        }
        public Suit(char suit, Int32 value)
        {
            this.suit = suit;
            this.value = value;
        }
        public int CompareTo(Suit other)
        {
            if (other == null) { return 1; }
            return value.CompareTo(other.value);
        }
        public override string ToString()
        {
            return this.suit.ToString();
        }
    }
}

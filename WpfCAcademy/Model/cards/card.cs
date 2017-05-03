using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCAcademy.Model.cards
{
    class card : IComparable<card>
    {
        public card(Suit suit, Mark mark, bool Special)
        {
            this.mark = mark;
            this.suite = suit;
            this.isSpecial = Special;

        }

        public Suit suite { get; set; }
        private Mark mark { get; set; }
        private bool isSpecial { get; set; }

        public int CompareTo(card other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                if (suite.CompareTo(other.suite) == 0)
                {
                    return mark.CompareTo(other.mark);
                }
                else {
                    return suite.CompareTo(other.suite);
                }
                
            }
        }

        public override string ToString()
        {
            return string.Concat(suite.ToString(), ' ', mark.ToString());
        }
    }
}

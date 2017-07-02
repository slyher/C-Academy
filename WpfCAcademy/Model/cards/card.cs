using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCAcademy.Model.cards
{
    public class card : IComparable<card>
    {
        public card(Suit Suit, Mark Mark, bool Special)
        {
            this.mark = Mark;
            this.suite = Suit;
            this.isSpecial = Special;

        }

        public Suit suite { get; set; }
        public Mark mark { get; set; }
        public bool isSpecial { get; set; }

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

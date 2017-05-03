﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCAcademy.Model.cards
{
    class Mark : IComparable<Mark>
    {
        enum mark : Int32 { two = 2, thre, four, five, six, seven, eight, nine, ten, jack, quen, king, ace, JOKER}
        private Int32 value { get; set; }
        private string display { get; set; }

        public  Mark(string display, Int32 value)
        {
            this.value = value;
            this.display = display;
        }

        public int CompareTo(Mark other)
        {
            if (other == null) { return 1; }
            return -1*value.CompareTo(other.value);
        }
        public override string ToString()
        {
            return this.display.ToString();
        }
        }
}

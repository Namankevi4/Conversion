using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Formula
    {
        public string first;
        public char ch;
        public string second;
        public Type answer;
        public Formula(string first, char ch, string second, Type answer)
        {
            this.first = first;
            this.second = second;
            this.ch = ch;
            this.answer = answer;
        }
    }
}

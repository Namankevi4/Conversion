using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    public class Time : Value
    {
        public Time(double value) : base(value) { name = "s"; }
    }
}

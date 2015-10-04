using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    public class Value
    {
        public int val;
        public string name;


        public static Value operator *(Value t, Value s)
        {
            var m = new Value();
            if (t.GetType() == s.GetType())
            {
                Type ty = t.GetType();
                
                m.val = t.val * s.val;
                return (Value)m;
            }
           
            
            m.name = "m";
            
            return m;
        }
    }
}

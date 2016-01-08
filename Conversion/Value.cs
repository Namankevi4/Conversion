using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    public class Value
    {
        public Value(double value)
        {
            this.val = value;
            
        }
        public double val;
        protected string name;


        public static Value operator +(Value t, Value s)
        {
            if (t.name == s.name)
            {
               return (Value)Activator.CreateInstance(t.GetType(), t.val + s.val);
            }
            throw new Exception();
        }

        public static Value operator -(Value t, Value s)
        {
            if (t.name == s.name)
            {
                return (Value)Activator.CreateInstance(t.GetType(), t.val - s.val);
            }
            throw new InvalidOperationException("Error operation");
        }
        public static Value operator *(Value t, Value s)
        {
            if (t.name == s.name)
            {
                return (Value)Activator.CreateInstance(t.GetType(), t.val * s.val);
            }
            else return Activator.CreateInstance(Dictionary.search(t.name, '*', s.name), t.val * s.val);
            throw new InvalidOperationException("Error operation");
        }
        public static Value operator /(Value t, Value s)
        {
            if (t.name == s.name)
            {
                return (Value)Activator.CreateInstance(t.GetType(), t.val / s.val);
            }
            else return Activator.CreateInstance(Dictionary.search(t.name, '/', s.name), t.val / s.val);
            throw new InvalidOperationException("Error operation");
        }
    }
}

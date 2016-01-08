using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    static class Dictionary
    {
         
        public static List<Formula> listForm = new List<Formula>();
        
        public static dynamic search(string first, char ch, string second)
        {
            foreach (var val in listForm)
            {
                if (((val.first == first && val.second == second) || (val.first == second && val.second == first)) && val.ch == ch)
                    return val.answer;
            }
            throw new InvalidOperationException("Formula not found");
        }
        
    }
}

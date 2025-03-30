using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_homework
{
    internal class Karta
    {
        public string Mast { get; set; }
        public string Value { get; set; }

        private static Dictionary<string, int> cardValue = new Dictionary<string, int>()
        {
            ["6"] = 6,
            ["7"] = 7,
            ["8"] = 8,
            ["9"] = 9,
            ["10"] = 10,
            ["валет"] = 11,
            ["дама"] = 12,
            ["король"] = 13,
            ["туз"] = 14,
        };
        public Karta(string mast,string value)
        {
            Mast = mast.ToLower();
            Value = value;
        }
        public int GetValue()
        {
            return cardValue[Value];  
        }
        public override string ToString()
        {
            return $"{Value} {Mast}";
        }
    }
}

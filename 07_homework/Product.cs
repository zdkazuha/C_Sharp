using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_homework
{
    internal  class Product : Money
    {
        string name = "NoName";
        public string Name { get=> name; set=> name = value ?? "NoName"; }
        public Product(string name = "NoName", int grn = 0,int cop = 0)
            :base(grn,cop)
        {
            Name = name;
        }

        public void ReducePrice(int grn_, int cop_)
        {
            if (grn_ < 0 || cop_ < 0)
            {
                throw new Exception("Values for reduction must be positive.");
            }

            if (this.grn < grn_ || (this.grn == grn_ && this.cop < cop_))
            {
                throw new Exception($"It is not possible to reduce by Grn {grn_,-10} Cop {cop_,-10}");
            }
            if (this.cop < cop_)
            {
                this.grn -= 1;
                this.cop += 100;
            }
            this.grn -= grn_;
            this.cop -= cop_;

        }

        public override void Print()
        {
            Console.WriteLine($"Name :: {name,-10} Grn :: {grn,-10} Cop :: {cop,-10}");
        }

    }
}

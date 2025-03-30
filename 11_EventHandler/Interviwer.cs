using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EventHandler
{
    internal class Interviewer
    {
        public string Name { get; set; }

        public void Dosomething(object sender,MyArgs args)
        {
            Console.WriteLine($"Interviwer {Name} notified about {args.Description} Date :: {args.Date} from Company {args.CompanyName}");
        }
    }
}

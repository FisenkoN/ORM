using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Voc
    {
        public Dictionary<string, string> Pairs { get; init; }

        public Voc()
        {
            Pairs = new Dictionary<string, string>();
            Pairs.Add("String","char(50)");

            Pairs.Add( "Int32","INT");
        }
    }
}

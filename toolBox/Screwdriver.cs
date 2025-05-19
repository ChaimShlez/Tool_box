using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolBox
{
    internal class Screwdriver : Tool
    {
        public Screwdriver(string name, int weight) : base(name, weight)
        {
        }

        public override void Use()
        {
            Console.WriteLine("plop plop plop");
        }
    }
}

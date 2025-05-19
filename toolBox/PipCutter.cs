using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolBox
{
    internal class PipeCutter : Tool
    {
        public PipeCutter(string name, int weight) : base(name, weight)
        {
        }

        public override void Use()
        {
            Console.WriteLine("zzzzzz");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolBox
{
    internal class Wrench : Tool

    {
        public Wrench(string name, int weight) : base(name, weight)
        {
        }

        public override void Use()
        {
            Console.WriteLine("sssssssssssssssss");
        }
    }
}

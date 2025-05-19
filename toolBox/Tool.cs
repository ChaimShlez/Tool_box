using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolBox
{
    abstract class Tool
    {
        private string _Name;
        private int _Weight;
        public static int count = 0;

        protected Tool(string name, int weight)
        {
            _Name = name;
            _Weight = weight;
            count++;

        }

        public int MyWeight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public void Describe()
        {
            Console.WriteLine($"name:{_Name} weight :{_Weight}");
        }

        public virtual void Use()
        {

            Console.WriteLine("Using a general tool.");
        }

    }
}

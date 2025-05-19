using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tool drill1 = new Drill("drill", 5);
            Tool dril2 = new Drill("drill1", 7);
            Tool hammer = new Hammer("hammer", 2);

            List<Tool> tools = new List<Tool> {
             new Drill("drill", 5),
             new Drill("drill1", 7),
             new Hammer("hammer", 2),

            };

            foreach (var tool in tools)
            {
                tool.Use();
                tool.Describe();
                Console.WriteLine(tool.Name);
                Console.WriteLine($" count : {Tool.count} ");
            }



            ToolBox b = new ToolBox();
            b.AddTool(drill1);


        }
    }
}

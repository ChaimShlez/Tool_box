using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolBox
{
    internal class ToolBox
    {
        private List<Tool> tools = new List<Tool>();



        public void AddTool(Tool t)
        {
            tools.Add(t);
        }
    }
}

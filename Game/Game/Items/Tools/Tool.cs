using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Tools
{
    public abstract class Tool
    {
        private string _itemname; // Local variable storing the name of the item.

        public Tool(string name) {
            _itemname = name;
        }

        public string ItemName { get { return _itemname; } }
    }
}

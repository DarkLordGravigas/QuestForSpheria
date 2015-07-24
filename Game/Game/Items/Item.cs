using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items {

    public abstract class Item {

        private string _itemname; // Local variable storing the name of the item.

        public Item (string name) { _itemname = name; }

        public string ItemName { get { return _itemname; } }
    }
}

using Game.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items {

    public class Item : GenericClass {

        public Item(string name) : base("item." + name) { }

    }
}

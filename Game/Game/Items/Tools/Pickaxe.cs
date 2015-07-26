using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Tools {

    class Pickaxe : Tool {
        public Pickaxe(string name, MATERIAL material) : base("tool.pickaxe." + name, TOOLTYPE.PICKAXE, material) { }
    }

}

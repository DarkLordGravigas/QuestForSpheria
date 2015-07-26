using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Tools {

    class Tool : Item {
        private TOOLTYPE _tooltype;
        private MATERIAL _material;

        public Tool(string name, TOOLTYPE type, MATERIAL material) : base("tool." + name) {
                _tooltype = type; 
                _material = material;
        }

        public TOOLTYPE Type { get { return _tooltype; } }
        public MATERIAL Material { get { return _material; } }
    }

    public enum TOOLTYPE { 
        AXE, 
        PICKAXE, 
        SHOVEL, 
        FISHINGROD ,
        WEAPON
    }

}

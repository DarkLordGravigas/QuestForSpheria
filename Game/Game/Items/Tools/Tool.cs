using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Tools
{

    public abstract class Tool : Item {
        private TOOLTYPE _type;
        private MATERIAL _material;

        public Tool(string name, TOOLTYPE type, MATERIAL material) : base("tool." + name) { 
            _type = type; 
            _material = material;
        }

        public TOOLTYPE Type { get { return _type; }}
    }

    public enum TOOLTYPE { 
        AXE, 
        PICKAXE, 
        SHOVEL, 
        FISHING_ROD 
    };

}

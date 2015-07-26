using Game.Items.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Weapons {

    class Weapon : Tool {
        private WEAPONTYPE _weapontype;

        public Weapon(string name, WEAPONTYPE weapontype, MATERIAL material) : base("weapon." + name, TOOLTYPE.WEAPON, material) { }
    }

    public enum WEAPONTYPE {
        SWORD,
        BOW,
        SCYTHE,
        KNIFE,
        GUN,
        HARP
    }
}

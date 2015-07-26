using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Weapons {

    class Sword : Weapon {
        private SWORDTYPE _swordtype;

        public Sword(string name, SWORDTYPE swordtype, MATERIAL material) : base("sword." + name, WEAPONTYPE.SWORD, material) { _swordtype = swordtype; }

        public SWORDTYPE Swordtype { get { return _swordtype; } }
    }

    public enum SWORDTYPE {
        LONGSWORD,
        SHORTSWORD,
        CLEAVER,
        RAPIER
    }

}

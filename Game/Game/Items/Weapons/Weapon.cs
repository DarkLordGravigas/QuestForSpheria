using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Weapons {

    class Weapon : Item {
        private WEAPONTYPE _weapontype;
        private MATERIAL _material;

        public Weapon(string name, WEAPONTYPE weapontype, MATERIAL material) : base("weapon." + name) {
                _weapontype = weapontype;
                _material = material;
        }

        public WEAPONTYPE Type { get { return _weapontype; } }
        public MATERIAL Material { get { return _material; } }
    }

    public enum WEAPONTYPE {
        SWORD,
        BOW,
        SCYTHE,
        KNIFE,
        GUN,
        RIFLE,
        HARP
    }
}

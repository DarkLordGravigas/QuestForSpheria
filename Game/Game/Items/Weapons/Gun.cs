using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Weapons {

    class Gun : Weapon {
        private GUNTYPE _guntype;

        public Gun(string name, GUNTYPE guntype, MATERIAL material) : base("gun." + name, WEAPONTYPE.GUN, material) { _guntype = guntype; }

        public GUNTYPE GunType { get { return _guntype; } }
    }

    public enum GUNTYPE {
        PISTOL,
        SUBMACHINEGUN,
        LIGHTMACHINEGUN,
        AUTORIFLE,
        PULSERIFLE,
        SNIPER,
        ROCKETLAUNCHER
    }
}

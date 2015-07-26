using Game.Items.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Weapons {

    class Weapon : Tool {
        private WEAPONTYPE _weapontype;
        private MATERIAL _material;
        private float attackSpeed, damage, armorPenetration;
        private int durability;

        public Weapon(string name, WEAPONTYPE weapontype, MATERIAL material) : base("weapon." + name, TOOLTYPE.WEAPON, material) {
                _weapontype = weapontype;
                _material = material;
        }

        public WEAPONTYPE Type { get { return _weapontype; } }
        public MATERIAL Material { get { return _material; } }
        public float AttackSpeed { get { return attackSpeed; } }
        public float Damage { get { return damage; } }
        public float ArmorPenetration { get { return armorPenetration; } }
        public int Durability { get { return durability; } }
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

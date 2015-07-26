using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Weapons {

    class Sword : Weapon {
        private SWORDTYPE _swordtype;
        private float attackSpeed, damage, armorPenetration;
        private int durability;

        public Sword(string name, SWORDTYPE swordtype, MATERIAL material) : base("sword." + name, WEAPONTYPE.SWORD, material) { _swordtype = swordtype; }

        public SWORDTYPE Swordtype { get { return _swordtype; } }
        public float AttackSpeed { get { return attackSpeed; } }
        public float Damage { get { return damage; } }
        public float ArmorPenetration { get { return armorPenetration; } }
        public int Durability { get { return durability; } }
    }

    public enum SWORDTYPE {
        LONGSWORD,
        SHORTSWORD,
        CLEAVER,
        RAPIER,
        KNIFE
    }

}

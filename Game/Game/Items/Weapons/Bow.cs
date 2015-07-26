using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Weapons {

    class Bow : Weapon {
        private BOWTYPE _bowtype;
        private float attackSpeed, damage, armorPenetration;
        private int durability;

        public Bow(string name, BOWTYPE bowtype, MATERIAL material) : base("bow." + name, WEAPONTYPE.BOW, material) { _bowtype = bowtype; }

        public BOWTYPE BowType { get { return _bowtype; } }
        public float AttackSpeed { get { return attackSpeed; } }
        public float Damage { get { return damage; } }
        public float ArmorPenetration { get { return armorPenetration; } }
        public int Durability { get { return durability; } }
    }

    public enum BOWTYPE {
        LONGBOW,
        RECURVEBOW,
        COMPOUNDBOW,
        CROSSBOW
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Items.Tools {

    class Axe : Tool {

        public Axe(string name, MATERIAL material) : base("axe." + name, TOOLTYPE.AXE, material) { }
    }
}

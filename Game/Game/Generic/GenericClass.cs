using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Generic {

    public class GenericClass {

        private string _name;

        public GenericClass(string name) { _name = name; }

        public string Name { get { return _name; } }
    }
}

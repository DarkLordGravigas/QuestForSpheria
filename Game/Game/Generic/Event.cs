using Game.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Events {

    class Event : GenericClass {

        public Event(string name) : base("event." + name) { }
    }
}

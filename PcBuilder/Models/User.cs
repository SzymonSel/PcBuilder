using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Models {
    public class User {
        public Pc[] MyComputers { get; set; }

        public void AddPc(Pc pc) {
            this.MyComputers = new Pc[1];
            this.MyComputers[0] = pc;
        }
    }
}

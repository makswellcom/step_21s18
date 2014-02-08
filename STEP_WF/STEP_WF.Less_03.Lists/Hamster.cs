using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEP_WF.Less_03.Lists
{
    public class Hamster
    {
        public string Name { set; get; }
        public string Color { set; get; }
        public int Age { set; get; }

        public override string ToString()
        {
            return String.Format("{0: 10} ({1}) {2}", Name, Age, Color);
        }
    }
}

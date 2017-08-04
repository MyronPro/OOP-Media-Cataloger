using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    interface IPhysical
    {
        string Condition { get; set; }
        bool Case { get; set; }
        bool Manual { get; set; }
    }
}

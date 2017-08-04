using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    interface IMedia
    {
        string Name { get; set; }
        DateTime Release { get; set; }
        string Genre { get; set; }
        string Format { get; set; }
        string Type { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    public interface IDigital
    {
        string DigitalService { get; set; }
        string FileSize { get; set; }
    }
}

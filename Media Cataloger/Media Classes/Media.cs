using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Cataloger
{
    public abstract class Media : IMedia
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime Release { get; set; }
        public virtual string Type { get { return "Media"; } }
        public virtual string Format { get; set; }

        public Media (string name)
        {
            this.Name = name;
        }

        public Media (string name, string release, string genre )
        {
            this.Name = name;
            this.Release = DateTime.Parse(release);
            this.Genre = genre;
        }


        public abstract  bool UpdateFields();

    }
}

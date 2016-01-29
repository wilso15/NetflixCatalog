using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Title
    {
        public string name;
        public float? rating;

        public Title(string name, float rating)
        {
            this.name = name;
            this.rating = rating;
        }
        public Title()
        {
            this.name = null;
            this.rating = null;
        }
    }
}

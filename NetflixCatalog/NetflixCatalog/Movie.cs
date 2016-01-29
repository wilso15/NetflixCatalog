using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Movie : Title
    {
        public float Duration;

        public Movie(float duration, float? rating, string name)
        {
            this.Duration = duration;
        }
    }
}

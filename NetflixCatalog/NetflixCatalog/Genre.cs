using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Genre : IEnumerable
    {
        public List<string> Titles;
        public IEnumerator GetEnumerator()
        {
            yield return Titles;
        }
        public void AddToList()
        {

        }
    }
}

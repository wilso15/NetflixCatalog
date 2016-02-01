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
        public List<Title> Titles = new List<Title>();
        public IEnumerator GetEnumerator()
        {
            yield return Titles;
        }
        public void AddToGenreList(Title genreType)
        {
            Titles.Add(genreType);
        }

        public static string operator +(Genre x, Genre y)
        {
           string genreAggregate = x.ToString() + y.ToString();
            return genreAggregate;
        }
        public static string operator +(Title x, Genre y)
        {
            string genreTitleAggregate = x.ToString() + y.ToString();
            return genreTitleAggregate;
        }
    }
}

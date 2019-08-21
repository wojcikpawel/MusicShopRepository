using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopLibrary
{
    //tak naprawdę to każdy album ma listę utworów!!!! 
    //a każdy utwór ma numer co do kolejności, tytuł, długość, nazwa wykonawcy, rok (takie wlasciwosci przychodza mi do głowy)
    public class Song
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public TimeSpan Lenght { get; set; }
        public Artist Performer { get; set; }
        public int PremiereYear { get; set; }

        public string ShowPlaylistData
        {
            get
            {
                return string.Format("{0}. {1} {2} {3}",Number, Title, Lenght, PremiereYear);
            }
        }
    }
}
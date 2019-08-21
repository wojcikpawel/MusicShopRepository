using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopLibrary
{
    public class Album
    {
        //jawne prywatne pole typu klasa Artist
        private Artist _performer;
        public Artist Performer
        {
            get { return _performer; }
            set { _performer = value; }
        }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
       // public Song Song { get; set; }
        public List<Song> YoungHemsPlaylist { get; set; }
        public List<Song> TrojkatWarszawskiPlaylist{ get; set; }
        public List<Song> MonochromyPlaylist { get; set; }
        public List<Song> ZleTowarzystwoPlaylist { get; set; }

        public List<Song> MalomiasteczkowyPlaylist { get; set; }
        public List<Song> PlasticBeachPlaylist { get; set; }
        public List<Song> InterstellarPlaylist { get; set; }

        //wlasciwosc z akcesorem get
        public string ShowStoreAlbums
        {
            get { return string.Format("{0} - {1} - {2} PLN ", Performer.Alias, Title, Price); }
        }

        public string ShowToPurchasedAlbums
        {
            get { return string.Format("{0} - {1}", Performer.Alias, Title); }
        }

        //konstuktor do listy
        public Album()
        {
            
            YoungHemsPlaylist = new List<Song>();
            TrojkatWarszawskiPlaylist = new List<Song>();
            MonochromyPlaylist = new List<Song>();
            ZleTowarzystwoPlaylist = new List<Song>();
            MalomiasteczkowyPlaylist = new List<Song>();
            PlasticBeachPlaylist = new List<Song>();
            InterstellarPlaylist = new List<Song>();
        }
    } 
}
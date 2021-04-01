using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MusicShopLibrary
{
    public class Store
    {
        //jawne prywatne pole typu lista artystów
        private List<Artist> _artists;
        public List<Artist> Artists
        {
            get { return _artists; }
            set { _artists = value; }
        }

        //jawne prywatne pole typu lista albumów
        private List<Album> _albums;
        public List<Album> Albums
        {
            get { return _albums; }
            set { _albums = value; }
        }

        private string _Imie;
        public string Imie
        {
            get { return _Imie; }
            set { _Imie = value; }
        }

        //konstruktor do stringa oraz listy
        public Store()
        {
            Imie = "JANUSZ KOWALSKI";
            Artists = new List<Artist>();//inicjacja listy obiektow Artists
            Albums = new List<Album>();//inicjacja listy obiektow Albums
            //empty comment
        }
    }
}
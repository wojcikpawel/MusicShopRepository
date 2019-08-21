using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopLibrary
{
    interface Iinterfejs
    {
        //List<Artist> = new List<Artist>();

    }

    struct struktura
    {
        //List<Artist> = new List<Artist>();
    }
    public class Artist
    {
        //List<Artist> = new List<Artist>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public double Comission { get; set; }
        public decimal Cash { get; set; }
        
        //wlasciwosc z akcesorem get
        public string ShowPersonalData
        {
            get { return string.Format("{0} {1} - {2: 0.00} PLN", FirstName, LastName, Cash); }
            
        }
        
        //konstruktor
        public Artist()
        {
            Comission = 0.5;
        }
    }
}
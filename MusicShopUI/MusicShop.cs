using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicShopLibrary;
using WMPLib;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;



using System.Media;
namespace MusicShopUI
{
    public partial class MusicShop : Form
    {
        
        private Store store = new Store();
        Album album = new Album();
        private List<Album> shoppingCartData = new List<Album>();
        private List<Album> purchasedAlbumsData = new List<Album>();

        BindingSource albumsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource artistsBinding = new BindingSource();
        BindingSource purchasedAlbumsBinding = new BindingSource();//to chyba niepotrzebne

        BindingSource playlistBinding = new BindingSource();//potrzebne

        private decimal storeProfit = 0;
        private int numberus;
        public  PlaylistForm playlistform = new PlaylistForm();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        
        //konstruktor
        public MusicShop()
        {
            //test comment
            InitializeComponent();
            SetupData();

            //linkowanie/bindowanie List<Album> Albums z albumsListbox
            albumsBinding.DataSource = store.Albums;// Where(x=> x.Sold == false).ToList();
            albumsListbox.DataSource = albumsBinding;

            albumsListbox.DisplayMember = "ShowStoreAlbums";//nazwa właściwości, w którym znajduja się własciwosci ktore chce wyswietlisc w listboxie
            albumsListbox.ValueMember = "ShowStoreAlbums";

            //linkowanie/bindowanie List<Album> shoppingCartData z shoppingCartListbox
            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "ShowStoreAlbums";
            shoppingCartListbox.ValueMember = "ShowStoreAlbums";
            
            //linkowanie/bindowanie List<Artist> Artists z artistsListbox
            artistsBinding.DataSource = store.Artists;
            artistsListbox.DataSource = artistsBinding;

            artistsListbox.DisplayMember = "ShowPersonalData";
            artistsListbox.ValueMember = "ShowPersonalData";

            //linkowanie/bindowanie List<Album> Albums z purchasedAlbumsListbox
            /*do wyrzucenia
            purchasedAlbumsBinding.DataSource = shoppingCartData;
            purchasedAlbumsListbox.DataSource = purchasedAlbumsBinding;

            purchasedAlbumsListbox.DisplayMember = "ShowToPurchasedAlbums";
            purchasedAlbumsListbox.ValueMember = "ShowToPurchasedAlbums";
            */
            backToStore.Enabled = false;
            makePurchase.Enabled = false;
            buttonCreatePDF.Enabled = false;
            artistsListbox.ClearSelected();
        }

        public void SetupData()
        {
            /*
            Artist artist = new Artist();
            artist.FirstName = "Filip";
            artist.LastName = "Szcześniak";
            artist.Alias = "Taco Hemingway";
            artist.Comission = .5;
            */

            // All Artists
            store.Artists.Add(new Artist { FirstName = "Filip", LastName = "Szcześniak", Alias = "Taco", Comission = .3 });
            store.Artists.Add(new Artist { FirstName = "Michał", LastName = "Łaszkiewicz", Alias = "W.E.N.A.", Comission = .3});

           // store.Artists.Add(new Artist { FirstName = "Dawid", LastName = "Podsiadło", Alias = "David Ross" });

            store.Artists.Add(new Artist { FirstName = "Damon", LastName = "Albarn", Alias = "Gorillaz", Comission = .5});
            store.Artists.Add(new Artist { FirstName = "Hans", LastName = "Zimmer", Alias = "Hans Zimmer", Comission = .5});

            // All Albums
            store.Albums.Add(new Album { Performer = store.Artists[0], Title = "Young Hems", Price = 39.99M });
            store.Albums.Add(new Album { Performer = store.Artists[0], Title = "Trójkąt Warszawski", Price = 49.99M });
            store.Albums.Add(new Album { Performer = store.Artists[1], Title = "Monochromy", Price = 39.99M });
            store.Albums.Add(new Album { Performer = store.Artists[1], Title = "Złe Towarzystwo", Price = 39.99M });

           // store.Albums.Add(new Album { Performer = store.Artists[2], Title = "Małomiasteczkowy", Price = 59.99M });
            store.Albums.Add(new Album { Performer = store.Artists[2], Title = "Plastic Beach", Price = 49.99M });

            store.Albums.Add(new Album { Performer = store.Artists[3], Title = "Interstellar", Price = 39.99M });

            // Young Hems playlist
            album.YoungHemsPlaylist.Add(new Song { Number = 1, Title = "Fuck Your List", Lenght = new TimeSpan(0,03,21), PremiereYear = 2013 });
            album.YoungHemsPlaylist.Add(new Song { Number = 2, Title = "Listening To Arctic Monkeys", Lenght = new TimeSpan(0,03,18), PremiereYear = 2013 });
            album.YoungHemsPlaylist.Add(new Song { Number = 3, Title = "22", Lenght = new TimeSpan(0, 01, 48), PremiereYear = 2013 });
            album.YoungHemsPlaylist.Add(new Song { Number = 4, Title = "Blueberries", Lenght = new TimeSpan(0, 03, 48), PremiereYear = 2013 });
            album.YoungHemsPlaylist.Add(new Song { Number = 5, Title = "Luck", Lenght = new TimeSpan(0, 02, 49), PremiereYear = 2013 });
            album.YoungHemsPlaylist.Add(new Song { Number = 6, Title = "Normal Man Pop Vulture", Lenght = new TimeSpan(0, 03, 31), PremiereYear = 2013 });
            album.YoungHemsPlaylist.Add(new Song { Number = 7, Title = "Halle Berry", Lenght = new TimeSpan(0, 03, 18), PremiereYear = 2013 });
            album.YoungHemsPlaylist.Add(new Song { Number = 8, Title = "Chewbacca", Lenght = new TimeSpan(0, 04, 09), PremiereYear = 2013 });

            // Trójkąt Warszawski playlist
            album.TrojkatWarszawskiPlaylist.Add(new Song { Number = 1, Title = "Szlugi i kalafiory", Lenght = new TimeSpan(0,03,06), PremiereYear = 2014 });
            album.TrojkatWarszawskiPlaylist.Add(new Song { Number = 2, Title = "Marsz, marsz", Lenght = new TimeSpan(0,03,50), PremiereYear = 2014 });
            album.TrojkatWarszawskiPlaylist.Add(new Song { Number = 3, Title = "Wszystko jedno", Lenght = new TimeSpan(0, 05, 10), PremiereYear = 2014 });
            album.TrojkatWarszawskiPlaylist.Add(new Song { Number = 4, Title = "Trójkąt", Lenght = new TimeSpan(0, 05, 26), PremiereYear = 2014 });
            album.TrojkatWarszawskiPlaylist.Add(new Song { Number = 5, Title = "(przerywnik)", Lenght = new TimeSpan(0, 02, 12), PremiereYear = 2014 });
            album.TrojkatWarszawskiPlaylist.Add(new Song { Number = 6, Title = "Mięso", Lenght = new TimeSpan(0, 04, 17), PremiereYear = 2014 });
            album.TrojkatWarszawskiPlaylist.Add(new Song { Number = 7, Title = "900729", Lenght = new TimeSpan(0, 05, 04), PremiereYear = 2014 });

            // Monochromy playlist
            album.MonochromyPlaylist.Add(new Song { Number = 1, Title = "Otis", Lenght = new TimeSpan(0, 03, 22), PremiereYear = 2015 });
            album.MonochromyPlaylist.Add(new Song { Number = 2, Title = "Taniec ryzyka", Lenght = new TimeSpan(0, 04, 0), PremiereYear = 2015 });
            album.MonochromyPlaylist.Add(new Song { Number = 3, Title = "Tylko jeden", Lenght = new TimeSpan(0, 02, 32), PremiereYear = 2015 });
            album.MonochromyPlaylist.Add(new Song { Number = 4, Title = "Od wiernej", Lenght = new TimeSpan(0, 03, 0), PremiereYear = 2015 });
            album.MonochromyPlaylist.Add(new Song { Number = 5, Title = "Spróbuj", Lenght = new TimeSpan(0, 03, 18), PremiereYear = 2015 });
            album.MonochromyPlaylist.Add(new Song { Number = 6, Title = "Magnolia", Lenght = new TimeSpan(0, 04, 07), PremiereYear = 2015 });
            album.MonochromyPlaylist.Add(new Song { Number = 7, Title = "Lato w mieście", Lenght = new TimeSpan(0, 03, 22), PremiereYear = 2015 });
            album.MonochromyPlaylist.Add(new Song { Number = 8, Title = "PWC", Lenght = new TimeSpan(0, 03, 41), PremiereYear = 2015 });

            // Złe Towarzystwo playlist
            album.ZleTowarzystwoPlaylist.Add(new Song { Number = 1, Title = "Myślę tylko o tym czego nie wiesz", Lenght = new TimeSpan(0, 03, 35), PremiereYear = 2015 });
            album.ZleTowarzystwoPlaylist.Add(new Song { Number = 2, Title = "Pilot", Lenght = new TimeSpan(0, 03, 21), PremiereYear = 2015 });
            album.ZleTowarzystwoPlaylist.Add(new Song { Number = 3, Title = "Shinobi", Lenght = new TimeSpan(0, 03, 34), PremiereYear = 2015 });
            album.ZleTowarzystwoPlaylist.Add(new Song { Number = 4, Title = "Nowy stary ja", Lenght = new TimeSpan(0, 03, 32), PremiereYear = 2015 });
            album.ZleTowarzystwoPlaylist.Add(new Song { Number = 5, Title = "Żadnych", Lenght = new TimeSpan(0, 04, 02), PremiereYear = 2015 });

            // Małomiasteczkowy playlist
            //album.MalomiasteczkowyPlaylist.Add(new Song { Number = 3, Title = "Małomiasteczkowy", Lenght = new TimeSpan(0,04,01), PremiereYear = 2018 });

            // Plastic Beach playlist
            album.PlasticBeachPlaylist.Add(new Song { Number = 1, Title = "Orchestral Intro", Lenght = new TimeSpan(0,01,09), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 2, Title = "Welcome To The Plastic Beach", Lenght = new TimeSpan(0,03, 32), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 3, Title = "White Flag", Lenght = new TimeSpan(0, 03, 41), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 4, Title = "Rhinestone Eyes", Lenght = new TimeSpan(0, 03, 18), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 5, Title = "Stylo", Lenght = new TimeSpan(0, 04, 30), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 6, Title = "Superfast Jellyfish", Lenght = new TimeSpan(0, 02, 54), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 7, Title = "Empire Ants", Lenght = new TimeSpan(0, 04, 42), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 8, Title = "Glitter Freeze", Lenght = new TimeSpan(0, 04, 00), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 9, Title = "Some Kind Of Nature", Lenght = new TimeSpan(0, 02, 58), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 10, Title = "On Melancholy Hill", Lenght = new TimeSpan(0, 03, 48), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 11, Title = "Broken", Lenght = new TimeSpan(0, 03, 15), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 12, Title = "Sweepstakes", Lenght = new TimeSpan(0, 05, 20), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 13, Title = "Plastic Beach", Lenght = new TimeSpan(0, 03, 47), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 14, Title = "To Binge", Lenght = new TimeSpan(0, 03, 57), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 15, Title = "Cloud Of Unknowing", Lenght = new TimeSpan(0, 03, 07), PremiereYear = 2010 });
            album.PlasticBeachPlaylist.Add(new Song { Number = 16, Title = "Pirate Jet", Lenght = new TimeSpan(0, 02, 25), PremiereYear = 2010 });

            // Interstellar playlist
            album.InterstellarPlaylist.Add(new Song { Number = 1, Title = "Dreaming of the Crash", Lenght = new TimeSpan(0, 03, 55), PremiereYear = 2014 });
            album.InterstellarPlaylist.Add(new Song { Number = 2, Title = "Cornfield Chase", Lenght = new TimeSpan(0, 02, 07), PremiereYear = 2014 });
            album.InterstellarPlaylist.Add(new Song { Number = 3, Title = "Dust", Lenght = new TimeSpan(0, 05, 47), PremiereYear = 2014 });
            album.InterstellarPlaylist.Add(new Song { Number = 4, Title = "Day One", Lenght = new TimeSpan(0, 03, 27), PremiereYear = 2014 });
            album.InterstellarPlaylist.Add(new Song { Number = 5, Title = "Stay", Lenght = new TimeSpan(0, 06, 05), PremiereYear = 2014 });
            album.InterstellarPlaylist.Add(new Song { Number = 6, Title = "Message from Home", Lenght = new TimeSpan(0, 01, 40), PremiereYear = 2014 });
            album.InterstellarPlaylist.Add(new Song { Number = 7, Title = "The Wormhole", Lenght = new TimeSpan(0, 01, 30), PremiereYear = 2014 });
            album.InterstellarPlaylist.Add(new Song { Number = 8, Title = "Mountains", Lenght = new TimeSpan(0, 03, 39), PremiereYear = 2014 });
            album.InterstellarPlaylist.Add(new Song { Number = 9, Title = "Afraid of Time", Lenght = new TimeSpan(0, 02, 32), PremiereYear = 2014 });
            album.InterstellarPlaylist.Add(new Song { Number = 10, Title = "A Place Among the Stars", Lenght = new TimeSpan(0, 03, 27), PremiereYear = 2014 });
            album.InterstellarPlaylist.Add(new Song { Number = 11, Title = "Running Out", Lenght = new TimeSpan(0, 01, 57), PremiereYear = 2014 });
            album.InterstellarPlaylist.Add(new Song { Number = 12, Title = "I'm Going Home", Lenght = new TimeSpan(0, 05, 48), PremiereYear = 2014 });


        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = (Album)albumsListbox.SelectedItem;
            shoppingCartData.Add(selectedAlbum);//dodanie do listy zaznaczonego elementu
            albumsBinding.Remove(selectedAlbum);

            cartBinding.ResetBindings(false);

            if(store.Albums.Count == 0) AddToCart.Enabled = false;
            //AKTYWOWANIE PRZYCISKU PURCHASE ORAZ BACK TO STORE
            //po nacisnieciu przycisku Add To Cart sprawdzam czy lista shoppingCartData jest pusta
            if (shoppingCartData.Count == 1)
            {
                backToStore.Enabled = true;
                makePurchase.Enabled = true;
            }

            //make sound effect of button 'Add'
            SoundPlayer splayer = new SoundPlayer(@"C:\Repos\wojcikpawel\MusicShopRepository\Resources\sndAddToCart.wav");
            splayer.Play();
        }

        public void makePurchase_Click(object sender, EventArgs e)
        {
            foreach (Album i in shoppingCartData)
            {
                i.Sold = true;
                i.Performer.Cash += (decimal)i.Performer.Comission * i.Price;
                storeProfit += (1 - (decimal)i.Performer.Comission) * i.Price;
                purchasedAlbumsData.Add(i);

                //form2.purchasedAlbumsListboxTest.Items.Add(i.ShowToPurchasedAlbums);
                //form2.purchasedAlbumsListboxTest.Items.Add(i.ShowStoreAlbums);
                //playlistform.purchasedAlbumsListboxTest.Items.Add(i.ShowToPurchasedAlbums);
                //playlistform.purchasedAlbumsListboxTest.Items.Add(i.ShowStoreAlbums);

                purchasedAlbumsListbox.Items.Add(i.ShowToPurchasedAlbums);

            }
            //wyslanie zakupionych albumow do drugiej listy PurchasedAlbumsListbox
            //tutaj chcialem zeby wszystkie elementy z koszyka przechodzily na raz a nie pojedynczo zaznaczone

            purchasedAlbumsBinding.ResetBindings(false);
            shoppingCartData.Clear();

            storeProfitValue.Text = string.Format("{0:0.00} PLN", storeProfit);

            cartBinding.ResetBindings(false);
            albumsBinding.ResetBindings(false);
            artistsBinding.ResetBindings(false);

            //DEZAKTYWOWANIE PRZYCISKU BACK TO STORE ORAZ PURCHASE
            //po nacisnieciu przycisku Purchase sprawdzam czy lista shoppingCartData jest pusta
            if (shoppingCartData.Count == 0)
            {
                backToStore.Enabled = false;
                makePurchase.Enabled = false;
            }
            artistsListbox.ClearSelected();

            if(purchasedAlbumsData.Count !=0)
            {
                buttonCreatePDF.Enabled = true;
            }

            //make sound effect of button 'Purchase'
            SoundPlayer splayer = new SoundPlayer(@"C:\Repos\wojcikpawel\MusicShopRepository\Resources\sndPurchase.wav");
            splayer.Play();

        }

        private void BackToStore_Click(object sender, EventArgs e)
        {
            numberus = shoppingCartData.Count;
            numberus--;

            //AKTYWOWANIE PRZYCISKU ADD TO CART
            //po nacisnieciu przycisku Back to store sprawdzam czy lista storeAlbums ma posiada elementy
            if (store.Albums.Count >= 0)
            {
                AddToCart.Enabled = true;
            }

            //DEZAKTYWOWANIE PRZYCISKU BACK TO STORE ORAZ PURCHASE 
            //po nacisnieciu przycisku Back To Store sprawdzam czy lista shoppingCartData jest pusta
            if(numberus == 0)
            {
                backToStore.Enabled = false;
                makePurchase.Enabled = false;
            }

            Album selectedAlbum = (Album)shoppingCartListbox.SelectedItem;
            store.Albums.Add(selectedAlbum);
            cartBinding.Remove(selectedAlbum);

            albumsBinding.ResetBindings(false);

            //make sound effect of button 'Back'
            SoundPlayer splayer = new SoundPlayer(@"C:\Repos\wojcikpawel\MusicShopRepository\Resources\sndBackToStore.wav");
            splayer.Play();
        }

        private void purchasedAlbumsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ToString bardzo pomocna metoda :))))
            switch(purchasedAlbumsListbox.SelectedItem.ToString())
            {
                case "Taco - Young Hems":
                    younghemsPictureBox.Visible = true;
                    trojkatwarszawskiPictureBox.Visible = false;
                    monochromyPictureBox.Visible = false;
                    zletowarzystwoPictureBox.Visible = false;
                    plasticBeachPictureBox.Visible = false;
                    interstellarPictureBox.Visible = false;

                    //linkowanie/bindowanie List<Song> YoungHemsPlaylist z playlistListbox
                    playlistBinding.DataSource = album.YoungHemsPlaylist;
                    playlistListBox.DataSource = playlistBinding;

                    playlistListBox.DisplayMember = "ShowPlaylistData";
                    playlistListBox.ValueMember = "ShowPlaylistData";
                    playlistListBox.ClearSelected();//odznacza dany item w listboxie
                    break;
                case "Taco - Trójkąt Warszawski":
                    trojkatwarszawskiPictureBox.Visible = true;
                    younghemsPictureBox.Visible = false;
                    monochromyPictureBox.Visible = false;
                    zletowarzystwoPictureBox.Visible = false;
                    plasticBeachPictureBox.Visible = false;
                    interstellarPictureBox.Visible = false;

                    //linkowanie/bindowanie List<Song> TrojkatWarszawskiPlaylist z playlistListbox
                    playlistBinding.DataSource = album.TrojkatWarszawskiPlaylist;
                    playlistListBox.DataSource = playlistBinding;

                    playlistListBox.DisplayMember = "ShowPlaylistData";
                    playlistListBox.ValueMember = "ShowPlaylistData";
                    playlistListBox.ClearSelected();//odznacza dany item w listboxie
                    break;
                case "W.E.N.A. - Monochromy":
                    monochromyPictureBox.Visible = true;
                    younghemsPictureBox.Visible = false;
                    trojkatwarszawskiPictureBox.Visible = false;
                    zletowarzystwoPictureBox.Visible = false;
                    plasticBeachPictureBox.Visible = false;
                    interstellarPictureBox.Visible = false;

                    //linkowanie/bindowanie List<Song> MonochromyPlaylist z playlistListbox
                    playlistBinding.DataSource = album.MonochromyPlaylist;
                    playlistListBox.DataSource = playlistBinding;

                    playlistListBox.DisplayMember = "ShowPlaylistData";
                    playlistListBox.ValueMember = "ShowPlaylistData";
                    playlistListBox.ClearSelected();//odznacza dany item w listboxie
                    break;
                case "W.E.N.A. - Złe Towarzystwo":
                    zletowarzystwoPictureBox.Visible = true;
                    younghemsPictureBox.Visible = false;
                    trojkatwarszawskiPictureBox.Visible = false;
                    monochromyPictureBox.Visible = false;
                    plasticBeachPictureBox.Visible = false;
                    interstellarPictureBox.Visible = false;

                    //linkowanie/bindowanie List<Song> ZleTowarzystwoPlaylist z playlistListbox
                    playlistBinding.DataSource = album.ZleTowarzystwoPlaylist;
                    playlistListBox.DataSource = playlistBinding;

                    playlistListBox.DisplayMember = "ShowPlaylistData";
                    playlistListBox.ValueMember = "ShowPlaylistData";
                    playlistListBox.ClearSelected();//odznacza dany item w listboxie
                    break;
                    /*
                case "David Ross - Małomiasteczkowy":
                    zletowarzystwoPictureBox.Visible = false;
                    younghemsPictureBox.Visible = false;
                    trojkatwarszawskiPictureBox.Visible = false;
                    monochromyPictureBox.Visible = false;
                    plasticBeachPictureBox.Visible = false;
                    interstellarPictureBox.Visible = false;

                    //linkowanie/bindowanie List<Song> ZleTowarzystwoPlaylist z playlistListbox
                    playlistBinding.DataSource = album.MalomiasteczkowyPlaylist;
                    playlistListBox.DataSource = playlistBinding;

                    playlistListBox.DisplayMember = "ShowPlaylistData";
                    playlistListBox.ValueMember = "ShowPlaylistData";
                    playlistListBox.ClearSelected();//odznacza dany item w listboxie
                    break;
                    */
                case "Gorillaz - Plastic Beach":
                    plasticBeachPictureBox.Visible = true;
                    zletowarzystwoPictureBox.Visible = false;
                    younghemsPictureBox.Visible = false;
                    trojkatwarszawskiPictureBox.Visible = false;
                    monochromyPictureBox.Visible = false;
                    interstellarPictureBox.Visible = false;
 
                    //linkowanie/bindowanie List<Song> ZleTowarzystwoPlaylist z playlistListbox
                    playlistBinding.DataSource = album.PlasticBeachPlaylist;
                    playlistListBox.DataSource = playlistBinding;

                    playlistListBox.DisplayMember = "ShowPlaylistData";
                    playlistListBox.ValueMember = "ShowPlaylistData";
                    playlistListBox.ClearSelected();//odznacza dany item w listboxie
                    break;

                case "Hans Zimmer - Interstellar":
                    interstellarPictureBox.Visible = true;
                    plasticBeachPictureBox.Visible = false;
                    zletowarzystwoPictureBox.Visible = false;
                    younghemsPictureBox.Visible = false;
                    trojkatwarszawskiPictureBox.Visible = false;
                    monochromyPictureBox.Visible = false;

                    //linkowanie/bindowanie List<Song> ZleTowarzystwoPlaylist z playlistListbox
                    playlistBinding.DataSource = album.InterstellarPlaylist;
                    playlistListBox.DataSource = playlistBinding;

                    playlistListBox.DisplayMember = "ShowPlaylistData";
                    playlistListBox.ValueMember = "ShowPlaylistData";
                    playlistListBox.ClearSelected();//odznacza dany item w listboxie
                    break;

            }
            //PROBLEM: W przypadku gdy konsument zakupi w określonej kolejności(po kolei) albumy wszystko jest ok.
            //Problem w tym, że konsument może dokonać zakupu w róznej konfiguracji tudzież kolejności. Podejrzewam, że
            //potrzebuje stworzyć nową właściwość do listy albumow 'cover'.

        }

        private void play_Click(object sender, EventArgs e)
        {
            //wiem masakryczne rozwiązanie, można to 100x lepiej napisać, ale przynajmniej działa :D
            //1. zbyt dużo linijek kodu, 2. nie szanuje pamięci, bo za dużo ifów

            //może kiedyś wrócę tutaj, żeby rozwiązać to w inny sposób
            //na pewno kiedyś z tego będę miał beke :D - patrz poniżej potężny swich-case :D


            try
            {
                switch (purchasedAlbumsListbox.SelectedItem.ToString())
                {
                    case "Taco - Young Hems":
                        if (playlistListBox.SelectedIndex == 0)
                        {
                            //W razie potrzeby zmienić ścieżkę
                            //MessageBox.Show("gramy 1. utwor z YH");
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Young Hems EP - (2013) - 26 grudnia\01 Fuck Your List.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 1)
                        {
                            //MessageBox.Show("gramy 2. utwor z YH");
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Young Hems EP - (2013) - 26 grudnia\02 Listening To Arctic Monkeys.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 2)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Young Hems EP - (2013) - 26 grudnia\03 22.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 3)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Young Hems EP - (2013) - 26 grudnia\04 Blueberries.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 4)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Young Hems EP - (2013) - 26 grudnia\05 Luck.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 5)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Young Hems EP - (2013) - 26 grudnia\06 Normal Man Pop Vulture.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 6)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Young Hems EP - (2013) - 26 grudnia\07 Halle Berry.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 7)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Young Hems EP - (2013) - 26 grudnia\08 Chewbacca.mp3";
                            player.controls.play();
                        }
                        break;
                    case "Taco - Trójkąt Warszawski":
                        if (playlistListBox.SelectedIndex == 0)
                        {
                            //MessageBox.Show("gramy 1. utwor z TW");
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Trójkąt Warszawski EP - (2014) - 19 grudnia\01 Szlugi i kalafiory.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 1)
                        {
                            //MessageBox.Show("gramy 2. utwor z TW");
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Trójkąt Warszawski EP - (2014) - 19 grudnia\02 Marsz, marsz.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 2)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Trójkąt Warszawski EP - (2014) - 19 grudnia\03 Wszystko jedno.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 3)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Trójkąt Warszawski EP - (2014) - 19 grudnia\04 Trójkąt.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 4)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Trójkąt Warszawski EP - (2014) - 19 grudnia\05 (przerywnik).mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 5)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Trójkąt Warszawski EP - (2014) - 19 grudnia\06 Mięso.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 6)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Taco Hemingway - Trójkąt Warszawski EP - (2014) - 19 grudnia\07 900729.mp3";
                            player.controls.play();
                        }
                        break;
                    case "W.E.N.A. - Monochromy":
                        if (playlistListBox.SelectedIndex == 0)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\W.E.N.A - Monochromy EP - (2015) - 11 maja\01 Otis.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 1)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\W.E.N.A - Monochromy EP - (2015) - 11 maja\02 Taniec ryzyka.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 2)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\W.E.N.A - Monochromy EP - (2015) - 11 maja\03 Tylko jeden.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 3)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\W.E.N.A - Monochromy EP - (2015) - 11 maja\04 Od wiernej.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 4)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\W.E.N.A - Monochromy EP - (2015) - 11 maja\05 Spróbuj.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 5)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\W.E.N.A - Monochromy EP - (2015) - 11 maja\06 Magnolia.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 6)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\W.E.N.A - Monochromy EP - (2015) - 11 maja\07 Lato w mieście.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 7)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\W.E.N.A - Monochromy EP - (2015) - 11 maja\BONUS PWC.mp3";
                            player.controls.play();
                        }
                        break;
                    case "W.E.N.A. - Złe Towarzystwo":
                        if (playlistListBox.SelectedIndex == 0)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\SARIUS x W.E.N.A - Złe Towarzystwo EP - (2015) - 23 marca\01 Myślę tylko o tym czego nie wiesz.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 1)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\SARIUS x W.E.N.A - Złe Towarzystwo EP - (2015) - 23 marca\02 Pilot.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 2)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\SARIUS x W.E.N.A - Złe Towarzystwo EP - (2015) - 23 marca\03 Shinobi.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 3)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\SARIUS x W.E.N.A - Złe Towarzystwo EP - (2015) - 23 marca\04 Nowy stary ja.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 4)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\SARIUS x W.E.N.A - Złe Towarzystwo EP - (2015) - 23 marca\05 Żadnych.mp3";
                            player.controls.play();
                        }
                        break;

                    case "David Ross - Małomiasteczkowy":
                        if(playlistListBox.SelectedIndex==0)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\David Ross - Małomiasteczkowy - (2018)\3.Małomiasteczkowy.mp3";
                            player.controls.play();
                        }
                        break;

                    case "Gorillaz - Plastic Beach":
                        if(playlistListBox.SelectedIndex == 0)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\1.Orchestral Intro.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 1)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\2.Welcome To The World Of The Plastic Beach.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 2)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\3.White Flag.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 3)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\4.Rhinestone Eyes.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 4)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\5.Stylo.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 5)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\6.Superfast Jellyfish.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 6)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\7.Empire Ants.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 7)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\8.Glitter Freeze.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 8)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\9.Some Kind Of Nature.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 9)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\10.On Melancholy Hill.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 10)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\11.Broken.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 11)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\12.Sweepstakes.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 12)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\13.Plastic Beach.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 13)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\14.To Binge.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 14)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\15.Cloud Of Unknowing.mp3";
                            player.controls.play();
                        }
                        else if (playlistListBox.SelectedIndex == 15)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Gorillaz - Plastic Beach - (2010)\16.Pirate Jet.mp3";
                            player.controls.play();
                        }
                        break;

                    case "Hans Zimmer - Interstellar":
                        if (playlistListBox.SelectedIndex == 0)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\1.Dreaming of the Crash.mp3";
                            player.controls.play();
                        }
                        if (playlistListBox.SelectedIndex == 1)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\2.Cornfield Chase.mp3";
                            player.controls.play();
                        }
                        if (playlistListBox.SelectedIndex == 2)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\3.Dust.mp3";
                            player.controls.play();
                        }
                        if (playlistListBox.SelectedIndex == 3)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\4.Day One.mp3";
                            player.controls.play();
                        }
                        if (playlistListBox.SelectedIndex == 4)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\5.Stay.mp3";
                            player.controls.play();
                        }
                        if (playlistListBox.SelectedIndex == 5)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\6.Message from Home.mp3";
                            player.controls.play();
                        }
                        if (playlistListBox.SelectedIndex == 6)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\7.The Wormhole.mp3";
                            player.controls.play();
                        }
                        if (playlistListBox.SelectedIndex == 7)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\8.Mountains.mp3";
                            player.controls.play();
                        }
                        if (playlistListBox.SelectedIndex == 8)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\9.Afraid of Time.mp3";
                            player.controls.play();
                        }
                        if (playlistListBox.SelectedIndex == 9)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\10.A Place Among the Stars.mp3";
                            player.controls.play();
                        }
                        if (playlistListBox.SelectedIndex == 10)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\11.Running Out.mp3";
                            player.controls.play();
                        }
                        if (playlistListBox.SelectedIndex == 11)
                        {
                            player.URL = @"C:\Users\Paweł Wójcik\Music\Hans Zimmer - Interstellar (2014)\12.I'm Going Home.mp3";
                            player.controls.play();
                        }
                        break;
                }

            }catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Brak utworów do odtworzenia");
            }
            
            /*
            if(playlistListBox.Text == "1. Fuck Your List 2013")//jezeli zaznaczony jest taki string to graj taki utwór itd.
            {
                MessageBox.Show("gramy utwor 1. z albumu Young Hems");
            }
            else if(playlistListBox.Text == "2. Listening To Arctic Monkeys 2013")
            {
                MessageBox.Show("gramy utwor 2. z albumu Young Hems");
            }
            */
        }

        private void stop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void buttonCreatePDF_Click(object sender, EventArgs e)
        {
            /*
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("This is my kurde first line of paragraph!");
            Paragraph para = new Paragraph("ELLOO");
            List lista = new List(true, 20);
            lista.Add("One");
            lista.Add("Two");
            lista.Add("Three");

            doc.Add(lista);
            doc.Add(paragraph);
            doc.Add(para);
            doc.Close();
            */

            //odkomentować1// Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);

            //odkomentować2// PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Albums.pdf", FileMode.Create));
            //odkomentować3// doc.Open();

            //Sposób 1

            // BaseFont czcionkaDoKonwertowania = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250 ,BaseFont.CACHED);
            // iTextSharp.text.Font f = new iTextSharp.text.Font(czcionkaDoKonwertowania, 72);
            // Paragraph para1 = new Paragraph("This is my kurde first line of paragraph! zażółć gęslą jaźń", f);


            //odkomentować4// BaseFont czciosnkaKonwert = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.CACHED);
            //odkomentować5// iTextSharp.text.Font font = new iTextSharp.text.Font(czciosnkaKonwert, 28);
            //odkomentować6// Paragraph para2 = new Paragraph("Your list of albums purchased: ", font);
            //odkomentować7// doc.Add(para2);
            // FontFactory.RegisterDirectory(@"C:\font");
            // FontFactory.GetFont("arial");

            

            
            //BaseFont base = BaseFont.createFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            //Font myFont = new Font(base, 16, Font.NORMAL);
            //cell = new PdfPCell(new Phrase("Śćźół:", myFont));

            //BaseFont font= BaseFont.createFont("assets/fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            /*
            foreach (var htmlElement in parsedHtmlElements)

            {

                BaseFont arial = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\arial.ttf", "iso-8859-2", BaseFont.EMBEDDED);

                iTextSharp.text.Font font = new iTextSharp.text.Font(arial, 10);

                //i tutaj się pojawił problem jak zrobić coś takiego:
                // //document.Add(new Paragraph(htmlElement), font));
                // bo zamiast htmlElement ma być typ string
            }
            */

            //w pętli foreach
            /*
            foreach(int i in purchasedAlbumsListbox.Items)
            {
                BaseFont czcionkaDoKonwertowania = BaseFont.CreateFont(@"C:\arial.tff", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font f = new iTextSharp.text.Font(czcionkaDoKonwertowania, 10);
            }
            */

            //doc.Add(para1);
          
            
            //create SaveDialog
            var safeFileDialog = new SaveFileDialog();
            safeFileDialog.FileName = "albums";
            safeFileDialog.DefaultExt = ".pdf";
            if(safeFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(safeFileDialog.FileName, FileMode.Create))
                {
                    Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);

                    PdfWriter wri = PdfWriter.GetInstance(doc, stream);
                    //opening document pdf very important
                    doc.Open();

                    //Sposób 1

                    // BaseFont czcionkaDoKonwertowania = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250 ,BaseFont.CACHED);
                    // iTextSharp.text.Font f = new iTextSharp.text.Font(czcionkaDoKonwertowania, 72);
                    // Paragraph para1 = new Paragraph("This is my kurde first line of paragraph! zażółć gęslą jaźń", f);


                    BaseFont czciosnkaKonwert = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.CACHED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(czciosnkaKonwert, 28);
                    Paragraph para2 = new Paragraph("Your list of albums purchased: ", font);
                    doc.Add(para2);
                    //doc.Close();
                    // FontFactory.RegisterDirectory(@"C:\font");
                    // FontFactory.GetFont("arial");
                    
                    foreach (string item in purchasedAlbumsListbox.Items)
                    {
                        BaseFont czcionkaDoKonwertowania = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.CACHED);
                        iTextSharp.text.Font f = new iTextSharp.text.Font(czcionkaDoKonwertowania, 20);
                        Paragraph paragraffff = new Paragraph(item, f);
                        doc.Add(paragraffff);
                    }
                    
                    //closing document pdf very important
                    doc.Close();
                    stream.Close();
                }
            }

            try
            {
                //doc.Close();
            }
            catch (IOException ex)
            {

                MessageBox.Show(ex.Message);
            }

            //make sound effect of button 'Export'
            SoundPlayer splayer = new SoundPlayer(@"C:\Repos\wojcikpawel\MusicShopRepository\Resources\sndExportToPdf.wav");
            splayer.Play();
            MessageBox.Show("The PDF file was created successfully!");

            
            

        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            Visible = true;
        }
        */


        private void MusicShop_Load(object sender, EventArgs e)
        {
           
        }

        private void nextWindowFormBtn_Click(object sender, EventArgs e)
        {
            //Form1 windowform1 = new Form1();
            //this.Hide();
            // Playlist windowformPlaylist = new Playlist();
            // windowformPlaylist.Show();

            //this.Hide();//też działa
            Visible = false;
            PlaylistForm playlistform = new PlaylistForm();
            playlistform.Show();
        }
    }
}
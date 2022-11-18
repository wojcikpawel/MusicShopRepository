using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Cs_03_baza_danych_sqlite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //zmienne pomocnicze
        public string path = null;                  //zmienna przechowująca lokalizację bazy danych
        public SQLiteConnection db_connect;         //zmienna przechowująca obiekt bazy danych
        public string db_querry = null;             //zmienna przechowująca zapytanie do bazy danych
        public SQLiteCommand db_command;            //zmienna przechowująca obiekt do wysyłania zapytań
        public SQLiteDataReader db_read;            //zmienna przechowująca dane z zapytania odczytującego

        public bool bool_read = false;              //czy zaczęto odczytywać jakieś dane

        //załadowanie formatki
        private void Form1_Load(object sender, EventArgs e)
        {
            //dezaktywacja przycisków
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;

            //aktywacja przycisków
            button2.Enabled = true;
            button3.Enabled = true;

            //aktywacja box z nazwą pliku
            textBox1.Enabled = true;
        }

        //przycisk zamknij
        private void button1_Click(object sender, EventArgs e)
        {
            //zamknięcie formatki
            Close();

            //rozłączenie się z bazą danych
            db_connect.Close();
        }

        //przycisk połącz
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //lokalizacja mojego pliku w folderze moje dokumenty
                //do ścieżki 'środowiskowej' moich dokumentów dodawana jest nazwa pliku z textboxa i rozszerzenie - dwa ukośniki bo 1 traktowany jest jako znak specjalny
                path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + textBox1.Text + ".db";
               
                //utworzenie obiektu potrzebnego do połączenia się z bazą, składnia wymagana przez bibliotekę.
                db_connect = new SQLiteConnection("Data Source =" + path + ";Version=3;");
                
                //połączenie się z bazą danych - jeżeli nie ma takiego pliku to go tworzy, ale uwaga - należy po utworzeniu dodać tabelę do bazy danych
                db_connect.Open();

                //aktywacja przycisków
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;

                //dezaktywacja przycisków
                button2.Enabled = false;
                button3.Enabled = false;

                //dezaktywacja box z nazwą pliku
                textBox1.Enabled = false;
            }
            catch(Exception ex)
            {
                //wyświetlenie ewentualnego błędu
                MessageBox.Show(ex.Message);
            }
        }

        //przycisk rozłącz
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //rozłączenie się z bazą danych
                db_connect.Close();

                //dezaktywacja przycisków
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;

                //aktywacja przycisków
                button2.Enabled = true;
                button3.Enabled = true;

                //dezaktywacja box z nazwą pliku
                textBox1.Enabled = true;

                //ustawienie na false zmienna pomocniczą
                bool_read = false;
            }
            catch (Exception ex)
            {
                //wyświetlenie ewentualnego błędu
                MessageBox.Show(ex.Message);
            }
        }

        //utwórz nową bazę danych
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //lokalizacja mojego pliku w folderze moje dokumenty
                //do ścieżki 'środowiskowej' moich dokumentó dodawana jest nazwa pliku z textboxa i rozszerzenie - dwa ukośniki bo 1 traktowany jest jako znak specjalny
                path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + textBox1.Text + ".db";

                //tworzenie nowego pliku i tutaj po tym należy utworzyć tabelę w nowej bazie
                SQLiteConnection.CreateFile(path);

                //utworzenie obiektu potrzebnego do połączenia się z bazą, składnia wymagana przez bibliotekę.
                db_connect = new SQLiteConnection("Data Source =" + path + ";Version=3;");

                //połączenie się z bazą danych - funkcja tworząca nowy plik nie powoduje otwarcia go
                db_connect.Open();

                //utworzenie nowego zapytania dotyczącego utworzenia nowej tabeli w bazie danych
                db_querry = "CREATE TABLE 'Osoby' ( 'Imie' TEXT, 'Nazwisko' TEXT)";

                //utworzenie obiektu który odpowiada za wysyłanie zapytania
                db_command = new SQLiteCommand(db_querry, db_connect);

                //wykonanie/wysłanie zapytania
                db_command.ExecuteNonQuery();

                //zamknięcie połączenia z bazą danych
                db_connect.Close();
            }
            catch(Exception ex)
            {
                //wyświetlenie ewentualnego błędu
                MessageBox.Show(ex.Message);
            }
        }

        //dodaj nowe dane do bazy
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //utworzenie nowego zapytania dodającego nowe dane do bazy
                db_querry = "INSERT INTO 'Osoby' ('Imie', 'Nazwisko') VALUES ('"+ textBox2.Text +"','" + textBox3.Text + "');";

                //utworzenie obiektu który odpowiada za wysyłanie zapytania
                db_command = new SQLiteCommand(db_querry, db_connect);

                //wykonanie/wysłanie zapytania
                db_command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //wyświetlenie ewentualnego błędu
                MessageBox.Show(ex.Message);
            }

        }

        //odczyt danych z bazy danych
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bool_read)
                {
                    //utworzenie nowego zapytania powodującego odczytanie/wyszukanie wszystkich danych z bazy
                    db_querry = "SELECT * FROM 'Osoby'";

                    //utworzenie obiektu który odpowiada za wysyłanie zapytania
                    db_command = new SQLiteCommand(db_querry, db_connect);

                    //wykonanie zapytania odczytującego dane z bazy danych
                    db_read = db_command.ExecuteReader();

                    //odczytywanie danych
                    db_read.Read();                                 //przed pierwszym użyciem też należy użyć funkcji odczytującej dane z bazy
                    label2.Text = db_read["Imie"].ToString();       //odczytywanie dokonuje się poprzez wskazanie nazyw kolumny 
                    label3.Text = db_read[1].ToString();            //bądź poprzez podanie numeru kolumny - liczenie od 0

                    //nastąpił pierwszy odczyt - zmienna pomocnicza, używana w programie - nie związana z działaniem bazy danych
                    bool_read = true;
                }
                else
                {
                    //odczytywanie danych
                    db_read.Read();                                 //przed każdym odczytanie danych, należy użyć funkcji odczytującej dane z bazy

                    //sprawdzenie czy osiągnięto ostatni punkt w bazie danych
                    if (db_read.HasRows)   
                    {
                        label2.Text = db_read["Imie"].ToString();       //odczytywanie dokonuje się poprzez wskazanie nazyw kolumny 
                        label3.Text = db_read[1].ToString();            //bądź poprzez podanie numeru kolumny
                        
                    }
                    else
                    {
                        bool_read = false;      //ponownie wykonaj odczyt
                    }

                }


            }
            catch (Exception ex)
            {
                //wyświetlenie ewentualnego błędu
                MessageBox.Show(ex.Message);
            }
        }

        //usuwanie podanego wpisu
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //sprawdzenie czy textboxy zawierają jakieś dane
                if( ( textBox2.Text == "" ) || ( textBox3.Text == "" ) )
                {   //jak nie to wyświetl komunikat
                    MessageBox.Show("Wpisz Imię i Nazwisko do usunięcia", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    //wyjdź z funkcji obsługi przycisku
                    return;
                }
                else
                {   //jeżeli coś jest to uzupełnij zapytanie

                    //utworzenie nowego zapytania dodającego nowe dane do bazy
                    db_querry = "DELETE FROM 'Osoby' WHERE Imie = '" + textBox2.Text + "' AND Nazwisko ='" + textBox3.Text + "'";
                }


                //utworzenie obiektu który odpowiada za wysyłanie zapytania
                db_command = new SQLiteCommand(db_querry, db_connect);
                //wykonanie zapytania
                db_command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //wyświetlenie ewentualnego błędu
                MessageBox.Show(ex.Message);
            }
        }

    }
}

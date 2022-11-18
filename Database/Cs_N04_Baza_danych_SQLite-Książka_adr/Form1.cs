using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Cs_N04_Baza_danych_SQLite_Książka_adr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //zmienne
        public string dir_fille = null;   //lokalizacji aktualnie otwartej bazy danych na dysku
        public string name_fille = null;    //nazwa pliku
        public SQLiteConnection db_connection;      //utworzenie zmiennej dla nowej bazy danych
        public string sql_querry;           //zmienna do zapytania sql
        public SQLiteCommand command;       //zmienna wysyłania komendy
        public SQLiteDataReader db_read;    //do odczytu

        //zamknięcie programu
        private void zamknijProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //wybór pliku bazy danych - przycisk
        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wyświetlenie okienka wyboru pliku
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //przepisanie z okienka adresu naszego pliku
                    dir_fille = openFileDialog1.FileName;
                    name_fille = openFileDialog1.SafeFileName;

                    //utworzenie nowego obiektu dla naszej bazy
                    db_connection = new SQLiteConnection("Data Source=" + dir_fille + "; Version = 3; ");
                    db_connection.Open();   //otwarcie naszej bazy danych


                    //wypisanie danych z bazy

                    //wyczyszczenie tabeli
                    while (dataGridView1.Rows.Count > 0) { dataGridView1.Rows.RemoveAt(0); }

                    //zapytanie
                    sql_querry = "SELECT * FROM 'Ksiazka adresowa' ";
                    command = new SQLiteCommand(sql_querry, db_connection);

                    db_read = command.ExecuteReader();

                    while (db_read.Read())
                    {
                        dataGridView1.Rows.Add(db_read["Imie"].ToString(), db_read["Nazwisko"].ToString(), db_read["Miejscowosc"].ToString(),db_read["Kod"].ToString(), db_read["Ulica"].ToString(), db_read["Telefon"].ToString());
                    }

                    //numeracja wierszy
                    foreach(DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.HeaderCell.Value = (row.Index + 1).ToString();
                    }

                    //zmiana statusu
                    status_bazy.Text = "Połączono z " + name_fille;

                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
                catch(Exception ex)
                {
                    //wyświetlenie ewentualnego błędu
                    MessageBox.Show(ex.Message);
                    db_connection.Close();          //ewentaulne zamknięcie jeżeli została baza otwarta
                }

            }

        }

        //nowa baza danych
        private void nowaBazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dir_fille = saveFileDialog1.FileName;
                    //SQLiteConnection.CreateFile(dir_fille);       //w taki sposób też można utworzyć nowy plik, ale trzeba zwolnić uchwyt na plik
                    name_fille = System.IO.Path.GetFileName(dir_fille);

                    //utworzenie nowego obiektu dla naszej bazy
                    db_connection = new SQLiteConnection("Data Source =" + dir_fille + ";Version=3;");
                    db_connection.Open();   //otwarcie naszej bazy danych
                                               
                    //utworzenie nowej tabeli w bazie danych
                    sql_querry = "CREATE TABLE 'Ksiazka adresowa' ( 'Imie' TEXT, 'Nazwisko' TEXT, 'Miejscowosc' TEXT, 'Kod' TEXT, 'Ulica' TEXT, 'Telefon' INTEGER)";
                    //utworzenie nowego obiektu dla zapytania
                    command = new SQLiteCommand(sql_querry, db_connection);
                    //wykonanie zapytania
                    command.ExecuteNonQuery();

                    //zmiana statusu
                    status_bazy.Text = "Połączono z " + name_fille;

                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //odłącz bazę danych
        private void odłączBazęDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db_connection.Close();  //zamknięcie dostępu do bazy danych

            //zmiana statusu
            status_bazy.Text = "Rozłączono";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            //wyczyszczenie tabeli
            while (dataGridView1.Rows.Count > 0) { dataGridView1.Rows.RemoveAt(0); }
        }

        //po załadowaniu formatki
        private void Form1_Load(object sender, EventArgs e)
        {
            //zmiana statusu
            status_bazy.Text = "Rozłączono";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            //ustawienie kolumn datagridview
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Imię  ";
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].Name = "Nazwisko  ";
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].Name = "Miejscowowść  ";
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[3].Name = "Kod pocztowy";
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[4].Name = "Ulica, nr domu/mieszkania  ";
            dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[5].Name = "Numer telefonu";
            dataGridView1.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;


        }

        //dodaj nową pozycję
        private void button1_Click(object sender, EventArgs e)
        {
            //sprawdzenie czy jest połączenie z bazą danych
            if(db_connection.State.Equals(ConnectionState.Open))
            {
                try
                {
                    sql_querry = "INSERT INTO 'Ksiazka adresowa' ( 'Imie' , 'Nazwisko' , 'Miejscowosc' , 'Kod' , 'Ulica' , 'Telefon' ) values ('" + textBox1.Text + "','" + textBox2.Text +"','" + textBox3.Text +"','" + textBox4.Text  + "','" + textBox5.Text + "'," + Convert.ToUInt64(textBox6.Text) + ")";
                    //utworzenie nowego obiektu dla zapytania
                    command = new SQLiteCommand(sql_querry, db_connection);
                    //wykonanie zapytania
                    command.ExecuteNonQuery();

                    //dodanie danych do tabeli
                    dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);

                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].HeaderCell.Value = dataGridView1.Rows.Count.ToString();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //usunięcie zaznaczonej komórki
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sql_querry = "DELETE FROM `Ksiazka adresowa` WHERE Imie = '" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString() + "' AND Nazwisko ='" + dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString() + "' AND Telefon ='" + dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString() + "'";
                //utworzenie nowego obiektu dla zapytania
                command = new SQLiteCommand(sql_querry, db_connection);
                //wykonanie zapytania
                command.ExecuteNonQuery();

                //wyczyszczenie tabeli
                while (dataGridView1.Rows.Count > 0) { dataGridView1.Rows.RemoveAt(0); }
                
                //ponowne wypisanie danych z bazy

                //zapytanie
                sql_querry = "SELECT * FROM 'Ksiazka adresowa' ";
                command = new SQLiteCommand(sql_querry, db_connection);

                db_read = command.ExecuteReader();

                while (db_read.Read())
                {
                    dataGridView1.Rows.Add(db_read["Imie"].ToString(), db_read["Nazwisko"].ToString(), db_read["Miejscowosc"].ToString(), db_read["Kod"].ToString(), db_read["Ulica"].ToString(), db_read["Telefon"].ToString());
                }

                //numeracja wierszy
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //wyszukaj podane imiona
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                //wyczyszczenie tabeli
                while (dataGridView1.Rows.Count > 0) { dataGridView1.Rows.RemoveAt(0); }

                //ponowne wypisanie danych z bazy
                //zapytanie
                if (textBox7.Text != "")
                {
                    sql_querry = "SELECT * FROM 'Ksiazka adresowa' WHERE Imie LIKE '" + textBox7.Text + "%'";
                }else
                    sql_querry = "SELECT * FROM 'Ksiazka adresowa'";
                command = new SQLiteCommand(sql_querry, db_connection);

                db_read = command.ExecuteReader();

                while (db_read.Read())
                {
                    dataGridView1.Rows.Add(db_read["Imie"].ToString(), db_read["Nazwisko"].ToString(), db_read["Miejscowosc"].ToString(), db_read["Kod"].ToString(), db_read["Ulica"].ToString(), db_read["Telefon"].ToString());
                }

                //numeracja wierszy
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //jeżeli w textbox od wyszukiwania wciśnięto enter
        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //jeżeli wciśnięto enter
                button2_Click(null, null);
            }
        }

        //informacje o programie
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tworzy nowy obiekt dla nowego okna, którym jest okno informacje
            Form about = new Informacje();
            //wyświetla nowe okno - aktywne jest tylko jedno okno
            about.ShowDialog();
        }

    }
}

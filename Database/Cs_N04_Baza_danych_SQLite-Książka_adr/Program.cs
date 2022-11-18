using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cs_N04_Baza_danych_SQLite_Książka_adr
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

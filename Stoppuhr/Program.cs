using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stoppuhr
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AnzeigeFenster anzeigeFenster = new AnzeigeFenster();
            SteuerungFenster steuerungFenster = new SteuerungFenster(anzeigeFenster);
            anzeigeFenster.Steuerung = steuerungFenster;            
            Application.Run(steuerungFenster);            
        }
    }
}
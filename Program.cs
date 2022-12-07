using System;
using System.Windows.Forms;
using TZCars.db;

namespace TZCars {
    public static class Program {

        public static Form1 MainForm { get; private set; }

        [STAThread]
        static void Main() {
            _ = TZDatabase.SqlCommand; // Load static clause

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(MainForm = new Form1());
        }
    }
}

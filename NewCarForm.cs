using System;
using System.Windows.Forms;

namespace TZCars {
    public partial class NewCarForm : Form {

        public NewCarForm() {
            InitializeComponent();

            evjarat.Value = utolsoMuszaki.Value = evjarat.MaxDate = utolsoMuszaki.MaxDate = DateTime.Now;
        }

        private void ResetProperties() {
            evjarat.Value = utolsoMuszaki.Value = evjarat.MaxDate;
            tulajdonosNeve.Text = markak.Text = "";
            markak.SelectedItem = null;
            addCar.Enabled = false;
        }

        private void cancel_Click(object sender, EventArgs e) {
            Close();
            ResetProperties();
        }

        private void markaTulajChanged(object sender, EventArgs e) {
            addCar.Enabled = rendszam.Text.Trim().Length != 0 && markak.Text.Trim().Length != 0 && tulajdonosNeve.Text.Trim().Length != 0;
        }

        private async void addCar_Click(object sender, EventArgs e) {
            await Program.PerformSqlCommand("insert into `auto` (`rendszam`, `forgalomba`, `tulajdonos`, `utolsomuszaki`, `evjarat`, `marka`) VALUES (@0, @1, @2, @3, @4, @5);",
                rendszam.Text, forgalomba.Checked, tulajdonosNeve.Text, utolsoMuszaki.Value, evjarat.Value, markak.Text);

            Program.MainForm.RefreshGridItems();
            MessageBox.Show("Új autó rögzítve lett", "Autó rögzítése", MessageBoxButtons.OK);

            Close();
            ResetProperties();
        }
    }
}

using System;
using System.Windows.Forms;
using TZCars.db;

namespace TZCars {
    public partial class UpdateCarForm : Form {

        private Car selectedCar;

        public UpdateCarForm() {
            InitializeComponent();
        }

        public void LoadVariables(Car car) {
            selectedCar = car;

            rendszam.Text = car.Rendszam;
            markak.Text = car.Marka;
            tulajdonosNeve.Text = car.Tulajdonos;
            utolsoMuszaki.Value = car.UtolsoMuszaki;
            evjarat.Value = car.Evjarat;
            forgalomba.Checked = car.Forgalomba;
        }

        private void ResetProperties() {
            rendszam.Text = markak.Text = tulajdonosNeve.Text = "";
            utolsoMuszaki.Value = evjarat.Value = evjarat.MaxDate;
            forgalomba.Checked = false;
        }

        private void data_TextChanged(object sender, EventArgs e) {
            modifyCar.Enabled = true;
        }

        private async void modifyCar_Click(object sender, EventArgs e) {
            await TZDatabase.PerformSqlCommand("update `auto` set `rendszam` = @0, `forgalomba` = @1, `tulajdonos` = @2, `utolsomuszaki` = @3, `evjarat` = @4, `marka` = @5 where `id` = @6;",
                rendszam.Text, forgalomba.Checked, tulajdonosNeve.Text, utolsoMuszaki.Value, evjarat.Value, markak.Text, selectedCar.Id);
            Program.MainForm.RefreshGridItems();

            MessageBox.Show("Az autó adatai frissítve lettek", "Autó adatok frissítése", MessageBoxButtons.OK);
            Close();

            ResetProperties();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
            ResetProperties();
        }
    }
}

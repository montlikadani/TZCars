using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TZCars.db;

namespace TZCars {
    public partial class Form1 : Form {

        private readonly Form newCarForm;
        private readonly UpdateCarForm updateCarForm;
        private readonly DataTable dataTable;

        private readonly List<Car> cars = new List<Car>();

        public Form1() {
            InitializeComponent();
            newCarForm = new NewCarForm();
            updateCarForm = new UpdateCarForm();
            dataTable = new DataTable();

            TZDatabase.SqlCommand.CommandText = "select * from auto;";

            using (MySqlDataReader reader = TZDatabase.SqlCommand.ExecuteReader()) {
                for (int i = 0; i < reader.FieldCount; i++) {
                    dataTable.Columns.Add(new DataColumn(reader.GetName(i), reader.GetFieldType(i)));
                }

                UploadRows(reader);
            }

            autokGrid.ColumnHeadersDefaultCellStyle.Alignment = autokGrid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            autokGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            autokGrid.DataSource = dataTable;
        }

        public void RefreshGridItems() {
            dataTable.Rows.Clear();
            cars.Clear();

            TZDatabase.SqlCommand.CommandText = "select * from auto;";

            using (MySqlDataReader reader = TZDatabase.SqlCommand.ExecuteReader()) {
                UploadRows(reader);
            }

            autokGrid.DataSource = dataTable;
            selectedModifyButton.Enabled = selectedCarRemoveButton.Enabled = removeAll.Enabled = cars.Count != 0;
        }

        private void UploadRows(MySqlDataReader reader) {
            while (reader.Read()) {
                Car car = new Car(reader.GetInt32("id"), reader.GetString("rendszam"), reader.GetBoolean("forgalomba"), reader.GetString("tulajdonos"),
                        reader.GetDateTime("utolsomuszaki"), reader.GetDateTime("evjarat"), reader.GetString("marka"));

                dataTable.Rows.Add(car.Id, car.Rendszam, car.Forgalomba, car.Tulajdonos, car.UtolsoMuszaki, car.Evjarat, car.Marka);
                cars.Add(car);
            }
        }

        private void closeMenuItem_click(object sender, EventArgs e) {
            TZDatabase.Connection.Close();
            Environment.Exit(0);
        }

        private void addNewMenuItem_Click(object sender, EventArgs e) {
            newCarForm.ShowDialog(this);
        }

        public Car GetCarFromCellSelection() {
            var selectedCells = autokGrid.SelectedCells;

            if (selectedCells.Count == 0) {
                return null;
            }

            object cellValue = selectedCells[0].Value;

            if (cellValue.GetType() != typeof(int)) {
                return null;
            }

            int id = Convert.ToInt32(cellValue);

            foreach (Car car in cars) {
                if (car.Id == id) {
                    return car;
                }
            }

            return null;
        }

        private void selectedModifyButton_Click(object sender, EventArgs e) {
            Car selectedCar = GetCarFromCellSelection();

            if (selectedCar != null) {
                updateCarForm.LoadVariables(selectedCar);
                updateCarForm.ShowDialog(this);
            }
        }

        private async void removeAll_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Biztosan el szeretné távolítani az összes autót?", "Autó adatok eltávolítása", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    != DialogResult.OK) {
                return;
            }

            await TZDatabase.PerformSqlCommand("delete from `auto`;");
            RefreshGridItems();
        }

        private async void selectedCarRemoveButton_Click(object sender, EventArgs e) {
            Car selectedCar = GetCarFromCellSelection();

            if (selectedCar == null || MessageBox.Show("Biztosan el szeretné távolítani a kiválasztott autót?", "Autó adat eltávolítása", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK) {
                return;
            }

            await TZDatabase.PerformSqlCommand("delete from `auto` where `id` = @0;", selectedCar.Id);
            selectedCarRemoveButton.Enabled = false;
            RefreshGridItems();

            MessageBox.Show("A kiválasztott autó eltávolítva", "Autó adat eltávolítva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void autokGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            selectedModifyButton.Enabled = selectedCarRemoveButton.Enabled = autokGrid.SelectedCells.Count != 0;
        }
    }
}

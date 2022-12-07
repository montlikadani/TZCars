using System;
using System.Windows.Forms;

namespace TZCars {
    public partial class Form1 : Form {

        private readonly Form newCarForm;

        public Form1() {
            InitializeComponent();
            newCarForm = new NewCarForm();
        }

        public void RefreshGridItems() {
            
        }

        private void closeMenuItem_click(object sender, EventArgs e) {
            Program.Connection.Close();
            Environment.Exit(0);
        }

        private void addNewMenuItem_Click(object sender, EventArgs e) {
            newCarForm.ShowDialog(this);
        }
    }
}

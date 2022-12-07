using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TZCars {
    public static class Program {

        public static Form1 MainForm { get; private set; }
        public static MySqlConnection Connection { get; private set; }
        public static MySqlCommand SqlCommand { get; private set; }

        [STAThread]
        static void Main() {
            try {
                (Connection = new MySqlConnection("server=localhost;user=root;database=autok;")).Open();
                SqlCommand = Connection.CreateCommand();
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Adatbázis kapcsolódás sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new Form1();
            LoadFromDatabase();

            Application.Run(MainForm);
        }

        private static void LoadFromDatabase() {
            SqlCommand.CommandText = "select * from auto;";

            using (MySqlDataReader reader = SqlCommand.ExecuteReader()) {
                while (reader.Read()) {
                    new Car(reader.GetInt32("id"), reader.GetString("rendszam"), reader.GetBoolean("forgalomba"), reader.GetString("tulajdonos"),
                        reader.GetDateTime("utolsomuszaki"), reader.GetDateTime("evjarat"), reader.GetString("marka"));
                }
            }
        }

        public static async Task<bool> PerformSqlCommand(string cmd, params object[] values) {
            SqlCommand.CommandText = cmd;
            SqlCommand.Parameters.Clear();

            for (int i = 0; i < values.Length; i++) {
                SqlCommand.Parameters.AddWithValue($"@{i}", values[i]);
            }

            return await ExecuteSql();
        }

        public static async Task<bool> ExecuteSql() {
            try {
                if ((await SqlCommand.ExecuteNonQueryAsync()) != 1) {
                    return false;
                }
            } catch (System.Data.Common.DbException ex) {
                MessageBox.Show("Hiba lépett fel az adatbázis parancs végrehajtásakor: " + ex.Message, "Adatbázis hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}

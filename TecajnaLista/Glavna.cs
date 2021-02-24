using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TecajnaLista
{
    public partial class FormGlavna : Form
    {
        private HttpClient client = new HttpClient();
        private string connString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        private DataTable dataTableTecajevi = new DataTable();

        public FormGlavna()
        {
            InitializeComponent();
        }

        private void FormGlavna_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Tecajevi2", connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    dataTableTecajevi.Load(reader);
                    TecajeviDataGridView.DataSource = dataTableTecajevi;
                }
            }
        }

        private async void dohvatiButton_Click(object sender, EventArgs e)
        {
            dataTableTecajevi.Clear();
            var response = await client.GetStringAsync("http://api.hnb.hr/tecajn/v2");

            List<Tecaj> tecajevi = JsonConvert.DeserializeObject<List<Tecaj>>(response);

            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Tecajevi2";
                    connection.Open();
                    command.ExecuteNonQuery();
                }

            }

            {
                foreach (var tecaj in tecajevi)
                {
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = "INSERT INTO Tecajevi2 (SifraValute, Valuta, Drzava, KupovniTecaj, ProdajniTecaj, SrednjiTecaj, DatumPrimjene) VALUES (@SifraValute, @Valuta, @Drzava, @Kupovni_tecaj, @Prodajni_tecaj, @Srednji_tecaj, @Datum_primjene)";
                            command.Parameters.AddWithValue("@SifraValute", tecaj.Sifra_Valute);
                            command.Parameters.AddWithValue("@Valuta", tecaj.Valuta);
                            command.Parameters.AddWithValue("@Drzava", tecaj.Drzava);
                            command.Parameters.AddWithValue("@Kupovni_tecaj", tecaj.Kupovni_tecaj);
                            command.Parameters.AddWithValue("@Prodajni_tecaj", tecaj.Prodajni_tecaj);
                            command.Parameters.AddWithValue("@Srednji_tecaj", tecaj.Srednji_tecaj);
                            command.Parameters.AddWithValue("@Datum_primjene", tecaj.Datum_primjene);

                            connection.Open();
                            command.ExecuteNonQuery();

                        }

                    }
                }

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Tecajevi2", connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        dataTableTecajevi.Load(reader);
                        TecajeviDataGridView.DataSource = dataTableTecajevi;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientTMB
{
    public partial class PageClient : Form
    {
        SqlCommand command = new SqlCommand();
        SqlConnection connection = new SqlConnection("Server=Admin-PC;Database=TmbBDD;Trusted_Connection=Yes");
        public PageClient()
        {
            InitializeComponent();
        }
        
        SqlDataReader reader;
        private void PageClient_Load(object sender, EventArgs e)
        {
            command.Connection = connection;
            loadgrid();
        }

        private void loadgrid()
        {
            dataGridView1.Rows.Clear();
            
            connection.Open();
            command.CommandText = "SELECT * FROM clients";
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                        reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
                }
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageContact contact = new PageContact();
            contact.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //dataGridView1.Rows[0].Selected = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxRaisonSocial.Text = row.Cells["RaisonSocial"].Value.ToString();
                textBoxVille.Text = row.Cells["ville"].Value.ToString();
                textBoxNomRef.Text = row.Cells["nomReferent"].Value.ToString();
            }
        }
    }
}

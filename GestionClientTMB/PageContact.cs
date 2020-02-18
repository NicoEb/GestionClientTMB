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
    public partial class PageContact : Form
    {
        public PageContact()
        {
            InitializeComponent();
        }

        static string SqlConnectionString = @"Server=Admin-PC;Database=TmbBDD;Trusted_Connection=Yes";

        private void buttonEnregisterClient_Click(object sender, EventArgs e)
        {
            if (textBoxRaisonSocial.Text == "")
            {
                MessageBox.Show("veuillez entrez une raison social");
            }
            
            if (textBoxAdresse.Text == "")
            {
                MessageBox.Show("veuillez entrez une adresse");
            }
            if (textBoxCodePostal.Text == "")
            {
                MessageBox.Show("veuillez entre un code postal");
            }
            if (textBoxVille.Text == "")
            {
                MessageBox.Show("veuillez renseigner une ville");
            }
            
            if (textBoxTel.Text == "")
            {
                MessageBox.Show("veuillez entrez un numéro de téléphone");
            }
            
            if (textBoxMail.Text == "")
            {
                MessageBox.Show("veuillez entrer une adresse mail");
            }
            
            if (textBoxReferent.Text == "")
            {
                MessageBox.Show("veuillez renseigner un référent");
            }
            if (textBoxLicence.Text == "")
            {
                MessageBox.Show("veuillez renseigner un numéro de licence");
            }
            if (textBoxSiret.Text == "")
            {
                MessageBox.Show("veuillez renseigner un numéro SIRET");
            }
            if (textBoxAPE.Text == "")
            {
                MessageBox.Show("veuillez renseigner un code APE");
            }
            else
            {




                SqlConnection Connection = new SqlConnection(SqlConnectionString);
                Connection.Open();
                SqlCommand FirstInsert =
                     new SqlCommand("INSERT INTO Clients (RaisonSocial,Adresse,CodePostal,Ville, Telephone , Mail , NomReferent , LicenceSpectacle,Siret,CodeAPE) " +
                     "VALUES (@raisonSocial,@adresse,@codePostal,@ville,@telephone,@mail,@nomReferent,@licencespectacle,@siret,@codeApe)", Connection);
                FirstInsert.Parameters.AddWithValue("@raisonSocial", textBoxRaisonSocial.Text);
                FirstInsert.Parameters.AddWithValue("@adresse", textBoxAdresse.Text);
                FirstInsert.Parameters.AddWithValue("@codePostal", textBoxCodePostal.Text);
                FirstInsert.Parameters.AddWithValue("@ville", textBoxVille.Text);
                FirstInsert.Parameters.AddWithValue("@telephone", textBoxTel.Text);
                FirstInsert.Parameters.AddWithValue("@mail", textBoxMail.Text);
                FirstInsert.Parameters.AddWithValue("@nomReferent", textBoxReferent.Text);
                FirstInsert.Parameters.AddWithValue("@licencespectacle", textBoxLicence.Text);
                FirstInsert.Parameters.AddWithValue("@siret", textBoxSiret.Text);
                FirstInsert.Parameters.AddWithValue("@codeApe", textBoxAPE.Text);
                FirstInsert.ExecuteNonQuery();
                Connection.Close();


                MessageBox.Show("client enregisté ");
                textBoxRaisonSocial.Text = "";
                textBoxAdresse.Text = "";
                textBoxCodePostal.Text = "";
                textBoxVille.Text = "";
                textBoxTel.Text = "";
                textBoxMail.Text = "";
                textBoxReferent.Text = "";
                textBoxLicence.Text = "";
                textBoxSiret.Text = "";
                textBoxAPE.Text = "";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            PageClient client = new PageClient();
            client.Show();
        }
    }
}

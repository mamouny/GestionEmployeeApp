using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionEmployeeApp
{
    public partial class AjoutEmployee : Form
    {
        public AjoutEmployee()
        {
            InitializeComponent();
        }

        private void AjoutEmployee_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_employeesDataSet.departements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.departementsTableAdapter.Fill(this.gestion_employeesDataSet.departements);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.departementsTableAdapter.FillBy(this.gestion_employeesDataSet.departements);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee fm = new Employee();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "" || txt_prenom.Text == "" || numericUpDownAge.Value <= 0)
            {
                MessageBox.Show("Entrer tous informations svp");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = Connexion.openConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into employees(nom,prenom,age,departement_id) values(@nom,@prenom,@age,@dep)", con);
                cmd.Parameters.AddWithValue("@nom", txt_nom.Text);
                cmd.Parameters.AddWithValue("@prenom", txt_prenom.Text);
                cmd.Parameters.AddWithValue("@age", numericUpDownAge.Value);
                cmd.Parameters.AddWithValue("@dep", int.Parse(txt_departement.SelectedValue.ToString()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employé été bien ajouté.");
                con.Close();
                this.Hide();
                Employee fm = new Employee();
                fm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

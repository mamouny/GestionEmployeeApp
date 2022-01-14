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
    public partial class Departement : Form
    {
        public Departement()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewDep.DataSource = GetDepartementList();
        }
        private DataTable GetDepartementList()
        {
            DataTable dtDepartement = new DataTable();
            SqlConnection con = Connexion.openConnection();
            SqlCommand cmd = new SqlCommand("Select * from departements", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dtDepartement.Load(reader);

            return dtDepartement;
        }

        private void Departement_Load(object sender, EventArgs e)
        {
            dataGridViewDep.DataSource = GetDepartementList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "")
            {
                MessageBox.Show("Entrer tous informations svp");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = Connexion.openConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into departements(nom) values('" + txt_nom.Text +"')", con);
                cmd.ExecuteNonQuery();
                dataGridViewDep.DataSource = GetDepartementList();
                MessageBox.Show("Departement été bien ajouté.");
                con.Close();
                txt_nom.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (nom_txt.Text == "" || numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Entrer tous informations valide svp");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = Connexion.openConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("update departements set nom='" + nom_txt.Text + "' where id="+ numericUpDown1.Value, con);
                cmd.ExecuteNonQuery();
                dataGridViewDep.DataSource = GetDepartementList();
                MessageBox.Show("Departement été bien modifie.");
                con.Close();
                nom_txt.Text = "";
                numericUpDown1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Entrer identifiant valide svp");
                return;
            }
            try
            {
                if (MessageBox.Show("Voulez-Vous Vraiment Supprimer cette Departement ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    SqlConnection con = Connexion.openConnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from employees where departement_id=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", numericUpDown1.Value);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("delete from departements where id=" + numericUpDown1.Value, con);
                    cmd1.ExecuteNonQuery();
                    dataGridViewDep.DataSource = GetDepartementList();
                    MessageBox.Show("Departement été bien supprimé.");
                    con.Close();
                    numericUpDown1.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(text_recherche.Text == "")
            {
                dataGridViewDep.DataSource = GetDepartementList();
            }
            else
            {
                DataTable dtDepartement = new DataTable();
                SqlConnection con = Connexion.openConnection();
                SqlCommand cmd = new SqlCommand("Select * from departements where nom like '%" + text_recherche.Text + "%'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtDepartement.Load(reader);
                dataGridViewDep.DataSource = dtDepartement;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home fm = new Home();
            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}

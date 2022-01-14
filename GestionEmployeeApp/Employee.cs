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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home fm = new Home();
            fm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjoutEmployee fm = new AjoutEmployee();
            fm.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_employeesDataSet5.departements'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.departementsTableAdapter.Fill(this.gestion_employeesDataSet5.departements);
            // TODO: cette ligne de code charge les données dans la table 'gestion_employeesDataSet2.employees'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            dataGridView1.DataSource = GetEmployeeList();

        }

        private DataTable GetEmployeeList()
        {
            DataTable dtEmployee = new DataTable();
            SqlConnection con = Connexion.openConnection();
            SqlCommand cmd = new SqlCommand("Select * from employees", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dtEmployee.Load(reader);

            return dtEmployee;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlConnection con = Connexion.openConnection();
                SqlCommand cmd = new SqlCommand("Select * from employees",con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "" || txt_prenom.Text == "" || numericUpDownAge.Value <= 0 || numericUpDownId.Value <= 0)
            {
                MessageBox.Show("Entrer tous informations valide svp");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = Connexion.openConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("update employees set nom='" + txt_nom.Text + "', prenom='"+ txt_prenom.Text + "', age="+ numericUpDownAge.Value + ",departement_id=" + int.Parse(comboBoxDep.SelectedValue.ToString()) + " where id=" + numericUpDownId.Value, con);
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = GetEmployeeList();
                MessageBox.Show("Employee été bien modifie.");
                con.Close();
                txt_nom.Text = "";
                txt_prenom.Text = "";
                numericUpDownAge.Value = 0;
                numericUpDownId.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numericUpDownId.Value <= 0)
            {
                MessageBox.Show("Entrer un identifiant valide svp");
                return;
            }
            try
            {
                if (MessageBox.Show("Voulez-Vous Vraiment Supprimer cet employée ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    //Create SqlConnection
                    SqlConnection con = Connexion.openConnection();
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("delete from employees where id=" + numericUpDownId.Value, con);
                    cmd1.ExecuteNonQuery();
                    dataGridView1.DataSource = GetEmployeeList();
                    MessageBox.Show("Employé été bien supprimé.");
                    con.Close();
                    numericUpDownId.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_recherche.Text == "")
            {
                dataGridView1.DataSource = GetEmployeeList();
            }
            else
            {
                DataTable dtEmployee = new DataTable();
                SqlConnection con = Connexion.openConnection();
                SqlCommand cmd = new SqlCommand("Select * from employees where prenom like '%" + txt_recherche.Text + "%'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtEmployee.Load(reader);
                dataGridView1.DataSource = dtEmployee;
            }
        }
    }
}

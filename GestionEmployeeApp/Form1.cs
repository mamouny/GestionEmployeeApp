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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Entrer tous informations svp");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = Connexion.openConnection();
                SqlCommand cmd = new SqlCommand("Select * from users where username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_pass.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    this.Hide();
                    Home fm = new Home();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Username ou password est incorrecte!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur terminer votre programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

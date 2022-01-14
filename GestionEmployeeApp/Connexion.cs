using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionEmployeeApp
{
    class Connexion
    {
        public static SqlConnection openConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MAMOUNY078\SQLEXPRESS;Initial Catalog=gestion_employees;Integrated Security=True");
            return con;
        }
    }
}

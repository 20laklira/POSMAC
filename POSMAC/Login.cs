using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace POSMAC
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
            buttonLogin.Click += ButtonLogin_Click;
           

            
        }
       
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=pos;Integrated Security=True");

        int count;

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

           




        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username, password;


            username = textBoxUserName.Text;
            password = textBoxPass.Text;


            string query = "select * from login where username = '" + username + "' && password ='" + password + "' ";
            SqlDataAdapter data = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            data.Fill(dt);
          
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("LOgi Sucess");
            }

            else
            {
                MessageBox.Show("try again");
                textBoxUserName.Clear();
                textBoxPass.Clear();

            }

        }
    }
}

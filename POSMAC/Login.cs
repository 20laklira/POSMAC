using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSMAC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            buttonLogin.Click += ButtonLogin_Click;
            
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            string username, password;


            username = textBoxUserName.Text;
            password = textBoxPass.Text;
           
        }
    }
}

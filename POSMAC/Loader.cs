﻿using System;
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
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
            button1.Click += Button1_Click;

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("load sucess asdasdasd");

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

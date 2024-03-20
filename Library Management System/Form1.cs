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

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        string Connection = "Data Source=DESKTOP-U7DD4IT\\SQLEXPRESS;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if(txtPassword.Text== "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtusername_MouseEnter(object sender, EventArgs e)
        {
            if(txtusername.Text=="Username")
            {
                txtusername.Clear();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseofPain
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (kryptonMaskedTextBox1.Text == "admin" && kryptonComboBox1.Text == "Administrator")
            {
                this.Hide();
                Form1 newform = new Form1(1);
                newform.Show();
            }
            else
                MessageBox.Show("Invalid Credentials,Please Try Again.","Login Error! ");

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

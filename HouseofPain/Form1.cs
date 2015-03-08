using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
//using OnBarcode.Barcode;

namespace HouseofPain
{
    public partial class Form1 : Form
    {
        int userId = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int uid)
        {
            InitializeComponent();
            userId = uid;
        }
        DatabaseConnection objConnect = new DatabaseConnection();
        
        private void Form1_Load(object sender, EventArgs e)
        {
               
               }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void buttonfind_Click(object sender, EventArgs e)
        {
            Finduser _formFind = new Finduser();
            _formFind.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Addmember _formAdd = new Addmember();
            _formAdd.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void kryptonListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kryptonListBox1.SelectedIndex == 0)
            {
                boxCommunication.Hide();
            }

            if (kryptonListBox1.SelectedIndex == 5)
            {
                boxCommunication.Show();
            }
            
        }
    }
}

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
    public partial class memberdetails : Form
    {
        public memberdetails()
        {
            InitializeComponent();
        }

        private void memberdetails_Load(object sender, EventArgs e)
        {
            groupdetails.Text = "Member Details";
            groupmembership.Text = "Memberships";
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

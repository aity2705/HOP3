using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace HouseofPain
{
    public partial class AddPaymeny : Form
    {
        String _tempStore;
        public AddPaymeny()
        {
            InitializeComponent();
        }
        public AddPaymeny(String _text)
        {
            InitializeComponent();
            _tempStore = _text;
            sdateBox.Text = Convert.ToString(DateTime.Now.Date.ToShortDateString());
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            String pcText = pCombo.Text;
            String pgText = pgCombo.Text;
            DataClasses1DataContext _database = new DataClasses1DataContext();
            Table<Mship> _Mship = _database.GetTable<Mship>();
            Mship _newMship = new Mship();
            _newMship.programme = pcText;
            _newMship.pg = pgText;
            _newMship.sdate = sdateBox.Text;
            _newMship.price = ppriceBox.Text;
            //_newMship.conditions = conditonsBox.Text;
            _newMship.IDD = _tempStore;
            if (pcText == "1 Month")
                _newMship.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(1).ToShortDateString());
            if (pcText == "3 Month")
                _newMship.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(3).ToShortDateString());
            if (pcText == "6 Month")
                _newMship.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(6).ToShortDateString());
            if (pcText == "Annual Basis")
                _newMship.edate = Convert.ToString(Convert.ToDateTime(sdateBox.Text).AddMonths(12).ToShortDateString());
            _Mship.InsertOnSubmit(_newMship);
            _database.SubmitChanges();
            MessageBox.Show("Successfully Added new Payment!");
            this.Close();
            
            
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

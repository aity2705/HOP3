using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Data.Linq;
namespace HouseofPain
{
    public partial class Finduser : Form
    {
        public Finduser()
        {
            //Read from
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        void search_Record(String _txtName)
        {
            DataClasses1DataContext _database = new DataClasses1DataContext();
            Table<Mdetail> _Mdetail = _database.GetTable<Mdetail>();
            int i = 1;
            IQueryable<Mdetail> ItemQuery = from Item in _Mdetail

                                            where Item.fname.Contains(TextNameBox.Text)
                                            select Item;
            foreach (Mdetail Item in ItemQuery)
            {
                kryptonDataGridView1.Rows.Add(i++.ToString(),Item.fname,Item.cardn,Item.home,Item.cell,Item.street,Item.email);
            }
        }

        private void Finduser_KeyDown(object sender, KeyEventArgs e)
        {
           // if (TextNameBox.Focused)
              //  search_Record(TextNameBox.Text);
        }

        private void TextNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            kryptonDataGridView1.Rows.Clear();
            search_Record(TextNameBox.Text);
        }

      

        private void kryptonDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow _tempRow = kryptonDataGridView1.Rows[e.RowIndex];

            Addmember _tempNewForm = new Addmember(_tempRow.Cells[1].Value.ToString());
            //_tempNewForm.ShowDialog();
        }

    }
}

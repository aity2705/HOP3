using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseofPain
{
    class DatabaseConnection
    {
        private string sql_string;
        private string strcon;
        public string sql
        {
            set { sql_string = value; }
        }
        public string connection_string
        {
            set { strcon = value; }
        }
        public System.Data.DataSet GetConnection
        {
            get
            {
                return MyDataSet();
            }
        }
        private System.Data.DataSet MyDataSet()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strcon);
            con.Open();
            System.Data.SqlClient.SqlDataAdapter da_1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con);
            System.Data.DataSet dat_set = new System.Data.DataSet();
            da_1.Fill(dat_set, "DataTabale_1");
            con.Close();
            return dat_set;

        }

        public void updateDatabase(System.Data.DataSet ds)
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strcon);
            con.Open();
            System.Data.SqlClient.SqlDataAdapter da_1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con);
            System.Data.DataSet dat_set = new System.Data.DataSet();
            da_1.Fill(dat_set, "DataTabale_1");
            System.Data.SqlClient.SqlCommandBuilder cb = new System.Data.SqlClient.SqlCommandBuilder(da_1);
            cb.DataAdapter.Update(ds.Tables[0]);
        }

    }
}

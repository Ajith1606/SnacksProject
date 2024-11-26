using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnacksProject
{
    public partial class GridPage : Form
    {
        public GridPage()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["AjithConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(fetchDBDetails);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_tempfetchImage", con);
                cmd.CommandType = CommandType.StoredProcedure;

                

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                //dataGridView1.DataSource = ds.Tables[0];
  
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    //Image img;
                    //img = Image.FromFile(dr[1].ToString());
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString());
                }

                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

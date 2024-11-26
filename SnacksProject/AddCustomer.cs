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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtMobileNo.Clear();
            txtAddress.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtCustomerName.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "")
            {
                try
                {
                    string fetchDBDetails = ConfigurationManager.ConnectionStrings["AjithConnection"].ConnectionString;

                    SqlConnection con = new SqlConnection(fetchDBDetails);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_addCustomer", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@cust_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txtCustomerName.Text;

                    SqlParameter p2 = new SqlParameter("@mobile", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = txtMobileNo.Text;

                    SqlParameter p3 = new SqlParameter("@address", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = txtAddress.Text;

                    int a = cmd.ExecuteNonQuery();

                    if(a > 0)
                    {
                        MessageBox.Show("Customer details Added");
                        txtCustomerName.Text = "";
                        txtMobileNo.Text = "";
                        txtAddress.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Falied");
                        con.Close();
                    }
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Please enter all the Fields");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

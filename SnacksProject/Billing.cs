using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace SnacksProject
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }
        private string usename = "";
        public void qwe(string name)
        {
            usename = name;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            txtBilledby.Text = usename;

            gbSnack.Visible = false;
            gbCoolDrink.Visible = false;
            btnSnack_Click(sender, e);
            cbPayment.SelectedIndex = 0;
        }
        private void btnSnack_Click(object sender, EventArgs e)
        {
            gbSnack.Visible = true;
            gbCoolDrink.Visible = false;
        }

        private void btnCoolDrink_Click(object sender, EventArgs e)
        {
            gbCoolDrink.Visible = true;
            gbSnack.Visible = false;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "Cake";

            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["AjithConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(fetchDBDetails);
                con.Open();
                SqlCommand cmd = new SqlCommand("fetchcost", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@productName", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = txtProductName.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtCost.Text = ds.Tables[0].Rows[0][0].ToString();
                txtProductid.Text = ds.Tables[0].Rows[0][1].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "Chips";       

            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["AjithConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(fetchDBDetails);
                con.Open();
                SqlCommand cmd = new SqlCommand("fetchcost", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@productName", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = txtProductName.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtCost.Text = ds.Tables[0].Rows[0][0].ToString();
                txtProductid.Text = ds.Tables[0].Rows[0][1].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "Pepsi";

            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["AjithConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(fetchDBDetails);
                con.Open();
                SqlCommand cmd = new SqlCommand("fetchcost", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@productName", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = txtProductName.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtCost.Text = ds.Tables[0].Rows[0][0].ToString();
                txtProductid.Text = ds.Tables[0].Rows[0][1].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "Coca Cola";

            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["AjithConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(fetchDBDetails);
                con.Open();
                SqlCommand cmd = new SqlCommand("fetchcost", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@productName", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = txtProductName.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtCost.Text = ds.Tables[0].Rows[0][0].ToString();
                txtProductid.Text = ds.Tables[0].Rows[0][1].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void llExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productname = txtProductName.Text;
            int cost = Convert.ToInt32(txtCost.Text);
            int quantity = Convert.ToInt32(cbQuantity.SelectedItem.ToString());
            int finalcost = cost * quantity;
            int productid = Convert.ToInt32(txtProductid.Text);

            dgvProduct.Rows.Add(productname, quantity, finalcost, productid);
            int totalamount = 0;

            foreach(DataGridViewRow dv in dgvProduct.Rows)
            {     
                totalamount += Convert.ToInt32(Convert.ToString(dv.Cells[2].Value));         
            }
            txtBillCost.Text = totalamount.ToString();
            txtGst.Text = ((totalamount * 18) / 100).ToString();
            txtFinalbill.Text = (totalamount + ((totalamount * 18) / 100)).ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["AjithConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(fetchDBDetails);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_addBill", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@billedby", SqlDbType.Int);
                cmd.Parameters.Add(p1).Value = txtBilledby.Text;

                SqlParameter p2 = new SqlParameter("@customerid", SqlDbType.Int);
                cmd.Parameters.Add(p2).Value = txtCustomerid.Text;

                SqlParameter p3 = new SqlParameter("@totalamount", SqlDbType.Float);
                cmd.Parameters.Add(p3).Value = txtFinalbill.Text;

                SqlParameter p4 = new SqlParameter("@cashoronline", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = cbPayment.SelectedItem.ToString(); 
 
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                MessageBox.Show(a.ToString());
                txtBillidno.Text = a.ToString();

                foreach (DataGridViewRow dv in dgvProduct.Rows)
                {
                    string productname = Convert.ToString(dv.Cells[0].Value);
                    int quantity = Convert.ToInt32(Convert.ToString(dv.Cells[1].Value));
                    int amount = Convert.ToInt32(Convert.ToString(dv.Cells[2].Value));
                    int productid = Convert.ToInt32(Convert.ToString(dv.Cells[3].Value));

                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("sp_adduserProduct", con);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    SqlParameter p11 = new SqlParameter("@billid", SqlDbType.Int);
                    cmd1.Parameters.Add(p11).Value = txtBillidno.Text;

                    SqlParameter p22 = new SqlParameter("@product", SqlDbType.Int);
                    cmd1.Parameters.Add(p22).Value =productid.ToString();

                    SqlParameter p33 = new SqlParameter("@quantity", SqlDbType.Int);
                    cmd1.Parameters.Add(p33).Value = quantity.ToString();

                    SqlParameter p44 = new SqlParameter("@amount", SqlDbType.Float);
                    cmd1.Parameters.Add(p44).Value = amount.ToString();

                    int a1 = Convert.ToInt32(cmd1.ExecuteScalar());

                    if (a1 > 0)
                    {
                        MessageBox.Show("Failed!!!");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Product is Added in the bill");                   
                    }
                }


            }
            catch (Exception ex)
            {
                throw;
                //MessageBox.Show(ex.Message);
            }
        }

        private void gbCoolDrink_Enter(object sender, EventArgs e)
        {

        }

        private void txtBillCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtMobileNo.Text.Length == 10)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        string fetchDBDetails = ConfigurationManager.ConnectionStrings["AjithConnection"].ConnectionString;

                        SqlConnection con = new SqlConnection(fetchDBDetails);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("sp_fetchCustomerid", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@mobile", SqlDbType.VarChar);
                        cmd.Parameters.Add(p1).Value = txtMobileNo.Text;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        txtCustomerid.Text = ds.Tables[0].Rows[0][0].ToString();
                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid Mobile Number or Customer not available for this number. Please add Customer");
                        txtCustomerid.Text = "";
                    }
                }
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

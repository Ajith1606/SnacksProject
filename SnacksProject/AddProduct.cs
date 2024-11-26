using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using Application = System.Windows.Forms.Application;

namespace SnacksProject
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
      
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp) |" +
                " *.jpg; *.jpeg; *.png; *.gif; *.bmp | All files(*.*) | *.*";
            of.ShowDialog();

            txtProductImage.Text = of.FileName;
            pictureBox1.Image = Image.FromFile(of.FileName);

            //txtProductImage.Text = txtProductName.Text + ".png";


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != "" && txtCategoryName.Text != "" && txtCost.Text != "" && txtQuantity.Text != "" && txtProductImage.Text != "")
            {
                try
                {
                    string fetchDBDetails = ConfigurationManager.ConnectionStrings["AjithConnection"].ConnectionString;
                    SqlConnection con = new SqlConnection(fetchDBDetails);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_addProduct", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@product_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txtProductName.Text;

                    SqlParameter p2 = new SqlParameter("@category_name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = txtCategoryName.Text;

                    SqlParameter p3 = new SqlParameter("@cost", SqlDbType.Float);
                    cmd.Parameters.Add(p3).Value = txtCost.Text;

                    SqlParameter p4 = new SqlParameter("@quantity", SqlDbType.Int);
                    cmd.Parameters.Add(p4).Value = txtQuantity.Text;

                    SqlParameter p5 = new SqlParameter("@expirydate", SqlDbType.DateTime);
                    cmd.Parameters.Add(p5).Value = dtpExpiryDate.Value.ToString();

                    SqlParameter p6 = new SqlParameter("@productimage", SqlDbType.VarChar);
                    cmd.Parameters.Add(p6).Value = txtProductImage.Text + ".png";

                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        Image img = new Bitmap(txtProductImage.Text);
                        img.Save("Images/" + txtProductName.Text + ".png", ImageFormat.Png);
                        MessageBox.Show("Product details Added");
                    }
                    else
                    {
                        MessageBox.Show("Failed!!!");
                        con.Close();
                    }
                    txtProductName.Clear();
                    txtCategoryName.Clear();
                    txtCost.Clear();
                    txtQuantity.Clear();
                    txtProductImage.Clear();

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }
                    dtpExpiryDate.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter the all field");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();          
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

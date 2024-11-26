using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace SnacksProject
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public static bool IsPhoneValid(string phone)
        {
            bool isValid = false;
            if(!string.IsNullOrWhiteSpace(phone))
            {
                isValid = Regex.IsMatch(phone, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", RegexOptions.IgnoreCase);
            }
            return isValid;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isphone = IsPhoneValid(txtMobile.Text);
            if (isphone == true)
            {
                try
                {
                    string fetchDBDetails = ConfigurationManager.ConnectionStrings["AjithConnection"].ConnectionString;
                    SqlConnection con = new SqlConnection(fetchDBDetails);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_addUser2", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@empid", SqlDbType.Int);
                    cmd.Parameters.Add(p1).Value = txtregEmpId.Text;

                    SqlParameter p2 = new SqlParameter("@loginusername", SqlDbType.VarChar);
                    string key = "b14ca5898a4e4133bbce2ea2315a1916";
                    string encryptusername = EncryptString(key, txtregUserName.Text);
                    cmd.Parameters.Add(p2).Value = encryptusername;

                    SqlParameter p3 = new SqlParameter("@pwd", SqlDbType.VarChar);
                    string encryptpwd = EncryptString(key, txtregPassword.Text);
                    cmd.Parameters.Add(p3).Value = encryptpwd;

                    SqlParameter p4 = new SqlParameter("@email", SqlDbType.VarChar);
                    cmd.Parameters.Add(p4).Value = txtEmail.Text;

                    SqlParameter p5 = new SqlParameter("@mobile", SqlDbType.VarChar);
                    cmd.Parameters.Add(p5).Value = txtMobile.Text;


                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        MessageBox.Show("User Added Successfully");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed!!!");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please enter Valid Mobile number");
            }

        }

        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        private void llEXIT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
          
        }

        private void llLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void txtMobile_MouseClick(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(this.txtMobile, "Enter your mobile Number");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtregEmpId.Clear();
            txtregUserName.Clear();
            txtregPassword.Clear();         
            txtEmail.Clear();
            txtMobile.Clear();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnacksProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string name;
        
        public string loginName
        {
            get { return name; }
            set { name = value; }
        }
            

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string fetchDBDetails = ConfigurationManager.ConnectionStrings["AjithConnection"].ConnectionString;
                SqlConnection con = new SqlConnection(fetchDBDetails);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_LoginUser1", con);
                cmd.CommandType = CommandType.StoredProcedure;

                string key = "b14ca5898a4e4133bbce2ea2315a1916";
                string encryptusername = EncryptString(key, txtlogUserName.Text);

                SqlParameter p1 = new SqlParameter("@loginusername", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = encryptusername;

                SqlParameter p2 = new SqlParameter("@pwd", SqlDbType.VarChar);
                string encryptpwd = EncryptString(key, txtlogPassword.Text);
                cmd.Parameters.Add(p2).Value = encryptpwd;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                string username = ds.Tables[0].Rows[0][0].ToString();
               
                string decryptusername = DecryptString(key, username);

                MessageBox.Show("Welcome " + decryptusername);
                
                if (decryptusername != null || decryptusername != "")
                {
                    MessageBox.Show("Logined Successfully");  
                    loginName = decryptusername;
                    Billing billing = new Billing();
                    billing.qwe(loginName);
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtlogUserName.Clear();
            txtlogPassword.Clear(); 
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void llLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}

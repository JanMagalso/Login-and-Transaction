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

namespace Login_Form_and_Transactions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = usernameTxt;
            usernameTxt.Focus();
        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            passwordLogin.PasswordChar = '*';
            Sign_Up sign = new Sign_Up();
            sign.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Sign_Up sign = new Sign_Up();
            sign.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (usernameTxt.Text != null && passwordLogin.Text != null)
            {
                try
                {
                    TransactionDetails.Store = usernameTxt.Text;
                    Connect obj = new Connect();
                    obj.conn.ConnectionString = obj.locate;
                    obj.conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT (*) FROM userTable where username = '" + usernameTxt.Text + "' and password = '" + passwordLogin.Text + "' ", obj.conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    { 
                        Transaction meLoad = new Transaction();
                        meLoad.Visible = true;
                        this.Hide();
                        MessageBox.Show("Successfuly Logged In!");
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect");
                    }
                    obj.conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No empty fields are allowed");
            }
        }


        private void usernameTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransactionDetails.Store = usernameTxt.Text;
        }


        private void passwordLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void groupbox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


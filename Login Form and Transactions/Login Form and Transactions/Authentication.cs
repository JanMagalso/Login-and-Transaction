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

namespace Login_Form_and_Transactions
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
            this.ActiveControl = searchID;
            searchID.Focus();
        }

        private void searchID_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchID_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            if (searchID.Text != null)
            {
                /*
                string cs = @"Data Source=(LocalDb)\Thesis;Initial Catalog=login;Integrated Security=True";
                SqlConnection conn1 = new SqlConnection(cs);
                conn1.Open();
                string qr = "select * from StudentInfo where SerialID= '" + searchID.Text + "'";
                SqlCommand cmd1 = new SqlCommand(qr, conn1);
                SqlDataReader dr = cmd1.ExecuteReader();
                bool recordfound = dr.Read();
               
                if (recordfound)
                {*/
                //try
                //{
                    TransactionDetails.SerialID = searchID.Text;
                    DateTime now = DateTime.Now;
                    decimal money = TransactionDetails.Expenditure;
                    string storename = TransactionDetails.Store;
                    //Cash
                    TransactionDetails.PersonID = searchID.Text;
                    TransactionDetails.CreatedDate = now;
                    TransactionDetails.TransactionType = "Cash";
                    //string credit = TransactionDetails.Expenditure;
                    Connect obj = new Connect();
                    obj.conn.ConnectionString = obj.locate;
                    string insertdata = "insert into IDPaymentTransactionList ([PersonID],[Store],[Expenditure],[CreatedDate],[TransactionType]) values (@PersonID,@Store,@Expenditure,@CreatedDate,@Transaction)";
                    using (SqlConnection cnn = new SqlConnection(obj.locate))
                    {
                        try
                        {
                            cnn.Open();
                            using (SqlCommand cmd = new SqlCommand(insertdata, cnn))
                            {
                                cmd.Parameters.Add("@PersonID", SqlDbType.NVarChar).Value = TransactionDetails.SerialID;
                                cmd.Parameters.Add("@Store", SqlDbType.NVarChar).Value = TransactionDetails.Store;
                                cmd.Parameters.Add("@Expenditure", SqlDbType.Decimal).Value = TransactionDetails.Expenditure;
                                cmd.Parameters.Add("@Transaction", SqlDbType.NVarChar).Value = TransactionDetails.TransactionType;
                                 cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = TransactionDetails.CreatedDate;
                                 /*cmd.Parameters.Add("@ID", SqlDbType.DateTime).Value = null;
                                 cmd.Parameters.Add("@ID", SqlDbType.DateTime).Value = null;
                                 cmd.Parameters.Add("@ID", SqlDbType.Decimal).Value = null;
                                 cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = null;
                                 */
                                int rowsAdded = cmd.ExecuteNonQuery();
                                if (rowsAdded > 0)
                                {
                                    MessageBox.Show("Transaction Successful! ");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }
                    }
                   Transaction load = new Transaction();
                   load.Visible = true;
                   this.Hide();

               }
                       
                //}
            }
        private void Authentication_Load(object sender, EventArgs e)
        {
               searchID.PasswordChar = '*';
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Login_Form_and_Transactions
{
    class Connect
    {
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = @"Data Source=(LocalDb)\Thesis;Initial Catalog=login;Integrated Security=True";
    }
    class TransactionDetails
    {
        public static string SerialID;
        public static string PersonID;
        public static string Store;
        public static decimal Expenditure;
        //public static string IDnumber;
        public static DateTime CreatedDate;
        public static string TransactionType = "Cash";
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDB4
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接数据库
            SqlConnection conn= new SqlConnection();
            //要连接的数据库信息
            conn.ConnectionString = "Server=localhost;Database=AmazonMarketplaceDB;Trusted_Connection=true;";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from OrderHeader";

            SqlDataAdapter adapter =new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            conn.Close();

            DataTable table = ds.Tables[0];

            for (int i = 0; i < table.Rows.Count; i++) {
                Console.WriteLine($" {table.Rows[i]["AmazonOrderID"]}    {table.Rows[i]["PurchaseDate"]} ");
            }


        }
    }
}

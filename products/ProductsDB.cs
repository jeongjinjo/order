using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderForm.products
{
    public class ProductsDB
    {
        string server = "localhost"; // HeidiSQL 서버 주소
        string database = "c#project"; // 데이터베이스 이름
        string uid = "root"; // 사용자 이름
        string password = "1234"; // 암호
        string connectionString = null;

        public ProductsDB()
        {
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};"; // DB 연결
        }

        public Products doSelect(string name)
        {
            Products products = new Products();
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string query = $"SELECT name, quantity, price, category FROM products where name = '{name}'";
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            if(reader.Read())
            {
                products.name = reader.GetString("name");
                products.category = reader.GetString("category");
                products.price = reader.GetInt32("price");


            }


            mySqlConnection.Close();
            return products;
        }
    }
}

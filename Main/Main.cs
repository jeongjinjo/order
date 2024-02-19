using MySql.Data.MySqlClient;
using OrderForm;
using OrderForm.products;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.Food
{
    public partial class Main : UserControl
    {
        string server = "localhost"; // HeidiSQL 서버 주소
        string database = "c#project"; // 데이터베이스 이름
        string uid = "root"; // 사용자 이름
        string password = "1234"; // 암호

        string connectionString;
        MySqlConnection connection;

        public Main()
        {
            InitializeComponent();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(int product_id)
        {

            String connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            try
            {
                string query = $"SELECT name,quantity,price FROM products WHERE product_id={product_id}";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string productName = reader.GetString("name");
                    int productPrice = reader.GetInt32("price");

                    //ListViewItem existingItem = listView1.FindItemWithText(productName);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsDB db = new ProductsDB();
            Products products =  db.doSelect("와퍼");

            ListViewItem item = new ListViewItem(products.name);
            item.SubItems.Add(products.quantity);
            item.SubItems.Add(products.price); // quantity를 항상 1로 설정

            Main_form.listView1.Items.Add(item);
        }
    }
}

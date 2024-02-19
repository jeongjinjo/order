using OrderForm;
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

namespace WinFormsApp1.Food
{
    public partial class Main : UserControl
    {
        string server = "localhost"; // HeidiSQL 서버 주소
        string database = "c#project"; // 데이터베이스 이름
        string uid = "root"; // 사용자 이름
        string password = "1234"; // 암호

        public Main()
        {
            InitializeComponent();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";




        }
    }
}

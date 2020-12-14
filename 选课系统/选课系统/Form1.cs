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
namespace 选课系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String connStr = @"Data Source=.;Initial Catalog=xkSystem;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            String sql = String.Format("select pwd from stu where stuid = {0}",textBox1.Text.ToString().Trim());
            SqlDataAdapter sda = new SqlDataAdapter(sql, connStr);
            
        }

    }
}

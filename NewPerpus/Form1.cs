using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NewPerpus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\users.accdb");

            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from login where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or passwor please try again...");
            }
        }
    }
}


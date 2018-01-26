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

namespace Centennial_Catering_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Connection String for home PC
        public static string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\FW 2017- 2018\COMP 212\Midterm\Centennial Catering System\Centennial Catering System\App_Data\CateringDB.mdf;Integrated Security=True";
        //Connection String for minion USB
        //public string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\New folder\COMP 212\Midterm\Centennial Catering System\Centennial Catering System\App_Data\CateringDB.mdf;Integrated Security=True";
        SqlConnection cn = new SqlConnection(cnStr);
        private int counter = 2;

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxUsername.Text = tbxPwd.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
           
            SqlCommand cmd = new SqlCommand("select * from tblEmployees where Username=@usr and Password=@pwd", cn);
            cmd.Parameters.AddWithValue("@usr", tbxUsername.Text);
            cmd.Parameters.AddWithValue("@pwd", tbxPwd.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            cn.Open();
            int reader = cmd.ExecuteNonQuery();
            cn.Close();

            if(dt.Rows.Count > 0) 
            {
                Menu menu = new Centennial_Catering_System.Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                if(counter > 0)
                {
                    lbMsg1.Visible = true;
                    lbMsg2.Text = counter.ToString() + " Attempt(s) Remaining";
                    counter--;
                }
                else
                {
                    lbMsg1.Visible = true;
                    tbxUsername.Enabled = false;
                    tbxPwd.Enabled = false;
                    btnClear.Enabled = false;
                    btnLogin.Enabled = false;
                    lbMsg2.Text = "Account Locked.";
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is written by Yayun (Kim) YANG.", "Copyright",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

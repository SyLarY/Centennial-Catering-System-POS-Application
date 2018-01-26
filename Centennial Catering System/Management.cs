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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        //Connection String for home PC
        static string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\FW 2017- 2018\COMP 212\Midterm\Centennial Catering System\Centennial Catering System\App_Data\CateringDB.mdf;Integrated Security=True";
        //Connection String for minion USB
        //static cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\New folder\COMP 212\Midterm\Centennial Catering System\Centennial Catering System\App_Data\CateringDB.mdf;Integrated Security=True";
        SqlConnection cn = new SqlConnection(cnStr);
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommand cmd;

        private void Management_Load(object sender, EventArgs e)
        {
            displayItems();
        }

        private void displayItems()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select ItemID, CategoryDescription, ProductName, ProductImg, Price from tblItems full outer join tblCategories on tblItems.CategoryID=tblCategories.CategoryID", cn);
            cmd.ExecuteNonQuery();
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dgvManagement.DataSource = dt;
            cn.Close();
            tbxItemID.Text = "";
            tbxItemName.Text = "";
            tbxPrice.Text = "";
            tbxImage.Text = "";
            tbxSearchCat.Text = "";
            tbxSearchName.Text = "";
            tbxSearchID.Text = "";

        }


        //MenuStrip Item Function
        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void mANAGEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management m1 = new Management();
            m1.Show();
        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer();
            c1.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report r1 = new Report();
            r1.Show();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.ico) | *.png; *.jpg; *.jpeg; *.ico";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbxImage.Text = ofd.SafeFileName;
            }

        }

        private void tbxSearchCat_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            sda = new SqlDataAdapter("Select ItemID, CategoryDescription, ProductName, ProductImg, Price from tblItems full outer join tblCategories on tblItems.CategoryID=tblCategories.CategoryID where tblCategories.CategoryDescription like '%" + tbxSearchCat.Text + "%';", cn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvManagement.DataSource = dt;
            cn.Close();
        }

        private void tbxSearchName_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            sda = new SqlDataAdapter("Select ItemID, CategoryDescription, ProductName, ProductImg, Price from tblItems full outer join tblCategories on tblItems.CategoryID=tblCategories.CategoryID where tblItems.ProductName like '%" + tbxSearchName.Text + "%';", cn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvManagement.DataSource = dt;
            cn.Close();
        }

        private void tbxSearchID_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            sda = new SqlDataAdapter("Select ItemID, CategoryDescription, ProductName, ProductImg, Price from tblItems full outer join tblCategories on tblItems.CategoryID=tblCategories.CategoryID where tblItems.ItemID like '%" + tbxSearchID.Text + "%'", cn);
            dt = new DataTable();
            sda.Fill(dt);
            dgvManagement.DataSource = dt;
            cn.Close();

        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            tbxSearchCat.Text = "";
            tbxSearchName.Text = "";
            tbxSearchID.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbxItemID.Text == "" || tbxItemName.Text == "" || tbxPrice.Text == "" || lbxCategory.SelectedItem == null)
            {
                MessageBox.Show("Insert Failed! Invalid Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string id = tbxItemID.Text;
                    string name = tbxItemName.Text;
                    double price = Convert.ToDouble(tbxPrice.Text);
                    string catDescription = lbxCategory.SelectedItem.ToString().Substring(2);
                    string filePath = string.Format("Image/{0}/", lbxCategory.SelectedItem.ToString().Substring(2));
                    string imgPath = tbxImage.Text == "" ? "Image/default.png" : filePath + tbxImage.Text;

                    cn.Open();
                    cmd = new SqlCommand("Insert into tblItems Values(@id, (Select CategoryID from tblCategories where CategoryDescription=@catDescription),@name,@img,@price)", cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@catDescription", catDescription);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@img", imgPath);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Insert Succeed! Item Added!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayItems();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbxItemID.Text == "")
            {
                MessageBox.Show("Update Failed!  Item ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string id = tbxItemID.Text;
                    string name;
                    string price;
                    cn.Open();
                    SqlCommand readercmd = new SqlCommand("select * from tblItems where ItemID='" + id + "';", cn);
                    SqlDataReader reader = readercmd.ExecuteReader();
                    if (reader.Read())
                    {
                        //get column value for the ItemID entered and store them to fields respectively
                        //if there is input in textbox, previous value will be replaced with new one
                        //if there is not input in textbox, value will remain the same
                        name = tbxItemName.Text == "" ? reader[2].ToString() : tbxItemName.Text;
                        price = tbxPrice.Text == "" ? reader[4].ToString() : tbxPrice.Text;
                        cmd = new SqlCommand("Update tblItems set ProductName=@name,  Price=@price where ItemID='" + id + "'", cn);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@price", price);
                    }
                    reader.Close();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    displayItems();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbxItemID.Text == "")
            {
                MessageBox.Show("Delete Failed! Item ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cn.Open();
                    string id = tbxItemID.Text;
                    cmd = new SqlCommand("Delete from tblItems where ItemID ='" + id + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item Deleted!");
                    displayItems();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}

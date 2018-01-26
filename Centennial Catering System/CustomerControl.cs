using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Centennial_Catering_System
{
    public partial class CustomerControl : UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
        }


        //Connection String for home PC
        public static string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\FW 2017- 2018\COMP 212\Midterm\Centennial Catering System\Centennial Catering System\App_Data\CateringDB.mdf;Integrated Security=True";
        //Connection String for minion USB
        //public string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\New folder\COMP 212\Midterm\Centennial Catering System\Centennial Catering System\App_Data\CateringDB.mdf;Integrated Security=True";
        SqlConnection cn = new SqlConnection(cnStr);
        SqlCommand cmd;


        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            lbResult.ForeColor = Color.Crimson;
            lbResult.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (tbxCustomerID.Text == "")
            {
                lbResult.ForeColor = Color.Crimson;
                lbResult.Text = "Please enter a value!";
            }
            else
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("select * from tblCustomers where CustomerID='" + tbxCustomerID.Text + "';", cn);
                    if (cmd.ExecuteScalar() == null)
                    {
                        btnClear_Click(sender, e);
                        lbResult.Text = "Customer Record Not Found!";
                    }
                    else
                    {
                        btnClear_Click(sender, e);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            CustomerInfo c = new CustomerInfo
                            {
                                CustomerID = reader[0].ToString(),
                                FirstName = reader[1].ToString(),
                                LastName = reader[2].ToString(),
                                Phone = reader[3].ToString(),
                                Email = reader[4].ToString(),
                                Address1 = reader.IsDBNull(5) ? "" : reader[5].ToString(),
                                Address2 = reader.IsDBNull(6) ? "" : reader[6].ToString(),
                                City = reader.IsDBNull(7) ? "" : reader[7].ToString(),
                                Province = reader.IsDBNull(8) ? "" : reader[8].ToString(),
                                PostalCode = reader.IsDBNull(9) ? "" : reader[9].ToString().ToUpper()
                            };

                            tbxCustomerID.Text = c.CustomerID;
                            tbxFName.Text = c.FirstName;
                            tbxLName.Text = c.LastName;
                            tbxPhone.Text = c.Phone;
                            tbxEmail.Text = c.Email;
                            tbxAddress1.Text = c.Address1;
                            tbxAddress2.Text = c.Address2;
                            tbxCity.Text = c.City;
                            tbxProvince.Text = c.Province;
                            tbxPostCode.Text = c.PostalCode;

                            lbResult.ForeColor = Color.ForestGreen;
                            lbResult.Text = "Customer Record Found!";

                        }
                        reader.Close();
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxCustomerID.Text == "" || tbxFName.Text == "" || tbxLName.Text == "" ||
                tbxPhone.Text == "" || tbxEmail.Text == "")
            {
                lbResult.ForeColor = Color.Crimson;
                lbResult.Text = "Save Failed! Information Missing.";
            }
            else
            {
                try
                {
                    CustomerInfo c = new CustomerInfo
                    {
                        CustomerID = tbxCustomerID.Text,
                        FirstName = tbxFName.Text,
                        LastName = tbxLName.Text,
                        Phone = tbxPhone.Text,
                        Email = tbxEmail.Text,
                        Address1 = tbxAddress1.Text,
                        Address2 = tbxAddress2.Text,
                        City = tbxCity.Text,
                        Province = tbxProvince.Text,
                        PostalCode = tbxPostCode.Text
                    };

                    cn.Open();
                    cmd = new SqlCommand("Insert Into tblCustomers Values (@id,@fn,@ln,@phone,@email,@a1,@a2,@city,@prov,@pc);", cn);
                    cmd.Parameters.AddWithValue("@id", c.CustomerID);
                    cmd.Parameters.AddWithValue("@fn", c.FirstName);
                    cmd.Parameters.AddWithValue("@ln", c.LastName);
                    cmd.Parameters.AddWithValue("@phone", c.Phone);
                    cmd.Parameters.AddWithValue("@email", c.Email);
                    cmd.Parameters.AddWithValue("@a1", c.Address1 == "" ? (object)DBNull.Value : c.Address1);
                    cmd.Parameters.AddWithValue("@a2", c.Address2 == "" ? (object)DBNull.Value : c.Address2);
                    cmd.Parameters.AddWithValue("@city", c.City == "" ? (object)DBNull.Value : c.City);
                    cmd.Parameters.AddWithValue("@prov", c.Province == "" ? (object)DBNull.Value : c.Province);
                    cmd.Parameters.AddWithValue("@pc", c.PostalCode == "" ? (object)DBNull.Value : c.PostalCode.ToUpper());
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    btnClear_Click(sender, e);
                    lbResult.ForeColor = Color.ForestGreen;
                    lbResult.Text = "Customer Information Saved!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbxCustomerID.Text == "")
            {
                lbResult.ForeColor = Color.Crimson;
                lbResult.Text = "Customer Id Cannot be empty!";
            }
            else
            {
                try
                {

                    cn.Open();
                    cmd = new SqlCommand("select * from tblCustomers where CustomerID='" + tbxCustomerID.Text + "';", cn);
                    if (cmd.ExecuteScalar() == null)
                    {
                        btnClear_Click(sender, e);
                        lbResult.Text = "Customer Record Not Found!";
                        cn.Close();
                    }
                    else
                    {
                        CustomerInfo c = new CustomerInfo();
                        cn.Close();
                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            c = new CustomerInfo
                            {
                                CustomerID = reader[0].ToString(),
                                FirstName = tbxFName.Text == "" ? reader[1].ToString() : tbxFName.Text,
                                LastName = tbxLName.Text == "" ? reader[2].ToString() : tbxLName.Text,
                                Phone = tbxPhone.Text == "" ? reader[3].ToString() : tbxPhone.Text,
                                Email = tbxEmail.Text == "" ? reader[4].ToString() : tbxEmail.Text,
                                Address1 = tbxAddress1.Text == "" ? reader.IsDBNull(5) ? "" : reader[5].ToString() : tbxAddress1.Text,
                                Address2 = tbxAddress2.Text == "" ? reader.IsDBNull(6) ? "" : reader[6].ToString() : tbxAddress2.Text,
                                City = tbxCity.Text == "" ? reader.IsDBNull(7) ? "" : reader[7].ToString() : tbxCity.Text,
                                Province = tbxProvince.Text == "" ? reader.IsDBNull(8) ? "" : reader[8].ToString() : tbxProvince.Text,
                                PostalCode = tbxPostCode.Text == "" ? reader.IsDBNull(9) ? "" : reader[9].ToString().ToUpper() : tbxPostCode.Text.ToUpper()
                            };
                        }
                        reader.Close();
                        cmd = new SqlCommand("Update tblCustomers set FirstName=@fn,LastName=@ln,Phone=@phone,Email=@email,Address1=@a1,Address2=@a2,City=@city,Province=@prov,PostalCode=@pc", cn);
                        cmd.Parameters.AddWithValue("@fn", c.FirstName);
                        cmd.Parameters.AddWithValue("@ln", c.LastName);
                        cmd.Parameters.AddWithValue("@phone", c.Phone);
                        cmd.Parameters.AddWithValue("@email", c.Email);
                        cmd.Parameters.AddWithValue("@a1", c.Address1 == "" ? (object)DBNull.Value : c.Address1);
                        cmd.Parameters.AddWithValue("@a2", c.Address2 == "" ? (object)DBNull.Value : c.Address2);
                        cmd.Parameters.AddWithValue("@city", c.City == "" ? (object)DBNull.Value : c.City);
                        cmd.Parameters.AddWithValue("@prov", c.Province == "" ? (object)DBNull.Value : c.Province);
                        cmd.Parameters.AddWithValue("@pc", c.PostalCode == "" ? (object)DBNull.Value : c.PostalCode.ToUpper());
                        cmd.ExecuteNonQuery();

                        btnClear_Click(sender, e);
                        lbResult.ForeColor = Color.ForestGreen;
                        lbResult.Text = "Customer Record Updated!";


                        cn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbxCustomerID.Text == "")
            {
                lbResult.ForeColor = Color.Crimson;
                lbResult.Text = "Customer Id Cannot be empty!";
            }
            else
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("Delete from tblCustomers where CustomerID='" + tbxCustomerID.Text + "';", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    btnClear_Click(sender, e);
                    lbResult.ForeColor = Color.ForestGreen;
                    lbResult.Text = "Customer Information Deleted!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

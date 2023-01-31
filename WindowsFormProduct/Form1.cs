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
using System.Configuration;
namespace WindowsFormProduct
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
        }
        private void ClearForm()
        {
            textid.Clear();
            textname.Clear();
            textprice.Clear();
            textcompname.Clear();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write the sql query
                string qry = "insert into product2 values(@name,@price,@companyname)";
                //step3 the query to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@name", textname.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(textprice.Text));
                cmd.Parameters.AddWithValue("@companyname", textcompname.Text);
                //step5 oppen con
                con.Open();
                //step6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("record added");
                    ClearForm();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //step7
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write the sql query
                string qry = "update product2 set name=@name,price=@price,companyname=@companyname where id=@id";
                //step3 the query to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@name", textname.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(textprice.Text));
                cmd.Parameters.AddWithValue("@companyname", textcompname.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textid.Text));
                //step5 oppen con
                con.Open();
                //step6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("record updated");
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //step7
                con.Close();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write the sql query
                string qry = "select * from product2 where id=@id";
                //step3 the query to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textid.Text));
                //step5 oppen con
                con.Open();
                //step6 fire the query
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textname.Text = dr["pname"].ToString();
                        textprice.Text = dr["price"].ToString();
                        textcompname.Text = dr["companyname"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //step7
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write the sql query
                string qry = "delete from product2 where id=@id";
                //step3 the query to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textid.Text));

                //step5 oppen con
                con.Open();
                //step6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("record deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //step7
                con.Close();
            }
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write the sql query
                string qry = "select * from product2 where id=@id";
                //step3 the query to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textid.Text));
                //step5 oppen con
                con.Open();
                //step6 fire the query
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //step7
                con.Close();
            }
        }
    }
}

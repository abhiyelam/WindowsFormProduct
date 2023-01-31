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
    public partial class FormE : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public FormE()
        {
            InitializeComponent();
            //step1 create connection
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

        }
        private void ClearForm()
        {
            textId.Clear();
            textename.Clear();
            textdname.Clear();
            textage.Clear();
            textsalary.Clear();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write the sql query
                string qry = "insert into tblEmployee values(@ename,@dname,@age,@salary)";
                //step3 pass  the query and con to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@ename", textename.Text);
                cmd.Parameters.AddWithValue("@dname", textdname.Text);
                cmd.Parameters.AddWithValue("@age",Convert.ToInt32(textage.Text));
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(textsalary.Text));
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write the sql query
                string qry = "update  tblEmployee set ename=@ename,dname=@dname,age=@age,salary=@salary where id=@id";
                //step3 the query to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@ename", textename.Text);
                cmd.Parameters.AddWithValue("@dname", textdname.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(textage.Text));
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(textsalary.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));
                //step5 oppen con
                con.Open();
                //step6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("record update");
                    ClearForm();
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
                //step2 write sql query
                string qry = "delete from tblEmployee where id=@id";
                //step3 pass  the query and con to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));
                //step5 open con
                con.Open();
                //step6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("recoed deleted");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write sql query
                string qry = "select * from tblEmployee where id=@id";
                //step3 pass  the query and con to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));
                //step5 open con
                con.Open();
                //step6 fire the query
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        textename.Text = dr["ename"].ToString();
                        textdname.Text = dr["dname"].ToString();
                        textage.Text = dr["age"].ToString();
                        textsalary.Text = dr["salary"].ToString();
                        
                    }
                    
                }
                else
                {
                    MessageBox.Show("recoed not found");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write sql query
                string qry = "select * from tblEmployee where id=@id";
                //step3 pass  the query and con to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
               cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));
                //step5 open con
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
                con.Close();
            }
        }

        private void btn1clear_Click(object sender, EventArgs e)
        {
            textId.Clear();
            textename.Clear();
            textdname.Clear();
            textage.Clear();
            textsalary.Clear();
        }

        private void btnclear_Load(object sender, EventArgs e)
        {

        }
    }
}

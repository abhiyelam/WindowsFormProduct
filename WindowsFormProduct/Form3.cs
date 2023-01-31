using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormProduct
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }
        private void ClearForm()
        {
            textrollno.Clear();
            textsname.Clear();
            textbranch.Clear();
            txtage.Clear();
            textgender.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write the sql query
                string qry = "insert into student4 values(@rollno,@sname,@branch,@mark,@age,@gender)";
                //step3 pass  the query and con to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(textrollno.Text));
                cmd.Parameters.AddWithValue("@sname", textsname.Text);
                cmd.Parameters.AddWithValue("@branch", textbranch.Text);
                cmd.Parameters.AddWithValue("@mark", Convert.ToInt32(textpercentage.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtage.Text));
                cmd.Parameters.AddWithValue("@gender", textgender.Text);
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
                string qry = "update student4 set sname=@sname,branch=@branch,mark=@mark,age=@age,gender=@gender where rollno=@rollno";
                //step3 pass  the query and con to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(textrollno.Text));
                cmd.Parameters.AddWithValue("@sname", textsname.Text);
                cmd.Parameters.AddWithValue("@branch", textbranch.Text);
                cmd.Parameters.AddWithValue("@mark", Convert.ToInt32(textpercentage.Text));
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtage.Text));
                cmd.Parameters.AddWithValue("@gender", textgender.Text);
                //step5 oppen con
                con.Open();
                //step6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("record updated");
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
                //step2 write the sql query
                string qry = "delete from student4 where rollno=@rollno";
                //step3 pass  the query and con to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(textrollno.Text));
               
                //step5 oppen con
                con.Open();
                //step6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("record deleted");
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write sql query
                string qry = "select * from tblEmployee where Rollno=@Rollno";
                //step3 pass  the query and con to command class
                cmd = new SqlCommand(qry, con);
                //step4 assign values to the parameter
                cmd.Parameters.AddWithValue("@Rollno", Convert.ToInt32(textrollno.Text));
                //step5 open con
                con.Open();
                //step6 fire the query
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textsname.Text = dr["sname"].ToString();
                        textbranch.Text = dr["branch"].ToString();
                        textpercentage.Text = dr["mark"].ToString();
                        txtage.Text= dr["age"].ToString();
                        textgender.Text = dr["gender"].ToString();
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
    }
}

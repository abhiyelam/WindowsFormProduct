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
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormProduct
{
    public partial class Form6 : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommandBuilder SqlCommandBuilder;
        DataSet ds;
        private void ClearForm()
        {
            textrollno.Clear();
            textsname.Clear();
            textbranch.Clear();
            textpercentage.Clear();
            txtage.Clear();
            textgender.Clear();
        }
        public Form6()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }
        private DataSet GetAll()
        {
            adapter = new SqlDataAdapter("select * from student4", con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "stud");
            return ds;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["stud"].NewRow();
                row["Rollno"] = textrollno.Text;
                row["sname"] = textsname.Text;
                row["branch"] = textbranch.Text;
                row["Mark"] = textpercentage.Text;
                row["age"] = txtage.Text;
                row["gender"] = textgender.Text;
                ds.Tables["stud"].Rows.Add(row);
                int result = adapter.Update(ds.Tables["stud"]);
                if (result == 1)
                {
                    MessageBox.Show("record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["stud"].Rows.Find(textrollno.Text);
                if (row != null)
                {
                    row["rollno"] = textrollno.Text;
                    row["sname"] = textsname.Text;
                    row["branch"] = textbranch.Text;
                    row["percentage"] = textpercentage.Text;
                    row["age"] = txtage.Text;
                    row["gender"] = textgender.Text;


                    int result = adapter.Update(ds.Tables["stud"]);
                    if (result == 1)
                    {
                        MessageBox.Show("record updated");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["stud"].Rows.Find(textrollno.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = adapter.Update(ds.Tables["stud"]);
                    if (result == 1)
                    {
                        MessageBox.Show("record deleted");
                    }
                    else
                    {
                        MessageBox.Show("record not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["stud"].Rows.Find(textrollno.Text);
                if (row != null)
                {
                      textrollno.Text = row["rollno"].ToString();
                    textsname.Text = row["sname"].ToString();
                    textbranch.Text = row["branch"].ToString();
                    textpercentage.Text = row["Mark"].ToString();
                    txtage.Text = row["age"].ToString();
                    textgender.Text = row["gender"].ToString();


                    //int result = adapter.Update(ds.Tables["stud"]);
                    
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
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                dataGridView1.DataSource = ds.Tables["stud"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

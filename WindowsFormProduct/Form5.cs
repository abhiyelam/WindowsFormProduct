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
    public partial class Form5 : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommandBuilder SqlCommandBuilder;
        DataSet ds;
        public Form5()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }
        private DataSet GetAll()
        {
            adapter = new SqlDataAdapter("select * from tblEmployee",con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "Emp");
            return ds;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["Emp"].NewRow();
                row["ename"] = textename.Text;
                row["dname"] = textdname.Text;
                row["age"] = textage.Text;
                row["salary"] = textsalary.Text;
                ds.Tables["Emp"].Rows.Add(row);
                int result = adapter.Update(ds.Tables["Emp"]);
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
                DataRow row = ds.Tables["Emp"].Rows.Find(textId.Text);
                if (row != null)
                {
                    row["ename"] = textename.Text;
                    row["dname"] = textdname.Text;
                    row["age"] = textage.Text;
                    row["salary"] = textsalary.Text;
                   

                    int result = adapter.Update(ds.Tables["Emp"]);
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
                DataRow row = ds.Tables["Emp"].Rows.Find(textId.Text);
                if (row != null)
                {
                    row.Delete();
                     int result = adapter.Update(ds.Tables["Emp"]);
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
                DataRow row = ds.Tables["Emp"].Rows.Find(textId.Text);
                if (row != null)
                {
                    textename.Text = row["ename"].ToString();
                    textdname.Text = row["dname"].ToString();
                    textage.Text = row["age"].ToString();
                    textsalary.Text = row["salary"].ToString();

                    int result = adapter.Update(ds.Tables["Emp"]);
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
                dataGridView1.DataSource = ds.Tables["Emp"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
 }


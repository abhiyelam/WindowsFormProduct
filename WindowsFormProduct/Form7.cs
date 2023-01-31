using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
namespace WindowsFormProduct
{
    public partial class Form7 : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommandBuilder SqlCommandBuilder;
        DataSet ds;
        public Form7()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
        }

        private void lblbname_Click(object sender, EventArgs e)
        {

        }
        private DataSet GetAll()
        {
            adapter = new SqlDataAdapter("select * from book1",con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "book");
            return ds;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["book"].NewRow();
                row["name"] = textbname.Text;
                row["price"] = textprice.Text;
                row["author"] = textauthor.Text;
                row["edition"] = textedition.Text;
                row["publication"] = textpublication.Text;
                ds.Tables["book"].Rows.Add(row);
                int result = adapter.Update(ds.Tables["book"]);
                if (result == 1)
                {
                    MessageBox.Show("record inserted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["book"].Rows.Find(textid.Text);
                if (row != null)
                {
                    row["name"] = textbname.Text;
                    row["price"] = textprice.Text;
                    row["author"] = textauthor.Text;
                    row["edition"] = textedition.Text;
                    row["publication"] = textpublication.Text;
                  
                    int result = adapter.Update(ds.Tables["book"]);
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
                DataRow row = ds.Tables["book"].Rows.Find(textid.Text);
                if (row != null)
                {
                    row.Delete();
                    //ds.Tables["book"].Rows.Add(row);
                    int result = adapter.Update(ds.Tables["book"]);
                    if (result == 1)
                    {
                        MessageBox.Show("record deleted");
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
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAll();
                DataRow row = ds.Tables["book"].Rows.Find(textid.Text);
                if (row != null)
                {
                    textbname.Text = row["name"].ToString();
                    textprice.Text= row["price"].ToString();
                    textauthor.Text = row["author"].ToString();
                    textedition.Text = row["edition"].ToString();
                    textpublication.Text = row["publication"].ToString();

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
                dataGridView1.DataSource = ds.Tables["book"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

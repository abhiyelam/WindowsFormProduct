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
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommandBuilder SqlCommandBuilder;
        DataSet ds;

        public Form4()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

        }
        private DataSet GetALL()
        {
            adapter = new SqlDataAdapter("select * from Product2",con);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "product");
            return ds;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetALL();
                DataRow row = ds.Tables["product"].NewRow();
                row["pName"] = textname.Text;
                row["price"] = textprice.Text;
                row["companyname"] = textcompname.Text;
                ds.Tables["product"].Rows.Add(row);
                int result = adapter.Update(ds.Tables["product"]);
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetALL();
                DataRow row = ds.Tables["product"].NewRow();
                //row["pName"] = textname.Text;
               // row["price"] = textprice.Text;
               // row["companyname"] = textcompname.Text;
                ds.Tables["product"].Rows.Find(textid.Text);
                //int result = adapter.Update(ds.Tables["product"]);
                if (row != null)
                {
                    textname.Text = row["pName"].ToString();
                    textprice.Text = row["price"].ToString();
                    textcompname.Text = row["companyname"].ToString();
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
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetALL();
                DataRow row = ds.Tables["product"].NewRow();
                //row["pName"] = textname.Text;
                // row["price"] = textprice.Text;
                // row["companyname"] = textcompname.Text;
                ds.Tables["product"].Rows.Find(textid.Text);
                //int result = adapter.Update(ds.Tables["product"]);
                if (row != null)
                {
                    row["pName"] = textname.Text;
                    row["price"] = textprice.Text;
                    row["companyname"] = textcompname.Text;
                    int result = adapter.Update(ds.Tables["product"]);
                    if (result == 1)
                    {
                        MessageBox.Show("record updated");

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
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetALL();
                DataRow row = ds.Tables["product"].NewRow();
                
                ds.Tables["product"].Rows.Find(textid.Text);
                //int result = adapter.Update(ds.Tables["product"]);
                if (row != null)
                {
                    row.Delete();
                    int result = adapter.Update(ds.Tables["product"]);
                    if (result == 1)
                    {
                        MessageBox.Show("record deleted");

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
        }
    }
 }



namespace WindowsFormProduct
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.textcompname = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.lblpcompany = new System.Windows.Forms.Label();
            this.lblpprice = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(452, 300);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(62, 23);
            this.btnshowall.TabIndex = 26;
            this.btnshowall.Text = "Showall";
            this.btnshowall.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(375, 300);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(62, 23);
            this.btnsearch.TabIndex = 25;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(295, 300);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(62, 23);
            this.btndelete.TabIndex = 24;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(211, 300);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(62, 23);
            this.btnupdate.TabIndex = 23;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(143, 300);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(62, 23);
            this.btnsave.TabIndex = 22;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // textcompname
            // 
            this.textcompname.Location = new System.Drawing.Point(227, 260);
            this.textcompname.Name = "textcompname";
            this.textcompname.Size = new System.Drawing.Size(100, 20);
            this.textcompname.TabIndex = 21;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(227, 217);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(100, 20);
            this.textprice.TabIndex = 20;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(227, 170);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 19;
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(227, 128);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 18;
            // 
            // lblpcompany
            // 
            this.lblpcompany.AutoSize = true;
            this.lblpcompany.Location = new System.Drawing.Point(142, 263);
            this.lblpcompany.Name = "lblpcompany";
            this.lblpcompany.Size = new System.Drawing.Size(76, 13);
            this.lblpcompany.TabIndex = 17;
            this.lblpcompany.Text = "companyname";
            // 
            // lblpprice
            // 
            this.lblpprice.AutoSize = true;
            this.lblpprice.Location = new System.Drawing.Point(170, 224);
            this.lblpprice.Name = "lblpprice";
            this.lblpprice.Size = new System.Drawing.Size(31, 13);
            this.lblpprice.TabIndex = 16;
            this.lblpprice.Text = "Price";
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Location = new System.Drawing.Point(170, 177);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(42, 13);
            this.lblpname.TabIndex = 15;
            this.lblpname.Text = "PName";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(170, 131);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 13);
            this.lblid.TabIndex = 14;
            this.lblid.Text = "pid";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.textcompname);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.lblpcompany);
            this.Controls.Add(this.lblpprice);
            this.Controls.Add(this.lblpname);
            this.Controls.Add(this.lblid);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox textcompname;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label lblpcompany;
        private System.Windows.Forms.Label lblpprice;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label lblid;
    }
}
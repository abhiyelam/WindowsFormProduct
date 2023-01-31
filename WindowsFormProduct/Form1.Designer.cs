
namespace WindowsFormProduct
{
    partial class Form1
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.lblpprice = new System.Windows.Forms.Label();
            this.lblpcompany = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.textcompname = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(165, 50);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "pid";
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Location = new System.Drawing.Point(165, 96);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(42, 13);
            this.lblpname.TabIndex = 1;
            this.lblpname.Text = "PName";
            // 
            // lblpprice
            // 
            this.lblpprice.AutoSize = true;
            this.lblpprice.Location = new System.Drawing.Point(165, 143);
            this.lblpprice.Name = "lblpprice";
            this.lblpprice.Size = new System.Drawing.Size(31, 13);
            this.lblpprice.TabIndex = 2;
            this.lblpprice.Text = "Price";
            // 
            // lblpcompany
            // 
            this.lblpcompany.AutoSize = true;
            this.lblpcompany.Location = new System.Drawing.Point(137, 182);
            this.lblpcompany.Name = "lblpcompany";
            this.lblpcompany.Size = new System.Drawing.Size(76, 13);
            this.lblpcompany.TabIndex = 3;
            this.lblpcompany.Text = "companyname";
            this.lblpcompany.Click += new System.EventHandler(this.label4_Click);
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(222, 47);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 4;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(222, 89);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 5;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(222, 136);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(100, 20);
            this.textprice.TabIndex = 6;
            // 
            // textcompname
            // 
            this.textcompname.Location = new System.Drawing.Point(222, 179);
            this.textcompname.Name = "textcompname";
            this.textcompname.Size = new System.Drawing.Size(100, 20);
            this.textcompname.TabIndex = 7;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(138, 219);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(62, 23);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(206, 219);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(62, 23);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(290, 219);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(62, 23);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(370, 219);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(62, 23);
            this.btnsearch.TabIndex = 11;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(447, 219);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(62, 23);
            this.btnshowall.TabIndex = 12;
            this.btnshowall.Text = "Showall";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Label lblpprice;
        private System.Windows.Forms.Label lblpcompany;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox textcompname;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


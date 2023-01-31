
namespace WindowsFormProduct
{
    partial class Form7
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
            this.textpublication = new System.Windows.Forms.TextBox();
            this.textedition = new System.Windows.Forms.TextBox();
            this.textauthor = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.textbname = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.lblpublication = new System.Windows.Forms.Label();
            this.lbledition = new System.Windows.Forms.Label();
            this.lblauthor = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblbname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 52;
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(478, 334);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 51;
            this.btnshowall.Text = "showall";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(397, 334);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 50;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(316, 334);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 49;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(235, 334);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 48;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(154, 334);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 47;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // textpublication
            // 
            this.textpublication.Location = new System.Drawing.Point(236, 279);
            this.textpublication.Name = "textpublication";
            this.textpublication.Size = new System.Drawing.Size(100, 20);
            this.textpublication.TabIndex = 46;
            // 
            // textedition
            // 
            this.textedition.Location = new System.Drawing.Point(236, 253);
            this.textedition.Name = "textedition";
            this.textedition.Size = new System.Drawing.Size(100, 20);
            this.textedition.TabIndex = 45;
            // 
            // textauthor
            // 
            this.textauthor.Location = new System.Drawing.Point(236, 227);
            this.textauthor.Name = "textauthor";
            this.textauthor.Size = new System.Drawing.Size(100, 20);
            this.textauthor.TabIndex = 44;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(236, 197);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(100, 20);
            this.textprice.TabIndex = 43;
            // 
            // textbname
            // 
            this.textbname.Location = new System.Drawing.Point(235, 166);
            this.textbname.Name = "textbname";
            this.textbname.Size = new System.Drawing.Size(100, 20);
            this.textbname.TabIndex = 42;
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(236, 130);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 41;
            // 
            // lblpublication
            // 
            this.lblpublication.AutoSize = true;
            this.lblpublication.Location = new System.Drawing.Point(163, 286);
            this.lblpublication.Name = "lblpublication";
            this.lblpublication.Size = new System.Drawing.Size(58, 13);
            this.lblpublication.TabIndex = 40;
            this.lblpublication.Text = "publication";
            // 
            // lbledition
            // 
            this.lbledition.AutoSize = true;
            this.lbledition.Location = new System.Drawing.Point(180, 261);
            this.lbledition.Name = "lbledition";
            this.lbledition.Size = new System.Drawing.Size(38, 13);
            this.lbledition.TabIndex = 39;
            this.lbledition.Text = "edition";
            // 
            // lblauthor
            // 
            this.lblauthor.AutoSize = true;
            this.lblauthor.Location = new System.Drawing.Point(168, 230);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(37, 13);
            this.lblauthor.TabIndex = 38;
            this.lblauthor.Text = "author";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(180, 197);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(30, 13);
            this.lblprice.TabIndex = 37;
            this.lblprice.Text = "price";
            // 
            // lblbname
            // 
            this.lblbname.AutoSize = true;
            this.lblbname.Location = new System.Drawing.Point(163, 169);
            this.lblbname.Name = "lblbname";
            this.lblbname.Size = new System.Drawing.Size(57, 13);
            this.lblbname.TabIndex = 36;
            this.lblbname.Text = "bookname";
            this.lblbname.Click += new System.EventHandler(this.lblbname_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(180, 133);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 13);
            this.lblid.TabIndex = 35;
            this.lblid.Text = "id";
            // 
            // Form7
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
            this.Controls.Add(this.textpublication);
            this.Controls.Add(this.textedition);
            this.Controls.Add(this.textauthor);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textbname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.lblpublication);
            this.Controls.Add(this.lbledition);
            this.Controls.Add(this.lblauthor);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblbname);
            this.Controls.Add(this.lblid);
            this.Name = "Form7";
            this.Text = "Form7";
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
        private System.Windows.Forms.TextBox textpublication;
        private System.Windows.Forms.TextBox textedition;
        private System.Windows.Forms.TextBox textauthor;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox textbname;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label lblpublication;
        private System.Windows.Forms.Label lbledition;
        private System.Windows.Forms.Label lblauthor;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblbname;
        private System.Windows.Forms.Label lblid;
    }
}

namespace WindowsFormProduct
{
    partial class FormE
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
            this.lblname = new System.Windows.Forms.Label();
            this.lbldname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblsalary = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textdname = new System.Windows.Forms.TextBox();
            this.textename = new System.Windows.Forms.TextBox();
            this.textsalary = new System.Windows.Forms.TextBox();
            this.textage = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn1clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(126, 53);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "id";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(126, 93);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "ename";
            // 
            // lbldname
            // 
            this.lbldname.AutoSize = true;
            this.lbldname.Location = new System.Drawing.Point(126, 136);
            this.lbldname.Name = "lbldname";
            this.lbldname.Size = new System.Drawing.Size(63, 13);
            this.lbldname.TabIndex = 2;
            this.lbldname.Text = "departname";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(126, 175);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(25, 13);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "age";
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Location = new System.Drawing.Point(126, 211);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(34, 13);
            this.lblsalary.TabIndex = 4;
            this.lblsalary.Text = "salary";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(196, 50);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 5;
            // 
            // textdname
            // 
            this.textdname.Location = new System.Drawing.Point(196, 136);
            this.textdname.Name = "textdname";
            this.textdname.Size = new System.Drawing.Size(100, 20);
            this.textdname.TabIndex = 6;
            // 
            // textename
            // 
            this.textename.Location = new System.Drawing.Point(196, 93);
            this.textename.Name = "textename";
            this.textename.Size = new System.Drawing.Size(100, 20);
            this.textename.TabIndex = 7;
            // 
            // textsalary
            // 
            this.textsalary.Location = new System.Drawing.Point(196, 211);
            this.textsalary.Name = "textsalary";
            this.textsalary.Size = new System.Drawing.Size(100, 20);
            this.textsalary.TabIndex = 8;
            this.textsalary.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textage
            // 
            this.textage.Location = new System.Drawing.Point(196, 175);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(100, 20);
            this.textage.TabIndex = 9;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(115, 257);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(209, 257);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(306, 257);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(411, 257);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(522, 257);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 14;
            this.btnshowall.Text = "showall";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // btn1clear
            // 
            this.btn1clear.Location = new System.Drawing.Point(411, 306);
            this.btn1clear.Name = "btn1clear";
            this.btn1clear.Size = new System.Drawing.Size(75, 21);
            this.btn1clear.TabIndex = 16;
            this.btn1clear.Text = "clear";
            this.btn1clear.UseVisualStyleBackColor = true;
            this.btn1clear.Click += new System.EventHandler(this.btn1clear_Click);
            // 
            // FormE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.textage);
            this.Controls.Add(this.textsalary);
            this.Controls.Add(this.textename);
            this.Controls.Add(this.textdname);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lbldname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Name = "FormE";
            this.Text = "clear";
            this.Load += new System.EventHandler(this.btnclear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textdname;
        private System.Windows.Forms.TextBox textename;
        private System.Windows.Forms.TextBox textsalary;
        private System.Windows.Forms.TextBox textage;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn1clear;
    }
}
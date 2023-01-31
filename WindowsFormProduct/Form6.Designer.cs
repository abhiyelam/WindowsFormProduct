
namespace WindowsFormProduct
{
    partial class Form6
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
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.textgender = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.textpercentage = new System.Windows.Forms.TextBox();
            this.textbranch = new System.Windows.Forms.TextBox();
            this.textsname = new System.Windows.Forms.TextBox();
            this.textrollno = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblpercent = new System.Windows.Forms.Label();
            this.lblstrem = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblrollno = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(525, 316);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 33;
            this.btnshowall.Text = "showall";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(444, 316);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 32;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(363, 316);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 31;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(282, 316);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 30;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(201, 316);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 29;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // textgender
            // 
            this.textgender.Location = new System.Drawing.Point(283, 261);
            this.textgender.Name = "textgender";
            this.textgender.Size = new System.Drawing.Size(100, 20);
            this.textgender.TabIndex = 28;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(283, 235);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 20);
            this.txtage.TabIndex = 27;
            // 
            // textpercentage
            // 
            this.textpercentage.Location = new System.Drawing.Point(283, 209);
            this.textpercentage.Name = "textpercentage";
            this.textpercentage.Size = new System.Drawing.Size(100, 20);
            this.textpercentage.TabIndex = 26;
            // 
            // textbranch
            // 
            this.textbranch.Location = new System.Drawing.Point(283, 179);
            this.textbranch.Name = "textbranch";
            this.textbranch.Size = new System.Drawing.Size(100, 20);
            this.textbranch.TabIndex = 25;
            // 
            // textsname
            // 
            this.textsname.Location = new System.Drawing.Point(283, 144);
            this.textsname.Name = "textsname";
            this.textsname.Size = new System.Drawing.Size(100, 20);
            this.textsname.TabIndex = 24;
            // 
            // textrollno
            // 
            this.textrollno.Location = new System.Drawing.Point(283, 112);
            this.textrollno.Name = "textrollno";
            this.textrollno.Size = new System.Drawing.Size(100, 20);
            this.textrollno.TabIndex = 23;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(227, 268);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(40, 13);
            this.lblgender.TabIndex = 22;
            this.lblgender.Text = "gender";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(227, 243);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(25, 13);
            this.lblage.TabIndex = 21;
            this.lblage.Text = "age";
            // 
            // lblpercent
            // 
            this.lblpercent.AutoSize = true;
            this.lblpercent.Location = new System.Drawing.Point(215, 212);
            this.lblpercent.Name = "lblpercent";
            this.lblpercent.Size = new System.Drawing.Size(61, 13);
            this.lblpercent.TabIndex = 20;
            this.lblpercent.Text = "percentage";
            // 
            // lblstrem
            // 
            this.lblstrem.AutoSize = true;
            this.lblstrem.Location = new System.Drawing.Point(227, 179);
            this.lblstrem.Name = "lblstrem";
            this.lblstrem.Size = new System.Drawing.Size(40, 13);
            this.lblstrem.TabIndex = 19;
            this.lblstrem.Text = "branch";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(226, 151);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 13);
            this.lblname.TabIndex = 18;
            this.lblname.Text = "sname";
            // 
            // lblrollno
            // 
            this.lblrollno.AutoSize = true;
            this.lblrollno.Location = new System.Drawing.Point(227, 115);
            this.lblrollno.Name = "lblrollno";
            this.lblrollno.Size = new System.Drawing.Size(37, 13);
            this.lblrollno.TabIndex = 17;
            this.lblrollno.Text = "Rollno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(453, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 34;
            // 
            // Form6
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
            this.Controls.Add(this.textgender);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.textpercentage);
            this.Controls.Add(this.textbranch);
            this.Controls.Add(this.textsname);
            this.Controls.Add(this.textrollno);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblpercent);
            this.Controls.Add(this.lblstrem);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblrollno);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox textgender;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox textpercentage;
        private System.Windows.Forms.TextBox textbranch;
        private System.Windows.Forms.TextBox textsname;
        private System.Windows.Forms.TextBox textrollno;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblpercent;
        private System.Windows.Forms.Label lblstrem;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblrollno;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

namespace WindowsFormProduct
{
    partial class Form3
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
            this.lblrollno = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblstrem = new System.Windows.Forms.Label();
            this.lblpercent = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.textrollno = new System.Windows.Forms.TextBox();
            this.textsname = new System.Windows.Forms.TextBox();
            this.textbranch = new System.Windows.Forms.TextBox();
            this.textpercentage = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.textgender = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblrollno
            // 
            this.lblrollno.AutoSize = true;
            this.lblrollno.Location = new System.Drawing.Point(187, 28);
            this.lblrollno.Name = "lblrollno";
            this.lblrollno.Size = new System.Drawing.Size(37, 13);
            this.lblrollno.TabIndex = 0;
            this.lblrollno.Text = "Rollno";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(186, 64);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "sname";
            // 
            // lblstrem
            // 
            this.lblstrem.AutoSize = true;
            this.lblstrem.Location = new System.Drawing.Point(187, 92);
            this.lblstrem.Name = "lblstrem";
            this.lblstrem.Size = new System.Drawing.Size(40, 13);
            this.lblstrem.TabIndex = 2;
            this.lblstrem.Text = "branch";
            // 
            // lblpercent
            // 
            this.lblpercent.AutoSize = true;
            this.lblpercent.Location = new System.Drawing.Point(175, 125);
            this.lblpercent.Name = "lblpercent";
            this.lblpercent.Size = new System.Drawing.Size(61, 13);
            this.lblpercent.TabIndex = 3;
            this.lblpercent.Text = "percentage";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(187, 156);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(25, 13);
            this.lblage.TabIndex = 4;
            this.lblage.Text = "age";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(187, 181);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(40, 13);
            this.lblgender.TabIndex = 5;
            this.lblgender.Text = "gender";
            // 
            // textrollno
            // 
            this.textrollno.Location = new System.Drawing.Point(243, 25);
            this.textrollno.Name = "textrollno";
            this.textrollno.Size = new System.Drawing.Size(100, 20);
            this.textrollno.TabIndex = 6;
            this.textrollno.Text = "1";
            // 
            // textsname
            // 
            this.textsname.Location = new System.Drawing.Point(243, 57);
            this.textsname.Name = "textsname";
            this.textsname.Size = new System.Drawing.Size(100, 20);
            this.textsname.TabIndex = 7;
            // 
            // textbranch
            // 
            this.textbranch.Location = new System.Drawing.Point(243, 92);
            this.textbranch.Name = "textbranch";
            this.textbranch.Size = new System.Drawing.Size(100, 20);
            this.textbranch.TabIndex = 8;
            // 
            // textpercentage
            // 
            this.textpercentage.Location = new System.Drawing.Point(243, 122);
            this.textpercentage.Name = "textpercentage";
            this.textpercentage.Size = new System.Drawing.Size(100, 20);
            this.textpercentage.TabIndex = 9;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(243, 148);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 20);
            this.txtage.TabIndex = 10;
            // 
            // textgender
            // 
            this.textgender.Location = new System.Drawing.Point(243, 174);
            this.textgender.Name = "textgender";
            this.textgender.Size = new System.Drawing.Size(100, 20);
            this.textgender.TabIndex = 11;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(161, 229);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(242, 229);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(323, 229);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(404, 229);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 15;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(485, 229);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 16;
            this.btnshowall.Text = "showall";
            this.btnshowall.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrollno;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstrem;
        private System.Windows.Forms.Label lblpercent;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.TextBox textrollno;
        private System.Windows.Forms.TextBox textsname;
        private System.Windows.Forms.TextBox textbranch;
        private System.Windows.Forms.TextBox textpercentage;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox textgender;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnshowall;
    }
}
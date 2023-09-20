
namespace South_Africa_ID_Validation
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIDcheck = new System.Windows.Forms.Button();
            this.txtIDnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER ID NUMBER";
            // 
            // btnIDcheck
            // 
            this.btnIDcheck.Location = new System.Drawing.Point(254, 278);
            this.btnIDcheck.Name = "btnIDcheck";
            this.btnIDcheck.Size = new System.Drawing.Size(191, 49);
            this.btnIDcheck.TabIndex = 1;
            this.btnIDcheck.Text = "validate ID";
            this.btnIDcheck.UseVisualStyleBackColor = true;
            this.btnIDcheck.Click += new System.EventHandler(this.btnIDcheck_Click);
            // 
            // txtIDnum
            // 
            this.txtIDnum.Location = new System.Drawing.Point(356, 135);
            this.txtIDnum.Name = "txtIDnum";
            this.txtIDnum.Size = new System.Drawing.Size(173, 26);
            this.txtIDnum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDnum);
            this.Controls.Add(this.btnIDcheck);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "S.A ID NO. VALIDATION APP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIDcheck;
        private System.Windows.Forms.TextBox txtIDnum;
        private System.Windows.Forms.Label label2;
    }
}


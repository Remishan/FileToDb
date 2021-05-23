namespace FileToDb
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
            this.btnDbToFile = new System.Windows.Forms.Button();
            this.txtLowerLimit = new System.Windows.Forms.TextBox();
            this.txtUpperLimit = new System.Windows.Forms.TextBox();
            this.btnFileToDb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDbToFile
            // 
            this.btnDbToFile.Location = new System.Drawing.Point(12, 36);
            this.btnDbToFile.Name = "btnDbToFile";
            this.btnDbToFile.Size = new System.Drawing.Size(75, 23);
            this.btnDbToFile.TabIndex = 0;
            this.btnDbToFile.Text = "DbToFile";
            this.btnDbToFile.UseVisualStyleBackColor = true;
            this.btnDbToFile.Click += new System.EventHandler(this.btnDbToFile_Click);
            // 
            // txtLowerLimit
            // 
            this.txtLowerLimit.Location = new System.Drawing.Point(104, 39);
            this.txtLowerLimit.Name = "txtLowerLimit";
            this.txtLowerLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLowerLimit.TabIndex = 1;
            // 
            // txtUpperLimit
            // 
            this.txtUpperLimit.Location = new System.Drawing.Point(221, 40);
            this.txtUpperLimit.Name = "txtUpperLimit";
            this.txtUpperLimit.Size = new System.Drawing.Size(100, 20);
            this.txtUpperLimit.TabIndex = 2;
            // 
            // btnFileToDb
            // 
            this.btnFileToDb.Location = new System.Drawing.Point(327, 40);
            this.btnFileToDb.Name = "btnFileToDb";
            this.btnFileToDb.Size = new System.Drawing.Size(75, 23);
            this.btnFileToDb.TabIndex = 3;
            this.btnFileToDb.Text = "File To Db";
            this.btnFileToDb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lower Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Upper Limit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 98);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFileToDb);
            this.Controls.Add(this.txtUpperLimit);
            this.Controls.Add(this.txtLowerLimit);
            this.Controls.Add(this.btnDbToFile);
            this.Name = "Form1";
            this.Text = "File And Database ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDbToFile;
        private System.Windows.Forms.TextBox txtLowerLimit;
        private System.Windows.Forms.TextBox txtUpperLimit;
        private System.Windows.Forms.Button btnFileToDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


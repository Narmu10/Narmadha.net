namespace EMart
{
    partial class Insert
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stdName = new System.Windows.Forms.TextBox();
            this.stdDepartment = new System.Windows.Forms.TextBox();
            this.InsertSubmit = new System.Windows.Forms.Button();
            this.stdDOB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert - Student Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOB";
            // 
            // stdName
            // 
            this.stdName.Location = new System.Drawing.Point(296, 150);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(259, 26);
            this.stdName.TabIndex = 4;
            this.stdName.TextChanged += new System.EventHandler(this.Nametextbox);
            // 
            // stdDepartment
            // 
            this.stdDepartment.Location = new System.Drawing.Point(296, 201);
            this.stdDepartment.Name = "stdDepartment";
            this.stdDepartment.Size = new System.Drawing.Size(259, 26);
            this.stdDepartment.TabIndex = 5;
            this.stdDepartment.TextChanged += new System.EventHandler(this.Departmenttextbox);
            // 
            // InsertSubmit
            // 
            this.InsertSubmit.Location = new System.Drawing.Point(316, 364);
            this.InsertSubmit.Name = "InsertSubmit";
            this.InsertSubmit.Size = new System.Drawing.Size(112, 40);
            this.InsertSubmit.TabIndex = 7;
            this.InsertSubmit.Text = "SUBMIT";
            this.InsertSubmit.UseVisualStyleBackColor = true;
            this.InsertSubmit.TextChanged += new System.EventHandler(this.Submitinsert);
            this.InsertSubmit.Click += new System.EventHandler(this.Submitinsert);
            // 
            // stdDOB
            // 
            this.stdDOB.Location = new System.Drawing.Point(296, 271);
            this.stdDOB.Name = "stdDOB";
            this.stdDOB.Size = new System.Drawing.Size(259, 26);
            this.stdDOB.TabIndex = 8;
            this.stdDOB.TextChanged += new System.EventHandler(this.dateofbirth);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stdDOB);
            this.Controls.Add(this.InsertSubmit);
            this.Controls.Add(this.stdDepartment);
            this.Controls.Add(this.stdName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Insert";
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.TextBox stdDepartment;
        private System.Windows.Forms.Button InsertSubmit;
        private System.Windows.Forms.TextBox stdDOB;
    }
}
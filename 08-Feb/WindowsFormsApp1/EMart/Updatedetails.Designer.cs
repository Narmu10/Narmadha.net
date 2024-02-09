namespace EMart
{
    partial class Updatedetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateName = new System.Windows.Forms.TextBox();
            this.updateDepartment = new System.Windows.Forms.TextBox();
            this.submitupdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rollno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department";
            // 
            // updateName
            // 
            this.updateName.Location = new System.Drawing.Point(427, 192);
            this.updateName.Name = "updateName";
            this.updateName.Size = new System.Drawing.Size(246, 26);
            this.updateName.TabIndex = 6;
            this.updateName.TextChanged += new System.EventHandler(this.nameUpdate);
            // 
            // updateDepartment
            // 
            this.updateDepartment.Location = new System.Drawing.Point(427, 242);
            this.updateDepartment.Name = "updateDepartment";
            this.updateDepartment.Size = new System.Drawing.Size(246, 26);
            this.updateDepartment.TabIndex = 7;
            this.updateDepartment.TextChanged += new System.EventHandler(this.departmentUpdate);
            // 
            // submitupdate
            // 
            this.submitupdate.Location = new System.Drawing.Point(303, 380);
            this.submitupdate.Name = "submitupdate";
            this.submitupdate.Size = new System.Drawing.Size(142, 43);
            this.submitupdate.TabIndex = 8;
            this.submitupdate.Text = "SUBMIT";
            this.submitupdate.UseVisualStyleBackColor = true;
            this.submitupdate.TextChanged += new System.EventHandler(this.submitUpdate);
            this.submitupdate.Click += new System.EventHandler(this.submitUpdate);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(214, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 60);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "UPDATE DETAILS";
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(427, 299);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(246, 26);
            this.DOB.TabIndex = 9;
            this.DOB.TextChanged += new System.EventHandler(this.onDateBirth);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Roll Number";
            // 
            // rollno
            // 
            this.rollno.Location = new System.Drawing.Point(427, 144);
            this.rollno.Name = "rollno";
            this.rollno.Size = new System.Drawing.Size(246, 26);
            this.rollno.TabIndex = 11;
            this.rollno.TextChanged += new System.EventHandler(this.onRollNoChange);
            // 
            // Updatedetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rollno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.submitupdate);
            this.Controls.Add(this.updateDepartment);
            this.Controls.Add(this.updateName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "Updatedetails";
            this.Text = "Updatedetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox updateName;
        private System.Windows.Forms.TextBox updateDepartment;
        private System.Windows.Forms.Button submitupdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox DOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rollno;
    }
}
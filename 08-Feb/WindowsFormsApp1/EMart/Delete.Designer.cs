namespace EMart
{
    partial class Delete
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
            this.deletetext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deletesubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deletetext
            // 
            this.deletetext.Location = new System.Drawing.Point(311, 159);
            this.deletetext.Name = "deletetext";
            this.deletetext.Size = new System.Drawing.Size(207, 26);
            this.deletetext.TabIndex = 0;
            this.deletetext.TextChanged += new System.EventHandler(this.deletebyidtextbox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete By ID";
            // 
            // deletesubmit
            // 
            this.deletesubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletesubmit.Location = new System.Drawing.Point(311, 297);
            this.deletesubmit.Name = "deletesubmit";
            this.deletesubmit.Size = new System.Drawing.Size(120, 37);
            this.deletesubmit.TabIndex = 2;
            this.deletesubmit.Text = "Submit";
            this.deletesubmit.UseVisualStyleBackColor = true;
            this.deletesubmit.TextChanged += new System.EventHandler(this.submitdelete);
            this.deletesubmit.Click += new System.EventHandler(this.submitdelete);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(301, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 53);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "DELETE";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deletesubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletetext);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deletetext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletesubmit;
        private System.Windows.Forms.TextBox textBox1;
    }
}
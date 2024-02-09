using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using EMartDllOperation;

namespace EMart
{
    public partial class Insert : Form
    {
        private new string Name;
        private string Department;
        private string DOB;
        public Insert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Nametextbox(object sender, EventArgs e)
        {
            this.Name = stdName.Text.Trim();
        }

        private void Departmenttextbox(object sender, EventArgs e)
        {
            this.Department = stdDepartment.Text.Trim();
        }

        private void Submitinsert(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.CreateConnection();
            int id=connection.Insert(this.Name,this.Department,this.DOB);
            if (id > 0)
            {
                MessageBox.Show("Inserted"+id);
                stdName.Text = "";
                stdDepartment.Text = "";
                stdDOB.Text = "";

            }
            else
            {
                
                MessageBox.Show("Insert Failed");
            }
            connection.Close();
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }

        private void dateofbirth(object sender, EventArgs e)
        {
            this.DOB = stdDOB.Text.Trim();
        }
    }
}

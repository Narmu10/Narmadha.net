using EMartDllOperation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMart
{
    public partial class Updatedetails : Form
    {
        private int RollNumber;
        private new string Name;
        private string Department;
        private string DoB;
        public Updatedetails()
        {
            InitializeComponent();
        }

       

        private void nameUpdate(object sender, EventArgs e)
        {
            this.Name = updateName.Text.Trim();
        }

        private void departmentUpdate(object sender, EventArgs e)
        {
            this.Department = updateDepartment.Text.Trim();
        }

        private void submitUpdate(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.CreateConnection();
           
            int id = connection.Update(this.RollNumber,this.Name, this.Department, this.DoB);
            if (id > 0)
            {
                updateName.Text = "";
                updateDepartment.Text = "";
                DOB.Text = "";
                MessageBox.Show("Updated" + id);

            }
            else
            {

                MessageBox.Show("Update Failed");
            }
            connection.Close();
        }

        private void onDateBirth(object sender, EventArgs e)
        {
            this.DoB=DOB.Text.Trim();
        }

        private void onRollNoChange(object sender, EventArgs e)
        {
            this.RollNumber=int.Parse(rollno.Text.Trim());
        }
    }
}

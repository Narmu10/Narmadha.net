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
    public partial class Delete : Form
    {
        private int RollNumber;
        public Delete()
        {
            InitializeComponent();
        }

        private void deletebyidtextbox(object sender, EventArgs e)
        {
            this.RollNumber = int.Parse(deletetext.Text);   
        }
        private void submitdelete(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.CreateConnection();
            int id = connection.Delete(this.RollNumber);
            if (id>0)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Deletion failed");
            }
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

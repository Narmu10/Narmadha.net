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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Display_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.CreateConnection();
            DataSet dataset= connection.Display();
            dataGridView.DataSource = dataset.Tables[0];
            connection.Close();
        }
    }
}

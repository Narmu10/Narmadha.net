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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Insert(object sender, EventArgs e)
        {
            var insert = new Insert();
            insert.Show(this);
            
           

        }

        private void Delete_item(object sender, EventArgs e)
        {
            var Delete_item = new Delete();
            Delete_item.Show(this);

        }

        private void Update_item(object sender, EventArgs e)
        {
            var Update_item = new Updatedetails();
            Update_item.Show(this);


        }

        private void Disply_item(object sender, EventArgs e)
        {
            var Display_Item = new Display();
            Display_Item.Show(this);


        }
    }
}

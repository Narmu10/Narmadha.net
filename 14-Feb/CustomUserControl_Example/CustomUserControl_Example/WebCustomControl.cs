using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomUserControl_Example
{
    
    [ToolboxData("<{0}:WebCustomControl runat=server></{0}:WebCustomControl>")]
    public class WebCustomControl : CompositeControl
    {
        Label userName;
        Label password;
        TextBox textBox1;
        TextBox textBox2;
        Button Submit;
        LiteralControl lt1;
        Label label1;
        
        protected override void CreateChildControls()
        {
            userName= new Label();
            userName.Text = "Enter username";
            userName.Width = Unit.Pixel(130);

            password=new Label();
            password.Text = "Enter username";
            password.Width = Unit.Pixel(130);

            textBox1 = new TextBox();
            textBox1.ID = "textbox1";
            textBox1.Width = Unit.Pixel(150);

            textBox2 = new TextBox();
            textBox2.ID = "textbox2";
            textBox2.Width = Unit.Pixel(150);

            Submit = new Button();
            Submit.ID = "buttonsubmit";
            Submit.Text = "submit";
            Submit.Width = Unit.Pixel(100);
            Submit.Click += new EventHandler(buttonsubmit_Click);

            lt1 = new LiteralControl("<br/>");

            label1 = new Label();

            this.Controls.Add(userName);
            this.Controls.Add(textBox1);
            this.Controls.Add(lt1);
            this.Controls.Add(password);
            
            this.Controls.Add(textBox2);
            this.Controls.Add(lt1);
            this.Controls.Add(Submit);
            this.Controls.Add(label1);

        }

        protected override void Render(HtmlTextWriter writer)
        {
            userName.RenderControl(writer);
            textBox1.RenderControl(writer);
            lt1.RenderControl(writer);
            password.RenderControl(writer);
            textBox2.RenderControl(writer);
            lt1.RenderControl(writer);
            Submit.RenderControl(writer);
            label1.RenderControl(writer);
        }
        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text=="Narmadha" && textBox2.Text=="Narmadha")
            {
                label1.Text = "Welcome";
            }
            else
            {
                label1.Text = "wrong username or password";
            }
        }
    }
}

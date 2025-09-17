using System;
using System.Windows.Forms;

namespace pizza_desktop_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_home_click(object sender, MouseEventArgs e)
        {
            Form custom_form = new Form_custom_pizza();
            custom_form.ShowDialog();
        }
    }
}

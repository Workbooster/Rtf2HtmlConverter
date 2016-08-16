using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rtf2HtmlConverter.Demo
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                txtHTMLPlain.Text = RTF2HTMLConverter.Convert(txtRFTPlain.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnClearTextFields_Click(object sender, EventArgs e)
        {
            txtRFTPlain.Text = "";
            txtHTMLPlain.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class B_Parts : Form
    {
        public B_Parts()
        {
            InitializeComponent();
        }

        private void B_Parts_Load(object sender, EventArgs e)
        {

        }

        public string ShowMiniForm()
        {
            B_Parts f = new B_Parts();
            f.ShowDialog();
            string receiveText;
            if (f.TextAdd.Text != "-1" && f.TextAdd.Text != "")
            {
                receiveText = "<b>" + f.TextAdd.Text + "</b>";
            }
            else
            { 
                receiveText = "-1";     
            }
           
            f.Dispose();
            return receiveText;
        }

        private void AddConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            TextAdd.Text = "-1";
            Close();
        }
    }
}

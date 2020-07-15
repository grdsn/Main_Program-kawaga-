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

            string receiveText = "<b>" + f.TextAdd.Text + "</b>" ;
            f.Dispose();
            return receiveText;
        }

        private void AddConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

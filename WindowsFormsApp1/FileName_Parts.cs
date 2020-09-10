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
    public partial class FileName_Parts : Form
    {
        public FileName_Parts()
        {
            InitializeComponent();
        }

        private void TextAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileName_Parts_Load(object sender, EventArgs e)
        {
            this.TextAdd.KeyDown += new KeyEventHandler(Title_Add_KeyDown);
        }

        public string ShowMiniForm()
        {
            FileName_Parts f = new FileName_Parts();
            f.ShowDialog();

            string receiveText = f.TextAdd.Text ;
            f.Dispose();
            return receiveText;
        }

        private void AddConfirm_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Title_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AddConfirm_Click_1(this, new EventArgs());
            }
            
        }
    }
}

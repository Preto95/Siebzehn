using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skat
{
    public partial class frmStringInput : Form
    {
        public frmStringInput()
        {
            InitializeComponent();
        }

        private void frmStringInput_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(tbText.Text != string.Empty)
            {
                if (tbText.Text.ToLower() == "bank")
                {
                    MessageBox.Show("the name 'bank' is not allowed");
                }
                else
                {
                    Settings.StringInput = tbText.Text;
                    this.Close();
                }
            }
        }

        private void tbText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnEnter_Click(null, null);
        }
    }
}

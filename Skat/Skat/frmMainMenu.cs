﻿using System;
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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSingleplayer_Click(object sender, EventArgs e)
        {
            frmTwoPlayers frmTwoPlayers;
            frmTwoPlayers = new frmTwoPlayers("KI");
            frmTwoPlayers.ShowDialog();
        }
    }
}

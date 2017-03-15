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
    public partial class frmTwoPlayers : Form
    {
        #region Fields
        List<PanelPlayerInfo> lstPPI = new List<PanelPlayerInfo>();
        List<PanelChat> lstPC = new List<PanelChat>();
        Random random;
        #endregion

        #region Properties
        public string Mode { get; private set; }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mode">KI 
        /// Online</param>
        public frmTwoPlayers(string Mode)
        {
            if (Mode == "KI"){}else if (Mode == "Online"){}
            else
                throw new ArgumentException("Wrong mode");
            InitializeComponent();
            this.Mode = Mode;
            frmStringInput frmStringInput;
            frmStringInput = new frmStringInput();
            frmStringInput.Text = "Enter Playername";
            frmStringInput.ShowDialog();
        }

        private void frmTwoPlayers_Load(object sender, EventArgs e)
        {
            if (Settings.StringInput == null || Settings.StringInput == string.Empty)
                Settings.StringInput = "Anonymous";
            switch(Mode)
            {
                case "KI":
                    panMinimizedChat.Visible = false;
                    picOpponent.Visible = false;
                    picYourself.Visible = false;
                    PanelPlayerInfo ppiPlayer = new PanelPlayerInfo(Settings.StringInput, 50.0, 1);
                    ppiPlayer.Location = new Point(12, 463);
                    this.Controls.Add(ppiPlayer);
                    lstPPI.Add(ppiPlayer);
                    ppiPlayer.btnMessage.Enabled = false;
                    PanelPlayerInfo ppiKI = new PanelPlayerInfo("Bank", 500.0, 2);
                    ppiKI.Location = new Point(565, 12);
                    this.Controls.Add(ppiKI);
                    lstPPI.Add(ppiKI);
                    ppiKI.btnMessage.Enabled = false;
                    lbProtocol.Items.Add("[" + DateTime.Now.ToShortTimeString() + "] " + "The game started. You start with");
                    lbProtocol.Items.Add("50€!");
                    StartKIGame();
                    break;
                case "Online":

                    break;
            }
        }

        /// <summary>
        /// Count all balances from the user
        /// </summary>
        /// <param name="WithBank">true: Count the balance from the bank too
        /// false: Count not the balance from the bank</param>
        /// <returns></returns>
        private double GetAllBalance(bool WithBank)
        {
            double Value = 0;
            string[] Name = null;
            for (int i = 0; i < lstPPI.Count; i++)
            {
                Name = lstPPI[i].rtbPlayerInfo.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
                Name[1] = Name[1].Replace("Balance: ", "");
                if (WithBank)
                {
                    Value += Convert.ToDouble(Name[1].Substring(0, Name[1].Length - 1));
                }
                else
                {
                    if (!Name[0].ToLower().Contains("bank"))
                    {
                        Value += Convert.ToDouble(Name[1].Substring(0, Name[1].Length - 1));
                    }
                }
            }
            return Value;
        }

        private void StartKIGame()
        {
            double Balance = 0;
            int Value = 0;
            for (int i = 0; i < lstPPI.Count; i++)
            {
                string[] Name = lstPPI[i].rtbPlayerInfo.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
                if(Name[0].ToLower().Contains("bank"))
                {
                    random = new Random();
                    Name[1] = Name[1].Replace("Balance: ", "");
                    Balance = Convert.ToDouble(Name[1].Substring(0, Name[1].Length - 1));
                    Value = random.Next(1, Convert.ToInt32(GetAllBalance(false)));
                    Name = lstPPI[i].rtbPlayerInfo.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
                    Name[1] = Name[1].Replace("Balance: ", "");
                    Name[1] = "Balance: " + Convert.ToString(Convert.ToDouble(Name[1].Substring(0, Name[1].Length - 1)) - Value) + "€";
                    lstPPI[i].rtbPlayerInfo.Text = Name[0] + "\n" + Name[1];
                    break;
                }
            }              
            lbProtocol.Items.Add("[" + DateTime.Now.ToShortTimeString() + "] " + "The bank set " + Value + "€");
            lblLimit.Text = Value + "€";
            lblPot.Text = Convert.ToString(Convert.ToDouble(lblPot.Text.Substring(0, lblPot.Text.Length - 1)) + Value) + "€";
            lbProtocol.Items.Add("[" + DateTime.Now.ToShortTimeString() + "] " +  "Set your commitment");
            grpCommitment.Enabled = true;
            tbCommitment.Text = "0";
        }

        private void btnCommitment_Click(object sender, EventArgs e)
        {
            double Balance = 0;
            for (int i = 0; i < lstPPI.Count; i++)
            {
                string[] Name = lstPPI[i].rtbPlayerInfo.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
                if(!Name[0].ToLower().Contains("bank"))
                {
                    Name[1] = Name[1].Replace("Balance: ", "");
                    Balance = Convert.ToDouble(Name[1].Substring(0, Name[1].Length - 1));
                    break;
                }
            }
            Button button = (Button)sender;
            if((Convert.ToDouble(tbCommitment.Text) + Convert.ToDouble(button.Text)) > Convert.ToDouble(lblLimit.Text.Substring(0, lblLimit.Text.Length - 1)))
            {
                lbProtocol.Items.Add("[" + DateTime.Now.ToShortTimeString() + "] " + "You reached the limit from the");
                lbProtocol.Items.Add("bank");
                //Scroll to bottom
                int visibleItems = lbProtocol.ClientSize.Height / lbProtocol.ItemHeight;
                lbProtocol.TopIndex = Math.Max(lbProtocol.Items.Count - visibleItems + 1, 0);
            }           
            else if((Convert.ToDouble(tbCommitment.Text) + Convert.ToDouble(button.Text) > Balance))
            {
                lbProtocol.Items.Add("[" + DateTime.Now.ToShortTimeString() + "] " + "You reached your balance");
                lbProtocol.Items.Add("limit");
                //Scroll to bottom
                int visibleItems = lbProtocol.ClientSize.Height / lbProtocol.ItemHeight;
                lbProtocol.TopIndex = Math.Max(lbProtocol.Items.Count - visibleItems + 1, 0);
            }
            else
                tbCommitment.Text = Convert.ToString(Convert.ToDouble(button.Text) + Convert.ToDouble(tbCommitment.Text));
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool found = false;
            for(int i = 0; i < lstPPI.Count; i++)
            {
                if (found)
                    break;
                string[] Name = lstPPI[i].rtbPlayerInfo.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
                for(int j = 0; j < lstPPI[i].Controls.Count; j++)
                {
                    if (found)
                        break;
                    if(lstPPI[i].Controls[j].Name == button.Name)
                    {
                        panMinimizedChat.Visible = false;
                        found = true;
                        PanelChat pc = new PanelChat(lstPC.Count, Name[0]);
                        pc.Location = new Point(0, 75);
                        pc.btnMinimize.Click += btnMinimize_Click;
                        pc.btnChatSend.Click += btnChatSend_Click;
                        lstPC.Add(pc);
                        this.Controls.Add(pc);
                    }
                }
            }            
        }

        void btnChatSend_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string t = button.Name;

            foreach (PanelChat btn in lstPC)
            {
                if (btn.Controls.Contains(button))
                {
                    btn.dicChat.Clear();
                    btn.Hide();
                    panMinimizedChat.Visible = true;
                    for (int i = 0; i < btn.lbChat.Items.Count; i++)
                    {
                        string[] Chat = btn.lbChat.Items[i].ToString().Split(':');
                        btn.dicChat.Add(new Player(Chat[0]), btn.lbChat.Items[i].ToString().Substring(Chat[0].Length + 1));
                    }
                    break;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbCommitment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 44)
            {
                // ,
                if(e.KeyChar == 44)
                {
                    if (!tbCommitment.Text.Contains(','))
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
                else
                {
                    //only digit
                    if(e.KeyChar != 8)
                    {
                        double Balance = 0;
                        for (int i = 0; i < lstPPI.Count; i++)
                        {
                            string[] Name = lstPPI[i].rtbPlayerInfo.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
                            if (!Name[0].ToLower().Contains("bank"))
                            {
                                Name[1] = Name[1].Replace("Balance: ", "");
                                Balance = Convert.ToDouble(Name[1].Substring(0, Name[1].Length - 1));
                                break;
                            }
                        }
                        double tmpAmount = Convert.ToDouble(tbCommitment.Text + e.KeyChar.ToString());
                        if(tmpAmount > Convert.ToDouble(lblLimit.Text.Substring(0, lblLimit.Text.Length - 1)))
                        {
                            lbProtocol.Items.Add("[" + DateTime.Now.ToShortTimeString() + "] " + "You reached the limit from the");
                            lbProtocol.Items.Add("bank");
                            e.Handled = true;
                            int visibleItems = lbProtocol.ClientSize.Height / lbProtocol.ItemHeight;
                            lbProtocol.TopIndex = Math.Max(lbProtocol.Items.Count - visibleItems + 1, 0);
                        }
                        else if(tmpAmount > Balance)
                        {
                            lbProtocol.Items.Add("[" + DateTime.Now.ToShortTimeString() + "] " + "You reached your balance");
                            lbProtocol.Items.Add("limit");
                            e.Handled = true;
                            int visibleItems = lbProtocol.ClientSize.Height / lbProtocol.ItemHeight;
                            lbProtocol.TopIndex = Math.Max(lbProtocol.Items.Count - visibleItems + 1, 0);
                        }
                        else
                            e.Handled = false;
                    }         
                    else
                        e.Handled = false;                
                }
            }
            else
                e.Handled = true;
        }

        private void tbCommitment_TextChanged(object sender, EventArgs e)
        {
            if (tbCommitment.TextLength == 0)
                tbCommitment.Text = "0";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(tbCommitment.Text) > 0)
            {
                grpCommitment.Enabled = false;

            }
        }
    }
}
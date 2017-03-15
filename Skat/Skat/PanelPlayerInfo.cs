using System;
using System.Windows.Forms;

namespace Skat
{
    public class PanelPlayerInfo : Panel
    {
        public RichTextBox rtbPlayerInfo;
        public Button btnMessage;

        public PanelPlayerInfo(string Player, double Balance, int PlayerCount)
        {
            this.Size = new System.Drawing.Size(255, 55);
            rtbPlayerInfo = new RichTextBox();
            btnMessage = new Button();
            ///rtbPlayerInfo
            this.rtbPlayerInfo.Enabled = false;
            this.rtbPlayerInfo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPlayerInfo.Location = new System.Drawing.Point(0, 0);
            this.rtbPlayerInfo.Name = "rtbPlayerInfo" + Convert.ToString(PlayerCount + 1);
            this.rtbPlayerInfo.ReadOnly = true;
            this.rtbPlayerInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbPlayerInfo.Size = new System.Drawing.Size(200, 55);
            this.rtbPlayerInfo.TabIndex = 2;
            this.rtbPlayerInfo.Text = Player + "\nBalance: " + Balance + "€";
            ///btnMessage
            this.btnMessage.BackColor = System.Drawing.SystemColors.Control;
            this.btnMessage.BackgroundImage = Skat.Properties.Resources._1489503553_mail_icon;
            this.btnMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMessage.Location = new System.Drawing.Point(200, 0);
            this.btnMessage.Name = "btnMessage" + Convert.ToString(PlayerCount + 1);
            this.btnMessage.Size = new System.Drawing.Size(55, 55);
            this.btnMessage.TabIndex = 1;
            this.btnMessage.UseVisualStyleBackColor = false;
            this.Controls.Add(btnMessage);
            this.Controls.Add(rtbPlayerInfo);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}

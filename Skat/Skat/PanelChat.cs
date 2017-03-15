using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Skat
{
    public class PanelChat : Panel
    {
        public Button btnPlayerName, btnChatSend, btnMinimize;
        public ListBox lbChat;
        public RichTextBox rtbChat;
        public Dictionary<Player, string> dicChat;

        public PanelChat(int ChatCount, string Player)
        {
            dicChat = new Dictionary<Player, string>();
            this.Size = new Size(200, 371);
            btnPlayerName = new Button();
            btnChatSend = new Button();
            lbChat = new ListBox();
            rtbChat = new RichTextBox();
            btnMinimize = new Button();
            ///btnPlayerName
            btnPlayerName.Name = "btnPlayerName" + Convert.ToString(ChatCount + 1);
            btnPlayerName.Text = Player;
            this.btnPlayerName.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPlayerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerName.ForeColor = System.Drawing.Color.White;
            this.btnPlayerName.Location = new System.Drawing.Point(0, 0);
            this.btnPlayerName.Name = "btnPlayerName";
            this.btnPlayerName.Size = new System.Drawing.Size(150, 36);
            this.btnPlayerName.TabIndex = 4;
            this.btnPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayerName.UseVisualStyleBackColor = false;
            ///btnMinimize
            btnMinimize.Name = "btnMinimize" + Convert.ToString(ChatCount + 1);
            btnMinimize.Text = string.Empty;
            this.btnMinimize.BackColor = Color.White;
            this.btnMinimize.Location = new Point(150, 0);
            this.btnMinimize.Size = new Size(50, 36);
            this.btnMinimize.BackgroundImage = Skat.Properties.Resources._8g3nZKyH_400x400;
            this.btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            this.btnPlayerName.TabIndex = 5;
            /////lbChat
            this.lbChat.Name = "lbChat" + Convert.ToString(ChatCount + 1);
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 18;
            this.lbChat.Location = new System.Drawing.Point(0, 36);
            this.lbChat.ScrollAlwaysVisible = true;
            this.lbChat.Size = new System.Drawing.Size(200, 238);
            this.lbChat.TabIndex = 3;
            /////rtbChat
            this.rtbChat.Name = "rtbChat" + Convert.ToString(ChatCount + 1);
            this.rtbChat.Location = new System.Drawing.Point(0, 274);
            this.rtbChat.ReadOnly = false;
            this.rtbChat.Size = new System.Drawing.Size(162, 96);
            this.rtbChat.TabIndex = 1;
            this.rtbChat.Text = "";
            ///////btnChatSend
            this.btnChatSend.Name = "btnChatSend" + Convert.ToString(ChatCount + 1);
            this.btnChatSend.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChatSend.BackgroundImage = Skat.Properties.Resources.long_arrow_right;
            this.btnChatSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChatSend.Location = new System.Drawing.Point(160, 274);
            this.btnChatSend.Size = new System.Drawing.Size(40, 96);
            this.btnChatSend.TabIndex = 2;
            this.btnChatSend.UseVisualStyleBackColor = false;
            this.Controls.Add(rtbChat);
            this.Controls.Add(btnPlayerName);
            this.Controls.Add(lbChat);
            this.Controls.Add(btnChatSend);
            this.Controls.Add(btnMinimize);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}

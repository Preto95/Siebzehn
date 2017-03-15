namespace Skat
{
    partial class frmTwoPlayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTwoPlayers));
            this.picYourself = new System.Windows.Forms.PictureBox();
            this.picOpponent = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panMinimizedChat = new System.Windows.Forms.Panel();
            this.btnMinimizedChat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpCommitment = new System.Windows.Forms.GroupBox();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.tbCommitment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lbProtocol = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picYourself)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpponent)).BeginInit();
            this.panMinimizedChat.SuspendLayout();
            this.grpCommitment.SuspendLayout();
            this.SuspendLayout();
            // 
            // picYourself
            // 
            this.picYourself.BackColor = System.Drawing.Color.LightGray;
            this.picYourself.Location = new System.Drawing.Point(354, 400);
            this.picYourself.Name = "picYourself";
            this.picYourself.Size = new System.Drawing.Size(100, 150);
            this.picYourself.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYourself.TabIndex = 0;
            this.picYourself.TabStop = false;
            // 
            // picOpponent
            // 
            this.picOpponent.BackColor = System.Drawing.Color.LightGray;
            this.picOpponent.Location = new System.Drawing.Point(265, 12);
            this.picOpponent.Name = "picOpponent";
            this.picOpponent.Size = new System.Drawing.Size(100, 150);
            this.picOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOpponent.TabIndex = 0;
            this.picOpponent.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panMinimizedChat
            // 
            this.panMinimizedChat.Controls.Add(this.btnMinimizedChat);
            this.panMinimizedChat.Location = new System.Drawing.Point(1, 155);
            this.panMinimizedChat.Name = "panMinimizedChat";
            this.panMinimizedChat.Size = new System.Drawing.Size(150, 33);
            this.panMinimizedChat.TabIndex = 2;
            // 
            // btnMinimizedChat
            // 
            this.btnMinimizedChat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimizedChat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizedChat.ForeColor = System.Drawing.Color.White;
            this.btnMinimizedChat.Location = new System.Drawing.Point(0, -3);
            this.btnMinimizedChat.Name = "btnMinimizedChat";
            this.btnMinimizedChat.Size = new System.Drawing.Size(150, 36);
            this.btnMinimizedChat.TabIndex = 0;
            this.btnMinimizedChat.Text = "René";
            this.btnMinimizedChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizedChat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(521, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Protocol";
            // 
            // btnDraw
            // 
            this.btnDraw.BackgroundImage = global::Skat.Properties.Resources.goldgelb;
            this.btnDraw.Enabled = false;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDraw.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnDraw.ForeColor = System.Drawing.Color.White;
            this.btnDraw.Location = new System.Drawing.Point(248, 301);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 30);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(304, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pot:";
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.BackColor = System.Drawing.Color.Transparent;
            this.lblPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPot.Location = new System.Drawing.Point(392, 251);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(66, 46);
            this.lblPot.TabIndex = 9;
            this.lblPot.Text = "0€";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Skat.Properties.Resources.goldgelb;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(354, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Match";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Skat.Properties.Resources.goldgelb;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(460, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Bank";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grpCommitment
            // 
            this.grpCommitment.BackColor = System.Drawing.Color.Transparent;
            this.grpCommitment.Controls.Add(this.btn500);
            this.grpCommitment.Controls.Add(this.btn50);
            this.grpCommitment.Controls.Add(this.btn200);
            this.grpCommitment.Controls.Add(this.btn20);
            this.grpCommitment.Controls.Add(this.btn100);
            this.grpCommitment.Controls.Add(this.btn10);
            this.grpCommitment.Controls.Add(this.btnSet);
            this.grpCommitment.Controls.Add(this.tbCommitment);
            this.grpCommitment.Enabled = false;
            this.grpCommitment.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCommitment.Location = new System.Drawing.Point(615, 403);
            this.grpCommitment.Name = "grpCommitment";
            this.grpCommitment.Size = new System.Drawing.Size(207, 147);
            this.grpCommitment.TabIndex = 12;
            this.grpCommitment.TabStop = false;
            this.grpCommitment.Text = "Commitment";
            // 
            // btn500
            // 
            this.btn500.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btn500.Location = new System.Drawing.Point(138, 107);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(60, 32);
            this.btn500.TabIndex = 1;
            this.btn500.Text = "500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btnCommitment_Click);
            // 
            // btn50
            // 
            this.btn50.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btn50.Location = new System.Drawing.Point(138, 69);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(60, 32);
            this.btn50.TabIndex = 1;
            this.btn50.Text = "50";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btnCommitment_Click);
            // 
            // btn200
            // 
            this.btn200.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btn200.Location = new System.Drawing.Point(72, 107);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(60, 32);
            this.btn200.TabIndex = 1;
            this.btn200.Text = "200";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btnCommitment_Click);
            // 
            // btn20
            // 
            this.btn20.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btn20.Location = new System.Drawing.Point(72, 69);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(60, 32);
            this.btn20.TabIndex = 1;
            this.btn20.Text = "20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btnCommitment_Click);
            // 
            // btn100
            // 
            this.btn100.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btn100.Location = new System.Drawing.Point(6, 107);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(60, 32);
            this.btn100.TabIndex = 1;
            this.btn100.Text = "100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btnCommitment_Click);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btn10.Location = new System.Drawing.Point(6, 69);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(60, 32);
            this.btn10.TabIndex = 1;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btnCommitment_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnSet.Location = new System.Drawing.Point(138, 31);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(60, 32);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tbCommitment
            // 
            this.tbCommitment.Font = new System.Drawing.Font("Arial", 15.75F);
            this.tbCommitment.Location = new System.Drawing.Point(6, 31);
            this.tbCommitment.Name = "tbCommitment";
            this.tbCommitment.Size = new System.Drawing.Size(126, 32);
            this.tbCommitment.TabIndex = 0;
            this.tbCommitment.Text = "0";
            this.tbCommitment.TextChanged += new System.EventHandler(this.tbCommitment_TextChanged);
            this.tbCommitment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCommitment_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Limit:";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.BackColor = System.Drawing.Color.Transparent;
            this.lblLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimit.Location = new System.Drawing.Point(713, 219);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(57, 39);
            this.lblLimit.TabIndex = 9;
            this.lblLimit.Text = "0€";
            // 
            // lbProtocol
            // 
            this.lbProtocol.FormattingEnabled = true;
            this.lbProtocol.ItemHeight = 18;
            this.lbProtocol.Location = new System.Drawing.Point(522, 94);
            this.lbProtocol.Name = "lbProtocol";
            this.lbProtocol.Size = new System.Drawing.Size(300, 112);
            this.lbProtocol.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmTwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skat.Properties.Resources.bg_berlin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbProtocol);
            this.Controls.Add(this.grpCommitment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panMinimizedChat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picOpponent);
            this.Controls.Add(this.picYourself);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTwoPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skat";
            this.Load += new System.EventHandler(this.frmTwoPlayers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picYourself)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpponent)).EndInit();
            this.panMinimizedChat.ResumeLayout(false);
            this.grpCommitment.ResumeLayout(false);
            this.grpCommitment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picYourself;
        private System.Windows.Forms.PictureBox picOpponent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panMinimizedChat;
        private System.Windows.Forms.Button btnMinimizedChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpCommitment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox tbCommitment;
        private System.Windows.Forms.ListBox lbProtocol;
        private System.Windows.Forms.Button button3;
    }
}
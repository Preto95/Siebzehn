namespace Skat
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnSingleplayer = new System.Windows.Forms.Button();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSingleplayer
            // 
            this.btnSingleplayer.Location = new System.Drawing.Point(12, 12);
            this.btnSingleplayer.Name = "btnSingleplayer";
            this.btnSingleplayer.Size = new System.Drawing.Size(300, 50);
            this.btnSingleplayer.TabIndex = 0;
            this.btnSingleplayer.Text = "Singleplayer";
            this.btnSingleplayer.UseVisualStyleBackColor = true;
            this.btnSingleplayer.Click += new System.EventHandler(this.btnSingleplayer_Click);
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.Location = new System.Drawing.Point(12, 68);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(300, 50);
            this.btnMultiplayer.TabIndex = 1;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 186);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.btnSingleplayer);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingleplayer;
        private System.Windows.Forms.Button btnMultiplayer;
        private System.Windows.Forms.Button btnExit;
    }
}


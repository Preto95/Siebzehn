namespace Skat
{
    partial class frmStringInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStringInput));
            this.label1 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text:";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(57, 12);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(300, 26);
            this.tbText.TabIndex = 0;
            this.tbText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbText_KeyPress);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(107, 44);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(150, 26);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmStringInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 81);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStringInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter text";
            this.Load += new System.EventHandler(this.frmStringInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnEnter;
    }
}
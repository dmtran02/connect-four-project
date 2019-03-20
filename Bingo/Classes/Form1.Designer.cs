namespace Bingo.Classes
{
    partial class frmBingo
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPlay = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtCardCalled = new System.Windows.Forms.TextBox();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.Crimson;
            this.lblWelcome.Location = new System.Drawing.Point(276, 7);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(125, 17);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Bingo!";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(102, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 33);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Location = new System.Drawing.Point(60, 85);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(151, 17);
            this.lblPlay.TabIndex = 3;
            this.lblPlay.Text = "Are you ready to play?";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(260, 76);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(116, 34);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes, let\'s play!";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(407, 76);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "No, exit.";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(53, 130);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(323, 74);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "We call one number at a time. Check your card for that number and if found click " +
    "that cell. If you do not have that number, click \"Don\'t Have.\"";
            this.lblInstructions.Visible = false;
            // 
            // txtCardCalled
            // 
            this.txtCardCalled.Enabled = false;
            this.txtCardCalled.Location = new System.Drawing.Point(406, 128);
            this.txtCardCalled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardCalled.Name = "txtCardCalled";
            this.txtCardCalled.Size = new System.Drawing.Size(117, 22);
            this.txtCardCalled.TabIndex = 7;
            this.txtCardCalled.Visible = false;
            // 
            // btnDontHave
            // 
            this.btnDontHave.Location = new System.Drawing.Point(409, 154);
            this.btnDontHave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(114, 26);
            this.btnDontHave.TabIndex = 8;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = true;
            this.btnDontHave.Visible = false;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(84, 207);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(1020, 1100);
            this.pnlCard.TabIndex = 9;
            this.pnlCard.Visible = false;
            // 
            // frmBingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 840);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.txtCardCalled);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBingo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtCardCalled;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Panel pnlCard;
    }
}


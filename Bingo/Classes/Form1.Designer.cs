namespace Bingo.Classes
{
    partial class frmConnectFour
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
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.lblPlay = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.Crimson;
            this.lblWelcome.Location = new System.Drawing.Point(276, 7);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(174, 17);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Connect Four!";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.Location = new System.Drawing.Point(101, 38);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(136, 33);
            this.lblPlayer1Name.TabIndex = 1;
            this.lblPlayer1Name.Text = "Player 1:";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(173, 36);
            this.txtPlayer1Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(160, 22);
            this.txtPlayer1Name.TabIndex = 1;
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
            this.btnYes.TabIndex = 3;
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
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "No, exit.";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(83, 130);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(1020, 1100);
            this.pnlCard.TabIndex = 9;
            this.pnlCard.Visible = false;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.Location = new System.Drawing.Point(368, 36);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(136, 33);
            this.lblPlayer2Name.TabIndex = 10;
            this.lblPlayer2Name.Text = "Player 2:";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Location = new System.Drawing.Point(437, 34);
            this.txtPlayer2Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(160, 22);
            this.txtPlayer2Name.TabIndex = 2;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(667, 76);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(99, 17);
            this.lblCurrentPlayer.TabIndex = 12;
            this.lblCurrentPlayer.Text = "Current Player";
            this.lblCurrentPlayer.Visible = false;
            // 
            // frmConnectFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 500);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConnectFour";
            this.Text = "Connect Four";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.Label lblCurrentPlayer;
    }
}


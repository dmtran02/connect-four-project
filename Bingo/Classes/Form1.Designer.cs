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
            this.lblWelcome.Location = new System.Drawing.Point(207, 6);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(134, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Connect Four!";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.Location = new System.Drawing.Point(76, 31);
            this.lblPlayer1Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(102, 27);
            this.lblPlayer1Name.TabIndex = 1;
            this.lblPlayer1Name.Text = "Player 1:";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(130, 29);
            this.txtPlayer1Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(121, 20);
            this.txtPlayer1Name.TabIndex = 2;
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Location = new System.Drawing.Point(45, 69);
            this.lblPlay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(112, 13);
            this.lblPlay.TabIndex = 3;
            this.lblPlay.Text = "Are you ready to play?";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(195, 62);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(87, 28);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes, let\'s play!";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(305, 62);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "No, exit.";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(62, 106);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(765, 894);
            this.pnlCard.TabIndex = 9;
            this.pnlCard.Visible = false;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.Location = new System.Drawing.Point(276, 29);
            this.lblPlayer2Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(102, 27);
            this.lblPlayer2Name.TabIndex = 10;
            this.lblPlayer2Name.Text = "Player 2:";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Location = new System.Drawing.Point(328, 28);
            this.txtPlayer2Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(121, 20);
            this.txtPlayer2Name.TabIndex = 11;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(500, 62);
            this.lblCurrentPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentPlayer.TabIndex = 12;
            this.lblCurrentPlayer.Text = "Current Player";
            this.lblCurrentPlayer.Visible = false;
            // 
            // frmBingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 406);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBingo";
            this.Text = "Form1";
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


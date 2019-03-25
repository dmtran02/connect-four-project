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
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.Crimson;
            this.lblWelcome.Location = new System.Drawing.Point(414, 12);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(267, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Connect Four!";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.Location = new System.Drawing.Point(152, 60);
            this.lblPlayer1Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(204, 52);
            this.lblPlayer1Name.TabIndex = 1;
            this.lblPlayer1Name.Text = "Player 1:";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(260, 56);
            this.txtPlayer1Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(238, 31);
            this.txtPlayer1Name.TabIndex = 2;
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Location = new System.Drawing.Point(90, 133);
            this.lblPlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(228, 25);
            this.lblPlay.TabIndex = 3;
            this.lblPlay.Text = "Are you ready to play?";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(390, 119);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(174, 54);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes, let\'s play!";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(610, 119);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 54);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "No, exit.";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(125, 204);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(1530, 1719);
            this.pnlCard.TabIndex = 9;
            this.pnlCard.Visible = false;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.Location = new System.Drawing.Point(552, 56);
            this.lblPlayer2Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(204, 52);
            this.lblPlayer2Name.TabIndex = 10;
            this.lblPlayer2Name.Text = "Player 2:";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Location = new System.Drawing.Point(656, 54);
            this.txtPlayer2Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(238, 31);
            this.txtPlayer2Name.TabIndex = 11;
            // 
            // frmBingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}


namespace BlackJack
{
    partial class blackJackForm
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
            this.shuffleBtn = new System.Windows.Forms.Button();
            this.dealBtn = new System.Windows.Forms.Button();
            this.hitBtn = new System.Windows.Forms.Button();
            this.dealerLB = new System.Windows.Forms.ListBox();
            this.playerLB = new System.Windows.Forms.ListBox();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerValueLbl = new System.Windows.Forms.Label();
            this.dealerValueLbl = new System.Windows.Forms.Label();
            this.stayBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerScoreLbl = new System.Windows.Forms.Label();
            this.dealerScorelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.Location = new System.Drawing.Point(289, 221);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(75, 23);
            this.shuffleBtn.TabIndex = 0;
            this.shuffleBtn.Text = "Shuffle";
            this.shuffleBtn.UseVisualStyleBackColor = true;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // dealBtn
            // 
            this.dealBtn.Location = new System.Drawing.Point(198, 221);
            this.dealBtn.Name = "dealBtn";
            this.dealBtn.Size = new System.Drawing.Size(75, 23);
            this.dealBtn.TabIndex = 1;
            this.dealBtn.Text = "Deal";
            this.dealBtn.UseVisualStyleBackColor = true;
            this.dealBtn.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // hitBtn
            // 
            this.hitBtn.Location = new System.Drawing.Point(198, 166);
            this.hitBtn.Name = "hitBtn";
            this.hitBtn.Size = new System.Drawing.Size(75, 49);
            this.hitBtn.TabIndex = 2;
            this.hitBtn.Text = "Hit";
            this.hitBtn.UseVisualStyleBackColor = true;
            this.hitBtn.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // dealerLB
            // 
            this.dealerLB.FormattingEnabled = true;
            this.dealerLB.Location = new System.Drawing.Point(41, 44);
            this.dealerLB.Name = "dealerLB";
            this.dealerLB.Size = new System.Drawing.Size(141, 160);
            this.dealerLB.TabIndex = 10;
            // 
            // playerLB
            // 
            this.playerLB.FormattingEnabled = true;
            this.playerLB.Location = new System.Drawing.Point(370, 44);
            this.playerLB.Name = "playerLB";
            this.playerLB.Size = new System.Drawing.Size(141, 160);
            this.playerLB.TabIndex = 11;
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Location = new System.Drawing.Point(23, 221);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(38, 13);
            this.dealerLabel.TabIndex = 12;
            this.dealerLabel.Text = "Dealer";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(369, 226);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(36, 13);
            this.playerLabel.TabIndex = 13;
            this.playerLabel.Text = "Player";
            // 
            // playerValueLbl
            // 
            this.playerValueLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerValueLbl.Location = new System.Drawing.Point(411, 220);
            this.playerValueLbl.Name = "playerValueLbl";
            this.playerValueLbl.Size = new System.Drawing.Size(100, 23);
            this.playerValueLbl.TabIndex = 14;
            // 
            // dealerValueLbl
            // 
            this.dealerValueLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dealerValueLbl.Location = new System.Drawing.Point(67, 216);
            this.dealerValueLbl.Name = "dealerValueLbl";
            this.dealerValueLbl.Size = new System.Drawing.Size(100, 23);
            this.dealerValueLbl.TabIndex = 15;
            // 
            // stayBtn
            // 
            this.stayBtn.Location = new System.Drawing.Point(289, 166);
            this.stayBtn.Name = "stayBtn";
            this.stayBtn.Size = new System.Drawing.Size(75, 49);
            this.stayBtn.TabIndex = 16;
            this.stayBtn.Text = "Stay";
            this.stayBtn.UseVisualStyleBackColor = true;
            this.stayBtn.Click += new System.EventHandler(this.stayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Player Score :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dealer Score :";
            // 
            // playerScoreLbl
            // 
            this.playerScoreLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerScoreLbl.Location = new System.Drawing.Point(269, 97);
            this.playerScoreLbl.Name = "playerScoreLbl";
            this.playerScoreLbl.Size = new System.Drawing.Size(34, 21);
            this.playerScoreLbl.TabIndex = 22;
            // 
            // dealerScorelbl
            // 
            this.dealerScorelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dealerScorelbl.Location = new System.Drawing.Point(269, 59);
            this.dealerScorelbl.Name = "dealerScorelbl";
            this.dealerScorelbl.Size = new System.Drawing.Size(34, 21);
            this.dealerScorelbl.TabIndex = 23;
            // 
            // blackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 268);
            this.Controls.Add(this.dealerScorelbl);
            this.Controls.Add(this.playerScoreLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stayBtn);
            this.Controls.Add(this.dealerValueLbl);
            this.Controls.Add(this.playerValueLbl);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.playerLB);
            this.Controls.Add(this.dealerLB);
            this.Controls.Add(this.hitBtn);
            this.Controls.Add(this.dealBtn);
            this.Controls.Add(this.shuffleBtn);
            this.Name = "blackJackForm";
            this.Text = "Blackjack Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shuffleBtn;
        private System.Windows.Forms.Button dealBtn;
        private System.Windows.Forms.Button hitBtn;
        private System.Windows.Forms.ListBox dealerLB;
        private System.Windows.Forms.ListBox playerLB;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerValueLbl;
        private System.Windows.Forms.Label dealerValueLbl;
        private System.Windows.Forms.Button stayBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerScoreLbl;
        private System.Windows.Forms.Label dealerScorelbl;
    }
}


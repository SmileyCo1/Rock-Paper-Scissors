namespace RPS
{
    partial class RPS
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
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRock = new System.Windows.Forms.Button();
            this.BtnPaper = new System.Windows.Forms.Button();
            this.BtnScissors = new System.Windows.Forms.Button();
            this.lblUserOutcome = new System.Windows.Forms.Label();
            this.lblComputerOutcome = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblScoreTwo = new System.Windows.Forms.Label();
            this.lblScoreOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(185, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 29);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comp";
            // 
            // BtnRock
            // 
            this.BtnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRock.Location = new System.Drawing.Point(12, 126);
            this.BtnRock.Name = "BtnRock";
            this.BtnRock.Size = new System.Drawing.Size(107, 42);
            this.BtnRock.TabIndex = 2;
            this.BtnRock.Text = "Rock";
            this.BtnRock.UseVisualStyleBackColor = true;
            this.BtnRock.Click += new System.EventHandler(this.BtnRock_Click);
            // 
            // BtnPaper
            // 
            this.BtnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaper.Location = new System.Drawing.Point(12, 174);
            this.BtnPaper.Name = "BtnPaper";
            this.BtnPaper.Size = new System.Drawing.Size(107, 42);
            this.BtnPaper.TabIndex = 3;
            this.BtnPaper.Text = "Paper";
            this.BtnPaper.UseVisualStyleBackColor = true;
            this.BtnPaper.Click += new System.EventHandler(this.BtnPaper_Click);
            // 
            // BtnScissors
            // 
            this.BtnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScissors.Location = new System.Drawing.Point(12, 222);
            this.BtnScissors.Name = "BtnScissors";
            this.BtnScissors.Size = new System.Drawing.Size(107, 42);
            this.BtnScissors.TabIndex = 4;
            this.BtnScissors.Text = "Scissors";
            this.BtnScissors.UseVisualStyleBackColor = true;
            this.BtnScissors.Click += new System.EventHandler(this.BtnScissors_Click);
            // 
            // lblUserOutcome
            // 
            this.lblUserOutcome.AutoSize = true;
            this.lblUserOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOutcome.Location = new System.Drawing.Point(187, 71);
            this.lblUserOutcome.Name = "lblUserOutcome";
            this.lblUserOutcome.Size = new System.Drawing.Size(0, 29);
            this.lblUserOutcome.TabIndex = 5;
            // 
            // lblComputerOutcome
            // 
            this.lblComputerOutcome.AutoSize = true;
            this.lblComputerOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerOutcome.Location = new System.Drawing.Point(346, 71);
            this.lblComputerOutcome.Name = "lblComputerOutcome";
            this.lblComputerOutcome.Size = new System.Drawing.Size(0, 29);
            this.lblComputerOutcome.TabIndex = 6;
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserScore.Location = new System.Drawing.Point(26, 34);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(26, 29);
            this.lblUserScore.TabIndex = 7;
            this.lblUserScore.Text = "0";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.Location = new System.Drawing.Point(532, 34);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(26, 29);
            this.lblComputerScore.TabIndex = 8;
            this.lblComputerScore.Text = "0";
            // 
            // BtnRestart
            // 
            this.BtnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestart.Location = new System.Drawing.Point(262, 311);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(107, 42);
            this.BtnRestart.TabIndex = 9;
            this.BtnRestart.Text = "Restart";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(12, 267);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 20);
            this.lblText.TabIndex = 10;
            // 
            // lblScoreTwo
            // 
            this.lblScoreTwo.AutoSize = true;
            this.lblScoreTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTwo.Location = new System.Drawing.Point(511, 9);
            this.lblScoreTwo.Name = "lblScoreTwo";
            this.lblScoreTwo.Size = new System.Drawing.Size(64, 25);
            this.lblScoreTwo.TabIndex = 11;
            this.lblScoreTwo.Text = "Score";
            // 
            // lblScoreOne
            // 
            this.lblScoreOne.AutoSize = true;
            this.lblScoreOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreOne.Location = new System.Drawing.Point(7, 9);
            this.lblScoreOne.Name = "lblScoreOne";
            this.lblScoreOne.Size = new System.Drawing.Size(64, 25);
            this.lblScoreOne.TabIndex = 12;
            this.lblScoreOne.Text = "Score";
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 374);
            this.Controls.Add(this.lblScoreOne);
            this.Controls.Add(this.lblScoreTwo);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.lblComputerOutcome);
            this.Controls.Add(this.lblUserOutcome);
            this.Controls.Add(this.BtnScissors);
            this.Controls.Add(this.BtnPaper);
            this.Controls.Add(this.BtnRock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Name = "RPS";
            this.Text = "Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.RPS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRock;
        private System.Windows.Forms.Button BtnPaper;
        private System.Windows.Forms.Button BtnScissors;
        private System.Windows.Forms.Label lblUserOutcome;
        private System.Windows.Forms.Label lblComputerOutcome;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblScoreTwo;
        private System.Windows.Forms.Label lblScoreOne;
    }
}


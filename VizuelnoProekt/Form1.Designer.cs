namespace VizuelnoProekt
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.superJackpotLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.superjackotTitleLabel = new System.Windows.Forms.Label();
            this.jackpotTitleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ballTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.gameTitleLabel.Location = new System.Drawing.Point(13, 33);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(201, 40);
            this.gameTitleLabel.TabIndex = 0;
            this.gameTitleLabel.Text = "LUCKY BALLS";
            // 
            // superJackpotLabel
            // 
            this.superJackpotLabel.AutoSize = true;
            this.superJackpotLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.superJackpotLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.superJackpotLabel.Location = new System.Drawing.Point(501, 33);
            this.superJackpotLabel.Name = "superJackpotLabel";
            this.superJackpotLabel.Size = new System.Drawing.Size(234, 45);
            this.superJackpotLabel.TabIndex = 1;
            this.superJackpotLabel.Text = "20.567,42 EUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(793, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "7.238,90 EUR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1362, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "SPORTS";
            // 
            // superjackotTitleLabel
            // 
            this.superjackotTitleLabel.AutoSize = true;
            this.superjackotTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.superjackotTitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.superjackotTitleLabel.Location = new System.Drawing.Point(547, 7);
            this.superjackotTitleLabel.Name = "superjackotTitleLabel";
            this.superjackotTitleLabel.Size = new System.Drawing.Size(132, 21);
            this.superjackotTitleLabel.TabIndex = 4;
            this.superjackotTitleLabel.Text = "SUPER JACKPOT";
            // 
            // jackpotTitleLabel
            // 
            this.jackpotTitleLabel.AutoSize = true;
            this.jackpotTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.jackpotTitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.jackpotTitleLabel.Location = new System.Drawing.Point(855, 7);
            this.jackpotTitleLabel.Name = "jackpotTitleLabel";
            this.jackpotTitleLabel.Size = new System.Drawing.Size(78, 21);
            this.jackpotTitleLabel.TabIndex = 6;
            this.jackpotTitleLabel.Text = "JACKPOT";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Controls.Add(this.gameTitleLabel);
            this.groupBox1.Controls.Add(this.jackpotTitleLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.superjackotTitleLabel);
            this.groupBox1.Controls.Add(this.superJackpotLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-1, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1547, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ballTimer
            // 
            this.ballTimer.Tick += new System.EventHandler(this.ballTimer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VizuelnoProekt.Properties.Resources.balls_2;
            this.pictureBox2.Location = new System.Drawing.Point(494, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(514, 352);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1539, 807);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Game";
            this.Text = "LuckyBalls";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.Label superJackpotLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label superjackotTitleLabel;
        private System.Windows.Forms.Label jackpotTitleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer ballTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


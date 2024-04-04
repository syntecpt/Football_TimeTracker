namespace Football_TimeTracker
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tempoTotalLabel = new System.Windows.Forms.Label();
            this.tempoAdicionalLabel = new System.Windows.Forms.Label();
            this.endButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SegmentActiveButton = new System.Windows.Forms.Button();
            this.SegmentOutofBoundsButton = new System.Windows.Forms.Button();
            this.SegmentRefBlowButton = new System.Windows.Forms.Button();
            this.SegmentGoalButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StateActiveTimer = new System.Windows.Forms.Label();
            this.StateOutofBoundsTimer = new System.Windows.Forms.Label();
            this.StateRefBlowTimer = new System.Windows.Forms.Label();
            this.StateGoalTimer = new System.Windows.Forms.Label();
            this.KeybindActive = new System.Windows.Forms.Label();
            this.KeybindOutofBounds = new System.Windows.Forms.Label();
            this.KeybindRefBlow = new System.Windows.Forms.Label();
            this.KeybindGoal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.KeybindStartStop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primeira Parte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segunda Parte";
            // 
            // tempoTotalLabel
            // 
            this.tempoTotalLabel.AutoSize = true;
            this.tempoTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoTotalLabel.Location = new System.Drawing.Point(429, 18);
            this.tempoTotalLabel.Name = "tempoTotalLabel";
            this.tempoTotalLabel.Size = new System.Drawing.Size(145, 55);
            this.tempoTotalLabel.TabIndex = 4;
            this.tempoTotalLabel.Text = "00:00";
            // 
            // tempoAdicionalLabel
            // 
            this.tempoAdicionalLabel.AutoSize = true;
            this.tempoAdicionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoAdicionalLabel.Location = new System.Drawing.Point(560, 18);
            this.tempoAdicionalLabel.Name = "tempoAdicionalLabel";
            this.tempoAdicionalLabel.Size = new System.Drawing.Size(186, 55);
            this.tempoAdicionalLabel.TabIndex = 6;
            this.tempoAdicionalLabel.Text = "+ 00:00";
            this.tempoAdicionalLabel.Visible = false;
            // 
            // endButton
            // 
            this.endButton.Enabled = false;
            this.endButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endButton.Location = new System.Drawing.Point(1155, 662);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(313, 120);
            this.endButton.TabIndex = 7;
            this.endButton.Text = "Terminar 1ª parte";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(1155, 518);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(313, 120);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Iniciar 1ª parte";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Football_TimeTracker.Properties.Resources.TimeRuler;
            this.pictureBox2.Location = new System.Drawing.Point(12, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1058, 262);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Football_TimeTracker.Properties.Resources.TimeRuler;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1058, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SegmentActiveButton
            // 
            this.SegmentActiveButton.BackColor = System.Drawing.Color.SpringGreen;
            this.SegmentActiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentActiveButton.Location = new System.Drawing.Point(387, 527);
            this.SegmentActiveButton.Name = "SegmentActiveButton";
            this.SegmentActiveButton.Size = new System.Drawing.Size(187, 111);
            this.SegmentActiveButton.TabIndex = 9;
            this.SegmentActiveButton.Text = "A Seguir";
            this.SegmentActiveButton.UseVisualStyleBackColor = false;
            this.SegmentActiveButton.Click += new System.EventHandler(this.SegmentActiveButton_Click);
            // 
            // SegmentOutofBoundsButton
            // 
            this.SegmentOutofBoundsButton.BackColor = System.Drawing.Color.Yellow;
            this.SegmentOutofBoundsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentOutofBoundsButton.Location = new System.Drawing.Point(202, 590);
            this.SegmentOutofBoundsButton.Name = "SegmentOutofBoundsButton";
            this.SegmentOutofBoundsButton.Size = new System.Drawing.Size(187, 111);
            this.SegmentOutofBoundsButton.TabIndex = 10;
            this.SegmentOutofBoundsButton.Text = "Bola fora do terreno de jogo";
            this.SegmentOutofBoundsButton.UseVisualStyleBackColor = false;
            this.SegmentOutofBoundsButton.Click += new System.EventHandler(this.SegmentOutofBoundsButton_Click);
            // 
            // SegmentRefBlowButton
            // 
            this.SegmentRefBlowButton.BackColor = System.Drawing.Color.Salmon;
            this.SegmentRefBlowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentRefBlowButton.Location = new System.Drawing.Point(572, 590);
            this.SegmentRefBlowButton.Name = "SegmentRefBlowButton";
            this.SegmentRefBlowButton.Size = new System.Drawing.Size(187, 111);
            this.SegmentRefBlowButton.TabIndex = 11;
            this.SegmentRefBlowButton.Text = "Arbitro interrompeu jogo";
            this.SegmentRefBlowButton.UseVisualStyleBackColor = false;
            this.SegmentRefBlowButton.Click += new System.EventHandler(this.SegmentRefBlowButton_Click);
            // 
            // SegmentGoalButton
            // 
            this.SegmentGoalButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SegmentGoalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentGoalButton.Location = new System.Drawing.Point(387, 644);
            this.SegmentGoalButton.Name = "SegmentGoalButton";
            this.SegmentGoalButton.Size = new System.Drawing.Size(187, 111);
            this.SegmentGoalButton.TabIndex = 12;
            this.SegmentGoalButton.Text = "Golo / celebração / revisão";
            this.SegmentGoalButton.UseVisualStyleBackColor = false;
            this.SegmentGoalButton.Click += new System.EventHandler(this.SegmentGoalButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SpringGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1095, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 110);
            this.label3.TabIndex = 13;
            this.label3.Text = "Jogo a seguir:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1095, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 110);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bola fora do terreno de jogo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1095, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 110);
            this.label5.TabIndex = 15;
            this.label5.Text = "Arbitro interrompeu jogo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1095, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(437, 110);
            this.label6.TabIndex = 16;
            this.label6.Text = "Golo / Celebração / Revisão:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StateActiveTimer
            // 
            this.StateActiveTimer.AutoSize = true;
            this.StateActiveTimer.BackColor = System.Drawing.Color.SpringGreen;
            this.StateActiveTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateActiveTimer.Location = new System.Drawing.Point(1450, 62);
            this.StateActiveTimer.Name = "StateActiveTimer";
            this.StateActiveTimer.Size = new System.Drawing.Size(82, 31);
            this.StateActiveTimer.TabIndex = 17;
            this.StateActiveTimer.Text = "00:00";
            this.StateActiveTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateOutofBoundsTimer
            // 
            this.StateOutofBoundsTimer.AutoSize = true;
            this.StateOutofBoundsTimer.BackColor = System.Drawing.Color.Yellow;
            this.StateOutofBoundsTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateOutofBoundsTimer.Location = new System.Drawing.Point(1450, 172);
            this.StateOutofBoundsTimer.Name = "StateOutofBoundsTimer";
            this.StateOutofBoundsTimer.Size = new System.Drawing.Size(82, 31);
            this.StateOutofBoundsTimer.TabIndex = 18;
            this.StateOutofBoundsTimer.Text = "00:00";
            this.StateOutofBoundsTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateRefBlowTimer
            // 
            this.StateRefBlowTimer.AutoSize = true;
            this.StateRefBlowTimer.BackColor = System.Drawing.Color.Salmon;
            this.StateRefBlowTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateRefBlowTimer.Location = new System.Drawing.Point(1450, 282);
            this.StateRefBlowTimer.Name = "StateRefBlowTimer";
            this.StateRefBlowTimer.Size = new System.Drawing.Size(82, 31);
            this.StateRefBlowTimer.TabIndex = 19;
            this.StateRefBlowTimer.Text = "00:00";
            this.StateRefBlowTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateGoalTimer
            // 
            this.StateGoalTimer.AutoSize = true;
            this.StateGoalTimer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.StateGoalTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateGoalTimer.Location = new System.Drawing.Point(1450, 392);
            this.StateGoalTimer.Name = "StateGoalTimer";
            this.StateGoalTimer.Size = new System.Drawing.Size(82, 31);
            this.StateGoalTimer.TabIndex = 20;
            this.StateGoalTimer.Text = "00:00";
            this.StateGoalTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // KeybindActive
            // 
            this.KeybindActive.AutoSize = true;
            this.KeybindActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindActive.Location = new System.Drawing.Point(460, 493);
            this.KeybindActive.Name = "KeybindActive";
            this.KeybindActive.Size = new System.Drawing.Size(39, 31);
            this.KeybindActive.TabIndex = 21;
            this.KeybindActive.Text = "W";
            // 
            // KeybindOutofBounds
            // 
            this.KeybindOutofBounds.AutoSize = true;
            this.KeybindOutofBounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindOutofBounds.Location = new System.Drawing.Point(159, 630);
            this.KeybindOutofBounds.Name = "KeybindOutofBounds";
            this.KeybindOutofBounds.Size = new System.Drawing.Size(32, 31);
            this.KeybindOutofBounds.TabIndex = 22;
            this.KeybindOutofBounds.Text = "A";
            // 
            // KeybindRefBlow
            // 
            this.KeybindRefBlow.AutoSize = true;
            this.KeybindRefBlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindRefBlow.Location = new System.Drawing.Point(765, 630);
            this.KeybindRefBlow.Name = "KeybindRefBlow";
            this.KeybindRefBlow.Size = new System.Drawing.Size(34, 31);
            this.KeybindRefBlow.TabIndex = 23;
            this.KeybindRefBlow.Text = "D";
            // 
            // KeybindGoal
            // 
            this.KeybindGoal.AutoSize = true;
            this.KeybindGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindGoal.Location = new System.Drawing.Point(460, 758);
            this.KeybindGoal.Name = "KeybindGoal";
            this.KeybindGoal.Size = new System.Drawing.Size(32, 31);
            this.KeybindGoal.TabIndex = 24;
            this.KeybindGoal.Text = "S";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1083, 579);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 108);
            this.label11.TabIndex = 25;
            this.label11.Text = "{";
            // 
            // KeybindStartStop
            // 
            this.KeybindStartStop.AutoSize = true;
            this.KeybindStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindStartStop.Location = new System.Drawing.Point(1062, 630);
            this.KeybindStartStop.Name = "KeybindStartStop";
            this.KeybindStartStop.Size = new System.Drawing.Size(32, 31);
            this.KeybindStartStop.TabIndex = 26;
            this.KeybindStartStop.Text = "P";
            // 
            // GameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1555, 827);
            this.Controls.Add(this.KeybindStartStop);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.KeybindGoal);
            this.Controls.Add(this.KeybindRefBlow);
            this.Controls.Add(this.KeybindOutofBounds);
            this.Controls.Add(this.KeybindActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StateGoalTimer);
            this.Controls.Add(this.StateRefBlowTimer);
            this.Controls.Add(this.StateOutofBoundsTimer);
            this.Controls.Add(this.StateActiveTimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SegmentGoalButton);
            this.Controls.Add(this.tempoAdicionalLabel);
            this.Controls.Add(this.tempoTotalLabel);
            this.Controls.Add(this.SegmentRefBlowButton);
            this.Controls.Add(this.SegmentOutofBoundsButton);
            this.Controls.Add(this.SegmentActiveButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tempoTotalLabel;
        private System.Windows.Forms.Label tempoAdicionalLabel;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button SegmentActiveButton;
        private System.Windows.Forms.Button SegmentOutofBoundsButton;
        private System.Windows.Forms.Button SegmentRefBlowButton;
        private System.Windows.Forms.Button SegmentGoalButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StateActiveTimer;
        private System.Windows.Forms.Label StateOutofBoundsTimer;
        private System.Windows.Forms.Label StateRefBlowTimer;
        private System.Windows.Forms.Label StateGoalTimer;
        private System.Windows.Forms.Label KeybindActive;
        private System.Windows.Forms.Label KeybindOutofBounds;
        private System.Windows.Forms.Label KeybindRefBlow;
        private System.Windows.Forms.Label KeybindGoal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label KeybindStartStop;
    }
}


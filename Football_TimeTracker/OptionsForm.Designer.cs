namespace Football_TimeTracker
{
    partial class OptionsForm
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
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ActiveKey = new System.Windows.Forms.Button();
            this.OutOfBoundsKey = new System.Windows.Forms.Button();
            this.RefBlowKey = new System.Windows.Forms.Button();
            this.GoalKey = new System.Windows.Forms.Button();
            this.UndoKey = new System.Windows.Forms.Button();
            this.StartStopKey = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Definir teclas";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SpringGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "A seguir";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bola Fora";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Árbitro Apita";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "Golo";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 45);
            this.label6.TabIndex = 5;
            this.label6.Text = "Desfazer";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 45);
            this.label7.TabIndex = 6;
            this.label7.Text = "Iniciar/Terminar";
            // 
            // ActiveKey
            // 
            this.ActiveKey.CausesValidation = false;
            this.ActiveKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveKey.Location = new System.Drawing.Point(331, 87);
            this.ActiveKey.Name = "ActiveKey";
            this.ActiveKey.Size = new System.Drawing.Size(123, 45);
            this.ActiveKey.TabIndex = 7;
            this.ActiveKey.TabStop = false;
            this.ActiveKey.Text = "W";
            this.ActiveKey.UseVisualStyleBackColor = true;
            this.ActiveKey.Click += new System.EventHandler(this.ActiveKey_Click);
            // 
            // OutOfBoundsKey
            // 
            this.OutOfBoundsKey.CausesValidation = false;
            this.OutOfBoundsKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutOfBoundsKey.Location = new System.Drawing.Point(331, 148);
            this.OutOfBoundsKey.Name = "OutOfBoundsKey";
            this.OutOfBoundsKey.Size = new System.Drawing.Size(123, 45);
            this.OutOfBoundsKey.TabIndex = 8;
            this.OutOfBoundsKey.TabStop = false;
            this.OutOfBoundsKey.Text = "A";
            this.OutOfBoundsKey.UseVisualStyleBackColor = true;
            this.OutOfBoundsKey.Click += new System.EventHandler(this.OutOfBoundsKey_Click);
            // 
            // RefBlowKey
            // 
            this.RefBlowKey.CausesValidation = false;
            this.RefBlowKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefBlowKey.Location = new System.Drawing.Point(331, 212);
            this.RefBlowKey.Name = "RefBlowKey";
            this.RefBlowKey.Size = new System.Drawing.Size(123, 45);
            this.RefBlowKey.TabIndex = 9;
            this.RefBlowKey.TabStop = false;
            this.RefBlowKey.Text = "D";
            this.RefBlowKey.UseVisualStyleBackColor = true;
            this.RefBlowKey.Click += new System.EventHandler(this.RefBlowKey_Click);
            // 
            // GoalKey
            // 
            this.GoalKey.CausesValidation = false;
            this.GoalKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalKey.Location = new System.Drawing.Point(331, 274);
            this.GoalKey.Name = "GoalKey";
            this.GoalKey.Size = new System.Drawing.Size(123, 45);
            this.GoalKey.TabIndex = 10;
            this.GoalKey.TabStop = false;
            this.GoalKey.Text = "S";
            this.GoalKey.UseVisualStyleBackColor = true;
            this.GoalKey.Click += new System.EventHandler(this.GoalKey_Click);
            // 
            // UndoKey
            // 
            this.UndoKey.CausesValidation = false;
            this.UndoKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndoKey.Location = new System.Drawing.Point(331, 337);
            this.UndoKey.Name = "UndoKey";
            this.UndoKey.Size = new System.Drawing.Size(123, 45);
            this.UndoKey.TabIndex = 11;
            this.UndoKey.TabStop = false;
            this.UndoKey.Text = "Backspace";
            this.UndoKey.UseVisualStyleBackColor = true;
            this.UndoKey.Click += new System.EventHandler(this.UndoKey_Click);
            // 
            // StartStopKey
            // 
            this.StartStopKey.CausesValidation = false;
            this.StartStopKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStopKey.Location = new System.Drawing.Point(331, 399);
            this.StartStopKey.Name = "StartStopKey";
            this.StartStopKey.Size = new System.Drawing.Size(123, 45);
            this.StartStopKey.TabIndex = 12;
            this.StartStopKey.TabStop = false;
            this.StartStopKey.Text = "P";
            this.StartStopKey.UseVisualStyleBackColor = true;
            this.StartStopKey.Click += new System.EventHandler(this.StartStopKey_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.CausesValidation = false;
            this.leaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveButton.Location = new System.Drawing.Point(565, 12);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(112, 56);
            this.leaveButton.TabIndex = 13;
            this.leaveButton.TabStop = false;
            this.leaveButton.Text = "Voltar";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(325, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "?";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(689, 463);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.StartStopKey);
            this.Controls.Add(this.UndoKey);
            this.Controls.Add(this.GoalKey);
            this.Controls.Add(this.RefBlowKey);
            this.Controls.Add(this.OutOfBoundsKey);
            this.Controls.Add(this.ActiveKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(705, 502);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ActiveKey;
        private System.Windows.Forms.Button OutOfBoundsKey;
        private System.Windows.Forms.Button RefBlowKey;
        private System.Windows.Forms.Button GoalKey;
        private System.Windows.Forms.Button UndoKey;
        private System.Windows.Forms.Button StartStopKey;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
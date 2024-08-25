namespace Number_Guessing_Game
{
    partial class dashboard
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
            this.start_btn = new System.Windows.Forms.Button();
            this.guess_text = new System.Windows.Forms.MaskedTextBox();
            this.guess_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.high_or_low = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.Color.Black;
            this.start_btn.Location = new System.Drawing.Point(176, 266);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(127, 44);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // guess_text
            // 
            this.guess_text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guess_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guess_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess_text.Location = new System.Drawing.Point(173, 180);
            this.guess_text.Name = "guess_text";
            this.guess_text.Size = new System.Drawing.Size(416, 37);
            this.guess_text.TabIndex = 3;
            this.guess_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guess_text.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.guess_text_MaskInputRejected);
            // 
            // guess_btn
            // 
            this.guess_btn.BackColor = System.Drawing.Color.Tomato;
            this.guess_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guess_btn.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess_btn.ForeColor = System.Drawing.Color.Black;
            this.guess_btn.Location = new System.Drawing.Point(462, 266);
            this.guess_btn.Name = "guess_btn";
            this.guess_btn.Size = new System.Drawing.Size(127, 44);
            this.guess_btn.TabIndex = 5;
            this.guess_btn.Text = "Guess";
            this.guess_btn.UseVisualStyleBackColor = false;
            this.guess_btn.Click += new System.EventHandler(this.guess_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(711, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // high_or_low
            // 
            this.high_or_low.BackColor = System.Drawing.Color.WhiteSmoke;
            this.high_or_low.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.high_or_low.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high_or_low.Location = new System.Drawing.Point(286, 424);
            this.high_or_low.Name = "high_or_low";
            this.high_or_low.Size = new System.Drawing.Size(204, 37);
            this.high_or_low.TabIndex = 6;
            this.high_or_low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Guess a number between 1 - 20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Click on the start to start the game";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(628, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter the number into the box and click on the guess button to guess the number";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(755, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.high_or_low);
            this.Controls.Add(this.guess_btn);
            this.Controls.Add(this.guess_text);
            this.Controls.Add(this.start_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.MaskedTextBox guess_text;
        private System.Windows.Forms.Button guess_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox high_or_low;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
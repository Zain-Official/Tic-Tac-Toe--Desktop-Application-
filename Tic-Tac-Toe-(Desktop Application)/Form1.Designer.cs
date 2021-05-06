
namespace Tic_Tac_Toe__Desktop_Application_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.new_Game = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.player_O = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player_X = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_9 = new System.Windows.Forms.Button();
            this.Btn_6 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_7 = new System.Windows.Forms.Button();
            this.Btn_8 = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.Btn_5 = new System.Windows.Forms.Button();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(220, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 354);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.Exit_Btn);
            this.panel5.Controls.Add(this.Reset_Btn);
            this.panel5.Controls.Add(this.new_Game);
            this.panel5.Location = new System.Drawing.Point(564, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 184);
            this.panel5.TabIndex = 2;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Exit_Btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit_Btn.Location = new System.Drawing.Point(100, 105);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(86, 47);
            this.Exit_Btn.TabIndex = 1;
            this.Exit_Btn.Text = "Exist";
            this.Exit_Btn.UseVisualStyleBackColor = false;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Reset_Btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reset_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset_Btn.Location = new System.Drawing.Point(11, 105);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(83, 47);
            this.Reset_Btn.TabIndex = 1;
            this.Reset_Btn.Text = "Reset";
            this.Reset_Btn.UseVisualStyleBackColor = false;
            this.Reset_Btn.Click += new System.EventHandler(this.Reset_Btn_Click);
            // 
            // new_Game
            // 
            this.new_Game.BackColor = System.Drawing.SystemColors.HotTrack;
            this.new_Game.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.new_Game.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.new_Game.Location = new System.Drawing.Point(11, 33);
            this.new_Game.Name = "new_Game";
            this.new_Game.Size = new System.Drawing.Size(175, 46);
            this.new_Game.TabIndex = 0;
            this.new_Game.Text = "New Game";
            this.new_Game.UseVisualStyleBackColor = false;
            this.new_Game.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.player_O);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.player_X);
            this.panel4.Location = new System.Drawing.Point(563, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 141);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(147, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            // 
            // player_O
            // 
            this.player_O.AutoSize = true;
            this.player_O.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player_O.Location = new System.Drawing.Point(12, 87);
            this.player_O.Name = "player_O";
            this.player_O.Size = new System.Drawing.Size(124, 32);
            this.player_O.TabIndex = 2;
            this.player_O.Text = "Player O :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(147, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // player_X
            // 
            this.player_X.AutoSize = true;
            this.player_X.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player_X.Location = new System.Drawing.Point(12, 30);
            this.player_X.Name = "player_X";
            this.player_X.Size = new System.Drawing.Size(129, 32);
            this.player_X.TabIndex = 0;
            this.player_X.Text = "Player X : ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Btn_9);
            this.panel3.Controls.Add(this.Btn_6);
            this.panel3.Controls.Add(this.Btn_3);
            this.panel3.Controls.Add(this.Btn_7);
            this.panel3.Controls.Add(this.Btn_8);
            this.panel3.Controls.Add(this.Btn_4);
            this.panel3.Controls.Add(this.Btn_5);
            this.panel3.Controls.Add(this.Btn_1);
            this.panel3.Controls.Add(this.Btn_2);
            this.panel3.Location = new System.Drawing.Point(10, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 331);
            this.panel3.TabIndex = 0;
            // 
            // Btn_9
            // 
            this.Btn_9.Location = new System.Drawing.Point(369, 214);
            this.Btn_9.Name = "Btn_9";
            this.Btn_9.Size = new System.Drawing.Size(173, 104);
            this.Btn_9.TabIndex = 0;
            this.Btn_9.UseVisualStyleBackColor = true;
            this.Btn_9.Click += new System.EventHandler(this.Btn_9_Click);
            // 
            // Btn_6
            // 
            this.Btn_6.Location = new System.Drawing.Point(369, 109);
            this.Btn_6.Name = "Btn_6";
            this.Btn_6.Size = new System.Drawing.Size(173, 99);
            this.Btn_6.TabIndex = 0;
            this.Btn_6.UseVisualStyleBackColor = true;
            this.Btn_6.Click += new System.EventHandler(this.Btn_6_Click);
            // 
            // Btn_3
            // 
            this.Btn_3.Location = new System.Drawing.Point(369, -2);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(173, 105);
            this.Btn_3.TabIndex = 0;
            this.Btn_3.UseVisualStyleBackColor = true;
            this.Btn_3.Click += new System.EventHandler(this.Btn_3_Click);
            // 
            // Btn_7
            // 
            this.Btn_7.Location = new System.Drawing.Point(11, 214);
            this.Btn_7.Name = "Btn_7";
            this.Btn_7.Size = new System.Drawing.Size(173, 104);
            this.Btn_7.TabIndex = 0;
            this.Btn_7.UseVisualStyleBackColor = true;
            this.Btn_7.Click += new System.EventHandler(this.Btn_7_Click);
            // 
            // Btn_8
            // 
            this.Btn_8.Location = new System.Drawing.Point(190, 214);
            this.Btn_8.Name = "Btn_8";
            this.Btn_8.Size = new System.Drawing.Size(173, 104);
            this.Btn_8.TabIndex = 0;
            this.Btn_8.UseVisualStyleBackColor = true;
            this.Btn_8.Click += new System.EventHandler(this.Btn_8_Click);
            // 
            // Btn_4
            // 
            this.Btn_4.Location = new System.Drawing.Point(11, 109);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(173, 99);
            this.Btn_4.TabIndex = 0;
            this.Btn_4.UseVisualStyleBackColor = true;
            this.Btn_4.Click += new System.EventHandler(this.Btn_4_Click);
            // 
            // Btn_5
            // 
            this.Btn_5.Location = new System.Drawing.Point(190, 109);
            this.Btn_5.Name = "Btn_5";
            this.Btn_5.Size = new System.Drawing.Size(173, 99);
            this.Btn_5.TabIndex = 0;
            this.Btn_5.UseVisualStyleBackColor = true;
            this.Btn_5.Click += new System.EventHandler(this.Btn_5_Click);
            // 
            // Btn_1
            // 
            this.Btn_1.Location = new System.Drawing.Point(11, -2);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(173, 105);
            this.Btn_1.TabIndex = 0;
            this.Btn_1.UseVisualStyleBackColor = true;
            this.Btn_1.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_2
            // 
            this.Btn_2.Location = new System.Drawing.Point(190, -2);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(173, 105);
            this.Btn_2.TabIndex = 0;
            this.Btn_2.UseVisualStyleBackColor = true;
            this.Btn_2.Click += new System.EventHandler(this.Btn_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.Button new_Game;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_9;
        private System.Windows.Forms.Button Btn_6;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_7;
        private System.Windows.Forms.Button Btn_8;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.Button Btn_5;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label player_O;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player_X;
    }
}


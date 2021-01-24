namespace GUI_V_2
{
    partial class Form10
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
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.circularProgressBar5 = new CircularProgressBar.CircularProgressBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.circularProgressBar6 = new CircularProgressBar.CircularProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(44, 45);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.White;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Navy;
            this.circularProgressBar1.ProgressWidth = 35;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(318, 269);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(5);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(5, 5, -1, 10);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.Text = "Station nord";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 10, 0, 0);
            this.circularProgressBar1.Value = 68;
            this.circularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.circularProgressBar1);
            this.panel1.Location = new System.Drawing.Point(25, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 428);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(101, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 58);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.circularProgressBar2);
            this.panel2.Location = new System.Drawing.Point(878, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 428);
            this.panel2.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(101, 361);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(190, 58);
            this.panel8.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(48, 45);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.White;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.Navy;
            this.circularProgressBar2.ProgressWidth = 35;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.Size = new System.Drawing.Size(306, 269);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(5);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(5, 5, -1, 10);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 0;
            this.circularProgressBar2.Text = "Camion SNVI";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 10, 0, 0);
            this.circularProgressBar2.Value = 68;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.circularProgressBar5);
            this.panel5.Location = new System.Drawing.Point(1298, 142);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(414, 428);
            this.panel5.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(141, 349);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 58);
            this.panel7.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(176, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 34);
            this.label9.TabIndex = 13;
            this.label9.Text = "label9";
            // 
            // circularProgressBar5
            // 
            this.circularProgressBar5.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar5.AnimationSpeed = 500;
            this.circularProgressBar5.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar5.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar5.InnerMargin = 2;
            this.circularProgressBar5.InnerWidth = -1;
            this.circularProgressBar5.Location = new System.Drawing.Point(48, 42);
            this.circularProgressBar5.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar5.Name = "circularProgressBar5";
            this.circularProgressBar5.OuterColor = System.Drawing.Color.White;
            this.circularProgressBar5.OuterMargin = -25;
            this.circularProgressBar5.OuterWidth = 26;
            this.circularProgressBar5.ProgressColor = System.Drawing.Color.Navy;
            this.circularProgressBar5.ProgressWidth = 35;
            this.circularProgressBar5.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar5.Size = new System.Drawing.Size(329, 269);
            this.circularProgressBar5.StartAngle = 270;
            this.circularProgressBar5.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar5.SubscriptMargin = new System.Windows.Forms.Padding(5);
            this.circularProgressBar5.SubscriptText = "";
            this.circularProgressBar5.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar5.SuperscriptMargin = new System.Windows.Forms.Padding(5, 5, -1, 10);
            this.circularProgressBar5.SuperscriptText = "";
            this.circularProgressBar5.TabIndex = 0;
            this.circularProgressBar5.Text = "Camion IVECO";
            this.circularProgressBar5.TextMargin = new System.Windows.Forms.Padding(8, 10, 0, 0);
            this.circularProgressBar5.Value = 68;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.circularProgressBar6);
            this.panel6.Location = new System.Drawing.Point(445, 145);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(427, 425);
            this.panel6.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(153, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 34);
            this.label11.TabIndex = 13;
            this.label11.Text = "label11";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(125, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 58);
            this.panel4.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 28);
            this.label12.TabIndex = 12;
            this.label12.Text = "label12";
            // 
            // circularProgressBar6
            // 
            this.circularProgressBar6.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar6.AnimationSpeed = 500;
            this.circularProgressBar6.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar6.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar6.InnerMargin = 2;
            this.circularProgressBar6.InnerWidth = -1;
            this.circularProgressBar6.Location = new System.Drawing.Point(50, 45);
            this.circularProgressBar6.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar6.Name = "circularProgressBar6";
            this.circularProgressBar6.OuterColor = System.Drawing.Color.White;
            this.circularProgressBar6.OuterMargin = -25;
            this.circularProgressBar6.OuterWidth = 26;
            this.circularProgressBar6.ProgressColor = System.Drawing.Color.Navy;
            this.circularProgressBar6.ProgressWidth = 35;
            this.circularProgressBar6.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar6.Size = new System.Drawing.Size(310, 266);
            this.circularProgressBar6.StartAngle = 270;
            this.circularProgressBar6.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar6.SubscriptMargin = new System.Windows.Forms.Padding(5);
            this.circularProgressBar6.SubscriptText = "";
            this.circularProgressBar6.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar6.SuperscriptMargin = new System.Windows.Forms.Padding(5, 5, -1, 10);
            this.circularProgressBar6.SuperscriptText = "";
            this.circularProgressBar6.TabIndex = 0;
            this.circularProgressBar6.Text = "Station sud";
            this.circularProgressBar6.TextMargin = new System.Windows.Forms.Padding(8, 10, 0, 0);
            this.circularProgressBar6.Value = 68;
            this.circularProgressBar6.Click += new System.EventHandler(this.circularProgressBar6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "Stock par station :";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1946, 856);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private CircularProgressBar.CircularProgressBar circularProgressBar5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private CircularProgressBar.CircularProgressBar circularProgressBar6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
    }
}
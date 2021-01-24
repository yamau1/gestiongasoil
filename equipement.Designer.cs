namespace GUI_V_2
{
    partial class equipement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipement));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ajout = new System.Windows.Forms.Button();
            this.Supp = new System.Windows.Forms.Button();
            this.textrech = new System.Windows.Forms.TextBox();
            this.combofiltre = new System.Windows.Forms.ComboBox();
            this.Rechercher = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "La Liste Des équipements:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(52, 134);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1678, 784);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Ajout
            // 
            this.Ajout.Location = new System.Drawing.Point(1181, 56);
            this.Ajout.Name = "Ajout";
            this.Ajout.Size = new System.Drawing.Size(120, 44);
            this.Ajout.TabIndex = 5;
            this.Ajout.Text = "Ajouter";
            this.Ajout.UseVisualStyleBackColor = true;
            this.Ajout.Click += new System.EventHandler(this.Ajout_Click);
            // 
            // Supp
            // 
            this.Supp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Supp.BackgroundImage")));
            this.Supp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Supp.Location = new System.Drawing.Point(1646, 58);
            this.Supp.Name = "Supp";
            this.Supp.Size = new System.Drawing.Size(57, 49);
            this.Supp.TabIndex = 7;
            this.Supp.UseVisualStyleBackColor = true;
            this.Supp.Click += new System.EventHandler(this.Doc_Click);
            // 
            // textrech
            // 
            this.textrech.CausesValidation = false;
            this.textrech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrech.Location = new System.Drawing.Point(176, 63);
            this.textrech.Multiline = true;
            this.textrech.Name = "textrech";
            this.textrech.Size = new System.Drawing.Size(392, 35);
            this.textrech.TabIndex = 8;
            this.textrech.TextChanged += new System.EventHandler(this.textrech_TextChanged);
            // 
            // combofiltre
            // 
            this.combofiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combofiltre.Location = new System.Drawing.Point(736, 65);
            this.combofiltre.Name = "combofiltre";
            this.combofiltre.Size = new System.Drawing.Size(256, 28);
            this.combofiltre.TabIndex = 9;
            this.combofiltre.SelectedIndexChanged += new System.EventHandler(this.combofiltre_SelectedIndexChanged_1);
            this.combofiltre.TextUpdate += new System.EventHandler(this.combofiltre_SelectedIndexChanged);
            // 
            // Rechercher
            // 
            this.Rechercher.AutoSize = true;
            this.Rechercher.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rechercher.Location = new System.Drawing.Point(41, 63);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(129, 27);
            this.Rechercher.TabIndex = 10;
            this.Rechercher.Text = "Rechercher :";
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(682, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Par :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // equipement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1769, 976);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.combofiltre);
            this.Controls.Add(this.textrech);
            this.Controls.Add(this.Supp);
            this.Controls.Add(this.Ajout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "equipement";
            this.Text = "equipement";
            this.Load += new System.EventHandler(this.Equipement_load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Supp;
        private System.Windows.Forms.ComboBox combofiltre;
        private System.Windows.Forms.Label Rechercher;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button Ajout;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textrech;
    }
}
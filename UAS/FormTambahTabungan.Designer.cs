
namespace UAS
{
    partial class FormTambahTabungan
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPengguna = new System.Windows.Forms.ComboBox();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxketer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNorek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.comboBoxVerif = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxBank = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Verifikator :";
            // 
            // comboBoxPengguna
            // 
            this.comboBoxPengguna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPengguna.FormattingEnabled = true;
            this.comboBoxPengguna.Items.AddRange(new object[] {
            "Nama Ibu Kandung",
            "Nama Hewan Peliharaan"});
            this.comboBoxPengguna.Location = new System.Drawing.Point(248, 101);
            this.comboBoxPengguna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPengguna.Name = "comboBoxPengguna";
            this.comboBoxPengguna.Size = new System.Drawing.Size(327, 29);
            this.comboBoxPengguna.TabIndex = 25;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKeluar.Location = new System.Drawing.Point(816, 691);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(156, 65);
            this.buttonKeluar.TabIndex = 33;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.comboBoxBank);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBoxVerif);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxPengguna);
            this.panel1.Controls.Add(this.textBoxketer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxNorek);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 564);
            this.panel1.TabIndex = 32;
            // 
            // textBoxketer
            // 
            this.textBoxketer.Location = new System.Drawing.Point(248, 234);
            this.textBoxketer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxketer.Multiline = true;
            this.textBoxketer.Name = "textBoxketer";
            this.textBoxketer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxketer.Size = new System.Drawing.Size(344, 73);
            this.textBoxketer.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Keterangan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pengguna:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOREKENING :";
            this.label1.UseMnemonic = false;
            // 
            // textBoxNorek
            // 
            this.textBoxNorek.Location = new System.Drawing.Point(248, 48);
            this.textBoxNorek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNorek.MaxLength = 16;
            this.textBoxNorek.Name = "textBoxNorek";
            this.textBoxNorek.Size = new System.Drawing.Size(260, 27);
            this.textBoxNorek.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1123, 65);
            this.label2.TabIndex = 31;
            this.label2.Text = "R E G I S T R A S I  D I B A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpan.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSimpan.Location = new System.Drawing.Point(979, 690);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(156, 65);
            this.buttonSimpan.TabIndex = 30;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // comboBoxVerif
            // 
            this.comboBoxVerif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVerif.FormattingEnabled = true;
            this.comboBoxVerif.Items.AddRange(new object[] {
            "Nama Ibu Kandung",
            "Nama Hewan Peliharaan"});
            this.comboBoxVerif.Location = new System.Drawing.Point(248, 168);
            this.comboBoxVerif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxVerif.Name = "comboBoxVerif";
            this.comboBoxVerif.Size = new System.Drawing.Size(327, 29);
            this.comboBoxVerif.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(96, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 30);
            this.label10.TabIndex = 27;
            this.label10.Text = "Bank :";
            // 
            // comboBoxBank
            // 
            this.comboBoxBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Items.AddRange(new object[] {
            "Nama Ibu Kandung",
            "Nama Hewan Peliharaan"});
            this.comboBoxBank.Location = new System.Drawing.Point(248, 324);
            this.comboBoxBank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new System.Drawing.Size(327, 29);
            this.comboBoxBank.TabIndex = 28;
            // 
            // FormTambahTabungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 762);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSimpan);
            this.Name = "FormTambahTabungan";
            this.Text = "FormTambahTabungan";
            this.Load += new System.EventHandler(this.FormTambahTabungan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPengguna;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxketer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNorek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.ComboBox comboBoxBank;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxVerif;
    }
}
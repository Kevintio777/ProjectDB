
namespace UAS
{
    partial class FormTransfer
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nominal = new System.Windows.Forms.TextBox();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Transfer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_RekeningTujuan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nominal";
            // 
            // textBox_Nominal
            // 
            this.textBox_Nominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nominal.Location = new System.Drawing.Point(12, 210);
            this.textBox_Nominal.Name = "textBox_Nominal";
            this.textBox_Nominal.Size = new System.Drawing.Size(311, 38);
            this.textBox_Nominal.TabIndex = 41;
            this.textBox_Nominal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nominal_KeyPress);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKeluar.Location = new System.Drawing.Point(154, 437);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(169, 48);
            this.buttonKeluar.TabIndex = 40;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 40);
            this.label1.TabIndex = 38;
            this.label1.Text = "TRANSFER";
            // 
            // button_Transfer
            // 
            this.button_Transfer.BackColor = System.Drawing.Color.SlateBlue;
            this.button_Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Transfer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Transfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Transfer.Location = new System.Drawing.Point(12, 328);
            this.button_Transfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Transfer.Name = "button_Transfer";
            this.button_Transfer.Size = new System.Drawing.Size(311, 70);
            this.button_Transfer.TabIndex = 43;
            this.button_Transfer.Text = "Transfer";
            this.button_Transfer.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 30);
            this.label3.TabIndex = 45;
            this.label3.Text = "Rekening Tujuan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_RekeningTujuan
            // 
            this.textBox_RekeningTujuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RekeningTujuan.Location = new System.Drawing.Point(12, 112);
            this.textBox_RekeningTujuan.Name = "textBox_RekeningTujuan";
            this.textBox_RekeningTujuan.Size = new System.Drawing.Size(311, 38);
            this.textBox_RekeningTujuan.TabIndex = 44;
            this.textBox_RekeningTujuan.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox_RekeningTujuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_RekeningTujuan_KeyPress);
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(336, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_RekeningTujuan);
            this.Controls.Add(this.button_Transfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Nominal);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.label1);
            this.Name = "FormTransfer";
            this.Text = "FormTransfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nominal;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Transfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_RekeningTujuan;
    }
}
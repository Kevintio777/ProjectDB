namespace UAS
{
    partial class FormTransaksi
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Transfer = new System.Windows.Forms.Button();
            this.button_TopUp = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label_Saldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSAKSI";
            // 
            // button_Transfer
            // 
            this.button_Transfer.BackColor = System.Drawing.Color.SlateBlue;
            this.button_Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Transfer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Transfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Transfer.Location = new System.Drawing.Point(199, 173);
            this.button_Transfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Transfer.Name = "button_Transfer";
            this.button_Transfer.Size = new System.Drawing.Size(132, 70);
            this.button_Transfer.TabIndex = 27;
            this.button_Transfer.Text = "Transfer";
            this.button_Transfer.UseVisualStyleBackColor = false;
            // 
            // button_TopUp
            // 
            this.button_TopUp.BackColor = System.Drawing.Color.SlateBlue;
            this.button_TopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TopUp.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TopUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_TopUp.Location = new System.Drawing.Point(34, 173);
            this.button_TopUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_TopUp.Name = "button_TopUp";
            this.button_TopUp.Size = new System.Drawing.Size(132, 70);
            this.button_TopUp.TabIndex = 28;
            this.button_TopUp.Text = "Top Up";
            this.button_TopUp.UseVisualStyleBackColor = false;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKeluar.Location = new System.Drawing.Point(176, 381);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(169, 48);
            this.buttonKeluar.TabIndex = 29;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // label_Saldo
            // 
            this.label_Saldo.AutoSize = true;
            this.label_Saldo.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Saldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Saldo.Location = new System.Drawing.Point(94, 85);
            this.label_Saldo.Name = "label_Saldo";
            this.label_Saldo.Size = new System.Drawing.Size(36, 40);
            this.label_Saldo.TabIndex = 30;
            this.label_Saldo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 40);
            this.label3.TabIndex = 31;
            this.label3.Text = "Rp";
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(376, 452);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Saldo);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.button_TopUp);
            this.Controls.Add(this.button_Transfer);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Transfer;
        private System.Windows.Forms.Button button_TopUp;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label_Saldo;
        private System.Windows.Forms.Label label3;
    }
}
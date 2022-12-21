namespace UAS
{
    partial class FormTopUp
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
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.button_TopUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nominal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKeluar.Location = new System.Drawing.Point(123, 305);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(127, 39);
            this.buttonKeluar.TabIndex = 35;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // button_TopUp
            // 
            this.button_TopUp.BackColor = System.Drawing.Color.SlateBlue;
            this.button_TopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TopUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_TopUp.Location = new System.Drawing.Point(17, 197);
            this.button_TopUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_TopUp.Name = "button_TopUp";
            this.button_TopUp.Size = new System.Drawing.Size(233, 57);
            this.button_TopUp.TabIndex = 34;
            this.button_TopUp.Text = "Top Up";
            this.button_TopUp.UseVisualStyleBackColor = false;
            this.button_TopUp.Click += new System.EventHandler(this.button_TopUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Top Up";
            // 
            // textBox_Nominal
            // 
            this.textBox_Nominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nominal.Location = new System.Drawing.Point(16, 95);
            this.textBox_Nominal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Nominal.Name = "textBox_Nominal";
            this.textBox_Nominal.Size = new System.Drawing.Size(234, 32);
            this.textBox_Nominal.TabIndex = 36;
            this.textBox_Nominal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nominal_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nominal";
            // 
            // FormTopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(263, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Nominal);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.button_TopUp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTopUp";
            this.Text = "FormTopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button button_TopUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nominal;
        private System.Windows.Forms.Label label2;
    }
}
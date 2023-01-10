namespace Proiect_MIP
{
    partial class AdaugaNota
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMate = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.textBoxRom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNota = new System.Windows.Forms.ComboBox();
            this.adaugaNotaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matematica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informatica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Romana";
            // 
            // textBoxMate
            // 
            this.textBoxMate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMate.Location = new System.Drawing.Point(225, 53);
            this.textBoxMate.Name = "textBoxMate";
            this.textBoxMate.Size = new System.Drawing.Size(125, 41);
            this.textBoxMate.TabIndex = 3;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInfo.Location = new System.Drawing.Point(225, 120);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(125, 41);
            this.textBoxInfo.TabIndex = 4;
            // 
            // textBoxRom
            // 
            this.textBoxRom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRom.Location = new System.Drawing.Point(225, 186);
            this.textBoxRom.Name = "textBoxRom";
            this.textBoxRom.Size = new System.Drawing.Size(125, 41);
            this.textBoxRom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(491, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selecteaza Student";
            // 
            // comboBoxNota
            // 
            this.comboBoxNota.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxNota.FormattingEnabled = true;
            this.comboBoxNota.Location = new System.Drawing.Point(420, 118);
            this.comboBoxNota.Name = "comboBoxNota";
            this.comboBoxNota.Size = new System.Drawing.Size(355, 43);
            this.comboBoxNota.TabIndex = 7;
            // 
            // adaugaNotaButton
            // 
            this.adaugaNotaButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adaugaNotaButton.Location = new System.Drawing.Point(249, 314);
            this.adaugaNotaButton.Name = "adaugaNotaButton";
            this.adaugaNotaButton.Size = new System.Drawing.Size(315, 81);
            this.adaugaNotaButton.TabIndex = 8;
            this.adaugaNotaButton.Text = "Adauga";
            this.adaugaNotaButton.UseVisualStyleBackColor = true;
            this.adaugaNotaButton.Click += new System.EventHandler(this.adaugaNotaButton_Click);
            // 
            // AdaugaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adaugaNotaButton);
            this.Controls.Add(this.comboBoxNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRom);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.textBoxMate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaNota";
            this.Text = "AdaugaNota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxMate;
        private TextBox textBoxInfo;
        private TextBox textBoxRom;
        private Label label4;
        private ComboBox comboBoxNota;
        private Button adaugaNotaButton;
    }
}
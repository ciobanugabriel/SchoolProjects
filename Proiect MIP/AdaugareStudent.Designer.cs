namespace Proiect_MIP
{
    partial class AdaugareStudent
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
            this.studentNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.studentPasswordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // studentNameInput
            // 
            this.studentNameInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentNameInput.Location = new System.Drawing.Point(195, 73);
            this.studentNameInput.Name = "studentNameInput";
            this.studentNameInput.Size = new System.Drawing.Size(362, 41);
            this.studentNameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume: ";
            // 
            // studentButton
            // 
            this.studentButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentButton.Location = new System.Drawing.Point(234, 312);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(294, 59);
            this.studentButton.TabIndex = 2;
            this.studentButton.Text = "Adauga";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola: ";
            // 
            // studentPasswordInput
            // 
            this.studentPasswordInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentPasswordInput.Location = new System.Drawing.Point(195, 169);
            this.studentPasswordInput.Name = "studentPasswordInput";
            this.studentPasswordInput.Size = new System.Drawing.Size(362, 41);
            this.studentPasswordInput.TabIndex = 4;
            // 
            // AdaugareStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 480);
            this.Controls.Add(this.studentPasswordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentNameInput);
            this.Name = "AdaugareStudent";
            this.Text = "AdaugareStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox studentNameInput;
        private Label label1;
        private Button studentButton;
        private Label label2;
        private TextBox studentPasswordInput;
    }
}
namespace Proiect_MIP
{
    partial class AdaugareProfesor
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
            this.profesorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profesorInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // profesorButton
            // 
            this.profesorButton.Location = new System.Drawing.Point(283, 331);
            this.profesorButton.Name = "profesorButton";
            this.profesorButton.Size = new System.Drawing.Size(228, 50);
            this.profesorButton.TabIndex = 0;
            this.profesorButton.Text = "Adauga";
            this.profesorButton.UseVisualStyleBackColor = true;
            this.profesorButton.Click += new System.EventHandler(this.profesorButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume: ";
            // 
            // profesorInput
            // 
            this.profesorInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profesorInput.Location = new System.Drawing.Point(220, 127);
            this.profesorInput.Name = "profesorInput";
            this.profesorInput.Size = new System.Drawing.Size(343, 41);
            this.profesorInput.TabIndex = 2;
            // 
            // AdaugareProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.profesorInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profesorButton);
            this.Name = "AdaugareProfesor";
            this.Text = "AdaugareProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button profesorButton;
        private Label label1;
        private TextBox profesorInput;
    }
}
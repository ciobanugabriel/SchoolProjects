namespace Proiect_MIP
{
    partial class Meniu
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
            this.button1 = new System.Windows.Forms.Button();
            this.profesorButton = new System.Windows.Forms.Button();
            this.notaButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adaugare Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // profesorButton
            // 
            this.profesorButton.Location = new System.Drawing.Point(609, 68);
            this.profesorButton.Name = "profesorButton";
            this.profesorButton.Size = new System.Drawing.Size(235, 55);
            this.profesorButton.TabIndex = 1;
            this.profesorButton.Text = "Adaugare Profersor";
            this.profesorButton.UseVisualStyleBackColor = true;
            this.profesorButton.Click += new System.EventHandler(this.profesorButton_Click);
            // 
            // notaButton
            // 
            this.notaButton.Location = new System.Drawing.Point(239, 187);
            this.notaButton.Name = "notaButton";
            this.notaButton.Size = new System.Drawing.Size(439, 57);
            this.notaButton.TabIndex = 2;
            this.notaButton.Text = "Adauga Nota";
            this.notaButton.UseVisualStyleBackColor = true;
            this.notaButton.Click += new System.EventHandler(this.notaButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(239, 338);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(439, 66);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Afiseaza Note";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 495);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.notaButton);
            this.Controls.Add(this.profesorButton);
            this.Controls.Add(this.button1);
            this.Name = "Meniu";
            this.Text = "Meniu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button profesorButton;
        private Button notaButton;
        private Button showButton;
    }
}
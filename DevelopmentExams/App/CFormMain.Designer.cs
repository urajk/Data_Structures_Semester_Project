namespace App
{
    partial class CFormMain
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
            btnCountries = new Button();
            btnContinents = new Button();
            btnHighways = new Button();
            SuspendLayout();
            // 
            // btnCountries
            // 
            btnCountries.Location = new Point(77, 52);
            btnCountries.Name = "btnCountries";
            btnCountries.Size = new Size(172, 57);
            btnCountries.TabIndex = 1;
            btnCountries.Text = "Countries";
            btnCountries.UseVisualStyleBackColor = true;
            btnCountries.Click += DoOnAnyCommand;
            // 
            // btnContinents
            // 
            btnContinents.Location = new Point(77, 115);
            btnContinents.Name = "btnContinents";
            btnContinents.Size = new Size(172, 57);
            btnContinents.TabIndex = 2;
            btnContinents.Text = "Continents";
            btnContinents.UseVisualStyleBackColor = true;
            btnContinents.Click += DoOnAnyCommand;
            // 
            // btnHighways
            // 
            btnHighways.Location = new Point(77, 178);
            btnHighways.Name = "btnHighways";
            btnHighways.Size = new Size(172, 57);
            btnHighways.TabIndex = 3;
            btnHighways.Text = "Highways";
            btnHighways.UseVisualStyleBackColor = true;
            btnHighways.Click += DoOnAnyCommand;
            // 
            // CFormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHighways);
            Controls.Add(btnContinents);
            Controls.Add(btnCountries);
            Name = "CFormMain";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCountries;
        private Button btnContinents;
        private Button btnHighways;
    }
}

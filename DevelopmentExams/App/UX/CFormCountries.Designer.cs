namespace App.UX
{
    partial class CFormCountries
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
            btnLoad = new Button();
            txtView = new TextBox();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(385, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(145, 49);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += BtnLoad_OnClick;
            // 
            // txtView
            // 
            txtView.Location = new Point(12, 12);
            txtView.Multiline = true;
            txtView.Name = "txtView";
            txtView.ScrollBars = ScrollBars.Vertical;
            txtView.Size = new Size(348, 473);
            txtView.TabIndex = 5;
            // 
            // CFormCountries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(btnLoad);
            Controls.Add(txtView);
            Name = "CFormCountries";
            Text = "Countries";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private TextBox txtView;
    }
}
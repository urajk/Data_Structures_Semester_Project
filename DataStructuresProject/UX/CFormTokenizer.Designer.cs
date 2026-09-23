namespace DataStructuresProject.UX
{
    partial class CFormTokenizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFormTokenizer));
            picLogo = new PictureBox();
            btnTokenize = new Button();
            txtUserInput = new TextBox();
            txtTokenSequence = new TextBox();
            txtTokensDict = new TextBox();
            lblUserInput = new Label();
            lblTokenSequence = new Label();
            lblTokensDict = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(237, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(55, 57);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 9;
            picLogo.TabStop = false;
            // 
            // btnTokenize
            // 
            btnTokenize.Image = (Image)resources.GetObject("btnTokenize.Image");
            btnTokenize.ImageAlign = ContentAlignment.TopCenter;
            btnTokenize.Location = new Point(174, 221);
            btnTokenize.Name = "btnTokenize";
            btnTokenize.Size = new Size(196, 64);
            btnTokenize.TabIndex = 8;
            btnTokenize.Text = "Tokenize";
            btnTokenize.TextAlign = ContentAlignment.BottomCenter;
            btnTokenize.UseVisualStyleBackColor = true;
            btnTokenize.Click += BtnTokenize_OnClick;
            // 
            // txtUserInput
            // 
            txtUserInput.BackColor = Color.WhiteSmoke;
            txtUserInput.BorderStyle = BorderStyle.None;
            txtUserInput.Location = new Point(37, 75);
            txtUserInput.Multiline = true;
            txtUserInput.Name = "txtUserInput";
            txtUserInput.ScrollBars = ScrollBars.Vertical;
            txtUserInput.Size = new Size(491, 144);
            txtUserInput.TabIndex = 7;
            // 
            // txtTokenSequence
            // 
            txtTokenSequence.BackColor = Color.White;
            txtTokenSequence.BorderStyle = BorderStyle.None;
            txtTokenSequence.Location = new Point(37, 294);
            txtTokenSequence.Multiline = true;
            txtTokenSequence.Name = "txtTokenSequence";
            txtTokenSequence.ScrollBars = ScrollBars.Vertical;
            txtTokenSequence.Size = new Size(491, 144);
            txtTokenSequence.TabIndex = 10;
            // 
            // txtTokensDict
            // 
            txtTokensDict.BackColor = Color.Cornsilk;
            txtTokensDict.BorderStyle = BorderStyle.None;
            txtTokensDict.Location = new Point(534, 35);
            txtTokensDict.Multiline = true;
            txtTokensDict.Name = "txtTokensDict";
            txtTokensDict.ScrollBars = ScrollBars.Both;
            txtTokensDict.Size = new Size(296, 403);
            txtTokensDict.TabIndex = 11;
            txtTokensDict.WordWrap = false;
            // 
            // lblUserInput
            // 
            lblUserInput.AutoSize = true;
            lblUserInput.Font = new Font("Segoe UI", 11.25F);
            lblUserInput.Location = new Point(37, 49);
            lblUserInput.Name = "lblUserInput";
            lblUserInput.Size = new Size(36, 20);
            lblUserInput.TabIndex = 12;
            lblUserInput.Text = "Text";
            // 
            // lblTokenSequence
            // 
            lblTokenSequence.AutoSize = true;
            lblTokenSequence.Font = new Font("Segoe UI", 11.25F);
            lblTokenSequence.Location = new Point(37, 265);
            lblTokenSequence.Name = "lblTokenSequence";
            lblTokenSequence.Size = new Size(73, 20);
            lblTokenSequence.TabIndex = 13;
            lblTokenSequence.Text = "Token IDs";
            // 
            // lblTokensDict
            // 
            lblTokensDict.AutoSize = true;
            lblTokensDict.Font = new Font("Segoe UI", 11.25F);
            lblTokensDict.Location = new Point(534, 9);
            lblTokensDict.Name = "lblTokensDict";
            lblTokensDict.Size = new Size(105, 20);
            lblTokensDict.TabIndex = 14;
            lblTokensDict.Text = "Unique Tokens";
            // 
            // CFormTokenizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 460);
            Controls.Add(lblTokensDict);
            Controls.Add(lblTokenSequence);
            Controls.Add(lblUserInput);
            Controls.Add(txtTokensDict);
            Controls.Add(txtTokenSequence);
            Controls.Add(picLogo);
            Controls.Add(btnTokenize);
            Controls.Add(txtUserInput);
            Name = "CFormTokenizer";
            Text = "Tokenizer for Chatbot Input";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Button btnTokenize;
        private TextBox txtUserInput;
        private TextBox txtTokenSequence;
        private TextBox txtTokensDict;
        private Label lblUserInput;
        private Label lblTokenSequence;
        private Label lblTokensDict;
    }
}
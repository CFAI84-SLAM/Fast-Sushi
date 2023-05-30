namespace Fast_Sushi_2
{
    partial class LoginForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            mdp_hash = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Titre = new TextBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(232, 171);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(361, 23);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(232, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(361, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(314, 266);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Connexion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // mdp_hash
            // 
            mdp_hash.Location = new Point(100, 372);
            mdp_hash.Name = "mdp_hash";
            mdp_hash.Size = new Size(648, 23);
            mdp_hash.TabIndex = 3;
            mdp_hash.TextChanged += mdp_hash_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 153);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "Nom";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 202);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 5;
            label2.Text = "Mot de passe";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Titre
            // 
            Titre.BackColor = SystemColors.ButtonFace;
            Titre.BorderStyle = BorderStyle.FixedSingle;
            Titre.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Titre.Location = new Point(142, 78);
            Titre.Name = "Titre";
            Titre.ReadOnly = true;
            Titre.Size = new Size(557, 43);
            Titre.TabIndex = 6;
            Titre.TextAlign = HorizontalAlignment.Center;
            Titre.TextChanged += Titre_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Titre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mdp_hash);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private TextBox mdp_hash;
        private Label label1;
        private Label label2;
        private TextBox Titre;
    }
}
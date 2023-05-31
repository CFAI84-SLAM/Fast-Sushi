namespace Fast_Sushi_2
{
    partial class Accueil
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Utilisateur = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 0;
            button1.Text = "Liste Clients";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(166, 415);
            button2.Name = "button2";
            button2.Size = new Size(195, 23);
            button2.TabIndex = 1;
            button2.Text = "Historique des commandes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(367, 415);
            button3.Name = "button3";
            button3.Size = new Size(110, 23);
            button3.TabIndex = 2;
            button3.Text = "Gérer les menus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(683, 415);
            button4.Name = "button4";
            button4.Size = new Size(105, 23);
            button4.TabIndex = 3;
            button4.Text = "Déconnexion";
            button4.UseVisualStyleBackColor = true;
            // 
            // Utilisateur
            // 
            Utilisateur.BackColor = SystemColors.ButtonFace;
            Utilisateur.BorderStyle = BorderStyle.FixedSingle;
            Utilisateur.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Utilisateur.Location = new Point(12, 122);
            Utilisateur.Name = "Utilisateur";
            Utilisateur.ReadOnly = true;
            Utilisateur.Size = new Size(776, 43);
            Utilisateur.TabIndex = 7;
            Utilisateur.TextAlign = HorizontalAlignment.Center;
            Utilisateur.TextChanged += Utilisateur_TextChanged;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Utilisateur);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Accueil";
            Text = "Accueil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox Utilisateur;
    }
}
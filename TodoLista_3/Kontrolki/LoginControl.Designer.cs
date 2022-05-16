
namespace TodoLista_1.Formularze.Kontrolki
{
    partial class LoginControl
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.btnZalozKonto = new System.Windows.Forms.Button();
            this.lblWalidacjaLogowania = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(37, 98);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(66, 25);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasło:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(133, 98);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(230, 29);
            this.tbLogin.TabIndex = 2;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(133, 175);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '*';
            this.tbHaslo.Size = new System.Drawing.Size(230, 29);
            this.tbHaslo.TabIndex = 3;
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Location = new System.Drawing.Point(133, 277);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(230, 82);
            this.btnZaloguj.TabIndex = 4;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = true;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // btnZalozKonto
            // 
            this.btnZalozKonto.Location = new System.Drawing.Point(133, 393);
            this.btnZalozKonto.Name = "btnZalozKonto";
            this.btnZalozKonto.Size = new System.Drawing.Size(230, 87);
            this.btnZalozKonto.TabIndex = 5;
            this.btnZalozKonto.Text = "Załóż konto";
            this.btnZalozKonto.UseVisualStyleBackColor = true;
            this.btnZalozKonto.Click += new System.EventHandler(this.btnZalozKonto_Click);
            // 
            // lblWalidacjaLogowania
            // 
            this.lblWalidacjaLogowania.AutoSize = true;
            this.lblWalidacjaLogowania.Location = new System.Drawing.Point(133, 223);
            this.lblWalidacjaLogowania.Name = "lblWalidacjaLogowania";
            this.lblWalidacjaLogowania.Size = new System.Drawing.Size(222, 25);
            this.lblWalidacjaLogowania.TabIndex = 6;
            this.lblWalidacjaLogowania.Text = "Nieporawny login i hasło";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWalidacjaLogowania);
            this.Controls.Add(this.btnZalozKonto);
            this.Controls.Add(this.btnZaloguj);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogin);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(476, 576);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.Button btnZalozKonto;
        private System.Windows.Forms.Label lblWalidacjaLogowania;
    }
}
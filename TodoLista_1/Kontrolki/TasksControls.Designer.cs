
namespace TodoLista_1.Formularze.Kontrolki
{
    partial class TasksControls
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
            this.lblZalogowany = new System.Windows.Forms.Label();
            this.lblZalogowanyWartosc = new System.Windows.Forms.Label();
            this.btnWyloguj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.lvZadania = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.collsRedy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblZalogowany
            // 
            this.lblZalogowany.AutoSize = true;
            this.lblZalogowany.Location = new System.Drawing.Point(12, 9);
            this.lblZalogowany.Name = "lblZalogowany";
            this.lblZalogowany.Size = new System.Drawing.Size(118, 25);
            this.lblZalogowany.TabIndex = 0;
            this.lblZalogowany.Text = "Zalogowany";
            // 
            // lblZalogowanyWartosc
            // 
            this.lblZalogowanyWartosc.AutoSize = true;
            this.lblZalogowanyWartosc.Location = new System.Drawing.Point(136, 9);
            this.lblZalogowanyWartosc.Name = "lblZalogowanyWartosc";
            this.lblZalogowanyWartosc.Size = new System.Drawing.Size(138, 25);
            this.lblZalogowanyWartosc.TabIndex = 1;
            this.lblZalogowanyWartosc.Text = "ZalogowanyW";
            // 
            // btnWyloguj
            // 
            this.btnWyloguj.Location = new System.Drawing.Point(356, 9);
            this.btnWyloguj.Name = "btnWyloguj";
            this.btnWyloguj.Size = new System.Drawing.Size(108, 67);
            this.btnWyloguj.TabIndex = 2;
            this.btnWyloguj.Text = "Wyloguj";
            this.btnWyloguj.UseVisualStyleBackColor = true;
            this.btnWyloguj.Click += new System.EventHandler(this.btnWyloguj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(356, 185);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 65);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(356, 269);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(108, 63);
            this.btnEdytuj.TabIndex = 4;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(356, 347);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(108, 67);
            this.btnUsun.TabIndex = 5;
            this.btnUsun.Text = "Usun";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // lvZadania
            // 
            this.lvZadania.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTitle,
            this.collsRedy});
            this.lvZadania.FullRowSelect = true;
            this.lvZadania.GridLines = true;
            this.lvZadania.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvZadania.HideSelection = false;
            this.lvZadania.Location = new System.Drawing.Point(17, 65);
            this.lvZadania.MultiSelect = false;
            this.lvZadania.Name = "lvZadania";
            this.lvZadania.ShowGroups = false;
            this.lvZadania.Size = new System.Drawing.Size(315, 473);
            this.lvZadania.TabIndex = 6;
            this.lvZadania.UseCompatibleStateImageBehavior = false;
            this.lvZadania.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            // 
            // colTitle
            // 
            this.colTitle.Text = "Tytuł";
            // 
            // collsRedy
            // 
            this.collsRedy.Text = "Zrobione";
            this.collsRedy.Width = 126;
            // 
            // TasksControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvZadania);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnWyloguj);
            this.Controls.Add(this.lblZalogowanyWartosc);
            this.Controls.Add(this.lblZalogowany);
            this.Name = "TasksControls";
            this.Size = new System.Drawing.Size(476, 576);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZalogowany;
        private System.Windows.Forms.Label lblZalogowanyWartosc;
        private System.Windows.Forms.Button btnWyloguj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.ListView lvZadania;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader collsRedy;
    }
}
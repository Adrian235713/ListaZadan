using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoLista_1.Klasy;

namespace TodoLista_1.Formularze.Kontrolki
{
    public partial class LoginControl : UserControl
    {

        private MainForm _mainForm;

        public LoginControl(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            Dock = DockStyle.Fill;

        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbHaslo.Text)){
                lblWalidacjaLogowania.Visible = true;
                lblWalidacjaLogowania.Text = "Login i haslo jest wymagane";
            }
            else
            {
                User urzytkownik = _mainForm.UserManager.WyszukajUrzytkownika(tbLogin.Text, tbHaslo.Text);
                if (urzytkownik == null)
                {
                    lblWalidacjaLogowania.Visible = true;
                    lblWalidacjaLogowania.Text = "Nieporawny login i hasło";
                }

                else
                {
                    _mainForm.PokazTasksControl(urzytkownik);
                }
            }









           
        }

        private void btnZalozKonto_Click(object sender, EventArgs e)
        {
            _mainForm.PokazRegisterControl();
        }
    }
}

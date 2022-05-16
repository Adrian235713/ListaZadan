using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoLista_1.Formularze.Kontrolki
{
    public partial class TasksControls : UserControl
    {
        private MainForm _mainForm;
        public TasksControls(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            Dock = DockStyle.Fill;

        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            _mainForm.PokazLoginControl();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {

        }
    }
}

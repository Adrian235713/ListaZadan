using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoLista_1.Formularze.Kontrolki;
using TodoLista_1.Klasy;

namespace TodoLista_1
{
    public partial class MainForm : Form
    {
        public UserManager UserManager;

        public MainForm()
        {
            InitializeComponent();
            UserManager = new UserManager();
            PokazLoginControl();
        }


        public void PokazLoginControl()
        {
            Controls.Clear();

            Controls.Add(new LoginControl(this));
        }

        public void PokazRegisterControl()
        {
            Controls.Clear();

            Controls.Add(new RegisterControl(this));

        }

        public void PokazTasksControl(User user)
        {
            Controls.Clear();

            Controls.Add(new TasksControls(this, user));
        }


    }
}

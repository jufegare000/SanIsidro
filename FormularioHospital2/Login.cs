using System;
using System.Windows.Forms;

namespace FormularioHospital2
{
    public partial class Login : Form {

        Registrarse registrarse = null;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.registrarse = new Registrarse(this);
            this.registrarse.Show();
        }
    }
}

using System;
using System.Windows.Forms;
using FormularioHospital2.Modelos;

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
            string usuarioStr = usuario.Text;
            string contrasenaStr = contrasena.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.registrarse = new Registrarse(this);
            this.registrarse.Show();
        }
    }
}

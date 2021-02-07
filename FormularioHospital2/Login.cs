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

            using (hostopitalsanisidroEntities4 db = new hostopitalsanisidroEntities4())
            {
                usuario usuariodb = new usuario();
                usuariodb.usuario1 = usuarioStr;
                usuariodb.contrasena = contrasenaStr;
                try
                {
                    usuario usuarioTofind = db.usuario.Find(usuarioStr);

                    if(usuarioTofind.contrasena == contrasenaStr)
                    {
                        MessageBox.Show("Ha ingresado el usuario: " + usuarioTofind.nombre);
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña inválidos");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se puede conectar con la base de datos");
                }

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.registrarse = new Registrarse(this);
            this.registrarse.Show();
        }
    }
}

using System;
using System.Windows.Forms;
using FormularioHospital2.Modelos;

namespace FormularioHospital2
{
    
    public partial class Registrarse : Form
    {

        private Login loginForm = null;
        public Registrarse(Login loginFormLlamada)
        {
            loginForm = loginFormLlamada as Login;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreStr = nombre.Text;
            string usuarioStr = usuario.Text;
            string contrasenaStr = contrasena.Text;

            using(hostopitalsanisidroEntities4 db = new hostopitalsanisidroEntities4())
            {
                usuario usuariodb = new usuario();
                usuariodb.usuario1 = usuarioStr;
                usuariodb.contrasena = contrasenaStr;
                usuariodb.nombre = nombreStr;
                try
                {
                    db.usuario.Add(usuariodb);
                    db.SaveChanges();
                    db.SaveChanges();
                    MessageBox.Show("Se ha registrado el usuario: " + usuarioStr + " satisfactoriamente");
                }
                catch( Exception)
                {
                    MessageBox.Show("El usuario ya ha sido ingresado con anterioridad");
                }

            }
                
           // Program.usuarios;
        }
    }
}

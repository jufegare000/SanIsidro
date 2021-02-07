using System;
using System.Windows.Forms;
using FormularioHospital2.Formularios.Pacientes;
using FormularioHospital2.Formularios.Reportes;

namespace FormularioHospital2.Formularios.Principal
{
    public partial class Principal : Form
    {
        RegitrarPaciente registrarPaciente = null;
        RepPrincipal repPrincipal = null;
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrarPaciente = new RegitrarPaciente(this);
            this.Hide();
            registrarPaciente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            repPrincipal = new RepPrincipal(this);
            this.Hide();
            repPrincipal.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}

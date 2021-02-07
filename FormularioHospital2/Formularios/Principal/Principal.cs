using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormularioHospital2.Formularios.Pacientes;

namespace FormularioHospital2.Formularios.Principal
{
    public partial class Principal : Form
    {
        RegitrarPaciente registrarPaciente = null;
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
    }
}

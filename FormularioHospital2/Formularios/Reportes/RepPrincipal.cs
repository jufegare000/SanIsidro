using System;
using System.Windows.Forms;
using FormularioHospital2.Formularios.Reportes.Inmigrantes;

namespace FormularioHospital2.Formularios.Reportes
{
    public partial class RepPrincipal : Form
    {
        Principal.Principal pricipalForm;
        InmigrantesPorPais inmigrantes = null;
        public RepPrincipal(Principal.Principal princialcall)
        {
            pricipalForm = princialcall as Principal.Principal;
            InitializeComponent();
        }

        private void RepPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inmigrantes = new InmigrantesPorPais(this);
            this.Hide();
            inmigrantes.Show();
        }

        private void RepPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            pricipalForm.Show();
        }
    }
}

using System;
using System.Windows.Forms;
using FormularioHospital2.Modelos;
using System.Linq;
using FormularioHospital2.Formularios.Reportes;


namespace FormularioHospital2.Formularios.Reportes.Inmigrantes
{
    public partial class InmigrantesPorPais : Form
    {
        RepPrincipal repPrincipalFrm;
        public InmigrantesPorPais(RepPrincipal repprinciapalCall)
        {
            repPrincipalFrm = repprinciapalCall as RepPrincipal;
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InmigrantesPorPais_Load(object sender, EventArgs e)
        {
            using(hostopitalsanisidroEntities4 db = new hostopitalsanisidroEntities4())
            {
                var lista = from d in db.paciente
                            orderby d.paisdeorigen
                            select d;
                dataGridView1.DataSource = lista.ToList();
            }
        }

        private void InmigrantesPorPais_FormClosed(object sender, FormClosedEventArgs e)
        {
            repPrincipalFrm.Show();
        }
    }
}

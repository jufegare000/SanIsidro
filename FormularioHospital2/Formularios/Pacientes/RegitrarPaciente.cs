using System;
using System.Windows.Forms;
using FormularioHospital2.Formularios.Principal;
using FormularioHospital2.Modelos;

namespace FormularioHospital2.Formularios.Pacientes
{
    public partial class RegitrarPaciente : Form
    {
        Principal.Principal pricipalForm = null;
        public RegitrarPaciente(Principal.Principal principalCall)
        {
            pricipalForm = principalCall as Principal.Principal;
            InitializeComponent();
        }

        private void txtPermanenciaEnMeses_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtPermanenciaEnMeses.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrse solo números enteros porfavor");
                txtPermanenciaEnMeses.Text = txtPermanenciaEnMeses.Text.Remove(txtPermanenciaEnMeses.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dblPeso = Double.Parse(txtPeso.Text);
            double dblEstatura = Double.Parse(txtEstatura.Text);
            double dblEdad = Double.Parse(txtEdad.Text);

            if(dblPeso < 0.0)
            {
                MessageBox.Show("Ingrese un valor para PESO válido separando la parte real por un punto");
            }else if (dblEstatura < 0.0)
            {
                MessageBox.Show("Ingrese un valor para ESTATURA válido separando la parte real por un punto");
            }
            else if (dblEdad < 0.0)
            {
                MessageBox.Show("Ingrese un valor para EDAD válido");
            }
            else
            {
                calcularImc(dblPeso, dblEstatura, dblEdad);
            }
        }

        public void calcularImc(double peso, double estatura, double edad)
        {
            double imc = this.calcularIMCG(peso, estatura, edad);
            double imcm = this.calcularIMCM(peso, estatura, edad);
            double imch = this.calcularIMCH(peso, estatura, edad);
            string clasificacion = this.obtenerIMCDescripcion(imc);

            lbllIMCDescripcion.Text = clasificacion;
            lblIMC.Text =  Convert.ToString(imc);
            lblIMCM.Text = Convert.ToString(imcm);
            lblIMCH.Text = Convert.ToString(imch);
        }

        public double calcularIMCG(double peso, double estatura, double edad)
        {
            return peso / (estatura * estatura);
        }

        public double calcularIMCM(double peso, double estatura, double edad)
        {
            return 10 * peso + (6.25 * estatura) - 5 * edad - 16; 
        }

        public double calcularIMCH(double peso, double estatura, double edad)
        {
            return (10 * peso) + (6.25 * estatura) - (5 * edad) + 5;
        }

        public string obtenerIMCDescripcion(double imc)
        {
            string clasificacion = "";

            if (imc < 16)
                clasificacion = "Infrapeso, delgadez severa";
            else if (imc >= 16 & imc < 17)
                clasificacion = "Infrapeso, delgadez moderada";
            else if (imc >= 17 & imc < 18.5)
                clasificacion = "Infrapeso, delgadez aceptable";
            else if (imc >= 18.5 & imc < 25)
                clasificacion = "Peso normal";
            else if (imc >= 25 & imc < 30)
                clasificacion = "Sobrepeso";
            else if (imc >= 30 & imc < 35)
                clasificacion = "Obeso tipo I";
            else if (imc >= 35 & imc < 40)
                clasificacion = "Obeso tipo II";
            else
                clasificacion = "Obeso tipo III";

            return clasificacion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strNombre = txtNombre.Text, strApellidos = txtApellido.Text, strTipodoc = tiposIds.Text,
                strNumeroDoc = txtNroDoc.Text, strPaisDeOrigen = paises.Text, strGenero = cmbGenero.Text,
                strFechaNacimiento = txtFechaNacimiento.Text, strEstadiCivil = cmbEstadoCivil.Text, strCorreo = txtCorreo.Text,
                strDireccion = txtDireccion.Text, strBarrio = txtBarrio.Text, strTelefono = txtTelofonoContacto.Text,
                strOcupacion = txtOcupacion.Text, strNivelEscolaridad = txtEscolaridad.Text, strEPS = txtEPS.Text,
                strRegimen = txtRegimen.Text, strAntecedentesMedicos = txtAntecedentes.Text, strConvenio = txtConvenio.Text,
                strContactoEmergencia = txtContactoEmergencia.Text;

            int tiempoDePeremanenciaEnMeses = int.Parse(txtPermanenciaEnMeses.Text), intEdad = int.Parse(txtEdad.Text),
                intNumeroDeHijos = int.Parse(txtNumeroDeHijos.Text);

            double dblPeso = Double.Parse(txtPeso.Text), dblEstatura = Double.Parse(txtEstatura.Text),
                dblEdad = Double.Parse(txtEdad.Text), dblIMC, dblIMCM, dblIMCH;


            if(strNombre == "" || strApellidos == ""  || strTipodoc == "" || strNumeroDoc == "" ||
                strPaisDeOrigen == "" || strGenero == "" || strFechaNacimiento == "" || strEstadiCivil == "" ||
                strCorreo == "" || strDireccion == "" || strBarrio == "" || strTelefono == "" || strOcupacion == "" ||
                strNivelEscolaridad == "" || strEPS == "" || strRegimen == "" || strAntecedentesMedicos == "" ||
                strConvenio == "" || strContactoEmergencia == "" || tiempoDePeremanenciaEnMeses < 0 ||
                intEdad < 0 || intNumeroDeHijos < 0 || dblPeso < 0.0 || dblEstatura < 0.0 )
            {
                MessageBox.Show("Asegurese de ingresar correctamente todos los campos");
            }
            else
            {
                using (hostopitalsanisidroEntities4 db = new hostopitalsanisidroEntities4())
                {

                    try
                    {

                        paciente pacientenuevo = new paciente();
                        pacientenuevo.nombre = strNombre;
                        pacientenuevo.apellidos = strApellidos;
                        pacientenuevo.tipodedocumento = strTipodoc;
                        pacientenuevo.numerodocumento = strNumeroDoc;
                        pacientenuevo.paisdeorigen = strPaisDeOrigen;
                        pacientenuevo.tiempodepermanenciaenmeses = tiempoDePeremanenciaEnMeses;
                        pacientenuevo.genero = strGenero;
                        pacientenuevo.fechanacimiento = strFechaNacimiento;
                        pacientenuevo.edad = intEdad;
                        pacientenuevo.estadocivil = strEstadiCivil;
                        pacientenuevo.correoelectronico = strCorreo;
                        pacientenuevo.numerodehijos = intNumeroDeHijos;
                        pacientenuevo.direccionresidencia = strDireccion;
                        pacientenuevo.barrioresidencia = strBarrio;
                        pacientenuevo.telefonocontacto = strTelefono;
                        pacientenuevo.ocupacion = strOcupacion;
                        pacientenuevo.nivelescolaridad = strNivelEscolaridad;
                        pacientenuevo.eps = strEPS;
                        pacientenuevo.regimen = strRegimen;
                        pacientenuevo.antecedentesmedicos = strAntecedentesMedicos;
                        pacientenuevo.contactoemergencia = strContactoEmergencia;
                        pacientenuevo.convenio = strConvenio;
                        pacientenuevo.masa = dblPeso;
                        pacientenuevo.peso = dblPeso;
                        pacientenuevo.estatura = dblEstatura;
                        dblIMC = this.calcularIMCG(dblPeso, dblEstatura, dblEdad);
                        pacientenuevo.imcvalor = dblIMC;
                        dblIMCH = this.calcularIMCH(dblPeso, dblEstatura, dblEdad);
                        dblIMCM = this.calcularIMCM(dblPeso, dblEstatura, dblEdad);
                        pacientenuevo.imcmvalor = dblIMCM;
                        pacientenuevo.imchvalor = dblIMCH;
                        pacientenuevo.imcdescripcion = this.obtenerIMCDescripcion(dblIMC);

                        db.paciente.Add(pacientenuevo);
                        db.SaveChanges();
                        MessageBox.Show("Se ha registrado el paciente: " + strNombre + " satisfactoriamente");
                        this.Close();

                        pricipalForm.Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El usuario ya ha sido ingresado con anterioridad");
                    }

                }             
                
            }

        }
    }
}

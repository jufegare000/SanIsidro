//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormularioHospital2.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class paciente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string tipodedocumento { get; set; }
        public string numerodocumento { get; set; }
        public string paisdeorigen { get; set; }
        public Nullable<int> tiempodepermanenciaenmeses { get; set; }
        public string genero { get; set; }
        public string fechanacimiento { get; set; }
        public Nullable<int> edad { get; set; }
        public string estadocivil { get; set; }
        public string correoelectronico { get; set; }
        public Nullable<int> numerodehijos { get; set; }
        public string direccionresidencia { get; set; }
        public string barrioresidencia { get; set; }
        public string telefonocontacto { get; set; }
        public string ocupacion { get; set; }
        public string nivelescolaridad { get; set; }
        public string eps { get; set; }
        public string regimen { get; set; }
        public string antecedentesmedicos { get; set; }
        public string convenio { get; set; }
        public string contactoemergencia { get; set; }
        public Nullable<double> masa { get; set; }
        public Nullable<double> peso { get; set; }
        public Nullable<double> estatura { get; set; }
        public Nullable<double> imcmvalor { get; set; }
        public Nullable<double> imcvalor { get; set; }
        public Nullable<double> imchvalor { get; set; }
        public string imcdescripcion { get; set; }

        public string formula { get; set; }
    }
}

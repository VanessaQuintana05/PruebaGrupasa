//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaGrupasa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MT_Formulario
    {
        public int Id_Formulario { get; set; }
        public Nullable<int> Id_Actividad { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Enlace_Formulario { get; set; }
        public string NombreArchivo { get; set; }
        public Nullable<System.DateTime> Fecha_Creacion { get; set; }
        public string Estado { get; set; }
    }
}

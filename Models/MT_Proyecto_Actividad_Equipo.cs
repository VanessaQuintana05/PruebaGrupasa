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
    
    public partial class MT_Proyecto_Actividad_Equipo
    {
        public int Id_Proyecto_Actividad_Equipo { get; set; }
        public Nullable<int> Id_Proyecto_Actividad { get; set; }
        public Nullable<int> Id_Equipo { get; set; }
        public Nullable<int> Id_Persona { get; set; }
        public Nullable<System.DateTime> Fecha_Ini { get; set; }
        public Nullable<System.DateTime> Fecha_Fin { get; set; }
        public string Estado { get; set; }
    }
}

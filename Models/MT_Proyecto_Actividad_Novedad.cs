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
    
    public partial class MT_Proyecto_Actividad_Novedad
    {
        public int Id_Proyecto_Actividad_Novedad { get; set; }
        public Nullable<int> Id_Proyecto_Actividad { get; set; }
        public string Id_usuario { get; set; }
        public string Tipo_Novedad { get; set; }
        public string Novedad { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Id_Dirigido_a { get; set; }
        public string Estado { get; set; }
    }
}

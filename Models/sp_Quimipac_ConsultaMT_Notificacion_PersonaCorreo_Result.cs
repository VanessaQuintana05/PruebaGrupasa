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
    
    public partial class sp_Quimipac_ConsultaMT_Notificacion_PersonaCorreo_Result
    {
        public int Id_Notificacion_Persona { get; set; }
        public Nullable<int> Id_Notificacion { get; set; }
        public Nullable<int> Id_Persona { get; set; }
        public Nullable<int> Tipo { get; set; }
        public string Correo { get; set; }
        public Nullable<System.DateTime> Fecha_Hora { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}

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
    
    public partial class sp_Quimipac_ConsultaMT_ProyectoAlerta_Result
    {
        public int Id_Proyecto_Alerta { get; set; }
        public Nullable<int> Id_Proyecto { get; set; }
        public string Id_Usuario { get; set; }
        public Nullable<System.DateTime> Fecha_Registro { get; set; }
        public Nullable<System.DateTime> Fecha_Alerta { get; set; }
        public string Mensaje { get; set; }
        public string Repetir { get; set; }
        public string Estado { get; set; }
        public string Correo { get; set; }
        public string CodigoC { get; set; }
    }
}

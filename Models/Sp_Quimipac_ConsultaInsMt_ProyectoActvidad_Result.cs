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
    
    public partial class Sp_Quimipac_ConsultaInsMt_ProyectoActvidad_Result
    {
        public int Id_Proyecto_Actividad { get; set; }
        public Nullable<int> Id_Proyecto { get; set; }
        public Nullable<int> Id_Actividad { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<int> Orden { get; set; }
        public Nullable<System.DateTime> Fecha_Ini { get; set; }
        public Nullable<System.DateTime> Fecha_Fin { get; set; }
        public string Comentario { get; set; }
        public Nullable<int> Id_Planilla { get; set; }
        public Nullable<int> Estado_Actividad_Plantilla { get; set; }
        public string EstadoAct { get; set; }
        public string Codigo_Cliente { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionEstado { get; set; }
    }
}

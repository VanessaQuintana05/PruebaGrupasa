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
    
    public partial class MT_PrecioReferencial
    {
        public int Id_PrecioReferencial { get; set; }
        public Nullable<int> Id_TipoTablaDetalle { get; set; }
        public Nullable<int> Id_Proyecto_Contrato { get; set; }
        public string Id_Item { get; set; }
        public Nullable<int> Id_TipoTrabajo { get; set; }
        public string Id_Usuario { get; set; }
        public Nullable<System.DateTime> Fecha_Registro { get; set; }
        public Nullable<System.DateTime> Fecha_Inicio { get; set; }
        public Nullable<System.DateTime> Fecha_Fin { get; set; }
        public string Moneda { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public string Estado { get; set; }
        public string Unidad { get; set; }
    }
}

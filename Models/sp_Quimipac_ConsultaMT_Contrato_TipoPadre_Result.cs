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
    
    public partial class sp_Quimipac_ConsultaMT_Contrato_TipoPadre_Result
    {
        public int Id_Contrato { get; set; }
        public string Nombre { get; set; }
        public string Codigo_Interno { get; set; }
        public string Codigo_Cliente { get; set; }
        public Nullable<int> Contrato_Padre { get; set; }
        public string Id_Cliente { get; set; }
        public string Descripcion { get; set; }
    }
}
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
    
    public partial class MT_Proyecto_Parametro
    {
        public int Id_Proyecto_Parametros { get; set; }
        public Nullable<int> Id_Proyecto { get; set; }
        public string Parametro { get; set; }
        public string Tipo_Dato { get; set; }
        public Nullable<int> Valor { get; set; }
        public string Estado { get; set; }
        public string Moneda { get; set; }
    }
}

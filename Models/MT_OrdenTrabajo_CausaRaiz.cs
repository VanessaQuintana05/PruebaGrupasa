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
    
    public partial class MT_OrdenTrabajo_CausaRaiz
    {
        public int Id_OrdenTrabajo_CausaRaiz { get; set; }
        public Nullable<int> Id_Orden_Trabajo { get; set; }
        public Nullable<int> Id_Causa_Raiz { get; set; }
        public string Motivo_Causa { get; set; }
        public Nullable<int> Encontro { get; set; }
        public string Motivo_E { get; set; }
        public Nullable<int> Hizo { get; set; }
        public string Motivo_H { get; set; }
    }
}

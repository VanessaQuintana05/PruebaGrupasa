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
    
    public partial class MT_Estacion
    {
        public int Id_Estacion { get; set; }
        public string Id_Cliente { get; set; }
        public Nullable<int> Id_Provincia { get; set; }
        public Nullable<int> Id_Ciudad { get; set; }
        public Nullable<int> Id_Macrosector { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string Coordenada_X { get; set; }
        public string Coordenada_Y { get; set; }
    }
}

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
    
    public partial class sp_service_mail_notificacion_Result
    {
        public string CORREO { get; set; }
        public int Id_Notificacion { get; set; }
        public Nullable<int> Tipo_Notificacion { get; set; }
        public Nullable<int> Id_Codigo_origen { get; set; }
        public string Id_usuario { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Prioridad { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public Nullable<int> Criterio { get; set; }
        public Nullable<int> Frecuencia { get; set; }
        public Nullable<bool> Enviado { get; set; }
        public Nullable<System.DateTime> Fecha_Envio { get; set; }
        public Nullable<bool> Reenvio { get; set; }
        public string EmpresaID { get; set; }
    }
}

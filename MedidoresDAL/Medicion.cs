//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedidoresDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicion
    {
        public System.DateTime Fecha { get; set; }
        public decimal ValorConsumo { get; set; }
        public int IdMedidor { get; set; }
    
        public virtual Medidor Medidor { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string CodigoDeBarra { get; set; }
        public Nullable<int> IdArticuloFamilia { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<bool> Activo { get; set; }
    }
}

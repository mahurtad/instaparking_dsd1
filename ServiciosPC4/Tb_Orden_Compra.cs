//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosPC4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Orden_Compra
    {
        public string Num_oco { get; set; }
        public System.DateTime Fec_oco { get; set; }
        public string Cod_prv { get; set; }
        public Nullable<System.DateTime> Fec_ate { get; set; }
        public string Est_oco { get; set; }
    
        public virtual Tb_Proveedor Tb_Proveedor { get; set; }
    }
}

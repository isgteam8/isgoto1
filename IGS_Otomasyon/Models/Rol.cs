//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IGS_Otomasyon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rol
    {
        public Rol()
        {
            this.Kullanici = new HashSet<Kullanici>();
        }
    
        public int RolId { get; set; }
        public Nullable<int> RolTipi { get; set; }
    
        public virtual ICollection<Kullanici> Kullanici { get; set; }
    }
}

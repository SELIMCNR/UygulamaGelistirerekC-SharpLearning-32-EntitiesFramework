//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTİTYPROJECTAPP
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_MUSTERİ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_MUSTERİ()
        {
            this.TBL_SATİS = new HashSet<TBL_SATİS>();
        }
    
        public int MUSTERİD { get; set; }
        public string MUSTERİAD { get; set; }
        public string MUSTERİSOYAD { get; set; }
        public string SEHIR { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SATİS> TBL_SATİS { get; set; }
    }
}

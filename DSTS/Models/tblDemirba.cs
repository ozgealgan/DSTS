//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSTS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDemirba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDemirba()
        {
            this.tblOdaDemirbas = new HashSet<tblOdaDemirba>();
        }
    
        public int demirbasId { get; set; }
        public string demirbasAdi { get; set; }
        public int demirbasAdet { get; set; }
        public int demirbasTurId { get; set; }
        public System.DateTime alimTarihi { get; set; }
        public decimal fiyat { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public int fakulteId { get; set; }
        public string demirbasKodu { get; set; }
    
        public virtual tblFakulte tblFakulte { get; set; }
        public virtual tblTur tblTur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOdaDemirba> tblOdaDemirbas { get; set; }
    }
}

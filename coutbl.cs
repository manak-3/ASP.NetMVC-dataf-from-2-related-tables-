//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestASS2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class coutbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public coutbl()
        {
            this.Stutables = new HashSet<Stutable>();
        }
    
        public int course_id { get; set; }
        public string course_name { get; set; }
        public int tutor_id { get; set; }
        public string tutor_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stutable> Stutables { get; set; }
    }
}

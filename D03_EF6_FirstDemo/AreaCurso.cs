//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace D03_EF6_FirstDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class AreaCurso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AreaCurso()
        {
            this.SubareaCurso = new HashSet<SubareaCurso>();
        }
    
        public int AreaCursoID { get; set; }
        public string Area { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubareaCurso> SubareaCurso { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consultorio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profesionales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profesionales()
        {
            this.ProfesionalesEspecialidades = new HashSet<ProfesionalesEspecialidades>();
            this.ProfesionalesEspecialidades1 = new HashSet<ProfesionalesEspecialidades>();
        }
    
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int PersonaId { get; set; }
    
        public virtual Personas Personas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfesionalesEspecialidades> ProfesionalesEspecialidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfesionalesEspecialidades> ProfesionalesEspecialidades1 { get; set; }
    }
}

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
    
    public partial class Pacientes
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int PersonaId { get; set; }
    
        public virtual Personas Personas { get; set; }
    }
}

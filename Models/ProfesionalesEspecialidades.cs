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
    
    public partial class ProfesionalesEspecialidades
    {
        public int Id { get; set; }
        public int ProfesionalId { get; set; }
        public int EspecialidadId { get; set; }
    
        public virtual Especialidades Especialidades { get; set; }
        public virtual Especialidades Especialidades1 { get; set; }
        public virtual Profesionales Profesionales { get; set; }
        public virtual Profesionales Profesionales1 { get; set; }
    }
}

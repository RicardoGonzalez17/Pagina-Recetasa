//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaginaRecetas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class INGREDIENTES
    {
        public int ID_Ingrediente { get; set; }
        public int ID_Receta { get; set; }
        public string Ingrediente { get; set; }
    
        public virtual RECETAS RECETAS { get; set; }
    }
}
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
    
    public partial class RECETAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RECETAS()
        {
            this.COMENTARIOS = new HashSet<COMENTARIOS>();
            this.INGREDIENTES = new HashSet<INGREDIENTES>();
            this.MULTIMEDIA = new HashSet<MULTIMEDIA>();
        }
    
        public int ID_Receta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Fecha_Alta { get; set; }
        public int Puntuacion { get; set; }
        public int ID_Categoria { get; set; }
        public Nullable<int> ID_Usuario { get; set; }
        public Nullable<int> Likes { get; set; }
        public Nullable<int> Dislikes { get; set; }
    
        public virtual CATEGORIAS CATEGORIAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMENTARIOS> COMENTARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGREDIENTES> INGREDIENTES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MULTIMEDIA> MULTIMEDIA { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
    }
}

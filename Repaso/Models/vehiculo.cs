//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repaso.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vehiculo()
        {
            this.Accesorio = new HashSet<Accesorio>();
        }
    
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        public string marca { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public int precio { get; set; }

        [DisplayName("URL Foto")]
        [Required(ErrorMessage = "{0} es requerido")]
        public string foto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accesorio> Accesorio { get; set; }
    }
}

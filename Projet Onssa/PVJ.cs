//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_Onssa
{
    using System;
    using System.Collections.Generic;
    
    public partial class PVJ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PVJ()
        {
            this.ListFournisseursRepondu = new HashSet<Fournisseur>();
            this.ListCommissions = new HashSet<Commission>();
        }
    
        public int IdPVJ { get; set; }
        public string DateString { get; set; }
        public System.DateTime DatePvj { get; set; }
        public string NumPvj { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fournisseur> ListFournisseursRepondu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commission> ListCommissions { get; set; }
        public virtual Consultation InfoConsultation { get; set; }
        public virtual BC InfoBC { get; set; }
        public virtual Fournisseur InfoFournisseur { get; set; }
    }
}

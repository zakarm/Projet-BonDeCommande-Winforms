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
    
    public partial class Ligne
    {
        public int CodeLigne { get; set; }
        public string DescriptionLigne { get; set; }
    
        public virtual Lrg InfoLrg { get; set; }
        public virtual Morasse Morasse { get; set; }
    }
}

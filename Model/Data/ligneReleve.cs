//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataReporting.Model.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ligneReleve
    {
        public int idLigneReleve { get; set; }
        public double temperature { get; set; }
        public double hygrometrie { get; set; }
        public int releveID { get; set; }
        public System.DateTime dateLigneReleve { get; set; }
        public System.TimeSpan heureLigneReleve { get; set; }
    
        public virtual releve releve { get; set; }
    }
}

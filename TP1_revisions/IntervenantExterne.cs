using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesMetier
{
    public class IntervenantExterne : Intervenant 
    {
        public string Specialite { get; }
        public string Adresse { get; }
        public string Tel { get; }

        public IntervenantExterne( string pNom , string pPrenom ,string pSpecialite , string pAdresse, string pTel ) : base(pNom, pPrenom)
        {
            this.Specialite = pSpecialite;
            this.Adresse = pAdresse;
            this.Tel = pTel;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Specialite + " " + Adresse + " " + Tel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesMetier
{
    public class Intervenant
    {
        public string Nom { get; }
        public string Prenom { get; }

        public List<Prestation> lesPrestation { get;}

        public Intervenant(string pNom, string pPrenom)
        {
            this.Nom = pNom;
            this.Prenom = pPrenom;
            this.lesPrestation = new List<Prestation>();
        }

        public void ajoutePrestation(Prestation unePrestation)
        {
            lesPrestation.Add(unePrestation);
        }

        public override string ToString()
        {
            return Nom + " " + Prenom;
        }
    }
}

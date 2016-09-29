using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesMetier
{
    public class Dossier
    {
        // Attribut privée  de la classe Dossier
        public string NomPatient { get; set; }
        public string PrenomPatient { get; set; }
        public DateTime DateNaissancePatient { get; set; }
        public List<Prestation> MesPrestations { get; set; }

        // Constructeur de la classe Dossier
        public Dossier(string pNomPatient, string pPrenomPatient, DateTime pDateNaissancePatient)
        {
            this.NomPatient = pNomPatient;
            this.PrenomPatient = pPrenomPatient;
            this.DateNaissancePatient = pDateNaissancePatient;
            this.MesPrestations = new List<Prestation>();
        }

        public Dossier(string pNomPatient, string pPrenomPatient, DateTime pDateNaissancePatient, Prestation unePrestation)
        {
            this.NomPatient = pNomPatient;
            this.PrenomPatient = pPrenomPatient;
            this.DateNaissancePatient = pDateNaissancePatient;
            this.MesPrestations = new List<Prestation>();
            this.MesPrestations.Add(unePrestation);
        }

        public Dossier(string pNomPatient, string pPrenomPatient, DateTime pDateNaissancePatient, List<Prestation> pLesPrestations)
        {
            this.NomPatient = pNomPatient;
            this.PrenomPatient = pPrenomPatient;
            this.DateNaissancePatient = pDateNaissancePatient;
            this.MesPrestations = new List<Prestation>();
            this.MesPrestations = pLesPrestations;
        }

        // Methodes publiques 

        public override string ToString()
        {
            return "Dossier de " + NomPatient + " " + PrenomPatient + " née en " + DateNaissancePatient + " nombre de prestation : "+ this.MesPrestations.Count;
        }
        // ajoute une prestation dans la collection mesPrestations
        public void ajoutePrestation(string pLibelle, DateTime pDate, DateTime pHeure, Intervenant pIntervenant)
        {
            MesPrestations.Add(new Prestation(pLibelle, pDate, pHeure, pIntervenant));
        }

        // retourne le nombre d'intervenant externe dans la collection mesPrestation
        public int getNbPrestationsExternes()
        {
            int nb = 0;
            foreach (Prestation Prestation in MesPrestations)
            {
                if(Prestation.I_Intervenant is IntervenantExterne)
                {
                    nb++;
                }
            }
            return nb;

        }

        // retourne le nombre de prestations
        public int getNbPrestations()
        {
            return MesPrestations.Count();
        }

        public int getNbJoursSoins()
        {
            List<DateTime> listeDate = new List<DateTime>();
                foreach (Prestation unePrestation in MesPrestations)
                {
                    if (!(listeDate.Contains(unePrestation.DateSoin)))
                    {
                        listeDate.Add(unePrestation.DateSoin);
                    }
                }
                return listeDate.Count();
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesMetier
{
    public class Prestation
    {
        public string Libelle { get; }

        public DateTime DateSoin { get; }

        public DateTime Heuresoin { get; }

        public Intervenant I_Intervenant { get; }

        public Prestation(string pLibelle, DateTime pDateSoin, DateTime pHeureSoin, Intervenant pI_Intervenant)
        {
            this.Libelle = pLibelle;
            this.DateSoin = pDateSoin;
            this.Heuresoin = pHeureSoin;
            this.I_Intervenant = pI_Intervenant;
        }

        public int compareTo(Prestation unePrestation)
        {
            if( this.DateSoin.Year == unePrestation.DateSoin.Year && this.DateSoin.Month == unePrestation.DateSoin.Month && this.DateSoin.Day == unePrestation.DateSoin.Day)
            {
                return 0;
            }
            else if(this.DateSoin.Year > unePrestation.DateSoin.Year && this.DateSoin.Month > unePrestation.DateSoin.Month && this.DateSoin.Day > unePrestation.DateSoin.Day)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return ("Libelle : " + this.Libelle + "\n DateSoin : " + this.DateSoin + "\n HeureSoin : " + this.Heuresoin + "\n Intervenant : " + this.I_Intervenant);
        }
    }
}

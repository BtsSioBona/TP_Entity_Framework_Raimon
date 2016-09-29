using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classesMetier;
using System.Xml;
using System.Configuration;
using utilitaire;

namespace PrestationSoin
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(ConfigurationManager.AppSettings["urlXml"]);
            // Xml Element racine
            XmlElement root = doc.DocumentElement;

            
            
            // Creation des listes d'élements
            XmlNodeList Dossiers = root.GetElementsByTagName("Dossier");
            XmlNodeList prestations = root.GetElementsByTagName("prestation");
            XmlNodeList intervenants = root.GetElementsByTagName("Intervenants");
            
            
            // Creation des collections 
            List<Dossier> LesDossiers = new List<Dossier>();
            List<Prestation> LesPrestations = new List<Prestation>();
            List<Intervenant> LesIntervenants = new List<Intervenant>();
            List<DateTime> LesDates = new List<DateTime>();

            //LesDossiers.Add(XmlRead.XMLToDossier(Dossiers[0]));
            LesDossiers = XmlRead.XMLToDossiers(Dossiers);
            for (int i = 0; i < Dossiers.Count; i++)
            {
                Console.WriteLine("-----------------Creation dossier n°" + (i + 1) + "-----------------\n");
                Console.WriteLine(LesDossiers[i].ToString() + "\n\n\n");
            }
            for (int i = 0; i < 3; i++)
            {
                LesIntervenants.Add(XmlRead.XMLToIntervenant(intervenants[0].ChildNodes[i]));
                Console.WriteLine("-----------------Creation d'un intervenant n°" + (i + 1) + "-----------------\n");
                Console.WriteLine(LesIntervenants[i].ToString() + "\n\n\n");
            }
            /*
            //test 

            // Creation des DateTime
            for (int i = 0; i < Dossiers.Count; i++)
            {
                LesDates.Add(new DateTime(Convert.ToInt32(Dossiers[i].ChildNodes[2].ChildNodes[2].InnerXml),
                Convert.ToInt32(Dossiers[i].ChildNodes[2].ChildNodes[1].InnerXml),
                Convert.ToInt32(Dossiers[i].ChildNodes[2].ChildNodes[0].InnerXml)));
            }

            DateTime datesoinUn = new DateTime(Convert.ToInt32(prestations[0].ChildNodes[1].ChildNodes[2].InnerXml), 
                Convert.ToInt32(prestations[0].ChildNodes[1].ChildNodes[1].InnerXml), 
                Convert.ToInt32(prestations[0].ChildNodes[1].ChildNodes[0].InnerXml), 
                Convert.ToInt32(prestations[0].ChildNodes[2].ChildNodes[0].InnerXml),
                Convert.ToInt32(prestations[0].ChildNodes[2].ChildNodes[1].InnerXml),
                Convert.ToInt32(prestations[0].ChildNodes[2].ChildNodes[2].InnerXml));

            //Creation des Intervenants
            for (int i = 0; i < Dossiers.Count; i++)
            {

            }
            LesIntervenants.Add(new Intervenant(intervenants[0].ChildNodes[0].ChildNodes[0].InnerXml, intervenants[0].ChildNodes[0].ChildNodes[1].InnerXml));

            //Creation des Prestations 
            LesPrestations.Add(new Prestation(prestations[0].ChildNodes[0].InnerXml, datesoinUn, datesoinUn, LesIntervenants[0]));

            //Cration des Dossiers
            for(int i = 0; i < Dossiers.Count; i++)
            {
                Console.WriteLine("-----------------Creation dossier n°"+ (i+1)+"-----------------\n");
                LesDossiers.Add(new Dossier(Dossiers[i].ChildNodes[0].InnerXml, Dossiers[i].ChildNodes[1].InnerXml, LesDates[i]));
                Console.WriteLine(LesDossiers[i].ToString()+"\n\n\n");
            }
            /*
            
            Dossier UnDossier = new Dossier(Dossiers[0].ChildNodes[0].InnerXml, Dossiers[0].ChildNodes[1].InnerXml, ddnUnDossier);
            Console.WriteLine(UnDossier.ToString());
            Console.WriteLine("-----------------Creation dossier 2-----------------");
            Dossier DossierDeux = new Dossier(Dossiers[1].ChildNodes[0].InnerXml, Dossiers[1].ChildNodes[1].InnerXml, ddnDossierDeux , UnePrestation);
            Console.WriteLine(DossierDeux.ToString() + "\n Prestation : \n "+ UnePrestation.ToString());
            Dossier DossierTrois = new Dossier(Dossiers[0].ChildNodes[0].InnerXml, Dossiers[0].ChildNodes[1].InnerXml, new DateTime(Convert.ToInt32(Dossiers[0].ChildNodes[2].ChildNodes[2].InnerXml), Convert.ToInt32(Dossiers[0].ChildNodes[2].ChildNodes[1].InnerXml), Convert.ToInt32(Dossiers[0].ChildNodes[2].ChildNodes[0].InnerXml)));
            */
            Console.Read();
        }
    }
}

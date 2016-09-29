using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestationSoin;
using classesMetier;
using System.Xml;

namespace utilitaire
{
    public abstract class XmlRead
    {
        public static Dossier XMLToDossier(XmlNode node)
        {
            return new  Dossier(node.ChildNodes[0].InnerXml, node.ChildNodes[1].InnerXml, XMLToDate(node.ChildNodes[2]));
        }

        public static List<Dossier> XMLToDossiers(XmlNodeList node)
        {
            List<Dossier> LesDossiers = new List<Dossier>();
            for (int i = 0; i < node.Count; i++){
                LesDossiers.Add(XMLToDossier(node[i]));
            }
            return LesDossiers;
        }

        public static DateTime XMLToDate(XmlNode node)
        {
            if(node.ChildNodes[3]== null)
            {
                return new DateTime(Convert.ToInt32(node.ChildNodes[2].InnerXml), Convert.ToInt32(node.ChildNodes[1].InnerXml), Convert.ToInt32(node.ChildNodes[0].InnerXml));
            }
            else
            {
                return new DateTime(Convert.ToInt32(node.ChildNodes[2].InnerXml), Convert.ToInt32(node.ChildNodes[1].InnerXml), Convert.ToInt32(node.ChildNodes[0].InnerXml), Convert.ToInt32(node.ChildNodes[3].InnerXml), Convert.ToInt32(node.ChildNodes[4].InnerXml), Convert.ToInt32(node.ChildNodes[5].InnerXml));

            }
        }

        public static Intervenant XMLToIntervenant(XmlNode node)
        {
            if(node.ChildNodes[2] == null)
            {
                return new Intervenant(node.ChildNodes[0].InnerXml, node.ChildNodes[1].InnerXml);
            }
            else
            {
                return new IntervenantExterne(node.ChildNodes[0].InnerXml, node.ChildNodes[1].InnerXml, node.ChildNodes[2].InnerXml, node.ChildNodes[3].ChildNodes[0].InnerXml+ node.ChildNodes[3].ChildNodes[1].InnerXml+ node.ChildNodes[3].ChildNodes[2].InnerXml, node.ChildNodes[4].InnerXml);
            }
        }
        
        public static Prestation XMLToPrestation(XmlNode node)
        {
            return new Prestation(node.ChildNodes[0].InnerXml, XMLToDate(node.ChildNodes[1]), XMLToDate(node.ChildNodes[1]), XMLToIntervenant(node.ChildNodes[2]));
        }
    }
}

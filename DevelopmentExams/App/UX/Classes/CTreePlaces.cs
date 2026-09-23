using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Data.Structures;

namespace App.UX.Classes
{
    public class CTreePlaces
    {
        // ------------------------------------------------------------------------------------
        public CTreeNode<String> oRoot = new CTreeNode<String>();
        // ------------------------------------------------------------------------------------
        public CTreePlaces() { }
        // ------------------------------------------------------------------------------------
        public void AddOrUpdateNode(String p_sLine)
        {
            oRoot.Name = "Cool Tree!";

            String[] sLevels = p_sLine.Split(';');

            String sContinent = sLevels[0];
            String sCountry = sLevels[1];
            String sCity = sLevels[2];

            if (!NameExists(sContinent, oRoot))
            {
                oRoot.NewChild(sContinent).NewChild(sCountry).NewChild(sCity);
            }
            else
            {
                FindNode(sContinent, oRoot).NewChild(sCountry).NewChild(sCity);
            }
        }
        // ------------------------------------------------------------------------------------
        public bool NameExists(String p_sNodeName, CTreeNode<String> oParent)
        {
            bool found = false;

            foreach(CTreeNode<String> oChild in oParent.Children)
            {
                if(oChild.Name == p_sNodeName)
                {
                    found = true;
                    break;
                }
            }

            return found;
        }
        // ------------------------------------------------------------------------------------
        public CTreeNode<String> FindNode(String p_sNodeName, CTreeNode<String> p_oParent)
        {
            foreach(CTreeNode<String> oChild in p_oParent.Children)
            {
                if(oChild.Name == p_sNodeName)
                {
                    return oChild;
                }
            }
            return oRoot;
        }
        // ------------------------------------------------------------------------------------
    }
}
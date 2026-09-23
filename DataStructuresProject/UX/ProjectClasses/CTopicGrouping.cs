using Lib.Data.Structures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProject.UX.ProjectClasses
{
    public class CTopicGrouping
    {
        //-------------------------------------------------------------------------\\
        public CTreeNode<String> oRoot = new CTreeNode<String>();
        //-------------------------------------------------------------------------\\
        public CTopicGrouping() 
        {
            if(oRoot.Name != "Topic Grouping Tree Root")
            { 
                oRoot.Name = "Topic Grouping Tree Root";
            }
        }
        //-------------------------------------------------------------------------\\
        public void TreeGeneration(CArrayOrdered<String> oKeysArray)
        {
            CreateLetterChildren();

            foreach(String key in oKeysArray)
            {
                String sFirstTwoLetters = key.Substring(0, 2);
                FindAndCreateNode(sFirstTwoLetters, key);
            }
        }
        //-------------------------------------------------------------------------\\
        public void FindAndCreateNode(String p_sFirstTwoLetter, String p_sKey)
        {
            String sFirstLetter = p_sFirstTwoLetter.Substring(0, 1);
            foreach(CTreeNode<String> oChild in oRoot.Children)
            {
                if(oChild.Name == sFirstLetter)
                {
                    if(!PrefixExistsAlready(oChild, p_sFirstTwoLetter))
                    { 
                        oChild.NewChild(p_sFirstTwoLetter).NewChild(p_sKey);
                    }
                    else
                    {
                        CreateOnlyTheLastChild(p_sKey, p_sFirstTwoLetter, oChild);
                    }
                }
            }
        }
        //-------------------------------------------------------------------------\\
        public void CreateLetterChildren()
        {
            oRoot.NewChild("a");
            oRoot.NewChild("b");
            oRoot.NewChild("c");
            oRoot.NewChild("d");
            oRoot.NewChild("e");
            oRoot.NewChild("f");
            oRoot.NewChild("g");
            oRoot.NewChild("h");
            oRoot.NewChild("i");
            oRoot.NewChild("j");
            oRoot.NewChild("k");
            oRoot.NewChild("l");
            oRoot.NewChild("m");
            oRoot.NewChild("n");
            oRoot.NewChild("o");
            oRoot.NewChild("p");
            oRoot.NewChild("q");
            oRoot.NewChild("r");
            oRoot.NewChild("s");
            oRoot.NewChild("t");
            oRoot.NewChild("u");
            oRoot.NewChild("v");
            oRoot.NewChild("x");
            oRoot.NewChild("y");
            oRoot.NewChild("z");
        }
        //-------------------------------------------------------------------------\\
        public bool PrefixExistsAlready(CTreeNode<String> oParentNode, String p_sPrefix)
        {
            foreach(CTreeNode<String> oChild in oParentNode.Children)
            {
                if(oChild.Name == p_sPrefix)
                {
                    return true;
                }
            }
            return false;
        }
        //-------------------------------------------------------------------------\\
        public void CreateOnlyTheLastChild(String p_sKey, String p_sFirstTwoLetter, CTreeNode<String> oChild)
        {
            foreach(CTreeNode<String> oChildNode in oChild.Children)
            {
                if(oChildNode.Name == p_sFirstTwoLetter)
                {
                    oChildNode.NewChild(p_sKey);
                    break;
                }
            }
        }
        //-------------------------------------------------------------------------\\
    }
}
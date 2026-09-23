using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Data.Structures;

namespace DataStructuresProject.UX.ProjectClasses
{
    public class CTokenizer
    {
        //------------------------------------------------------------------------------------------------------------------------------
        private CDictionary<String, CToken> _tokenDict = new CDictionary<String, CToken>();
        public CDictionary<String, CToken> TokenDict { get { return _tokenDict; } }
        //------------------------------------------------------------------------------------------------------------------------------
        // private CHashTable<String, CToken> _tokenTable = new CHashTable<String, CToken>();
        // public CHashTable<String, CToken> TokenTable { get { return _tokenTable; } }
        //------------------------------------------------------------------------------------------------------------------------------
        public CTokenizer()
        {
            
        }
        //------------------------------------------------------------------------------------------------------------------------------
        public void PopulateUniqueTokensDict(String[] Array)
        {
            foreach(String s in Array)
            {
                if (!TokenDict.ContainsKey(s))
                {
                    CToken token = new CToken(s, 1);
                    TokenDict[s] = token;
                }
                else if (TokenDict.ContainsKey(s))
                {
                    TokenDict[s].TokenOccurences++;
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------
        public String TurnUserInputToIDs(String[] Array)
        {
            String sResultString = "";
            int count = 1;
            foreach(String s in Array)
            {
                if (count == Array.Length)
                { 
                    sResultString +=  $"{TokenDict[s].TokenID}";
                }
                else
                {
                    sResultString += $"{TokenDict[s].TokenID},";
                }
                count++;
            }
            return sResultString;
        }
        //------------------------------------------------------------------------------------------------------------------------------
    }
}
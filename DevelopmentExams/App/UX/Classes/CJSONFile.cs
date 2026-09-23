using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Lib.Data.Structures;

namespace App.UX.Classes
{
    public class CJSONFile
    {
        // ------------------------------------------------------------------------------------ 
        public Dictionary<String, String> oDict = new Dictionary<String, String>();
        public CArrayOrdered<String> oKeys = new CArrayOrdered<String>();
        // ------------------------------------------------------------------------------------
        public CJSONFile()
        {
            
        }
        // ------------------------------------------------------------------------------------
        public void PopulateDict(String p_sFilePath)
        {
            using (StreamReader oReader = new StreamReader(p_sFilePath))
            {
                String json = oReader.ReadToEnd();
                oDict = JsonSerializer.Deserialize<Dictionary<String, String>>(json);
            }

            foreach(String s in oDict.Keys)
            {
                oKeys.Add(s);
            }
        }
        // ------------------------------------------------------------------------------------
    }
}
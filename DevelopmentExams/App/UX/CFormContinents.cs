using App.UX.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib.Data.Structures;

namespace App.UX
{
    public partial class CFormContinents : Form
    {
        // ------------------------------------------------------------------------------------
        public CTree<String> oTree = new CTree<String>();
        public CTreePlaces oPlacesTree = new CTreePlaces();
        // ------------------------------------------------------------------------------------
        public CFormContinents()
        {
            InitializeComponent();
            oTree.Root = oPlacesTree.oRoot;
        }
        // ------------------------------------------------------------------------------------
        public void btnLoad_OnClick(object sender, EventArgs e)
        {
            ProcessAndDisplayData();
            this.txtView.Text = oTree.ToString();
        }
        // ------------------------------------------------------------------------------------
        public void ProcessAndDisplayData()
        {
            String[] sLines = File.ReadAllLines(@"C:\Code\Examples\DevelopmentExams\data_files\continents-sample.txt");

            int count = 0;
            foreach(String sLine in sLines)
            {
                if (count != 0)
                {
                    oPlacesTree.AddOrUpdateNode(sLine);
                }
                else
                {
                    count++;
                }
            }
        }
        // ------------------------------------------------------------------------------------
    }
}

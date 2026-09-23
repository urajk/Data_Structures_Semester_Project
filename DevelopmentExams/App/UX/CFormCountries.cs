using App;
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

namespace App.UX
{
    public partial class CFormCountries : Form
    {
        // ------------------------------------------------------------------------------------
        public CJSONFile oFileReader = new CJSONFile();
        // ------------------------------------------------------------------------------------
        public CFormCountries()
        {
            InitializeComponent();
        }
        // ------------------------------------------------------------------------------------
        public void BtnLoad_OnClick(object sender, EventArgs e)
        {
            ProcessAndDisplayData();
        }
        // ------------------------------------------------------------------------------------
        public void ProcessAndDisplayData()
        {
            oFileReader.PopulateDict(@"C:\Code\Examples\DevelopmentExams\App\Data\countries.json");
            txtView.Text = oFileReader.oKeys.ToString();
        }
        // ------------------------------------------------------------------------------------
    }
}

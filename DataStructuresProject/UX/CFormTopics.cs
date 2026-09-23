using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib.Data.Structures;
using DataStructuresProject.UX.ProjectClasses;

namespace DataStructuresProject.UX
{
    public partial class CFormTopics : Form
    {
        // ----------------------------------------------------------------------------
        CTopicGrouping otopicGroup = new CTopicGrouping();
        // ----------------------------------------------------------------------------
        CAlphabetButtonsGrid buttons;

        CJsonDict oDictReference = new CJsonDict();
        // ----------------------------------------------------------------------------
        public CFormTopics()
        {
            InitializeComponent();
            createLetterButtons();

            oDictReference.PopulateDict();
            this.richTextBox1.Text = PrintDictionary();

            otopicGroup.TreeGeneration(oDictReference.oKeys);
        }
        // ----------------------------------------------------------------------------
        private void createLetterButtons()
        {
            this.buttons = new CAlphabetButtonsGrid(this.grpLetters, 2);
            foreach (Button oButton in this.buttons)
            {
                oButton.Click += DoOnLetterButtonClick;
            }
        }
        // ----------------------------------------------------------------------------
        private void DoOnLetterButtonClick(object sender, EventArgs e)
        {
            string sLetter = ((Button)sender).Text;
            DisplayByLetter(sLetter.ToLower(), otopicGroup.oRoot);
        }
        // ----------------------------------------------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtUserInput.Text.Trim() != String.Empty)
            {
                this.richTextBox1.Text = oDictReference.SearchKeyValue(this.txtUserInput.Text.Trim().ToLower());
            }
            else
            {
                this.richTextBox1.Text = PrintDictionary();
            }
        }
        // ----------------------------------------------------------------------------
        public String? PrintDictionary()
        {
            String sResultString = null;
            foreach (String key in oDictReference.oSearchArray)
            {
                sResultString += key + "\r\n";
            }
            return sResultString;
        }
        // ----------------------------------------------------------------------------
        public void DisplayByLetter(String p_sLetter, CTreeNode<String> oRoot)
        {
            this.lstTopics.Items.Clear();
            this.lstTwoLetters.Items.Clear();

            int TopicCounter = 0;
            int TwoLetterPrefixesCounter = 0;

            foreach (CTreeNode<String> oChild in oRoot.Children)
            {
                if (oChild.Name == p_sLetter)
                {
                    foreach (CTreeNode<String> oGrandChild in oChild.Children)
                    {
                        this.lstTwoLetters.Items.Add(oGrandChild.Name);
                        TwoLetterPrefixesCounter++;
                        foreach (CTreeNode<String> oGreatGrandChild in oGrandChild.Children)
                        {
                            this.lstTopics.Items.Add(oGreatGrandChild.Name);
                            TopicCounter++;
                        }
                    }
                }
            }

            this.lblLevel2NodeChildrenCount.Text = $"Topics Count: {TopicCounter}";
            this.lblLevel1NodeChildrenCount.Text = $"Subcategories Count: {TwoLetterPrefixesCounter}";
        }
    }
}

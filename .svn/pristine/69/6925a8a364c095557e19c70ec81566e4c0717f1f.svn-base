using DataStructuresProject.UX.ProjectClasses;
using Lib.Data.Structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresProject.UX
{
    public partial class CFormTextFileBase : Form
    {
        //-------------------------------------------------------------------------------------------------------------------//
        public TreeView oTreeView = new TreeView();
        public ImageList oImageList = new ImageList();
        private long totalSize = 0;
        //-------------------------------------------------------------------------------------------------------------------//
        public const int FILE_ICON = 0;
        public const int FOLDER_ICON = 1;
        //-------------------------------------------------------------------------------------------------------------------//
        private CFileTree ofileTree = new CFileTree();
        private CTree<CFileEntry> oFileSystem = new CTree<CFileEntry>();
        //-------------------------------------------------------------------------------------------------------------------//
        public CFormTextFileBase()
        {   
            InitializeComponent();
            this.txtUserInput.Text = @"C:\Code\Project\TreeTesting";
        }
        //-------------------------------------------------------------------------------------------------------------------//
        public void btnBuild_OnClick(object sender, EventArgs e)
        {
            if(txtUserInput.Text.Trim() != null)
            {
                this.tvFileSystem.Nodes.Clear();

                ofileTree.BuildFileTree(txtUserInput.Text.Trim(), oFileSystem);
                TreeNode oVisualRoot = this.tvFileSystem.Nodes.Add("");

                oVisualRoot.ImageIndex = FOLDER_ICON;
                oVisualRoot.SelectedImageIndex = FOLDER_ICON;

                ofileTree.recurseCreateVisualNode(oVisualRoot, this.oFileSystem.Root);

                long nTotalSizeMBytes = totalSize / (1024 * 1024);

                visualizeList();
            }
        }
        //-------------------------------------------------------------------------------------------------------------------//
        public void btnBrowse_OnClick(object sender, EventArgs e)
        {
            FolderBrowserDialog oDialog = new FolderBrowserDialog();
            oDialog.Description = "Select a Folder";

            if (this.txtUserInput.Text.Trim() == String.Empty)
            {
                oDialog.InitialDirectory = @"C:\Code\TreeTesting";
            }
            else
            {
                oDialog.InitialDirectory = this.txtUserInput.Text;
            }

            if (oDialog.ShowDialog() == DialogResult.OK)
            { 
                this.txtUserInput.Text = oDialog.SelectedPath;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------//
        public void visualizeList()
        {
            this.lvTextFiles.Items.Clear();
            foreach (long num in ofileTree.fileSizes)
            {
                this.lvTextFiles.Items.Add(num.ToString());
            }
        }
        //-------------------------------------------------------------------------------------------------------------------//
    }
}
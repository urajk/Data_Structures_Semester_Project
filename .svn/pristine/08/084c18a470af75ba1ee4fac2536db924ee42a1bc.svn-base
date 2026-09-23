using Lib.Data.Structures;
using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProject.UX.ProjectClasses
{
    public class CFileTree
    {
        //-------------------------------------------------------------------------------------------------------------------\\
        public List<CFileEntry> leafList = new List<CFileEntry>();
        public List<long> fileSizes = new List<long>();
        //-------------------------------------------------------------------------------------------------------------------\\
        public const int FILE_ICON = 0;
        public const int FOLDER_ICON = 1;
        //-------------------------------------------------------------------------------------------------------------------//
        public CFileTree() 
        { 
                 
        }
        //-------------------------------------------------------------------------------------------------------------------\\
        public void BuildFileTree(String p_sPath, CTree<CFileEntry> p_oFileSystem)
        {
            CTreeNode<CFileEntry> oRoot = new CTreeNode<CFileEntry>();
            oRoot.Value = new CFileEntry(true);
            oRoot.Value.Path = p_sPath;
            p_oFileSystem.Root = oRoot;
            recurseFile(oRoot, 0);
            SortLeafListByFileSize();
        }
        //-------------------------------------------------------------------------------------------------------------------\\
        public void recurseFile(CTreeNode<CFileEntry> p_oFolder, int p_nDepth)
        {
            DirectoryInfo oDirectory = new DirectoryInfo(p_oFolder.Value.Path);
            DirectoryInfo[] oDirectoryFolders = oDirectory.GetDirectories();
            foreach(DirectoryInfo oFolderInfo in oDirectoryFolders)
            {
                CFileEntry oFolder = new CFileEntry(true);
                oFolder.Name = oFolderInfo.Name;
                oFolder.Path = oFolderInfo.FullName;

                CTreeNode<CFileEntry> oFolderNode = p_oFolder.NewChild(oFolder.Name);
                oFolderNode.Value = oFolder;
                recurseFile(oFolderNode, p_nDepth + 1);
            }
            processFolder(p_oFolder);
        }
        //-------------------------------------------------------------------------------------------------------------------\\
        public void processFolder(CTreeNode<CFileEntry> p_oDirectory)
        {
            DirectoryInfo oDirectory = new DirectoryInfo(p_oDirectory.Value.Path);
            FileInfo[] oDirectoryFolders = oDirectory.GetFiles();
            foreach(FileInfo ofileInfo in oDirectoryFolders)
            {
                CFileEntry oFile = new CFileEntry(false);
                oFile.Name = ofileInfo.Name;
                oFile.Path = ofileInfo.FullName;
                oFile.FileSize = ofileInfo.Length;

                CTreeNode<CFileEntry> oFileNode = p_oDirectory.NewChild(oFile.Name);
                oFileNode.Value = oFile;
                leafList.Add(oFile);
            }
        }
        //-------------------------------------------------------------------------------------------------------------------\\
        public void recurseCreateVisualNode(TreeNode p_oVisualNode, CTreeNode<CFileEntry> p_oNode)
        {
            foreach (CTreeNode<CFileEntry> oChild in p_oNode.Children)
            {
                TreeNode oVisualChildNode = new TreeNode(oChild.Name);

                int nImageIndex = FILE_ICON;
                if (oChild.Value.IsDirectory)
                    nImageIndex = FOLDER_ICON;

                oVisualChildNode.ImageIndex = nImageIndex;
                oVisualChildNode.SelectedImageIndex = nImageIndex;

                p_oVisualNode.Nodes.Add(oVisualChildNode);

                recurseCreateVisualNode(oVisualChildNode, oChild);
            }
        }
        //-------------------------------------------------------------------------------------------------------------------\\
        public void SortLeafListByFileSize()
        {
            fileSizes.Clear();
            foreach(CFileEntry oItem in leafList)
            {
                fileSizes.Add(oItem.FileSize);
            }
            fileSizes.Sort();
            leafList.Clear();
        }
        //-------------------------------------------------------------------------------------------------------------------\\
    }
}

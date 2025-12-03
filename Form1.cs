using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTP1;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.WebRequestMethods;
namespace FTP_Client
{
    public partial class Form1 : Form
    {
        /*string path = @"D:\";*/

        List<string> files = new List<string>()
        {
            {@"D:\C#" },
            {@"D:\lamquenvoiFTP" },
            {@"D:\laptrinhpython" },
            {@"D:\levinh1" }
        };
        FtpClient1 ftpClient = new FtpClient1();
        public Form1(string host, string user, string pass)
        {
            InitializeComponent();
            // Xóa các node cũ trong treeView1 (nếu có)
            treeView1.Nodes.Clear();
            ftpClient.Address = IPAddress.Parse(host);
            ftpClient.User = user;
            ftpClient.Password = pass;
            ftpClient.Connect();
            ftpClient.Login();
            /*treeView2.Nodes.Clear();*/
            foreach (string directoryPath in files)
            {
                TreeNode nodeToAdd;

                if (Directory.Exists(directoryPath))
                {
                    TreeNode root = new TreeNode();
                    root.Text = directoryPath;
                    load_explorer(root); // Gọi phương thức để tải nội dung của thư mục vào root
                    nodeToAdd = root;
                }
                else
                {
                    nodeToAdd = new TreeNode("Directory not found: " + directoryPath);
                }
                treeView1.Nodes.Add(nodeToAdd);

            }
            foreach (string directoryPath in files)
            {
                TreeNode nodeToAdd;

                if (Directory.Exists(directoryPath))
                {
                    TreeNode root = new TreeNode();
                    root.Text = directoryPath;
                    load_explorer(root); // Gọi phương thức để tải nội dung của thư mục vào root
                    nodeToAdd = root;
                }
                else
                {
                    nodeToAdd = new TreeNode("Directory not found: " + directoryPath);
                }
                treeView2.Nodes.Add(nodeToAdd);

            }
        }
        void load_explorer(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            try
            {
                var directoryInfo = new DirectoryInfo(root.Text);
                var folder_list = directoryInfo.GetDirectories();
                foreach (var folder in folder_list)
                {
                    if (Directory.Exists(folder.FullName))
                    {
                        TreeNode node = new TreeNode();
                        node.Text = folder.FullName;
                        root.Nodes.Add(node);
                        load_explorer(node);
                    }
                }

                // Get files
                var file_list = directoryInfo.GetFiles();
                foreach (var file in file_list)
                {
                    TreeNode node = new TreeNode();
                    node.Text = file.FullName;
                    root.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {

                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        string path = "";
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ftpClient.ChangeToParentDirectory();
                treeView1.SelectedNode = null;
                historyStack.Pop();
                TreeNode previousNode = historyStack.Peek();
                load_explorer(previousNode);
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(previousNode);
                textBox2.Text = previousNode.FullPath;
            }
            catch
            {
                treeView1.Nodes.Clear();

                foreach (string directoryPath in files)
                {
                    TreeNode nodeToAdd = new TreeNode();

                    if (Directory.Exists(directoryPath))
                    {
                        TreeNode root = new TreeNode();
                        root.Text = directoryPath;
                        load_explorer(root); // Gọi phương thức để tải nội dung của thư mục vào root
                        nodeToAdd = root;
                    }
                    treeView1.Nodes.Add(nodeToAdd);
                    textBox2.Text = "";
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {

        }
        string folderName = "";
        private bool isUserClicked = false;
        Stack<TreeNode> historyStack = new Stack<TreeNode>();
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Hiển thị ContextMenuStrip tại vị trí chuột
                contextMenuStrip1.Show(this, e.Location);
            }

        }


        private void contextMenuStrip3_Click(object sender, EventArgs e)
        {


        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            TreeNode newNode;

            if (selectedNode != null)
            {
                // Nếu có node được chọn, thêm node mới vào node con của node được chọn
                newNode = selectedNode.Nodes.Add("New Folder");
                selectedNode.Expand(); // Mở rộng node cha để hiển thị node con mới
            }
            else
            {
                // Nếu không có node nào được chọn, thêm node mới vào root
                newNode = treeView1.Nodes.Add("New Folder");
            }

            treeView1.LabelEdit = true; // Cho phép người dùng đổi tên node mới
            newNode.BeginEdit();
            selectedContextMenuAction = "NEW";
        }
        private string selectedContextMenuAction = "";
        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (selectedContextMenuAction == "NEW")
            {
                if (e.Label != null && e.Label.Trim().Length > 0)
                {
                    // Gọi CreateDirectory với tên mới của thư mục
                    ftpClient.CreateDirectory(e.Label);
                    MessageBox.Show("Tạo folder thành công!!");

                }
            }
            else if (selectedContextMenuAction == "RENAME")
            {

                if (e.Label != null)
                {
                    string currentName = e.Node.Text;
                    string path = Path.GetFileName(currentName);
                    textBox1.Text = path;
                    string newName = e.Label;
                    textBox2.Text = newName;

                    try
                    {
                        ftpClient.RenameFolder(path, newName);
                        e.Node.Text = newName;
                        MessageBox.Show("Đổi tên thành công!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to rename folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.CancelEdit = true; // Hủy việc đổi tên nếu có lỗi xảy ra
                    }
                }

                // Sau khi hoàn thành chỉnh sửa, thiết lập LabelEdit của TreeView về false
                treeView1.LabelEdit = false;
            }


        }

        private void rENAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;

            // Kiểm tra nếu có node được chọn và node không đang chỉnh sửa
            if (selectedNode != null && !selectedNode.IsEditing)
            {
                // Thiết lập LabelEdit của TreeView thành true
                treeView1.LabelEdit = true;

                // Bắt đầu chỉnh sửa tên của node
                selectedNode.BeginEdit();
            }
            selectedContextMenuAction = "RENAME";
        }



        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode selectedNode = treeView1.SelectedNode;
                string currentName = selectedNode.Text;
                string path = Path.GetFileName(currentName);

                if (path.Contains("."))
                {

                    ftpClient.RemoveFile(path);
                    /* MessageBox.Show($"Đã xóa tệp tin '{path}' thành công.");
                     // Xóa node khỏi TreeView
                     treeView1.Nodes.Remove(selectedNode);*/
                    treeView1.Nodes.Remove(selectedNode);
                    MessageBox.Show("Xóa file thành công!");
                }
                else
                {

                    ftpClient.RemoveFolder(path);
                    treeView1.Nodes.Remove(selectedNode);
                    MessageBox.Show("Xóa folder thành công!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!");
            }
        }

        private void uPLOADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode selectedNode = treeView1.SelectedNode;
                if (selectedNode == null)
                {
                    MessageBox.Show("Vui lòng chọn một thư mục trước khi tải lên.");
                    return;
                }
                string currentName = selectedNode.Text;
                string fileName = Path.GetFileName(currentName);

                object selectedItem = listBox1.SelectedItem;
                string file_format = Path.GetFileName(selectedItem.ToString());
                if (selectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn một tệp để tải lên.");
                    return;
                }

                /*textBox1.Text = file_format;*/
                textBox1.Text = file_format;

                ftpClient.Upload(file_format, fileName);

                MessageBox.Show("Tải lên thành công!");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi trong quá trình tải lên: {ex.Message}");
            }

        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {

        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode != null) // Kiểm tra xem có node được chọn hay không
            {
                string path = treeView1.SelectedNode.Text;
                string folderName = Path.GetFileName(path);


                TreeNode nodeToAdd = new TreeNode();
                ftpClient.ChangeDirectory(folderName);
                textBox2.Text = path;

                TreeNode root = new TreeNode();
                root.Text = path;
                load_explorer(root); // Gọi phương thức để tải nội dung của thư mục vào root

                nodeToAdd = root;
                historyStack.Push(root);

                foreach (TreeNode node in historyStack)
                {
                    textBox1.Text = node.Text; // In ra Text của node
                }

                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(nodeToAdd);

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dOWNLOADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode parentNode = treeView1.SelectedNode;
                string currentName = parentNode.Text;
                string fileName = Path.GetFileName(currentName);
                textBox1.Text = fileName;
                ftpClient.Download(fileName);
                MessageBox.Show("Tải xuống thành công!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void treeView2_DoubleClick(object sender, EventArgs e)
        {
            TreeNode parentNode = treeView2.SelectedNode; // Chọn nút cha, ví dụ: nút đã được chọn
            listBox1.Items.Clear();
            if (parentNode != null)
            {
                foreach (TreeNode childNode in parentNode.Nodes)
                {
                    // Thực hiện các thao tác bạn cần với childNode
                    string nodeName = childNode.Text;
                    // Ví dụ: hiển thị tên của mỗi nút con
                    listBox1.Items.Add(nodeName);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView2_Click(object sender, EventArgs e)
        {

        }

        private void sHOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftpClient.List();
            textBox1.Lines = ftpClient.fileList.ToArray();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
                    }
    }
}

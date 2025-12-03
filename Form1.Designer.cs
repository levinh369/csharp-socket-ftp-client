namespace FTP_Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeView1 = new TreeView();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            uPLOADToolStripMenuItem = new ToolStripMenuItem();
            dOWNLOADToolStripMenuItem = new ToolStripMenuItem();
            nEWToolStripMenuItem = new ToolStripMenuItem();
            dELETEToolStripMenuItem = new ToolStripMenuItem();
            rENAMEToolStripMenuItem = new ToolStripMenuItem();
            sHOWToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            treeView2 = new TreeView();
            listBox1 = new ListBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.AllowDrop = true;
            treeView1.Location = new Point(404, 55);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(352, 359);
            treeView1.TabIndex = 0;
            treeView1.AfterLabelEdit += treeView1_AfterLabelEdit;
            treeView1.ItemDrag += treeView1_ItemDrag;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            treeView1.DragDrop += treeView1_DragDrop;
            treeView1.DragEnter += treeView1_DragEnter;
            treeView1.DoubleClick += treeView1_DoubleClick;
            treeView1.MouseClick += treeView1_MouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(1, 10);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(799, 92);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(306, 201);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(474, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { uPLOADToolStripMenuItem, dOWNLOADToolStripMenuItem, nEWToolStripMenuItem, dELETEToolStripMenuItem, rENAMEToolStripMenuItem, sHOWToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(164, 148);
            // 
            // uPLOADToolStripMenuItem
            // 
            uPLOADToolStripMenuItem.Name = "uPLOADToolStripMenuItem";
            uPLOADToolStripMenuItem.Size = new Size(163, 24);
            uPLOADToolStripMenuItem.Text = "UPLOAD";
            uPLOADToolStripMenuItem.Click += uPLOADToolStripMenuItem_Click;
            // 
            // dOWNLOADToolStripMenuItem
            // 
            dOWNLOADToolStripMenuItem.Name = "dOWNLOADToolStripMenuItem";
            dOWNLOADToolStripMenuItem.Size = new Size(163, 24);
            dOWNLOADToolStripMenuItem.Text = "DOWNLOAD";
            dOWNLOADToolStripMenuItem.Click += dOWNLOADToolStripMenuItem_Click;
            // 
            // nEWToolStripMenuItem
            // 
            nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            nEWToolStripMenuItem.Size = new Size(163, 24);
            nEWToolStripMenuItem.Text = "NEW";
            nEWToolStripMenuItem.Click += nEWToolStripMenuItem_Click;
            // 
            // dELETEToolStripMenuItem
            // 
            dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            dELETEToolStripMenuItem.Size = new Size(163, 24);
            dELETEToolStripMenuItem.Text = "DELETE";
            dELETEToolStripMenuItem.Click += dELETEToolStripMenuItem_Click;
            // 
            // rENAMEToolStripMenuItem
            // 
            rENAMEToolStripMenuItem.Name = "rENAMEToolStripMenuItem";
            rENAMEToolStripMenuItem.Size = new Size(163, 24);
            rENAMEToolStripMenuItem.Text = "RENAME";
            rENAMEToolStripMenuItem.Click += rENAMEToolStripMenuItem_Click;
            // 
            // sHOWToolStripMenuItem
            // 
            sHOWToolStripMenuItem.Name = "sHOWToolStripMenuItem";
            sHOWToolStripMenuItem.Size = new Size(163, 24);
            sHOWToolStripMenuItem.Text = "SHOW";
            sHOWToolStripMenuItem.Click += sHOWToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(791, 55);
            label1.Name = "label1";
            label1.Size = new Size(314, 28);
            label1.TabIndex = 7;
            label1.Text = "Danh sách các tệp tin trên máy chủ";
            label1.Click += label1_Click;
            // 
            // treeView2
            // 
            treeView2.AllowDrop = true;
            treeView2.Location = new Point(1, 55);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(267, 185);
            treeView2.TabIndex = 10;
            treeView2.AfterSelect += treeView2_AfterSelect;
            treeView2.Click += treeView2_Click;
            treeView2.DoubleClick += treeView2_DoubleClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(1, 271);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(356, 224);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 625);
            Controls.Add(listBox1);
            Controls.Add(treeView2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem uPLOADToolStripMenuItem;
        private ToolStripMenuItem dOWNLOADToolStripMenuItem;
        private ToolStripMenuItem nEWToolStripMenuItem;
        private ToolStripMenuItem dELETEToolStripMenuItem;
        private ToolStripMenuItem rENAMEToolStripMenuItem;
        private ToolStripMenuItem sHOWToolStripMenuItem;
        private Label label1;
        private TreeView treeView2;
        private ListBox listBox1;
    }
}
namespace FTP_Client
{
    partial class frm_dangnhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_host = new TextBox();
            txt_port = new TextBox();
            txt_pass = new TextBox();
            txt_usename = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 96);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 145);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 200);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 252);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 3;
            label4.Text = "Port";
            // 
            // txt_host
            // 
            txt_host.Location = new Point(229, 93);
            txt_host.Name = "txt_host";
            txt_host.Size = new Size(185, 27);
            txt_host.TabIndex = 4;
            // 
            // txt_port
            // 
            txt_port.Location = new Point(229, 249);
            txt_port.Name = "txt_port";
            txt_port.Size = new Size(185, 27);
            txt_port.TabIndex = 5;
            txt_port.Text = "21";
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(229, 197);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(185, 27);
            txt_pass.TabIndex = 6;
            txt_pass.TextChanged += textBox3_TextChanged;
            // 
            // txt_usename
            // 
            txt_usename.Location = new Point(229, 145);
            txt_usename.Name = "txt_usename";
            txt_usename.Size = new Size(185, 27);
            txt_usename.TabIndex = 7;
            txt_usename.TextChanged += txt_usename_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(432, 310);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 8;
            button1.Text = "ĐĂNG NHẬP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(636, 24);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frm_dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_usename);
            Controls.Add(txt_pass);
            Controls.Add(txt_port);
            Controls.Add(txt_host);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_dangnhap";
            Text = "frm_dangnhap";
            Load += frm_dangnhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_host;
        private TextBox txt_port;
        private TextBox txt_pass;
        private TextBox txt_usename;
        private Button button1;
        private Button button2;
    }
}
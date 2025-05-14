namespace Cutdown
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            label1 = new Label();
            Day = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Hour = new Label();
            Minute = new Label();
            Second = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            RefreshToolStripMenuItem = new ToolStripMenuItem();
            OpenFolderToolStripMenuItem = new ToolStripMenuItem();
            CloseStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("等线", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "倒计时：";
            // 
            // Day
            // 
            Day.AutoSize = true;
            Day.BackColor = SystemColors.Desktop;
            Day.Font = new Font("Microsoft YaHei UI", 13F);
            Day.ForeColor = SystemColors.ButtonFace;
            Day.Location = new Point(188, 24);
            Day.Name = "Day";
            Day.Size = new Size(26, 30);
            Day.TabIndex = 1;
            Day.Text = "0";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("等线", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(236, 29);
            label2.Name = "label2";
            label2.Size = new Size(36, 25);
            label2.TabIndex = 2;
            label2.Text = "天";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("等线", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(315, 29);
            label3.Name = "label3";
            label3.Size = new Size(36, 25);
            label3.TabIndex = 3;
            label3.Text = "时";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("等线", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(392, 29);
            label4.Name = "label4";
            label4.Size = new Size(36, 25);
            label4.TabIndex = 4;
            label4.Text = "分";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("等线", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(474, 29);
            label5.Name = "label5";
            label5.Size = new Size(36, 25);
            label5.TabIndex = 5;
            label5.Text = "秒";
            // 
            // Hour
            // 
            Hour.AutoSize = true;
            Hour.BackColor = SystemColors.Desktop;
            Hour.Font = new Font("Microsoft YaHei UI", 13F);
            Hour.ForeColor = SystemColors.ButtonFace;
            Hour.Location = new Point(278, 24);
            Hour.Name = "Hour";
            Hour.Size = new Size(26, 30);
            Hour.TabIndex = 6;
            Hour.Text = "0";
            // 
            // Minute
            // 
            Minute.AutoSize = true;
            Minute.BackColor = SystemColors.Desktop;
            Minute.Font = new Font("Microsoft YaHei UI", 13F);
            Minute.ForeColor = SystemColors.ButtonFace;
            Minute.Location = new Point(357, 24);
            Minute.Name = "Minute";
            Minute.Size = new Size(26, 30);
            Minute.TabIndex = 7;
            Minute.Text = "0";
            // 
            // Second
            // 
            Second.AutoSize = true;
            Second.BackColor = SystemColors.Desktop;
            Second.Font = new Font("Microsoft YaHei UI", 13F);
            Second.ForeColor = SystemColors.ButtonFace;
            Second.Location = new Point(434, 24);
            Second.Name = "Second";
            Second.Size = new Size(26, 30);
            Second.TabIndex = 8;
            Second.Text = "0";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { RefreshToolStripMenuItem, OpenFolderToolStripMenuItem, CloseStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(154, 76);
            // 
            // RefreshToolStripMenuItem
            // 
            RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            RefreshToolStripMenuItem.Size = new Size(153, 24);
            RefreshToolStripMenuItem.Text = "刷新";
            RefreshToolStripMenuItem.Click += RefreshToolStripMenuItem_Click;
            // 
            // OpenFolderToolStripMenuItem
            // 
            OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem";
            OpenFolderToolStripMenuItem.Size = new Size(153, 24);
            OpenFolderToolStripMenuItem.Text = "打开文件夹";
            OpenFolderToolStripMenuItem.Click += OpenFolderToolStripMenuItem_Click;
            // 
            // CloseStripMenuItem1
            // 
            CloseStripMenuItem1.Name = "CloseStripMenuItem1";
            CloseStripMenuItem1.Size = new Size(153, 24);
            CloseStripMenuItem1.Text = "关闭窗口";
            CloseStripMenuItem1.Click += CloseStripMenuItem1_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(518, 80);
            Controls.Add(Second);
            Controls.Add(Minute);
            Controls.Add(Hour);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Day);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainView";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.Manual;
            Text = "MainView";
            Load += MainView_Load;
            MouseDown += Form_MouseDown;
            MouseMove += Form_MouseMove;
            MouseUp += Form_MouseUp;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Day;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Hour;
        private Label Minute;
        private Label Second;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem RefreshToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem;
        private ToolStripMenuItem OpenFolderToolStripMenuItem;
        private ToolStripMenuItem CloseStripMenuItem1;
    }
}

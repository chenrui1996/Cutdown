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
            settingToolStripMenuItem = new ToolStripMenuItem();
            RefreshToolStripMenuItem = new ToolStripMenuItem();
            CloseStripMenuItem1 = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            contextMenuStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("等线", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 0;
            label1.Text = "倒计时：";
            // 
            // Day
            // 
            Day.AutoSize = true;
            Day.BackColor = SystemColors.Desktop;
            Day.Font = new Font("Microsoft YaHei UI", 12F);
            Day.ForeColor = SystemColors.ButtonFace;
            Day.Location = new Point(117, 0);
            Day.Name = "Day";
            Day.Size = new Size(24, 27);
            Day.TabIndex = 1;
            Day.Text = "0";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("等线", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(147, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 27);
            label2.TabIndex = 2;
            label2.Text = "天";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("等线", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(219, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 27);
            label3.TabIndex = 3;
            label3.Text = "时";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("等线", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(291, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 27);
            label4.TabIndex = 4;
            label4.Text = "分";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("等线", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(363, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 27);
            label5.TabIndex = 5;
            label5.Text = "秒";
            // 
            // Hour
            // 
            Hour.AutoSize = true;
            Hour.BackColor = SystemColors.Desktop;
            Hour.Font = new Font("Microsoft YaHei UI", 12F);
            Hour.ForeColor = SystemColors.ButtonFace;
            Hour.Location = new Point(189, 0);
            Hour.Name = "Hour";
            Hour.Size = new Size(24, 27);
            Hour.TabIndex = 6;
            Hour.Text = "0";
            // 
            // Minute
            // 
            Minute.AutoSize = true;
            Minute.BackColor = SystemColors.Desktop;
            Minute.Font = new Font("Microsoft YaHei UI", 12F);
            Minute.ForeColor = SystemColors.ButtonFace;
            Minute.Location = new Point(261, 0);
            Minute.Name = "Minute";
            Minute.Size = new Size(24, 27);
            Minute.TabIndex = 7;
            Minute.Text = "0";
            // 
            // Second
            // 
            Second.AutoSize = true;
            Second.BackColor = SystemColors.Desktop;
            Second.Font = new Font("Microsoft YaHei UI", 12F);
            Second.ForeColor = SystemColors.ButtonFace;
            Second.Location = new Point(333, 0);
            Second.Name = "Second";
            Second.Size = new Size(24, 27);
            Second.TabIndex = 8;
            Second.Text = "0";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem, RefreshToolStripMenuItem, CloseStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(139, 76);
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(138, 24);
            settingToolStripMenuItem.Text = "设置";
            settingToolStripMenuItem.Click += settingToolStripMenuItem_Click;
            // 
            // RefreshToolStripMenuItem
            // 
            RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            RefreshToolStripMenuItem.Size = new Size(138, 24);
            RefreshToolStripMenuItem.Text = "刷新";
            RefreshToolStripMenuItem.Click += RefreshToolStripMenuItem_Click;
            // 
            // CloseStripMenuItem1
            // 
            CloseStripMenuItem1.Name = "CloseStripMenuItem1";
            CloseStripMenuItem1.Size = new Size(138, 24);
            CloseStripMenuItem1.Text = "关闭窗口";
            CloseStripMenuItem1.Click += CloseStripMenuItem1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(Day);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(Hour);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(Minute);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(Second);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Location = new Point(15, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(402, 27);
            flowLayoutPanel1.TabIndex = 9;
            flowLayoutPanel1.WrapContents = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(433, 63);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainView";
            Opacity = 0.8D;
            Padding = new Padding(10, 15, 10, 15);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "MainView";
            Load += MainView_Load;
            MouseDown += Form_MouseDown;
            MouseMove += Form_MouseMove;
            MouseUp += Form_MouseUp;
            contextMenuStrip1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
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
        private ToolStripMenuItem CloseStripMenuItem1;
        private ToolStripMenuItem settingToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

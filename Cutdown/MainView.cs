using System.Runtime.InteropServices;

namespace Cutdown
{
    public partial class MainView : Form
    {
        private System.Timers.Timer? timer;
        private DateTime endTime;

        private Point mouseOffset;
        private bool isMouseDown = false;
        public MainView()
        {
            InitializeComponent();
            SetupForm();
            StartTimer();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            Day.Text = "0";
            Hour.Text = "0";
            Minute.Text = "0";
            Second.Text = "0";
        }

        private int layoutMode;

        private void SetupForm()
        {
            int screenWidth = Screen.PrimaryScreen?.WorkingArea.Width ?? 1200;
            int formWidth = this.Width;
            int x = (screenWidth - formWidth) / 2;
            int y = 0;
            this.Location = new Point(x, y);
            layoutMode = 0;

            this.ShowInTaskbar = false;
            this.TopMost = true;
        }

        private void StartTimer()
        {
            var setting = FileHelper.GetSetting();
            endTime = setting.targetDate;
            var description = setting.description;
            label1.Text = description;
            if (timer != null)
            {
                timer.Stop();
                timer.Start();
                return;
            }
            timer = new System.Timers.Timer
            {
                Interval = 1000 // 每秒
            };
            timer.Elapsed += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (endTime <= DateTime.Now)
            {
                return;
            }
            TimeSpan elapsed = endTime - DateTime.Now;
            this.Invoke(() =>
            {
                ForceTopMost(this);
                Day.Text = elapsed.Days.ToString();
                Hour.Text = elapsed.Hours.ToString();
                Minute.Text = elapsed.Minutes.ToString();
                Second.Text = elapsed.Seconds.ToString();
            });
        }

        // 拖动窗口
        private void Form_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void Form_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
                if (Location.Y != 0)
                {
                    layoutMode = 2;
                }
            }
        }

        private void Form_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseDown = false;

            if (e.Button == MouseButtons.Right)
                // 显示菜单
                contextMenuStrip1?.Show(this, e.Location);
        }

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter,
        int X, int Y, int cx, int cy, uint uFlags);

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 SWP_NOACTIVATE = 0x0010;

        public void ForceTopMost(Form form)
        {
            if (onSettingFlag)
            {
                return;
            }
            SetWindowPos(form.Handle, HWND_TOPMOST, 0, 0, 0, 0,
                SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);
        }

        private const int WM_NCLBUTTONDBLCLK = 0x00A3;
        private const int WM_LBUTTONDBLCLK = 0x0203;

        protected override void WndProc(ref Message m)
        {
            // 将非客户区双击转换为客户区双击
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                m.Msg = WM_LBUTTONDBLCLK;
            }

            base.WndProc(ref m);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen?.WorkingArea.Width ?? 1200;
            int formWidth = this.Width;
            if (layoutMode == 0)
            {
                int x = screenWidth - formWidth;
                this.Location = new Point(x, 0);
                layoutMode = 1;
            }
            else
            {
                int x = (screenWidth - formWidth) / 2;
                this.Location = new Point(x, 0);
                layoutMode = 0;
            }
            base.OnDoubleClick(e);
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHelper.OpenApplationFolder();
        }

        private void CloseStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool onSettingFlag = false;

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onSettingFlag = true;
            var result = new SettingView().ShowDialog();
            if (result == DialogResult.OK)
            {
                StartTimer();
            }
            onSettingFlag = false;
        }
    }
}

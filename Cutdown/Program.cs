using System.Threading;

namespace Cutdown
{
    internal static class Program
    {
        private static Mutex mutex = null;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            const string appName = "Cutdown"; // 改为你的应用唯一名称

            bool createdNew;
            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                // 应用已经在运行
                MessageBox.Show("应用程序已经在运行中!", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainView());
        }
    }
}
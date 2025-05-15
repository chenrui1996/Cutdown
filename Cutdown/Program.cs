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
            const string appName = "Cutdown"; // ��Ϊ���Ӧ��Ψһ����

            bool createdNew;
            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                // Ӧ���Ѿ�������
                MessageBox.Show("Ӧ�ó����Ѿ���������!", "��ʾ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainView());
        }
    }
}
//using System.Runtime.InteropServices;

//namespace inventManagementApp
//{
//    internal static class Program
//    {
//        /// <summary>
//        ///  The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            // To customize application configuration such as set high DPI settings or default font,
//            // see https://aka.ms/applicationconfiguration.
//            ApplicationConfiguration.Initialize();

//            // **DPI スケーリングを無効化**
//            if (Environment.OSVersion.Version.Major >= 6)
//            {
//                SetProcessDPIAware();
//            }

//            Application.Run(new Form1());
//        }
//        [DllImport("user32.dll")]
//        private static extern bool SetProcessDPIAware();


//    }
//}

using System;

namespace ICOM_V2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            MainWindow view = new MainWindow();
            view.DataContext = new MainViewModel();
            new App().Run(view);
        }
    }
}

namespace QL_TTANHNGU
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
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new F_HocVien());
            //Application.Run(new F_HoaDon());
            Application.Run(new F_ChiTietDK_LH());
        }
    }
}
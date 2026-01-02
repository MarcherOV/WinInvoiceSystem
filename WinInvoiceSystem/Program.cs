using PdfSharp.Fonts;

namespace WinInvoiceSystem
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
            PdfSharp.Fonts.GlobalFontSettings.FontResolver = new FileFontResolver();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
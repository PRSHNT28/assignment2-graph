namespace bar
{
    internal static class Program
    {
        /// <summary>
        ///  Main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize application settings like high DPI mode or default font.
            // For more details, visit https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

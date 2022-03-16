namespace RatCategorizationForm
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
            Model m = new Model();
            Controller c = new Controller(m);
            RatDisplay d = new RatDisplay(c);
            c.InitializeView(d);
            Application.Run(d);

        }
    }
}
namespace ExamForm1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Form1 f1 = new Form1();
            f1.Show();
            Application.Run();
        }
    }
}
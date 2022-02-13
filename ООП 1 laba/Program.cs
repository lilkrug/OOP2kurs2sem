namespace ООП_1_laba
{
    internal static class Calculator
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            catch (Exception)
            {

                throw new Exception("Program krash");
            }
           
        }

    }

}


using NetEssencial.Delegates;
using NetEssencial.NullableTypes1;

namespace NetEssencial
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
            Application.Run(new ProgramacaoAssincrona.frmAsync());
        }
    }
}
using System;
using System.Windows.Forms;
namespace Conversor
{
    internal static class Program
    {
        public static object AppDb { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            AppDb.Init();
            Application.Run(new LoginForm());
        }
    }
}
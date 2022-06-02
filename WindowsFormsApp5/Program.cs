using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    internal static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LWP04Main());
        }
     

    }
    public delegate string NewDelegate1(); // Создаём делегата № 1
    public static class NewDelegate2Out
    {
        public static NewEventOut EventHandler;
        public delegate void NewEventOut(String Data);
    }
    public delegate  string NewDelegate2In();
}

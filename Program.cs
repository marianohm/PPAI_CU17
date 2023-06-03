using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_CU17_GrupoYaNoNosFaltan2;

using PPAI_CU17_GrupoYaNoNosFaltan2.NewFolder1;

namespace PPAI_CU17_GrupoYaNoNosFaltan2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InterfazIVR());
        }
    }
}

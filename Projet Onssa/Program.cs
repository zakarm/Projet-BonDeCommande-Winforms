using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using Bunifu.Framework.UI;
using Bunifu.Framework.Lib;
using Bunifu.Framework;

namespace Projet_Onssa
{
    static class Program
    {
        //public static string typeCompte;
        public static GestionCompte OG ;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LectureOp());
        }
        
    }
}

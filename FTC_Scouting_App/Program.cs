using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTC_Scouting_App
{
    static class Program
    {
        public static List<Competition> compList = new List<Competition>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            String MyDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String SaveFileFolder = Path.Combine(MyDocumentsFolder, "FTC_Scorecard");
            string curFile = @"c:\temp\test.txt";
            String fileSave = Path.Combine(SaveFileFolder, "saveFile");
            if (Directory.Exists(fileSave))
            {
                
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());

            
        }
    }
}

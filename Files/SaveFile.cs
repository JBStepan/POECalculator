using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using POECalculator2;
using IniFileParser;
using System.Windows.Forms;

namespace POECalculator2.Files
{
    class SaveFile
    {        
        /// <summary>
        /// Save contents to a file
        /// </summary>
        public static void Save(string Contents)
        {
            var ini = new IniFile("Settings.ini");

            string saveFile = ini.Read("SaveFile", "General");

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(saveFile, true))
            {
                file.WriteLine(Contents);
            }
        }

        /// <summary>
        /// Creates the save file
        /// </summary>
        public static void CreateSaveFile()
        {        
            var ini = new IniFile("Settings.ini");

            string SaveFile = ini.Read("SaveFile", "General");

            string[] line = { "StartFile \n" };

            System.IO.File.WriteAllLines(SaveFile, line);
            Logger.Logger.WriteLog("Created save file!");
        }

        public static void ClearSaveFile()
        {
            var ini = new IniFile("Settings.ini");

            string SaveFile = ini.Read("SaveFile", "General");

            string[] line = { "StartFile \n" };

            System.IO.File.WriteAllText(SaveFile, string.Empty);

            System.IO.File.WriteAllLines(SaveFile, line);

            Logger.Logger.WriteLog("Cleared save file");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POECalculator2;
using IniFileParser;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace POECalculator2.Logger
{
    class Logger
    {
        public static void WriteLog(string message)
        {
            var settings = new IniFile("Settings.ini");

            string logFile = settings.Read("LogFile", "Logging");
            string enabled = settings.Read("EnableLogFile", "Logging");

            DateTime time = DateTime.Now;
            string format = "M/d h:mm yyyy";

            string text = time.ToString(format) + ": " + message + "\n";
            if (enabled == "true")
            {
                if (logFile != "" || logFile != "None")
                {
                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(logFile, true))
                    {
                        file.WriteLine(text);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a logfile path", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }
    }
}

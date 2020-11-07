using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniFileParser;
using System.IO;
using POECalculator2.Files;
using Log = POECalculator2.Logger.Logger;
using System.Reflection;

namespace POECalculator2
{
    public partial class MainMenu : Form
    {
        public string saveFile;
        public string startUpWindow;
        public string logFile;
        public string logFileMaxSize;

        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Runs on app startup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            var settings = new IniFile("Settings.ini");

            saveFile = settings.Read("SaveFile", "General");
            startUpWindow = settings.Read("OnStartup", "General");
            logFile = settings.Read("LogFile", "Logging");
            logFileMaxSize = settings.Read("MaxiumFileSize", "Logging");
            string enabled = settings.Read("EnableLogFile", "Logging");

            Log.WriteLog("===============Start New Log===============");

            if(enabled=="false")
            {
                MessageBox.Show("Log File Disabled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if(startUpWindow == "None")
            {
                Log.WriteLog("Starting up with defualt window");
            }  
            else if(startUpWindow == "Levers")
            {
                Levers levers = new Levers();
                levers.Show();
                Log.WriteLog("Starting with Levers window");
            }
            else if(startUpWindow == "Wheels")
            {
                Wheels wheels = new Wheels();
                wheels.Show();
                Log.WriteLog("Opening Wheels");
            }
            else
            {
                MessageBox.Show("Unable to open window, unknown window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.WriteLog("Unable to open window, unknown window. Window specified" + startUpWindow);
            }
        }

        /// <summary>
        /// Runs on app close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            long fileLength = new System.IO.FileInfo(logFile).Length;

            long maxLength = Int64.Parse(logFileMaxSize);

            if (fileLength > maxLength)
            {
                File.Delete(logFile);
            }
            else
            {
                Log.WriteLog("Your log File size is: " + fileLength.ToString() + " BYTES!");
            }

            Log.WriteLog("===============End Log===============\n");
        }

        private void createSaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile.CreateSaveFile();
        }

        private void clearSaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile.ClearSaveFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wheels wheels = new Wheels();
            wheels.Show();
            Log.WriteLog("Opening Wheels");
        }
    }
}

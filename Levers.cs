using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniFileParser;
using System.IO;
using POECalculator2.Logger;

namespace POECalculator2
{
    public partial class Levers : Form
    {
        public Levers()
        {
            InitializeComponent();
        }

        IniFile ini = new IniFile("Settings.ini");
        string saveFile;
        string saveEnabled;

        private void Levers_Load(object sender, EventArgs e)
        {
            saveFile = ini.Read("SaveFile", "General");
            saveEnabled = ini.Read("EnableLogFile", "Logging");
            Logger.Logger.WriteLog("Levers page, opened");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float fr = float.Parse(textBox1.Text);
            float dr = float.Parse(textBox2.Text);
            float de = float.Parse(textBox3.Text);

            float fe = float.Parse(textBox4.Text);
            float ima = float.Parse(textBox5.Text);
            float ama = float.Parse(textBox6.Text);
            float eff = float.Parse(textBox7.Text);


        }
    }
}

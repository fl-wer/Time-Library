using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Library
{
    public partial class ShowLibrary : Form
    {
        // initializing component, ignore
        public ShowLibrary() { InitializeComponent(); }

        // runs on form load
        private void ShowLibrary_Load(object sender, EventArgs e)
        {
            // get list of active process
            string[] activeProcesses = Directory.GetDirectories(Main._dataProcessActiveDir);

            // go through each active process, calculate time 
            foreach (string process in activeProcesses)
            {
                // display process name in left column
                processNameTextBox.Text += Path.GetFileName(process) + Environment.NewLine;

                // get raw time of process in milliseconds
                long rawTime = calculateProcessTime(process);

                // format raw time
                long hours = rawTime / 1000 / 60 / 60;
                long minutes = (rawTime / 1000 / 60) - hours * 60;

                // display process time in right column with some formatting
                processTimeTextBox.Text += hours + "h " + minutes + "m" + Environment.NewLine;
            }
        }

        // return total milliseconds from all sessions for a process
        long calculateProcessTime(string name)
        {
            // get process sessions folder
            string processDir = Path.Combine(Main._dataProcessActiveDir, name, "sessions");

            // total process runtime in milliseconds
            long totalTime = 0;

            // get session file list
            string[] sessionFiles = Directory.GetFiles(processDir);

            // convert and add time to total time
            foreach (string fileDir in sessionFiles)
            {
                string fileTimeRaw = File.ReadAllText(fileDir);
                totalTime += long.Parse(fileTimeRaw);
            }

            // return total milliseconds from all sessions
            return totalTime;
        }
    }
}

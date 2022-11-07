using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Time_Library
{
    public partial class Main : Form
    {
        // initializing component, ignore
        public Main() { InitializeComponent(); }

        // show info & error functions
        public static void showError(string message) { MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        public static void showInfo(string message) { MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        // main program directories
        public static string _dir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public static string _dataDir = Path.Combine(_dir, "data");
        public static string _dataProcessDir = Path.Combine(_dataDir, "process");
        public static string _dataProcessActiveDir = Path.Combine(_dataProcessDir, "active");
        public static string _dataProcessInactiveDir = Path.Combine(_dataProcessDir, "inactive");

        // runs on form load
        private void Main_Load(object sender, EventArgs e)
        {
            // check if any other instance running
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                // show error and close
                showError("only single instance of the application is allowed");
                Application.Exit();
            }

            // hide program on startup
            ShowInTaskbar = false; Hide();

            // run background thread calculating time
            backgroundWorker.RunWorkerAsync();
        }

        // get duplicate processes
        public static Process[] getUniqueProcesses(bool sortByAlphabet)
        {
            // don't sort by alphabet
            if (!sortByAlphabet)
                return Process.GetProcesses().ToList().GroupBy(Process =>
                Process.ProcessName).Select(g => g.First()).ToArray();

            // sort by alphabet
            else return Process.GetProcesses().ToList().GroupBy(Process =>
            Process.ProcessName).Select(g => g.First()).OrderBy(o => o.ProcessName).ToArray();
        }

        // shows add process form
        private void addProcessButton_Click(object sender, EventArgs e)
        {
            // show add process form
            AddProcess addProcessForm = new AddProcess();
            addProcessForm.ShowDialog();
        }

        // shows remove process form
        private void removeProcessButton_Click(object sender, EventArgs e)
        {
            // show add process form
            RemoveProcess removeProcessForm = new RemoveProcess();
            removeProcessForm.ShowDialog();
        }

        // shows library form
        private void seeLibraryButton_Click(object sender, EventArgs e)
        {
            // show add process form
            ShowLibrary showLibraryForm = new ShowLibrary();
            showLibraryForm.ShowDialog();
        }

        // show main form on tray icon double click
        private void trayIcon_DoubleClick(object sender, EventArgs e)
        { ShowInTaskbar = true; Show(); WindowState = FormWindowState.Normal; }

        // show main form on Open click in tray
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        { ShowInTaskbar = true; Show(); WindowState = FormWindowState.Normal; }

        // close program once Exit clicked on tray icon
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { Application.Exit(); }

        // overloading closing form so we could make it minimize only and stay
        // available in tray instead of closing completely
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        { if (e.CloseReason == CloseReason.UserClosing) { Hide(); e.Cancel = true; } }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // infinite loop
            while (true)
            {
                // get list of active processes as directories
                string[] activeProcesses = Directory.GetDirectories(_dataProcessActiveDir);

                // convert directories to just names
                for (int i = 0; i < activeProcesses.Length; i++)
                    activeProcesses[i] = Path.GetFileName(activeProcesses[i]);

                // get running unique by name processes
                Process[] runningProcesses = getUniqueProcesses(false);

                // go through running processes
                foreach (Process process in runningProcesses)
                {
                    // check all active processes per saves
                    for (int i = 0; i < activeProcesses.Length; i++)
                    {
                        // if saved process name matches
                        if (activeProcesses[i] == process.ProcessName)
                        {
                            // calculate difference for session
                            DateTimeOffset startTime = process.StartTime;
                            long miliDifference = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - startTime.ToUnixTimeMilliseconds();

                            // location for session file that holds milliseconds
                            string sessionFileLocation = Path.Combine(_dataProcessActiveDir, activeProcesses[i], "sessions",
                                startTime.ToUnixTimeMilliseconds().ToString());

                            // write milliseconds for session
                            File.WriteAllText(sessionFileLocation, miliDifference.ToString());

                            // break
                            break;
                        }
                    }
                }

                // sleep for 1 minute
                Thread.Sleep(60000);
            }
        }
    }
}

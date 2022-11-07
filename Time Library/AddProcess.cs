using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Time_Library
{
    public partial class AddProcess : Form
    {
        // initializing component, ignore
        public AddProcess() { InitializeComponent(); }

        // get raw processes
        Process[] processRaw = Process.GetProcesses();

        private void AddProcess_Load(object sender, EventArgs e)
        {
            // clear any previous loaded processes in combobox
            processListComboBox.Items.Clear();

            // add processes name to combobox list
            foreach (Process process in Main.getUniqueProcesses(true))
                processListComboBox.Items.Add(process.ProcessName);

            // select first visible process
            processListComboBox.SelectedIndex = 0;
        }

        // create new process
        private void addProcessButton_Click(object sender, EventArgs e)
        {
            // get selected process
            string selectedProcess = processListComboBox.SelectedItem.ToString();

            // get list of inactive process
            string[] inactiveProcesses = Directory.GetDirectories(Main._dataProcessInactiveDir);

            // get list of active process
            string[] activeProcesses = Directory.GetDirectories(Main._dataProcessActiveDir);

            // check if already added and active
            bool foundInactive = false;
            foreach (string process in inactiveProcesses)
                if (Path.GetFileName(process) == selectedProcess) foundInactive = true;

            // check if already added and inactive
            bool foundActive = false;
            foreach (string process in activeProcesses)
                if (Path.GetFileName(process) == selectedProcess) foundActive = true;

            // check if already added in active
            if (foundActive) Main.showError("process already added");

            // if found inactive, just cut and paste from inactive
            // if no inactive found just create new directory
            else if (foundInactive)
            {
                // cut and paste from inactive to active
                Directory.Move(Path.Combine(Main._dataProcessInactiveDir, selectedProcess),
                    Path.Combine(Main._dataProcessActiveDir, selectedProcess));
            }
            else
            {
                // our selected process folder for time library
                string selectedProcessActiveDirectory = Path.Combine(Main._dataProcessActiveDir, selectedProcess);

                // create process folder in active folder
                Directory.CreateDirectory(selectedProcessActiveDirectory);

                // create sessions folder
                Directory.CreateDirectory(Path.Combine(selectedProcessActiveDirectory, "sessions"));

                // create empty time file with default 0 minutes
                File.WriteAllText(Path.Combine(selectedProcessActiveDirectory, "time"), "0");

                // create icon from exe, has to be in try-catch
                // becuase some system processes might not be accessible
                // we will then assign default system icon
                try
                {
                    // go through each processes and find the right one
                    foreach (Process process in processRaw)
                    {
                        // if it's the process we want to add
                        if (process.ProcessName == selectedProcess)
                        {
                            // extract icon and save to a time library process folder
                            Bitmap extractedIcon = (Icon.ExtractAssociatedIcon(process.MainModule.FileName)).ToBitmap();
                            extractedIcon.Save(Path.Combine(selectedProcessActiveDirectory, "icon.png"), ImageFormat.Png);
                        }
                    }
                }
                catch
                {
                    // save default system application icon instead if above failed
                    Bitmap extractedIcon = SystemIcons.Application.ToBitmap();
                    extractedIcon.Save(Path.Combine(selectedProcessActiveDirectory, "icon.png"), ImageFormat.Png);
                }

                // close form
                Close();
            }
        }
    }
}

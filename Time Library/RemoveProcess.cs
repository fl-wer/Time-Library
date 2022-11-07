using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Time_Library
{
    public partial class RemoveProcess : Form
    {
        // initializing component, ignore
        public RemoveProcess() { InitializeComponent(); }

        // get list of active process
        string[] activeProcesses = Directory.GetDirectories(Main._dataProcessActiveDir);

        // runs on form load
        private void RemoveProcess_Load(object sender, EventArgs e)
        {
            // sort array by alphabet
            Array.Sort(activeProcesses);

            // convert directory to just process names
            for (int i = 0; i < activeProcesses.Length; i++)
                activeProcesses[i] = Path.GetFileName(activeProcesses[i]);

            // add processes name to combobox list
            foreach (string process in activeProcesses)
                processListComboBox.Items.Add(process);

            // select first visible process if there is one
            if (processListComboBox.Items.Count > 0)
            processListComboBox.SelectedIndex = 0;
        }

        // remove saved process folder
        private void removeProcessButton_Click(object sender, EventArgs e)
        {
            // make sure process is selected
            if (processListComboBox.SelectedIndex != -1)
            {
                // get selected process name
                string selectedProcess = processListComboBox.SelectedItem.ToString();

                // process active directory
                string activeProcessDirectory = Path.Combine(Main._dataProcessActiveDir, selectedProcess);

                // process inactive directory
                string inactiveProcessDirectory = Path.Combine(Main._dataProcessInactiveDir, selectedProcess);

                // cut and paste from inactive to active
                Directory.Move(activeProcessDirectory, inactiveProcessDirectory);

                // remove removed process from the list
                processListComboBox.Items.Remove(selectedProcess);

                // remove old text
                processListComboBox.Text = "";

                // select first visible process if there is one
                if (processListComboBox.Items.Count > 0)
                    processListComboBox.SelectedIndex = 0;
            }
        }
    }
}

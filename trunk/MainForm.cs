using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BLog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            try
            {
                String command = "adb devices";
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();

                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();

                // Display the command output.
                MessageBox.Show(result);
            }
            catch (Exception objException)
            {
                // Log the exception
                MessageBox.Show(objException.StackTrace);
            }

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            String str = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            MessageBox.Show(str);
        }
    }
}

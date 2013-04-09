using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace BLog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //config file name and path
        private const String configFile = "b_log.conf";
        private String configFilePath = null;

        //config info
        private String AndroidSDKPath = null;
        private String ADBPath = null;        

        private void btnGetDevices_Click(object sender, EventArgs e)
        {
            try
            {
                String command = " devices";
                ProcessStartInfo procStartInfo = new ProcessStartInfo(ADBPath, command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;                
                procStartInfo.CreateNoWindow = true;

                // Now we create a process, assign its ProcessStartInfo and start it
                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();

                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();                

                // Modify combo box
                cbListDevices.Items.Clear();

                String []listDevices = result.Split('\n');

                for (int i = 1; i < listDevices.Length; i++)
                {
                    if (listDevices[i] != "" && listDevices[i].Length > 1)
                        cbListDevices.Items.Add(listDevices[i].Split('\t')[0]);
                }

                cbListDevices.SelectedIndex = 0;
            }
            catch (Exception objException)
            {
                // Log the exception
                MessageBox.Show(objException.StackTrace);
            }

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ConfigForm wfConfigForm = new ConfigForm();
            wfConfigForm.StartPosition = FormStartPosition.CenterParent;

            wfConfigForm.AndroidSDKPath = AndroidSDKPath;

            DialogResult dlgResult = wfConfigForm.ShowDialog(this);

            if (dlgResult == DialogResult.OK)
            {   
                //set ADB path
                AndroidSDKPath = wfConfigForm.AndroidSDKPath;
                ADBPath = AndroidSDKPath + "\\platform-tools\\adb.exe";

                //override old config
                StreamWriter sw = new StreamWriter(configFilePath, false);
                sw.WriteLine(AndroidSDKPath);

                sw.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //load default config file
            configFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + configFile;

            if (File.Exists(configFilePath))    //if config file not exist, create a new one
            {
                //read config from file
                StreamReader sr = new StreamReader(configFilePath);

                AndroidSDKPath = sr.ReadLine();
                ADBPath = AndroidSDKPath + "\\platform-tools\\adb.exe";

                //check Android SDK path                
                if (!File.Exists(ADBPath))
                {
                    MessageBox.Show("Android SDK Path wrong !!");

                    //delete file
                    sr.Close();
                    File.Delete(configFilePath);
                    return;
                }

                sr.Close();
            }
        }

        private void btnGetLog_Click(object sender, EventArgs e)
        {
            if (cbListDevices.Text == "")
            {
                MessageBox.Show("Must get devices first");
                return;
            }

            Thread tid = new Thread(GetLogJob);
            tid.Start(this);
        }

        public void SetRichTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { SetRichTextBox(text); });
                return;
            }

            rtbOutput.Text += text + '\n';
            rtbOutput.Refresh();
        }

        //function to get log
        public static void GetLogJob(Object parentForm)
        {
            try
            {
                MainForm mainForm = (MainForm)parentForm;

                //" -s " + cbListDevices.SelectedText + 
                String command = " logcat";
                ProcessStartInfo procStartInfo = new ProcessStartInfo(mainForm.ADBPath, command);

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();                           

                StreamReader sr = proc.StandardOutput;

                while (!sr.EndOfStream)
                {
                    String s = sr.ReadLine();
                    if (s != "")
                    {
                        mainForm.SetRichTextBox(s);
                    }                   
                }
                
            }
            catch (Exception objException)
            {
                // Log the exception
                MessageBox.Show(objException.StackTrace);
            }
        }
    }
}

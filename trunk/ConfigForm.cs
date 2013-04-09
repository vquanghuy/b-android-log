using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLog
{
    public partial class ConfigForm : Form
    {
        public String AndroidSDKPath = null;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btnChooseSDK_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrwDlg = new FolderBrowserDialog();
            folderBrwDlg.SelectedPath = AndroidSDKPath;
            folderBrwDlg.ShowNewFolderButton = false;

            if (folderBrwDlg.ShowDialog() == DialogResult.OK)
            {
                txbSDKPath.Text = folderBrwDlg.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AndroidSDKPath = txbSDKPath.Text;
            if (System.IO.File.Exists(AndroidSDKPath + "\\platform-tools\\adb.exe"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {   
                MessageBox.Show(this, "SDK Path not correct");
            }            
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            txbSDKPath.Text = AndroidSDKPath;
        }
    }
}

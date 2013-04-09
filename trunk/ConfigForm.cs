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
        public String strADBPath = null;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btnChooseSDK_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrwDlg = new FolderBrowserDialog();
            folderBrwDlg.SelectedPath = "c:\\";
            folderBrwDlg.ShowNewFolderButton = false;

            if (folderBrwDlg.ShowDialog() == DialogResult.OK)
            {
                txbSDKPath.Text = folderBrwDlg.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            strADBPath = txbSDKPath.Text + "\\platform-tools\\adb.exe";
            if (System.IO.File.Exists(strADBPath))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {   
                MessageBox.Show(this, "SDK Path not correct");
            }            
        }
    }
}

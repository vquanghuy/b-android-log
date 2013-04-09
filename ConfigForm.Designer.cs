namespace BLog
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabConfigPath = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAndroidSDK = new System.Windows.Forms.Label();
            this.txbSDKPath = new System.Windows.Forms.TextBox();
            this.btnChooseSDK = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabConfigPath.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfigPath
            // 
            this.tabConfigPath.Controls.Add(this.tabPage1);
            this.tabConfigPath.Controls.Add(this.tabPage2);
            this.tabConfigPath.Location = new System.Drawing.Point(12, 15);
            this.tabConfigPath.Name = "tabConfigPath";
            this.tabConfigPath.SelectedIndex = 0;
            this.tabConfigPath.Size = new System.Drawing.Size(502, 317);
            this.tabConfigPath.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnChooseSDK);
            this.tabPage1.Controls.Add(this.txbSDKPath);
            this.tabPage1.Controls.Add(this.lblAndroidSDK);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config Path";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAndroidSDK
            // 
            this.lblAndroidSDK.AutoSize = true;
            this.lblAndroidSDK.Location = new System.Drawing.Point(6, 14);
            this.lblAndroidSDK.Name = "lblAndroidSDK";
            this.lblAndroidSDK.Size = new System.Drawing.Size(108, 16);
            this.lblAndroidSDK.TabIndex = 0;
            this.lblAndroidSDK.Text = "Android SDK Path";
            // 
            // txbSDKPath
            // 
            this.txbSDKPath.Location = new System.Drawing.Point(157, 11);
            this.txbSDKPath.Name = "txbSDKPath";
            this.txbSDKPath.Size = new System.Drawing.Size(234, 23);
            this.txbSDKPath.TabIndex = 1;
            // 
            // btnChooseSDK
            // 
            this.btnChooseSDK.Location = new System.Drawing.Point(406, 11);
            this.btnChooseSDK.Name = "btnChooseSDK";
            this.btnChooseSDK.Size = new System.Drawing.Size(75, 23);
            this.btnChooseSDK.TabIndex = 2;
            this.btnChooseSDK.Text = "Browser ...";
            this.btnChooseSDK.UseVisualStyleBackColor = true;
            this.btnChooseSDK.Click += new System.EventHandler(this.btnChooseSDK_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(180, 338);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(272, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(527, 373);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabConfigPath);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "Config ...";
            this.tabConfigPath.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfigPath;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnChooseSDK;
        private System.Windows.Forms.TextBox txbSDKPath;
        private System.Windows.Forms.Label lblAndroidSDK;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
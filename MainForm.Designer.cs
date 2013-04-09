namespace BLog
{
    partial class MainForm
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
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnGetLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(690, 12);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(90, 30);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "Config ...";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(202, 12);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(90, 30);
            this.btnRefesh.TabIndex = 1;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(12, 64);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(768, 497);
            this.tbxOutput.TabIndex = 2;
            // 
            // btnGetLog
            // 
            this.btnGetLog.Location = new System.Drawing.Point(434, 12);
            this.btnGetLog.Name = "btnGetLog";
            this.btnGetLog.Size = new System.Drawing.Size(90, 30);
            this.btnGetLog.TabIndex = 3;
            this.btnGetLog.Text = "Get Log";
            this.btnGetLog.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.btnGetLog);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnConfig);
            this.Name = "MainForm";
            this.Text = "BLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnGetLog;
    }
}


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
            this.btnConfig.Location = new System.Drawing.Point(659, 15);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(120, 37);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "Config ...";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(16, 15);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(120, 37);
            this.btnRefesh.TabIndex = 1;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(16, 79);
            this.tbxOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(763, 481);
            this.tbxOutput.TabIndex = 2;
            // 
            // btnGetLog
            // 
            this.btnGetLog.Location = new System.Drawing.Point(154, 15);
            this.btnGetLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetLog.Name = "btnGetLog";
            this.btnGetLog.Size = new System.Drawing.Size(120, 37);
            this.btnGetLog.TabIndex = 3;
            this.btnGetLog.Text = "Get Log";
            this.btnGetLog.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.btnGetLog);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnConfig);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "BLog";
            this.Load += new System.EventHandler(this.MainForm_Load);
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


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
            this.btnGetDevices = new System.Windows.Forms.Button();
            this.btnGetLog = new System.Windows.Forms.Button();
            this.lsbListDevices = new System.Windows.Forms.ListBox();
            this.cbAutoScroll = new System.Windows.Forms.CheckBox();
            this.ctxbMainOut = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctxbMainOut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(662, 15);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(120, 37);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "Config ...";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnGetDevices
            // 
            this.btnGetDevices.Location = new System.Drawing.Point(251, 15);
            this.btnGetDevices.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetDevices.Name = "btnGetDevices";
            this.btnGetDevices.Size = new System.Drawing.Size(120, 37);
            this.btnGetDevices.TabIndex = 1;
            this.btnGetDevices.Text = "Get Devices";
            this.btnGetDevices.UseVisualStyleBackColor = true;
            this.btnGetDevices.Click += new System.EventHandler(this.btnGetDevices_Click);
            // 
            // btnGetLog
            // 
            this.btnGetLog.Location = new System.Drawing.Point(379, 15);
            this.btnGetLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetLog.Name = "btnGetLog";
            this.btnGetLog.Size = new System.Drawing.Size(120, 37);
            this.btnGetLog.TabIndex = 3;
            this.btnGetLog.Text = "Get Log";
            this.btnGetLog.UseVisualStyleBackColor = true;
            this.btnGetLog.Click += new System.EventHandler(this.btnGetLog_Click);
            // 
            // lsbListDevices
            // 
            this.lsbListDevices.FormattingEnabled = true;
            this.lsbListDevices.ItemHeight = 16;
            this.lsbListDevices.Location = new System.Drawing.Point(13, 13);
            this.lsbListDevices.Name = "lsbListDevices";
            this.lsbListDevices.Size = new System.Drawing.Size(231, 100);
            this.lsbListDevices.TabIndex = 5;
            // 
            // cbAutoScroll
            // 
            this.cbAutoScroll.AutoSize = true;
            this.cbAutoScroll.Location = new System.Drawing.Point(251, 95);
            this.cbAutoScroll.Name = "cbAutoScroll";
            this.cbAutoScroll.Size = new System.Drawing.Size(111, 20);
            this.cbAutoScroll.TabIndex = 7;
            this.cbAutoScroll.Text = "Scroll to end";
            this.cbAutoScroll.UseVisualStyleBackColor = true;
            this.cbAutoScroll.CheckedChanged += new System.EventHandler(this.cbAutoScroll_CheckedChanged);
            // 
            // ctxbMainOut
            // 
            this.ctxbMainOut.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.ctxbMainOut.AutoSize = true;
            this.ctxbMainOut.BackBrush = null;
            this.ctxbMainOut.CharHeight = 14;
            this.ctxbMainOut.CharWidth = 8;
            this.ctxbMainOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctxbMainOut.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ctxbMainOut.IsReplaceMode = false;
            this.ctxbMainOut.Location = new System.Drawing.Point(13, 119);
            this.ctxbMainOut.Name = "ctxbMainOut";
            this.ctxbMainOut.Paddings = new System.Windows.Forms.Padding(0);
            this.ctxbMainOut.ReadOnly = true;
            this.ctxbMainOut.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ctxbMainOut.Size = new System.Drawing.Size(766, 433);
            this.ctxbMainOut.TabIndex = 6;
            this.ctxbMainOut.Zoom = 100;
            this.ctxbMainOut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctxbMainOut_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 565);
            this.Controls.Add(this.cbAutoScroll);
            this.Controls.Add(this.ctxbMainOut);
            this.Controls.Add(this.lsbListDevices);
            this.Controls.Add(this.btnGetLog);
            this.Controls.Add(this.btnGetDevices);
            this.Controls.Add(this.btnConfig);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "BLog";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.ctxbMainOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnGetDevices;
        private System.Windows.Forms.Button btnGetLog;
        private System.Windows.Forms.ListBox lsbListDevices;
        private FastColoredTextBoxNS.FastColoredTextBox ctxbMainOut;
        private System.Windows.Forms.CheckBox cbAutoScroll;
    }
}


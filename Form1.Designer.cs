namespace RenamePNumbers
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpenFolderDialog = new System.Windows.Forms.Button();
            this.txtSelectedPath = new System.Windows.Forms.TextBox();
            this.btnScanAndRename = new System.Windows.Forms.Button();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenFolderDialog
            // 
            this.btnOpenFolderDialog.Location = new System.Drawing.Point(74, 44);
            this.btnOpenFolderDialog.Name = "btnOpenFolderDialog";
            this.btnOpenFolderDialog.Size = new System.Drawing.Size(116, 41);
            this.btnOpenFolderDialog.TabIndex = 0;
            this.btnOpenFolderDialog.Text = "Select Folder To Scan";
            this.btnOpenFolderDialog.UseVisualStyleBackColor = true;
            this.btnOpenFolderDialog.Click += new System.EventHandler(this.btnOpenFolderDialog_Click);
            // 
            // txtSelectedPath
            // 
            this.txtSelectedPath.Location = new System.Drawing.Point(74, 110);
            this.txtSelectedPath.Name = "txtSelectedPath";
            this.txtSelectedPath.Size = new System.Drawing.Size(369, 20);
            this.txtSelectedPath.TabIndex = 1;
            // 
            // btnScanAndRename
            // 
            this.btnScanAndRename.Location = new System.Drawing.Point(74, 180);
            this.btnScanAndRename.Name = "btnScanAndRename";
            this.btnScanAndRename.Size = new System.Drawing.Size(120, 42);
            this.btnScanAndRename.TabIndex = 2;
            this.btnScanAndRename.Text = "Scan and Rename";
            this.btnScanAndRename.UseVisualStyleBackColor = true;
            this.btnScanAndRename.Click += new System.EventHandler(this.btnScanAndRename_Click);
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(248, 152);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebug.Size = new System.Drawing.Size(232, 99);
            this.txtDebug.TabIndex = 3;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(273, 286);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(35, 13);
            this.lblCounter.TabIndex = 4;
            this.lblCounter.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 410);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.btnScanAndRename);
            this.Controls.Add(this.txtSelectedPath);
            this.Controls.Add(this.btnOpenFolderDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnOpenFolderDialog;
        private System.Windows.Forms.TextBox txtSelectedPath;
        private System.Windows.Forms.Button btnScanAndRename;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Label lblCounter;
    }
}


namespace SimpleCopy
{
    partial class Main
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SourceDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.DestinationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CopySource = new System.Windows.Forms.TextBox();
            this.CopyDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenSourceDialog = new System.Windows.Forms.Button();
            this.OpenDestinationDialog = new System.Windows.Forms.Button();
            this.CopyProgress = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(279, 302);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(198, 302);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // CopySource
            // 
            this.CopySource.Location = new System.Drawing.Point(15, 25);
            this.CopySource.Name = "CopySource";
            this.CopySource.Size = new System.Drawing.Size(309, 20);
            this.CopySource.TabIndex = 2;
            // 
            // CopyDestination
            // 
            this.CopyDestination.Location = new System.Drawing.Point(15, 84);
            this.CopyDestination.Name = "CopyDestination";
            this.CopyDestination.Size = new System.Drawing.Size(309, 20);
            this.CopyDestination.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination";
            // 
            // OpenSourceDialog
            // 
            this.OpenSourceDialog.Location = new System.Drawing.Point(330, 23);
            this.OpenSourceDialog.Name = "OpenSourceDialog";
            this.OpenSourceDialog.Size = new System.Drawing.Size(23, 23);
            this.OpenSourceDialog.TabIndex = 6;
            this.OpenSourceDialog.Text = "...";
            this.OpenSourceDialog.UseVisualStyleBackColor = true;
            this.OpenSourceDialog.Click += new System.EventHandler(this.OpenSourceDialog_Click);
            // 
            // OpenDestinationDialog
            // 
            this.OpenDestinationDialog.Location = new System.Drawing.Point(330, 82);
            this.OpenDestinationDialog.Name = "OpenDestinationDialog";
            this.OpenDestinationDialog.Size = new System.Drawing.Size(23, 23);
            this.OpenDestinationDialog.TabIndex = 7;
            this.OpenDestinationDialog.Text = "...";
            this.OpenDestinationDialog.UseVisualStyleBackColor = true;
            this.OpenDestinationDialog.Click += new System.EventHandler(this.OpenDestinationDialog_Click);
            // 
            // CopyProgress
            // 
            this.CopyProgress.FormattingEnabled = true;
            this.CopyProgress.Location = new System.Drawing.Point(15, 126);
            this.CopyProgress.Name = "CopyProgress";
            this.CopyProgress.Size = new System.Drawing.Size(338, 160);
            this.CopyProgress.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 337);
            this.Controls.Add(this.CopyProgress);
            this.Controls.Add(this.OpenDestinationDialog);
            this.Controls.Add(this.OpenSourceDialog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CopyDestination);
            this.Controls.Add(this.CopySource);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Cancel);
            this.Name = "Main";
            this.Text = "Simple Copy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.FolderBrowserDialog SourceDialog;
        private System.Windows.Forms.FolderBrowserDialog DestinationDialog;
        private System.Windows.Forms.TextBox CopySource;
        private System.Windows.Forms.TextBox CopyDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenSourceDialog;
        private System.Windows.Forms.Button OpenDestinationDialog;
        private System.Windows.Forms.ListBox CopyProgress;
    }
}


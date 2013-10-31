using SimpleCopy.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCopy
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CopySource.Text))
            { 
                //Messagebox isn't great, but it is quick
                MessageBox.Show("Please enter a copy source");
            }

            if (string.IsNullOrEmpty(CopyDestination.Text))
            {
                //Messagebox isn't great, but it is quick
                MessageBox.Show("Please enter a copy destination");                
            }

            CopyService copyService = new CopyService();

            //Event handler
            copyService.FileCopied += copyService_FileCopied;

            copyService.CopyDirectory(CopySource.Text, CopyDestination.Text);
        }

        private void copyService_FileCopied(object sender, FileCopyEventArgs e)
        {
            CopyProgress.Items.Add(string.Format("{0} copied", e.FileName));
            Application.DoEvents();
        }


        private void OpenSourceDialog_Click(object sender, EventArgs e)
        {
            var result = SourceDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                CopySource.Text = SourceDialog.SelectedPath;
            }

        }

        private void OpenDestinationDialog_Click(object sender, EventArgs e)
        {
            var result = DestinationDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                CopyDestination.Text = DestinationDialog.SelectedPath;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //TODO: If we get time, async/await would be nice and the UI thread will remain responsive, so raise a cancellation token to stop the copy
        }
    }
}

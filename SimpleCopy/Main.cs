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

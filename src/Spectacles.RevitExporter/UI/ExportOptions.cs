using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spectacles.RevitExporter
{
    public partial class ExportOptions : Form
    {
        public bool filterParameters = true;
        public bool includeTypeParameters = true;
        public bool includeViews = true;

        public ExportOptions()
        {
            InitializeComponent();
        }

        private void checkBox_FilterParameters_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_FilterParameters.Checked)
            {
                filterParameters = true;
            }
            else
            {
                filterParameters = false;
            }
        }

        private void checkBox_IncludeTypeParameters_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_IncludeTypeParameters.Checked)
            {
                includeTypeParameters = true;
            }
            else
            {
                includeTypeParameters = false;
            }
        }

        private void checkBox_CreateViews_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CreateViews.Checked)
            {
                includeViews = true;
            }
            else
            {
                includeViews = false;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

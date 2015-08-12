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
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Description_Click(object sender, EventArgs e)
        {

        }
    }
}

//The MIT License (MIT)

//Those portions created by va3c authors are provided with the following copyright:

//Copyright (c) 2014 va3c

//Those portions created by Thornton Tomasetti employees are provided with the following copyright:

//Copyright (c) 2015 Thornton Tomasetti

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

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
    public partial class ParameterFilter : Form
    {
        public ParameterFilter()
        {
            InitializeComponent();
        }


        public static string status = "";
        private bool changeAll = false;
        /// <summary>
        /// Function to check or uncheck all the checkboxes in a tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkUncheck_Click(object sender, EventArgs e)
        {
            
            int index = Command._tabControl.SelectedIndex;
            CheckedListBox currentCheckList = new CheckedListBox();
            if (!changeAll)
            {
                currentCheckList = (CheckedListBox)((TabPage)(Command._tabControl.GetControl(index))).Controls[0];

                bool areAllChecked = true;
                if (currentCheckList.CheckedItems.Count < currentCheckList.Items.Count) areAllChecked = false;
                checkUncheckBoxes(currentCheckList, areAllChecked);
            }
            else
            {
                List<CheckedListBox> allCheckLists = new List<CheckedListBox>();
                bool areAllChecked = true;
                
                foreach (TabPage tab in Command._tabControl.TabPages)
                {
                    currentCheckList = (CheckedListBox) tab.Controls[0];
                    if (currentCheckList.CheckedItems.Count < currentCheckList.Items.Count)
                    {
                        areAllChecked = false;
                        break;
                    }
                }

                foreach (TabPage tab in Command._tabControl.TabPages)
                {
                    currentCheckList = (CheckedListBox)tab.Controls[0];
                    checkUncheckBoxes(currentCheckList, areAllChecked);
                }
            }
        }

        private void export_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            status = "cancelled";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) changeAll = false;
            else changeAll = true;
        }

        private void checkUncheckBoxes(CheckedListBox currentCheckList, bool areAllChecked)
        {
            if (!areAllChecked)
            {
                for (int i = 0; i <= (currentCheckList.Items.Count - 1); i++)
                {
                    currentCheckList.SetItemCheckState(i, CheckState.Checked);
                }
            }
            else
            {
                for (int i = 0; i <= (currentCheckList.Items.Count - 1); i++)
                {
                    currentCheckList.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
    }
}

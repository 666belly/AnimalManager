using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VT24Assignment1
{
    public partial class DisplayFileContentsForm : Form
    {
        private EcoZoo ecoZoo; 

        public DisplayFileContentsForm()
        {
            InitializeComponent();
        }

        public void listBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void DisplayFileContents(string fileContents)
        {
            listBoxDisplay.Items.Clear();
            listBoxDisplay.Items.AddRange(fileContents.Split('\n')); 
        }


    }
}

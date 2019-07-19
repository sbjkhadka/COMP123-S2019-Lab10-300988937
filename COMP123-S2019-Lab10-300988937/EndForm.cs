using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Subarna Bijaya Khadka, Student#: 300988937, Summer 2019
namespace COMP123_S2019_Lab10_300988937
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event Handler for back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.MAIN_FORM].Show();
            Hide();
        }
        /// <summary>
        /// Event handler for close button in control box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

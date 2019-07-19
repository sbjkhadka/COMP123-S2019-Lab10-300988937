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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When next button is clicked, EndForms shows up and MainForm disppears
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.END_FORM].Show();
            Hide();
        }
        /// <summary>
        /// Event Handler: Application terminates when the close button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

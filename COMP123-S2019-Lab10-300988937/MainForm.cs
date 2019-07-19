using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// Alternative way commented for my reference
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NextButton_Click(object sender, EventArgs e)
        {
            //EndForm endForm = new EndForm();
            //endForm.Show();
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

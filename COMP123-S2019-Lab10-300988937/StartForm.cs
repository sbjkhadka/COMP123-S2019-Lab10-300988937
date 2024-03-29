﻿using System;
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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
    
        /// <summary>
        /// Event handler for form load event
        /// 3000ms timer enabled when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
        /// <summary>
        /// Eventhandler for tick event
        /// On first tick, Splash screen (StartForm) disappears
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[FormName.MAIN_FORM].Show();
            Hide();
        }
    }
}

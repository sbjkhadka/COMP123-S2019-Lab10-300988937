using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Subarna Bijaya Khadka, Student#: 300988937, Summer 2019
namespace COMP123_S2019_Lab10_300988937
{
    /// <summary>
    /// namespace enum to define names of forms
    /// </summary>
    public enum FormName
    {
        START_FORM,
        END_FORM,
        MAIN_FORM
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Key value pair. Key=Enum.FormNAme, value=object pointing to the respective form class
        /// </summary>
        /// 
        public static Dictionary<FormName, Form> Forms;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.MAIN_FORM,new MainForm());
            Forms.Add(FormName.END_FORM,new EndForm());
            Application.Run(Forms[FormName.START_FORM]);
        }
    }
}

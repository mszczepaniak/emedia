using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmediaQuest1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        //public static double IntToDouble(int data)
        //{
        //    return (double)data;
        //}
    }
}

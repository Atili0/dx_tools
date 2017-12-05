using System;
using System.Windows.Forms;
using DeXrm.Win.Tools.Controllers;
using DeXrm.Win.Tools.Models;
//using DeXrm.Win.Tools.Actions;

namespace DeXrm.Win.Tools
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //IActionMain actionMain = new ActionMain();
            var frmvewMain = new FrmMain();
            IModelFrmMain mdl = new ModelFrmMain();
            IControllerFrmMain crt = new ControllerFrmMain(frmvewMain, mdl);
            Application.Run(frmvewMain);
        }
    }
}
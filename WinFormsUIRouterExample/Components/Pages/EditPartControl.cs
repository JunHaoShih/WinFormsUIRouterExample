using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsUIRouterExample.Models;

namespace WinFormsUIRouterExample.Components.Pages
{
    public partial class EditPartControl : UserControl, IRouting
    {
        private UIRouter uiRouter;

        public EditPartControl(UIRouter uiRouter)
        {
            InitializeComponent();
            this.uiRouter = uiRouter;
        }

        public void SetArguments(params object[] arguments)
        {
            var part = (Part)arguments[0];
            tbNumber.Text = part.Number;
            tbName.Text = part.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Redirect the main panel back to PartsControl
            uiRouter.Redirect<PartsControl>();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
            // Redirect the main panel back to PartsControl
            uiRouter.Redirect<PartsControl>();
        }
    }
}

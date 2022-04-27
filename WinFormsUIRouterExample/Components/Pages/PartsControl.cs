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
    public partial class PartsControl : UserControl
    {
        private UIRouter uiRouter;

        public PartsControl(UIRouter uiRouter)
        {
            InitializeComponent();
            this.uiRouter = uiRouter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Redirect the main panel to NewPartControl
            uiRouter.Redirect<NewPartControl>();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var part = new Part { Id = 1, Number = "P01", Name = "Part 1" };
            // Redirect the main panel to EditPartControl
            uiRouter.Redirect<EditPartControl>(part);
        }
    }
}

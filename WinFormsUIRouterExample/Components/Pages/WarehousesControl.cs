using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUIRouterExample.Components.Pages
{
    public partial class WarehousesControl : UserControl
    {
        private UIRouter uiRouter;

        public WarehousesControl(UIRouter uiRouter)
        {
            InitializeComponent();
            this.uiRouter = uiRouter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Redirect the main panel to NewWarehouseControl
            uiRouter.Redirect<NewWarehouseControl>();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Redirect the main panel to EditWarehouseControl
            uiRouter.Redirect<EditWarehouseControl>();
        }
    }
}

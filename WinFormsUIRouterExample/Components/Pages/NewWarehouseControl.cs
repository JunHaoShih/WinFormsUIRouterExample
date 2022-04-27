using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUIRouterExample.Components.Pages
{
    public partial class NewWarehouseControl : UserControl
    {
        private UIRouter uiRouter;

        public NewWarehouseControl(UIRouter uiRouter)
        {
            InitializeComponent();
            this.uiRouter = uiRouter;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Redirect the main panel back to WarehousesControl
            uiRouter.Redirect<WarehousesControl>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success!");
            // Redirect the main panel back to WarehousesControl
            uiRouter.Redirect<WarehousesControl>();
        }
    }
}

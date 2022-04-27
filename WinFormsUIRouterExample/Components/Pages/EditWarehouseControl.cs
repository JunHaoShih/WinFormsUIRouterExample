using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUIRouterExample.Components.Pages
{
    public partial class EditWarehouseControl : UserControl
    {
        private UIRouter uiRouter;

        public EditWarehouseControl(UIRouter uiRouter)
        {
            InitializeComponent();
            this.uiRouter = uiRouter;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Redirect the main panel back to WarehousesControl
            uiRouter.Redirect<WarehousesControl>();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
            // Redirect the main panel back to WarehousesControl
            uiRouter.Redirect<WarehousesControl>();
        }
    }
}

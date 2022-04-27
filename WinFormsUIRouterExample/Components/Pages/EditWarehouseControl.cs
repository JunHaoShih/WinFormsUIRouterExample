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
    public partial class EditWarehouseControl : UserControl, IRouting
    {
        private UIRouter uiRouter;

        public EditWarehouseControl(UIRouter uiRouter)
        {
            InitializeComponent();
            this.uiRouter = uiRouter;
        }

        public void SetArguments(params object[] arguments)
        {
            var warehouse = (Warehouse)arguments[0];
            tbNumber.Text = warehouse.Number;
            tbName.Text = warehouse.Name;
            tbAddress.Text = warehouse.Address;
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

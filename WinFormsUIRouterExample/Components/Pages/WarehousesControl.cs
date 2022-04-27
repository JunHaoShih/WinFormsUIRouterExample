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
            var warehouse = new Warehouse { Id = 1, Name = "Warehouse1", Number = "W01", Address = "Somewhere in the world" };
            // Redirect the main panel to EditWarehouseControl
            uiRouter.Redirect<EditWarehouseControl>(warehouse);
        }
    }
}

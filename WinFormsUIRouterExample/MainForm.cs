using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUIRouterExample.Components;
using WinFormsUIRouterExample.Components.Pages;

namespace WinFormsUIRouterExample
{
    public partial class MainForm : Form
    {
        private UIRouter uiRouter;

        public MainForm(UIRouter uiRouter)
        {
            InitializeComponent();
            this.uiRouter = uiRouter;
            // Register panelCenter as the main panel
            this.uiRouter.MainPanel = this.panelCenter;
        }

        /// <summary>
        /// Reset all of SideButtonControl to default status，it will be triggered by ResetEvent of SideButtonControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetClick(object sender, EventArgs e)
        {
            foreach (SideButtonControl sideButton in flpLeftNavigation.Controls)
            {
                sideButton.ResetClick();
            }
        }

        private void sideButtonWarehouse_Click(object sender, EventArgs e)
        {
            // Redirect the main panel to WarehousesControl
            uiRouter.Redirect<WarehousesControl>();
        }

        private void sideButtonParts_Click(object sender, EventArgs e)
        {
            // Redirect the main panel to PartsControl
            uiRouter.Redirect<PartsControl>();
        }
    }
}

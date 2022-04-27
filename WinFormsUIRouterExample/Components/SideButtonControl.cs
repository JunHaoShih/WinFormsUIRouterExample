using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUIRouterExample.Components
{
    public partial class SideButtonControl : UserControl
    {
        public bool IsSelect { get; set; }

        [Browsable(true)]
        [Category("Action")]
        [Description("點選時觸發，用來重製其他按鈕用")]
        public event EventHandler ResetEvent;

        public string LabelName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public SideButtonControl()
        {
            InitializeComponent();
        }

        public void ResetClick()
        {
            IsSelect = false;
            this.BackColor = Color.WhiteSmoke;
            this.lblName.ForeColor = Color.Black;
        }

        /// <summary>
        /// 由於UserControl並沒有像Button一樣有PerformClick的method，只好自己做一個類似的功能
        /// </summary>
        public void TriggerClick()
        {
            this.OnClick(new EventArgs());
        }

        private void SideButtonControl_MouseEnter(object sender, EventArgs e)
        {
            if (!IsSelect)
                this.BackColor = Color.LightGray;
            this.panelMain.BackColor = Color.LightGray;
        }

        private void SideButtonControl_MouseLeave(object sender, EventArgs e)
        {
            if (!IsSelect)
                this.BackColor = Color.WhiteSmoke;
            this.panelMain.BackColor = Color.WhiteSmoke;
        }

        private void SideButtonControl_Click(object sender, EventArgs e)
        {
            ResetEvent?.Invoke(sender, e);
            //ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
            IsSelect = true;
            this.BackColor = Color.Red;
            this.lblName.ForeColor = Color.Red;
            this.panelMain.BackColor = Color.WhiteSmoke;
        }

        private void OnChildControlClicked(object sender, EventArgs e)
        {
            //SideButtonControl_Click(sender, e);
            this.OnClick(e);
        }
    }
}

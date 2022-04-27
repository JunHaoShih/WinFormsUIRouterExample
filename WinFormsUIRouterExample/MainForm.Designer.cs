
namespace WinFormsUIRouterExample
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flpLeftNavigation = new System.Windows.Forms.FlowLayoutPanel();
            this.sideButtonWarehouse = new WinFormsUIRouterExample.Components.SideButtonControl();
            this.sideButtonParts = new WinFormsUIRouterExample.Components.SideButtonControl();
            this.panelMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.flpLeftNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelCenter);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1084, 461);
            this.panelMain.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(200, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(884, 461);
            this.panelCenter.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.flpLeftNavigation);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 461);
            this.panelLeft.TabIndex = 0;
            // 
            // flpLeftNavigation
            // 
            this.flpLeftNavigation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpLeftNavigation.Controls.Add(this.sideButtonWarehouse);
            this.flpLeftNavigation.Controls.Add(this.sideButtonParts);
            this.flpLeftNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLeftNavigation.Location = new System.Drawing.Point(0, 0);
            this.flpLeftNavigation.Name = "flpLeftNavigation";
            this.flpLeftNavigation.Size = new System.Drawing.Size(200, 461);
            this.flpLeftNavigation.TabIndex = 0;
            // 
            // sideButtonWarehouse
            // 
            this.sideButtonWarehouse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sideButtonWarehouse.IsSelect = false;
            this.sideButtonWarehouse.LabelName = "Warehouses";
            this.sideButtonWarehouse.Location = new System.Drawing.Point(4, 4);
            this.sideButtonWarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.sideButtonWarehouse.Name = "sideButtonWarehouse";
            this.sideButtonWarehouse.Padding = new System.Windows.Forms.Padding(6, 1, 1, 1);
            this.sideButtonWarehouse.Size = new System.Drawing.Size(195, 42);
            this.sideButtonWarehouse.TabIndex = 0;
            this.sideButtonWarehouse.ResetEvent += new System.EventHandler(this.ResetClick);
            this.sideButtonWarehouse.Click += new System.EventHandler(this.sideButtonWarehouse_Click);
            // 
            // sideButtonParts
            // 
            this.sideButtonParts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sideButtonParts.IsSelect = false;
            this.sideButtonParts.LabelName = "Parts";
            this.sideButtonParts.Location = new System.Drawing.Point(4, 54);
            this.sideButtonParts.Margin = new System.Windows.Forms.Padding(4);
            this.sideButtonParts.Name = "sideButtonParts";
            this.sideButtonParts.Padding = new System.Windows.Forms.Padding(6, 1, 1, 1);
            this.sideButtonParts.Size = new System.Drawing.Size(195, 42);
            this.sideButtonParts.TabIndex = 1;
            this.sideButtonParts.ResetEvent += new System.EventHandler(this.ResetClick);
            this.sideButtonParts.Click += new System.EventHandler(this.sideButtonParts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.panelMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.flpLeftNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.FlowLayoutPanel flpLeftNavigation;
        private Components.SideButtonControl sideButtonWarehouse;
        private System.Windows.Forms.Panel panelCenter;
        private Components.SideButtonControl sideButtonParts;
    }
}


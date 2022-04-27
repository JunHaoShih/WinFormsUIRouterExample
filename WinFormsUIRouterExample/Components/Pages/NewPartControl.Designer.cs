
namespace WinFormsUIRouterExample.Components.Pages
{
    partial class NewPartControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tlpConfirm = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnContinueAdd = new System.Windows.Forms.Button();
            this.tlpCancel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.tlpConainerGrid = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tlpConfirm.SuspendLayout();
            this.tlpCancel.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.tlpConainerGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelCenter);
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(941, 442);
            this.panelMain.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.tlpTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(941, 54);
            this.panelTop.TabIndex = 6;
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 1;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitle.Controls.Add(this.lblTitle, 0, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpTitle.Location = new System.Drawing.Point(0, 0);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitle.Size = new System.Drawing.Size(267, 54);
            this.tlpTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(35, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Part";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.tlpConfirm);
            this.panelBottom.Controls.Add(this.tlpCancel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 388);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(941, 54);
            this.panelBottom.TabIndex = 7;
            // 
            // tlpConfirm
            // 
            this.tlpConfirm.ColumnCount = 2;
            this.tlpConfirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConfirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConfirm.Controls.Add(this.btnAdd, 1, 0);
            this.tlpConfirm.Controls.Add(this.btnContinueAdd, 0, 0);
            this.tlpConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlpConfirm.Location = new System.Drawing.Point(634, 0);
            this.tlpConfirm.Name = "tlpConfirm";
            this.tlpConfirm.RowCount = 1;
            this.tlpConfirm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConfirm.Size = new System.Drawing.Size(307, 54);
            this.tlpConfirm.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Location = new System.Drawing.Point(197, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 3, 35, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnContinueAdd
            // 
            this.btnContinueAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnContinueAdd.Location = new System.Drawing.Point(75, 15);
            this.btnContinueAdd.Name = "btnContinueAdd";
            this.btnContinueAdd.Size = new System.Drawing.Size(75, 23);
            this.btnContinueAdd.TabIndex = 1;
            this.btnContinueAdd.Text = "Add More";
            this.btnContinueAdd.UseVisualStyleBackColor = true;
            // 
            // tlpCancel
            // 
            this.tlpCancel.ColumnCount = 1;
            this.tlpCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCancel.Controls.Add(this.btnCancel, 0, 0);
            this.tlpCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpCancel.Location = new System.Drawing.Point(0, 0);
            this.tlpCancel.Name = "tlpCancel";
            this.tlpCancel.RowCount = 1;
            this.tlpCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCancel.Size = new System.Drawing.Size(200, 54);
            this.tlpCancel.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.Location = new System.Drawing.Point(35, 15);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.tlpConainerGrid);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 54);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Padding = new System.Windows.Forms.Padding(10);
            this.panelCenter.Size = new System.Drawing.Size(941, 334);
            this.panelCenter.TabIndex = 8;
            // 
            // tlpConainerGrid
            // 
            this.tlpConainerGrid.ColumnCount = 2;
            this.tlpConainerGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpConainerGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConainerGrid.Controls.Add(this.lblNumber, 0, 0);
            this.tlpConainerGrid.Controls.Add(this.lblName, 0, 1);
            this.tlpConainerGrid.Controls.Add(this.tbNumber, 1, 0);
            this.tlpConainerGrid.Controls.Add(this.tbName, 1, 1);
            this.tlpConainerGrid.Location = new System.Drawing.Point(14, 14);
            this.tlpConainerGrid.Name = "tlpConainerGrid";
            this.tlpConainerGrid.RowCount = 6;
            this.tlpConainerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpConainerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpConainerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpConainerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpConainerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpConainerGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConainerGrid.Size = new System.Drawing.Size(469, 291);
            this.tlpConainerGrid.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(30, 15);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(72, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(30, 65);
            this.lblName.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumber.Location = new System.Drawing.Point(153, 11);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(313, 28);
            this.tbNumber.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(153, 61);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(313, 28);
            this.tbName.TabIndex = 4;
            // 
            // NewPartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "NewPartControl";
            this.Size = new System.Drawing.Size(941, 442);
            this.panelMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.tlpConfirm.ResumeLayout(false);
            this.tlpCancel.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.tlpConainerGrid.ResumeLayout(false);
            this.tlpConainerGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tlpConfirm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnContinueAdd;
        private System.Windows.Forms.TableLayoutPanel tlpCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.TableLayoutPanel tlpConainerGrid;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbName;
    }
}

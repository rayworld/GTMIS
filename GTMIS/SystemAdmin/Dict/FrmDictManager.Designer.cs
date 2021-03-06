﻿namespace GTMIS.SystemAdmin.Dict
{
    partial class FrmDictManager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonQuery = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ButtonDelete = new DevComponents.DotNetBar.ButtonX();
            this.ButtonEdit = new DevComponents.DotNetBar.ButtonX();
            this.ButtonInsert = new DevComponents.DotNetBar.ButtonX();
            this.ButtonClean = new DevComponents.DotNetBar.ButtonX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.TextBoxX_QueryString = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.pager2 = new GTMIS.Controls.Pager();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItemEdit = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItemDelete = new DevComponents.DotNetBar.ButtonItem();
            this.ButtonItemInsert = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewX1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonQuery
            // 
            this.ButtonQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonQuery.Location = new System.Drawing.Point(325, 9);
            this.ButtonQuery.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonQuery.Name = "ButtonQuery";
            this.ButtonQuery.Size = new System.Drawing.Size(92, 31);
            this.ButtonQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonQuery.TabIndex = 2;
            this.ButtonQuery.Text = "查询";
            this.ButtonQuery.Click += new System.EventHandler(this.ButtonQuery_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(5, 9);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 31);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "条目名称：";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonDelete.Location = new System.Drawing.Point(237, 9);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(92, 31);
            this.ButtonDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "删除";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonEdit.Location = new System.Drawing.Point(131, 9);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(92, 31);
            this.ButtonEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonEdit.TabIndex = 7;
            this.ButtonEdit.Text = "修改";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonInsert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonInsert.Location = new System.Drawing.Point(26, 9);
            this.ButtonInsert.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(92, 31);
            this.ButtonInsert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonInsert.TabIndex = 6;
            this.ButtonInsert.Text = "新建";
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // ButtonClean
            // 
            this.ButtonClean.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonClean.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonClean.Location = new System.Drawing.Point(428, 9);
            this.ButtonClean.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonClean.Name = "ButtonClean";
            this.ButtonClean.Size = new System.Drawing.Size(92, 31);
            this.ButtonClean.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonClean.TabIndex = 10;
            this.ButtonClean.Text = "刷新";
            this.ButtonClean.Click += new System.EventHandler(this.ButtonClean_Click);
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.ButtonDelete);
            this.panelEx3.Controls.Add(this.ButtonEdit);
            this.panelEx3.Controls.Add(this.ButtonInsert);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx3.Location = new System.Drawing.Point(581, 0);
            this.panelEx3.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(352, 57);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 6;
            this.panelEx3.Text = "panelEx3";
            // 
            // TextBoxX_QueryString
            // 
            this.TextBoxX_QueryString.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxX_QueryString.Border.Class = "TextBoxBorder";
            this.TextBoxX_QueryString.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX_QueryString.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxX_QueryString.ForeColor = System.Drawing.Color.Black;
            this.TextBoxX_QueryString.Location = new System.Drawing.Point(99, 15);
            this.TextBoxX_QueryString.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxX_QueryString.Name = "TextBoxX_QueryString";
            this.TextBoxX_QueryString.PreventEnterBeep = true;
            this.TextBoxX_QueryString.Size = new System.Drawing.Size(212, 21);
            this.TextBoxX_QueryString.TabIndex = 1;
            // 
            // DataGridViewX1
            // 
            this.DataGridViewX1.AllowUserToAddRows = false;
            this.DataGridViewX1.AllowUserToOrderColumns = true;
            this.DataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contextMenuBar1.SetContextMenuEx(this.DataGridViewX1, this.buttonItem1);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewX1.EnableHeadersVisualStyles = false;
            this.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.DataGridViewX1.Location = new System.Drawing.Point(0, 57);
            this.DataGridViewX1.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewX1.Name = "DataGridViewX1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewX1.RowHeadersWidth = 70;
            this.DataGridViewX1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F);
            this.DataGridViewX1.RowTemplate.Height = 30;
            this.DataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewX1.Size = new System.Drawing.Size(933, 346);
            this.DataGridViewX1.TabIndex = 0;
            this.DataGridViewX1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewX1_CellDoubleClick);
            this.DataGridViewX1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewX1_CellFormatting);
            this.DataGridViewX1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewX1_DataBindingComplete);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.contextMenuBar1);
            this.panelEx1.Controls.Add(this.DataGridViewX1);
            this.panelEx1.Controls.Add(this.pager2);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(366, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(933, 450);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 8;
            this.panelEx1.Text = "panelEx1";
            // 
            // pager2
            // 
            this.pager2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pager2.Location = new System.Drawing.Point(0, 403);
            this.pager2.Margin = new System.Windows.Forms.Padding(1);
            this.pager2.Name = "pager2";
            this.pager2.PageIndex = 1;
            this.pager2.PageSize = 10;
            this.pager2.RecCount = 0;
            this.pager2.Size = new System.Drawing.Size(933, 47);
            this.pager2.TabIndex = 5;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.ButtonClean);
            this.panelEx2.Controls.Add(this.panelEx3);
            this.panelEx2.Controls.Add(this.ButtonQuery);
            this.panelEx2.Controls.Add(this.TextBoxX_QueryString);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(933, 57);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.ExpandableControl = this.advTree1;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.Black;
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.ForeColor = System.Drawing.Color.Black;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.Black;
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.Empty;
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.Black;
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(356, 0);
            this.expandableSplitter1.Margin = new System.Windows.Forms.Padding(2);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(10, 450);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 7;
            this.expandableSplitter1.TabStop = false;
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.Dock = System.Windows.Forms.DockStyle.Left;
            this.advTree1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.advTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.advTree1.Location = new System.Drawing.Point(0, 0);
            this.advTree1.Margin = new System.Windows.Forms.Padding(2);
            this.advTree1.Name = "advTree1";
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Size = new System.Drawing.Size(356, 450);
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.TabIndex = 6;
            this.advTree1.Text = "advTree1";
            this.advTree1.Click += new System.EventHandler(this.AdvTree1_Click);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.contextMenuBar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.contextMenuBar1.IsMaximized = false;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.contextMenuBar1.Location = new System.Drawing.Point(148, 146);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(125, 27);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 9;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItemInsert,
            this.ButtonItemEdit,
            this.ButtonItemDelete});
            this.buttonItem1.Text = "右键菜单";
            // 
            // ButtonItemEdit
            // 
            this.ButtonItemEdit.Name = "ButtonItemEdit";
            this.ButtonItemEdit.Text = "编辑(&E)";
            this.ButtonItemEdit.Click += new System.EventHandler(this.ButtonItemEdit_Click);
            // 
            // ButtonItemDelete
            // 
            this.ButtonItemDelete.Name = "ButtonItemDelete";
            this.ButtonItemDelete.Text = "删除(&D)";
            this.ButtonItemDelete.Click += new System.EventHandler(this.ButtonItemDelete_Click);
            // 
            // ButtonItemInsert
            // 
            this.ButtonItemInsert.Name = "ButtonItemInsert";
            this.ButtonItemInsert.Text = "新建(&N)";
            this.ButtonItemInsert.Click += new System.EventHandler(this.ButtonItemInsert_Click);
            // 
            // FrmDictManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 450);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.advTree1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "FrmDictManager";
            this.Text = "FrmTestManager";
            this.Load += new System.EventHandler(this.FrmTestManager_Load);
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewX1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX ButtonQuery;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX ButtonDelete;
        private DevComponents.DotNetBar.ButtonX ButtonEdit;
        private DevComponents.DotNetBar.ButtonX ButtonInsert;
        private DevComponents.DotNetBar.ButtonX ButtonClean;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_QueryString;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataGridViewX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Controls.Pager pager2;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem ButtonItemEdit;
        private DevComponents.DotNetBar.ButtonItem ButtonItemInsert;
        private DevComponents.DotNetBar.ButtonItem ButtonItemDelete;
    }
}
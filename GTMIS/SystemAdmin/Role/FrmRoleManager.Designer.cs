using System;
using System.Windows.Forms;

namespace GTMIS.SystemAdmin.Role
{
    partial class FrmRoleManager
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
            this.DataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.ButtonClean = new DevComponents.DotNetBar.ButtonX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.ButtonDelete = new DevComponents.DotNetBar.ButtonX();
            this.ButtonEdit = new DevComponents.DotNetBar.ButtonX();
            this.ButtonInsert = new DevComponents.DotNetBar.ButtonX();
            this.ButtonQuery = new DevComponents.DotNetBar.ButtonX();
            this.TextBoxX_QueryString = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pager2 = new GTMIS.Controls.Pager();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewX1)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
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
            this.DataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect});
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
            this.DataGridViewX1.Size = new System.Drawing.Size(1185, 346);
            this.DataGridViewX1.TabIndex = 9;
            this.DataGridViewX1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewX1_CellFormatting);
            this.DataGridViewX1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewX1_DataBindingComplete);
            // 
            // chkSelect
            // 
            this.chkSelect.DataPropertyName = "IsChecked";
            this.chkSelect.HeaderText = "";
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkSelect.Width = 40;
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
            this.panelEx2.Size = new System.Drawing.Size(1185, 57);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 10;
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
            this.panelEx3.Location = new System.Drawing.Point(833, 0);
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
            this.labelX1.Text = "角色名称：";
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
            this.pager2.Size = new System.Drawing.Size(1185, 47);
            this.pager2.TabIndex = 11;
            // 
            // FrmPremissionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 450);
            this.Controls.Add(this.DataGridViewX1);
            this.Controls.Add(this.pager2);
            this.Controls.Add(this.panelEx2);
            this.DoubleBuffered = true;
            this.Name = "FrmPremissionManager";
            this.Text = "FrmPremission";
            this.Load += new System.EventHandler(this.FrmRoleManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewX1)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DataGridViewX1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
        private Controls.Pager pager2;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX ButtonClean;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.ButtonX ButtonDelete;
        private DevComponents.DotNetBar.ButtonX ButtonEdit;
        private DevComponents.DotNetBar.ButtonX ButtonInsert;
        private DevComponents.DotNetBar.ButtonX ButtonQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxX_QueryString;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}
namespace GTMIS.SystemAdmin.Organization
{
    partial class FrmOrganizationDetail
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
            this.components = new System.ComponentModel.Container();
            this.TextBoxDeptName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.ButtonCancel = new DevComponents.DotNetBar.ButtonX();
            this.ButtonSave = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.TextBoxCreateBy = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxCreateDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ComboBoxParentId = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxOrder = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxDeptName
            // 
            this.TextBoxDeptName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxDeptName.Border.Class = "TextBoxBorder";
            this.TextBoxDeptName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxDeptName.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxDeptName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxDeptName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDeptName.Location = new System.Drawing.Point(156, 24);
            this.TextBoxDeptName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxDeptName.Name = "TextBoxDeptName";
            this.TextBoxDeptName.PreventEnterBeep = true;
            this.TextBoxDeptName.Size = new System.Drawing.Size(317, 26);
            this.TextBoxDeptName.TabIndex = 0;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 242);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(504, 47);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.ButtonCancel);
            this.panelEx3.Controls.Add(this.ButtonSave);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx3.Location = new System.Drawing.Point(261, 0);
            this.panelEx3.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(243, 47);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackgroundImageAlpha = ((byte)(0));
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 10;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonCancel.Location = new System.Drawing.Point(131, 9);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(92, 31);
            this.ButtonCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "取消";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSave.Location = new System.Drawing.Point(26, 9);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(92, 31);
            this.ButtonSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "保存";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // TextBoxCreateBy
            // 
            this.TextBoxCreateBy.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxCreateBy.Border.Class = "TextBoxBorder";
            this.TextBoxCreateBy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxCreateBy.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxCreateBy.Enabled = false;
            this.TextBoxCreateBy.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxCreateBy.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCreateBy.Location = new System.Drawing.Point(156, 145);
            this.TextBoxCreateBy.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCreateBy.Name = "TextBoxCreateBy";
            this.TextBoxCreateBy.PreventEnterBeep = true;
            this.TextBoxCreateBy.Size = new System.Drawing.Size(317, 26);
            this.TextBoxCreateBy.TabIndex = 6;
            // 
            // TextBoxCreateDate
            // 
            this.TextBoxCreateDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxCreateDate.Border.Class = "TextBoxBorder";
            this.TextBoxCreateDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxCreateDate.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxCreateDate.Enabled = false;
            this.TextBoxCreateDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxCreateDate.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCreateDate.Location = new System.Drawing.Point(156, 182);
            this.TextBoxCreateDate.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCreateDate.Name = "TextBoxCreateDate";
            this.TextBoxCreateDate.PreventEnterBeep = true;
            this.TextBoxCreateDate.Size = new System.Drawing.Size(317, 26);
            this.TextBoxCreateDate.TabIndex = 7;
            // 
            // ComboBoxParentId
            // 
            this.ComboBoxParentId.DisplayMember = "Text";
            this.ComboBoxParentId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxParentId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBoxParentId.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxParentId.FormattingEnabled = true;
            this.ComboBoxParentId.ItemHeight = 30;
            this.ComboBoxParentId.Location = new System.Drawing.Point(156, 61);
            this.ComboBoxParentId.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxParentId.Name = "ComboBoxParentId";
            this.ComboBoxParentId.Size = new System.Drawing.Size(318, 36);
            this.ComboBoxParentId.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxParentId.TabIndex = 8;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(27, 24);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(103, 16);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "部门名称";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(27, 64);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(103, 16);
            this.labelX2.TabIndex = 10;
            this.labelX2.Text = "上级节点";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(27, 104);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(103, 16);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "显示顺序";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(27, 144);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(103, 16);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "创建人";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(27, 184);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(103, 16);
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "创建时间";
            // 
            // TextBoxOrder
            // 
            this.TextBoxOrder.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxOrder.Border.Class = "TextBoxBorder";
            this.TextBoxOrder.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxOrder.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxOrder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxOrder.ForeColor = System.Drawing.Color.Black;
            this.TextBoxOrder.Location = new System.Drawing.Point(156, 108);
            this.TextBoxOrder.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxOrder.Name = "TextBoxOrder";
            this.TextBoxOrder.PreventEnterBeep = true;
            this.TextBoxOrder.Size = new System.Drawing.Size(317, 26);
            this.TextBoxOrder.TabIndex = 14;
            // 
            // FrmOrganizationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 289);
            this.Controls.Add(this.TextBoxOrder);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.ComboBoxParentId);
            this.Controls.Add(this.TextBoxCreateDate);
            this.Controls.Add(this.TextBoxCreateBy);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.TextBoxDeptName);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmOrganizationDetail";
            this.Text = "FrmOrganizationDetail";
            this.Load += new System.EventHandler(this.FrmOrganizationDetail_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxDeptName;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.ButtonX ButtonCancel;
        private DevComponents.DotNetBar.ButtonX ButtonSave;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxCreateBy;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxCreateDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxParentId;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxOrder;
    }
}
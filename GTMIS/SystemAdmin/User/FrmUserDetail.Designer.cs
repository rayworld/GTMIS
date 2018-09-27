namespace GTMIS.SystemAdmin.User
{
    partial class FrmUserDetail
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.ButtonCancel = new DevComponents.DotNetBar.ButtonX();
            this.ButtonSave = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.ComboBoxRoleName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ComboBoxDeptName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.TextBoxPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxCreateDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxCreateBy = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBoxUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 194);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(827, 47);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 19;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.ButtonCancel);
            this.panelEx3.Controls.Add(this.ButtonSave);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx3.Location = new System.Drawing.Point(584, 0);
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
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(23, 122);
            this.labelX6.Margin = new System.Windows.Forms.Padding(2);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(103, 16);
            this.labelX6.TabIndex = 38;
            this.labelX6.Text = "角色";
            // 
            // ComboBoxRoleName
            // 
            this.ComboBoxRoleName.DisplayMember = "Text";
            this.ComboBoxRoleName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxRoleName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBoxRoleName.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxRoleName.FormattingEnabled = true;
            this.ComboBoxRoleName.ItemHeight = 30;
            this.ComboBoxRoleName.Location = new System.Drawing.Point(130, 114);
            this.ComboBoxRoleName.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxRoleName.Name = "ComboBoxRoleName";
            this.ComboBoxRoleName.Size = new System.Drawing.Size(268, 36);
            this.ComboBoxRoleName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxRoleName.TabIndex = 37;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(424, 31);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(103, 16);
            this.labelX2.TabIndex = 36;
            this.labelX2.Text = "部门/职位";
            // 
            // ComboBoxDeptName
            // 
            this.ComboBoxDeptName.DisplayMember = "Text";
            this.ComboBoxDeptName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxDeptName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBoxDeptName.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxDeptName.FormattingEnabled = true;
            this.ComboBoxDeptName.ItemHeight = 30;
            this.ComboBoxDeptName.Location = new System.Drawing.Point(531, 30);
            this.ComboBoxDeptName.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxDeptName.Name = "ComboBoxDeptName";
            this.ComboBoxDeptName.Size = new System.Drawing.Size(268, 36);
            this.ComboBoxDeptName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxDeptName.TabIndex = 35;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxPassword.Border.Class = "TextBoxBorder";
            this.TextBoxPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxPassword.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPassword.Location = new System.Drawing.Point(130, 72);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PreventEnterBeep = true;
            this.TextBoxPassword.Size = new System.Drawing.Size(268, 26);
            this.TextBoxPassword.TabIndex = 34;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(424, 123);
            this.labelX7.Margin = new System.Windows.Forms.Padding(2);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(103, 16);
            this.labelX7.TabIndex = 33;
            this.labelX7.Text = "创建时间";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX8.Location = new System.Drawing.Point(424, 78);
            this.labelX8.Margin = new System.Windows.Forms.Padding(2);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(103, 14);
            this.labelX8.TabIndex = 32;
            this.labelX8.Text = "创建人";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX9.Location = new System.Drawing.Point(23, 76);
            this.labelX9.Margin = new System.Windows.Forms.Padding(2);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(103, 16);
            this.labelX9.TabIndex = 31;
            this.labelX9.Text = "密码";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX10.Location = new System.Drawing.Point(23, 30);
            this.labelX10.Margin = new System.Windows.Forms.Padding(2);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(103, 16);
            this.labelX10.TabIndex = 30;
            this.labelX10.Text = "用户名";
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
            this.TextBoxCreateDate.Location = new System.Drawing.Point(531, 114);
            this.TextBoxCreateDate.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCreateDate.Name = "TextBoxCreateDate";
            this.TextBoxCreateDate.PreventEnterBeep = true;
            this.TextBoxCreateDate.Size = new System.Drawing.Size(268, 26);
            this.TextBoxCreateDate.TabIndex = 29;
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
            this.TextBoxCreateBy.Location = new System.Drawing.Point(531, 72);
            this.TextBoxCreateBy.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCreateBy.Name = "TextBoxCreateBy";
            this.TextBoxCreateBy.PreventEnterBeep = true;
            this.TextBoxCreateBy.Size = new System.Drawing.Size(268, 26);
            this.TextBoxCreateBy.TabIndex = 28;
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBoxUserName.Border.Class = "TextBoxBorder";
            this.TextBoxUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxUserName.DisabledBackColor = System.Drawing.Color.White;
            this.TextBoxUserName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxUserName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxUserName.Location = new System.Drawing.Point(130, 30);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.PreventEnterBeep = true;
            this.TextBoxUserName.Size = new System.Drawing.Size(268, 26);
            this.TextBoxUserName.TabIndex = 27;
            // 
            // FrmUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 241);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.ComboBoxRoleName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.ComboBoxDeptName);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.TextBoxCreateDate);
            this.Controls.Add(this.TextBoxCreateBy);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "FrmUserDetail";
            this.Text = "FrmUserDetail";
            this.Load += new System.EventHandler(this.FrmUserDetail_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.ButtonX ButtonCancel;
        private DevComponents.DotNetBar.ButtonX ButtonSave;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxRoleName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxDeptName;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxPassword;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxCreateDate;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxCreateBy;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxUserName;
    }
}
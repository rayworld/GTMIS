namespace GTMIS.Controls
{
    partial class Pager
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonFirst = new DevComponents.DotNetBar.ButtonX();
            this.ButtonPrev = new DevComponents.DotNetBar.ButtonX();
            this.ButtonNext = new DevComponents.DotNetBar.ButtonX();
            this.ButtonLast = new DevComponents.DotNetBar.ButtonX();
            this.LabelPagerState = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonFirst.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonFirst.Location = new System.Drawing.Point(534, 12);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(138, 47);
            this.ButtonFirst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonFirst.TabIndex = 0;
            this.ButtonFirst.Text = "首  页";
            this.ButtonFirst.Click += new System.EventHandler(this.ButtonFirst_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonPrev.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonPrev.Location = new System.Drawing.Point(686, 12);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(138, 47);
            this.ButtonPrev.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonPrev.TabIndex = 1;
            this.ButtonPrev.Text = "上一页";
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonNext.Location = new System.Drawing.Point(838, 12);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(138, 47);
            this.ButtonNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonNext.TabIndex = 2;
            this.ButtonNext.Text = "下一页";
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonLast
            // 
            this.ButtonLast.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonLast.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonLast.Location = new System.Drawing.Point(990, 12);
            this.ButtonLast.Name = "ButtonLast";
            this.ButtonLast.Size = new System.Drawing.Size(138, 47);
            this.ButtonLast.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonLast.TabIndex = 3;
            this.ButtonLast.Text = "末  页";
            this.ButtonLast.Click += new System.EventHandler(this.ButtonLast_Click);
            // 
            // LabelPagerState
            // 
            // 
            // 
            // 
            this.LabelPagerState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelPagerState.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPagerState.Location = new System.Drawing.Point(21, 12);
            this.LabelPagerState.Name = "LabelPagerState";
            this.LabelPagerState.Size = new System.Drawing.Size(496, 46);
            this.LabelPagerState.TabIndex = 4;
            this.LabelPagerState.Text = "0/0 页  共 0 条记录，每页 0 条";
            this.LabelPagerState.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // Pager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelPagerState);
            this.Controls.Add(this.ButtonLast);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonPrev);
            this.Controls.Add(this.ButtonFirst);
            this.Name = "Pager";
            this.Size = new System.Drawing.Size(1234, 74);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX ButtonFirst;
        private DevComponents.DotNetBar.ButtonX ButtonPrev;
        private DevComponents.DotNetBar.ButtonX ButtonNext;
        private DevComponents.DotNetBar.ButtonX ButtonLast;
        private DevComponents.DotNetBar.LabelX LabelPagerState;
    }
}

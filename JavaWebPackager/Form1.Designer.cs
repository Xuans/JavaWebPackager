namespace JavaWebPackager
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SourceText = new System.Windows.Forms.TextBox();
            this.BaseText = new System.Windows.Forms.TextBox();
            this.TargetText = new System.Windows.Forms.TextBox();
            this.SourceBtn = new System.Windows.Forms.Button();
            this.BaseBtn = new System.Windows.Forms.Button();
            this.TargetBtn = new System.Windows.Forms.Button();
            this.ResultListbox = new System.Windows.Forms.ListBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.PackageBtn = new System.Windows.Forms.Button();
            this.despSourceLabel = new System.Windows.Forms.Label();
            this.BasePathLabel = new System.Windows.Forms.Label();
            this.TargetPathDespLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(475, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(90, 25);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "Close | 关闭";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(48)))), ((int)(((byte)(160)))));
            this.TitleLabel.Location = new System.Drawing.Point(14, 14);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(292, 25);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Java Web Packager | Xuans\' Yips";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.targetLabel.Location = new System.Drawing.Point(28, 80);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(154, 19);
            this.targetLabel.TabIndex = 2;
            this.targetLabel.Text = "Sources Path | 打包地址";
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseLabel.Location = new System.Drawing.Point(28, 150);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(133, 19);
            this.baseLabel.TabIndex = 3;
            this.baseLabel.Text = "Base Path | 基础版本";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target Path | 版本库地址";
            // 
            // SourceText
            // 
            this.SourceText.Location = new System.Drawing.Point(30, 110);
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(400, 23);
            this.SourceText.TabIndex = 5;
            // 
            // BaseText
            // 
            this.BaseText.Location = new System.Drawing.Point(30, 175);
            this.BaseText.Name = "BaseText";
            this.BaseText.Size = new System.Drawing.Size(400, 23);
            this.BaseText.TabIndex = 6;
            // 
            // TargetText
            // 
            this.TargetText.Location = new System.Drawing.Point(30, 235);
            this.TargetText.Name = "TargetText";
            this.TargetText.Size = new System.Drawing.Size(400, 23);
            this.TargetText.TabIndex = 7;
            // 
            // SourceBtn
            // 
            this.SourceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(48)))), ((int)(((byte)(160)))));
            this.SourceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SourceBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourceBtn.ForeColor = System.Drawing.Color.White;
            this.SourceBtn.Location = new System.Drawing.Point(450, 108);
            this.SourceBtn.Name = "SourceBtn";
            this.SourceBtn.Size = new System.Drawing.Size(75, 25);
            this.SourceBtn.TabIndex = 8;
            this.SourceBtn.Text = "浏览";
            this.SourceBtn.UseVisualStyleBackColor = false;
            this.SourceBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // BaseBtn
            // 
            this.BaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(48)))), ((int)(((byte)(160)))));
            this.BaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaseBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseBtn.ForeColor = System.Drawing.Color.White;
            this.BaseBtn.Location = new System.Drawing.Point(450, 173);
            this.BaseBtn.Name = "BaseBtn";
            this.BaseBtn.Size = new System.Drawing.Size(75, 25);
            this.BaseBtn.TabIndex = 9;
            this.BaseBtn.Text = "浏览";
            this.BaseBtn.UseVisualStyleBackColor = false;
            this.BaseBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // TargetBtn
            // 
            this.TargetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(48)))), ((int)(((byte)(160)))));
            this.TargetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TargetBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TargetBtn.ForeColor = System.Drawing.Color.White;
            this.TargetBtn.Location = new System.Drawing.Point(450, 233);
            this.TargetBtn.Name = "TargetBtn";
            this.TargetBtn.Size = new System.Drawing.Size(75, 25);
            this.TargetBtn.TabIndex = 10;
            this.TargetBtn.Text = "浏览";
            this.TargetBtn.UseVisualStyleBackColor = false;
            this.TargetBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // ResultListbox
            // 
            this.ResultListbox.FormattingEnabled = true;
            this.ResultListbox.HorizontalScrollbar = true;
            this.ResultListbox.ItemHeight = 17;
            this.ResultListbox.Location = new System.Drawing.Point(30, 295);
            this.ResultListbox.Name = "ResultListbox";
            this.ResultListbox.Size = new System.Drawing.Size(495, 242);
            this.ResultListbox.TabIndex = 11;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResultLabel.Location = new System.Drawing.Point(28, 270);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(84, 19);
            this.ResultLabel.TabIndex = 12;
            this.ResultLabel.Text = "Result | 结果";
            // 
            // PackageBtn
            // 
            this.PackageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(48)))), ((int)(((byte)(160)))));
            this.PackageBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PackageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PackageBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PackageBtn.ForeColor = System.Drawing.Color.White;
            this.PackageBtn.Location = new System.Drawing.Point(0, 560);
            this.PackageBtn.Name = "PackageBtn";
            this.PackageBtn.Size = new System.Drawing.Size(570, 40);
            this.PackageBtn.TabIndex = 13;
            this.PackageBtn.Text = "Package | 打包";
            this.PackageBtn.UseVisualStyleBackColor = false;
            this.PackageBtn.Click += new System.EventHandler(this.PackageBtn_Click);
            // 
            // despSourceLabel
            // 
            this.despSourceLabel.AutoSize = true;
            this.despSourceLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.despSourceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.despSourceLabel.Location = new System.Drawing.Point(190, 81);
            this.despSourceLabel.Name = "despSourceLabel";
            this.despSourceLabel.Size = new System.Drawing.Size(136, 17);
            this.despSourceLabel.TabIndex = 14;
            this.despSourceLabel.Text = "项目 WebContent 地址";
            // 
            // BasePathLabel
            // 
            this.BasePathLabel.AutoSize = true;
            this.BasePathLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BasePathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.BasePathLabel.Location = new System.Drawing.Point(190, 151);
            this.BasePathLabel.Name = "BasePathLabel";
            this.BasePathLabel.Size = new System.Drawing.Size(140, 17);
            this.BasePathLabel.TabIndex = 15;
            this.BasePathLabel.Text = "需要比对的基础版本地址";
            // 
            // TargetPathDespLabel
            // 
            this.TargetPathDespLabel.AutoSize = true;
            this.TargetPathDespLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TargetPathDespLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.TargetPathDespLabel.Location = new System.Drawing.Point(190, 211);
            this.TargetPathDespLabel.Name = "TargetPathDespLabel";
            this.TargetPathDespLabel.Size = new System.Drawing.Size(224, 17);
            this.TargetPathDespLabel.TabIndex = 16;
            this.TargetPathDespLabel.Text = "打包目标的路径（会自动创建日期版本）";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(120, 272);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(170, 17);
            this.totalLabel.TabIndex = 17;
            this.totalLabel.Text = "共 0 / 0 个文件，0 / 0 个文件";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(570, 600);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.TargetPathDespLabel);
            this.Controls.Add(this.BasePathLabel);
            this.Controls.Add(this.despSourceLabel);
            this.Controls.Add(this.PackageBtn);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultListbox);
            this.Controls.Add(this.TargetBtn);
            this.Controls.Add(this.BaseBtn);
            this.Controls.Add(this.SourceBtn);
            this.Controls.Add(this.TargetText);
            this.Controls.Add(this.BaseText);
            this.Controls.Add(this.SourceText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(570, 600);
            this.MinimumSize = new System.Drawing.Size(570, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Java Web Packager";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calc_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Calc_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Calc_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.TextBox BaseText;
        private System.Windows.Forms.TextBox TargetText;
        private System.Windows.Forms.Button SourceBtn;
        private System.Windows.Forms.Button BaseBtn;
        private System.Windows.Forms.Button TargetBtn;
        private System.Windows.Forms.ListBox ResultListbox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button PackageBtn;
        private System.Windows.Forms.Label despSourceLabel;
        private System.Windows.Forms.Label BasePathLabel;
        private System.Windows.Forms.Label TargetPathDespLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}


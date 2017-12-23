namespace 图片查看器
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBoxView = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.auto = new System.Windows.Forms.RadioButton();
            this.otu = new System.Windows.Forms.RadioButton();
            this.perf = new System.Windows.Forms.RadioButton();
            this.mid = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxView
            // 
            this.picBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxView.Location = new System.Drawing.Point(6, 6);
            this.picBoxView.Name = "picBoxView";
            this.picBoxView.Size = new System.Drawing.Size(310, 244);
            this.picBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxView.TabIndex = 0;
            this.picBoxView.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpen.Location = new System.Drawing.Point(12, 264);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(47, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "打开图片";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPre
            // 
            this.btnPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPre.Image = ((System.Drawing.Image)(resources.GetObject("btnPre.Image")));
            this.btnPre.Location = new System.Drawing.Point(90, 264);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(47, 23);
            this.btnPre.TabIndex = 8;
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(168, 264);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(47, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(372, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "中值滤波",
            "平滑去噪",
            "去除白边",
            "去除干扰",
            "抽取骨架",
            "倾斜矫正"});
            this.checkedListBox1.Location = new System.Drawing.Point(684, 6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(85, 116);
            this.checkedListBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "二值化:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(607, 190);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 21);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(607, 229);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(41, 21);
            this.numericUpDown2.TabIndex = 18;
            this.numericUpDown2.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.Location = new System.Drawing.Point(436, 188);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(71, 16);
            this.auto.TabIndex = 20;
            this.auto.Text = "自动阈值";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.CheckedChanged += new System.EventHandler(this.mid_CheckedChanged);
            // 
            // otu
            // 
            this.otu.AutoSize = true;
            this.otu.Checked = true;
            this.otu.Location = new System.Drawing.Point(436, 234);
            this.otu.Name = "otu";
            this.otu.Size = new System.Drawing.Size(71, 16);
            this.otu.TabIndex = 21;
            this.otu.TabStop = true;
            this.otu.Text = "大津算法";
            this.otu.UseVisualStyleBackColor = true;
            this.otu.CheckedChanged += new System.EventHandler(this.mid_CheckedChanged);
            // 
            // perf
            // 
            this.perf.AutoSize = true;
            this.perf.Location = new System.Drawing.Point(535, 234);
            this.perf.Name = "perf";
            this.perf.Size = new System.Drawing.Size(71, 16);
            this.perf.TabIndex = 22;
            this.perf.Text = "指定阈值";
            this.perf.UseVisualStyleBackColor = true;
            this.perf.CheckedChanged += new System.EventHandler(this.mid_CheckedChanged);
            // 
            // mid
            // 
            this.mid.AutoSize = true;
            this.mid.Location = new System.Drawing.Point(535, 188);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(71, 16);
            this.mid.TabIndex = 23;
            this.mid.Text = "中值差值";
            this.mid.UseVisualStyleBackColor = true;
            this.mid.CheckedChanged += new System.EventHandler(this.mid_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "识别结果:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(684, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 21);
            this.textBox1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(798, 299);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.perf);
            this.Controls.Add(this.otu);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picBoxView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "验证码识别例子";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxView;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RadioButton auto;
        private System.Windows.Forms.RadioButton otu;
        private System.Windows.Forms.RadioButton perf;
        private System.Windows.Forms.RadioButton mid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


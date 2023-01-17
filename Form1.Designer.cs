namespace ImageGrayscaleBrightenedEdge
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.checkBoxChangeBrightness = new System.Windows.Forms.CheckBox();
            this.trackBarBoundaryValue = new System.Windows.Forms.TrackBar();
            this.checkBoxChangeBoundaryValue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBoundaryValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(350, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(323, 296);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "グレイスケール";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.LargeChange = 20;
            this.trackBarBrightness.Location = new System.Drawing.Point(313, 316);
            this.trackBarBrightness.Maximum = 128;
            this.trackBarBrightness.Minimum = -128;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(360, 45);
            this.trackBarBrightness.TabIndex = 3;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            this.trackBarBrightness.ValueChanged += new System.EventHandler(this.trackBarBrightness_ValueChanged);
            this.trackBarBrightness.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trackBarBrightness_KeyDown);
            // 
            // checkBoxChangeBrightness
            // 
            this.checkBoxChangeBrightness.AutoSize = true;
            this.checkBoxChangeBrightness.Location = new System.Drawing.Point(218, 330);
            this.checkBoxChangeBrightness.Name = "checkBoxChangeBrightness";
            this.checkBoxChangeBrightness.Size = new System.Drawing.Size(77, 16);
            this.checkBoxChangeBrightness.TabIndex = 4;
            this.checkBoxChangeBrightness.Text = "明るさ変更";
            this.checkBoxChangeBrightness.UseVisualStyleBackColor = true;
            this.checkBoxChangeBrightness.CheckedChanged += new System.EventHandler(this.checkBoxChangeBrightness_CheckedChanged);
            // 
            // trackBarBoundaryValue
            // 
            this.trackBarBoundaryValue.LargeChange = 3;
            this.trackBarBoundaryValue.Location = new System.Drawing.Point(313, 356);
            this.trackBarBoundaryValue.Maximum = 50;
            this.trackBarBoundaryValue.Name = "trackBarBoundaryValue";
            this.trackBarBoundaryValue.Size = new System.Drawing.Size(360, 45);
            this.trackBarBoundaryValue.TabIndex = 6;
            this.trackBarBoundaryValue.ValueChanged += new System.EventHandler(this.trackBarBoundaryValue_ValueChanged);
            this.trackBarBoundaryValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trackBarBoundaryValue_KeyDown);
            // 
            // checkBoxChangeBoundaryValue
            // 
            this.checkBoxChangeBoundaryValue.AutoSize = true;
            this.checkBoxChangeBoundaryValue.Location = new System.Drawing.Point(218, 370);
            this.checkBoxChangeBoundaryValue.Name = "checkBoxChangeBoundaryValue";
            this.checkBoxChangeBoundaryValue.Size = new System.Drawing.Size(84, 16);
            this.checkBoxChangeBoundaryValue.TabIndex = 7;
            this.checkBoxChangeBoundaryValue.Text = "境界値変更";
            this.checkBoxChangeBoundaryValue.UseVisualStyleBackColor = true;
            this.checkBoxChangeBoundaryValue.CheckedChanged += new System.EventHandler(this.checkBoxChangeBoundaryValue_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 421);
            this.Controls.Add(this.checkBoxChangeBoundaryValue);
            this.Controls.Add(this.trackBarBoundaryValue);
            this.Controls.Add(this.checkBoxChangeBrightness);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBoundaryValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.CheckBox checkBoxChangeBrightness;
        private System.Windows.Forms.TrackBar trackBarBoundaryValue;
        private System.Windows.Forms.CheckBox checkBoxChangeBoundaryValue;
    }
}


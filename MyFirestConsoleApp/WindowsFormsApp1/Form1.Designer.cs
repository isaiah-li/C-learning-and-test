namespace WindowsFormsApp1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxshowhello = new System.Windows.Forms.TextBox();
            this.buttonsayhello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxshowhello
            // 
            this.textBoxshowhello.Location = new System.Drawing.Point(153, 42);
            this.textBoxshowhello.Name = "textBoxshowhello";
            this.textBoxshowhello.Size = new System.Drawing.Size(296, 25);
            this.textBoxshowhello.TabIndex = 0;
            this.textBoxshowhello.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonsayhello
            // 
            this.buttonsayhello.Location = new System.Drawing.Point(153, 94);
            this.buttonsayhello.Name = "buttonsayhello";
            this.buttonsayhello.Size = new System.Drawing.Size(296, 79);
            this.buttonsayhello.TabIndex = 1;
            this.buttonsayhello.Text = "Click Me";
            this.buttonsayhello.UseVisualStyleBackColor = true;
            this.buttonsayhello.Click += new System.EventHandler(this.buttonsayhello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 395);
            this.Controls.Add(this.buttonsayhello);
            this.Controls.Add(this.textBoxshowhello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxshowhello;
        private System.Windows.Forms.Button buttonsayhello;
    }
}


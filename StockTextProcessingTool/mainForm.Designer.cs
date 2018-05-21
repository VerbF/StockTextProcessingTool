namespace StockTextProcessingTool
{
    partial class mainForm
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
            this.confirmBtn = new System.Windows.Forms.Button();
            this.resultRTextBox = new System.Windows.Forms.RichTextBox();
            this.filePathTextbox = new System.Windows.Forms.TextBox();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(202, 328);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 27);
            this.confirmBtn.TabIndex = 0;
            this.confirmBtn.Text = "确定";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // resultRTextBox
            // 
            this.resultRTextBox.Location = new System.Drawing.Point(574, 12);
            this.resultRTextBox.Name = "resultRTextBox";
            this.resultRTextBox.Size = new System.Drawing.Size(747, 618);
            this.resultRTextBox.TabIndex = 1;
            this.resultRTextBox.Text = "";
            // 
            // filePathTextbox
            // 
            this.filePathTextbox.Location = new System.Drawing.Point(35, 190);
            this.filePathTextbox.Name = "filePathTextbox";
            this.filePathTextbox.Size = new System.Drawing.Size(296, 25);
            this.filePathTextbox.TabIndex = 2;
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Location = new System.Drawing.Point(337, 190);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(122, 25);
            this.chooseFileBtn.TabIndex = 3;
            this.chooseFileBtn.Text = "选择文本文件";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.chooseFileBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 637);
            this.Controls.Add(this.chooseFileBtn);
            this.Controls.Add(this.filePathTextbox);
            this.Controls.Add(this.resultRTextBox);
            this.Controls.Add(this.confirmBtn);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.RichTextBox resultRTextBox;
        private System.Windows.Forms.TextBox filePathTextbox;
        private System.Windows.Forms.Button chooseFileBtn;
    }
}


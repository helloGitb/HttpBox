namespace HttpBox
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
            this.buttonRequest = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPost = new System.Windows.Forms.CheckBox();
            this.checkBoxHex = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(492, 368);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonRequest.TabIndex = 0;
            this.buttonRequest.Text = "Request";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(79, 71);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(488, 98);
            this.textBoxInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL:";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(79, 20);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(488, 21);
            this.textBoxUrl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input:";
            // 
            // checkBoxPost
            // 
            this.checkBoxPost.AutoSize = true;
            this.checkBoxPost.Location = new System.Drawing.Point(79, 372);
            this.checkBoxPost.Name = "checkBoxPost";
            this.checkBoxPost.Size = new System.Drawing.Size(48, 16);
            this.checkBoxPost.TabIndex = 5;
            this.checkBoxPost.Text = "POST";
            this.checkBoxPost.UseVisualStyleBackColor = true;
            // 
            // checkBoxHex
            // 
            this.checkBoxHex.AutoSize = true;
            this.checkBoxHex.Location = new System.Drawing.Point(158, 372);
            this.checkBoxHex.Name = "checkBoxHex";
            this.checkBoxHex.Size = new System.Drawing.Size(66, 16);
            this.checkBoxHex.TabIndex = 6;
            this.checkBoxHex.Text = "SendHex";
            this.checkBoxHex.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Response:";
            // 
            // textBoxResp
            // 
            this.textBoxResp.Location = new System.Drawing.Point(79, 217);
            this.textBoxResp.Multiline = true;
            this.textBoxResp.Name = "textBoxResp";
            this.textBoxResp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResp.Size = new System.Drawing.Size(488, 125);
            this.textBoxResp.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 417);
            this.Controls.Add(this.textBoxResp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxHex);
            this.Controls.Add(this.checkBoxPost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonRequest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPost;
        private System.Windows.Forms.CheckBox checkBoxHex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResp;
    }
}


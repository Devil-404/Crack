namespace Crack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userControlCrack1 = new Crack.UserControlCrack();
            this.userControldownload1 = new Crack.UserControldownload();
            this.SuspendLayout();
            // 
            // userControlCrack1
            // 
            this.userControlCrack1.BackColor = System.Drawing.Color.Transparent;
            this.userControlCrack1.Location = new System.Drawing.Point(13, 12);
            this.userControlCrack1.Name = "userControlCrack1";
            this.userControlCrack1.SfoPath = null;
            this.userControlCrack1.Size = new System.Drawing.Size(372, 204);
            this.userControlCrack1.TabIndex = 2;
            this.userControlCrack1.UserPath = "C:\\Users\\Devil\\.IntelliJIdea2019.3\\config\\";
            // 
            // userControldownload1
            // 
            this.userControldownload1.BackColor = System.Drawing.Color.Transparent;
            this.userControldownload1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userControldownload1.GbText = null;
            this.userControldownload1.Location = new System.Drawing.Point(12, 213);
            this.userControldownload1.Name = "userControldownload1";
            this.userControldownload1.Size = new System.Drawing.Size(372, 265);
            this.userControldownload1.TabIndex = 1;
            this.userControldownload1.Uurl = "https://download.jetbrains.8686c.com/idea/ideaIU-2019.3.3.exe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(397, 496);
            this.Controls.Add(this.userControlCrack1);
            this.Controls.Add(this.userControldownload1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControldownload userControldownload1;
        private UserControlCrack userControlCrack1;
    }
}


namespace BrainSecurity
{
    partial class StartForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_set = new System.Windows.Forms.Button();
            this.button_cer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_set
            // 
            this.button_set.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_set.Font = new System.Drawing.Font("굴림", 15F);
            this.button_set.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_set.Location = new System.Drawing.Point(728, 200);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(200, 100);
            this.button_set.TabIndex = 0;
            this.button_set.Text = "사용자 설정";
            this.button_set.UseVisualStyleBackColor = false;
            this.button_set.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cer
            // 
            this.button_cer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_cer.Font = new System.Drawing.Font("굴림", 15F);
            this.button_cer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cer.Location = new System.Drawing.Point(728, 306);
            this.button_cer.Name = "button_cer";
            this.button_cer.Size = new System.Drawing.Size(200, 100);
            this.button_cer.TabIndex = 1;
            this.button_cer.Text = "사용자 인증";
            this.button_cer.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 29F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brain Security";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cer);
            this.Controls.Add(this.button_set);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "뇌파 기반 사용자 인증 시스템";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.Button button_cer;
        private System.Windows.Forms.Label label1;
    }
}


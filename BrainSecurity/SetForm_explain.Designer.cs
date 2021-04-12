namespace BrainSecurity
{
    partial class SetForm_explain
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
            this.label1 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 19F);
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1042, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "설정을 위한 슬라이드쇼가 나오니 선택한 숫자 이미지에 집중해 주세요!";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(348, 315);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(138, 37);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "준비 됐어요~ !!";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // SetForm_explain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.label1);
            this.Name = "SetForm_explain";
            this.Text = "SetForm_explain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_btn;
    }
}
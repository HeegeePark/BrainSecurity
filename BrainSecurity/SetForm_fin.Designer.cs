namespace BrainSecurity
{
    partial class SetForm_fin
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
            this.yes_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "설정이 완료되었습니다.";
            // 
            // yes_btn
            // 
            this.yes_btn.Location = new System.Drawing.Point(252, 314);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(75, 33);
            this.yes_btn.TabIndex = 1;
            this.yes_btn.Text = "좋아용";
            this.yes_btn.UseVisualStyleBackColor = true;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // no_btn
            // 
            this.no_btn.Location = new System.Drawing.Point(561, 313);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(75, 34);
            this.no_btn.TabIndex = 2;
            this.no_btn.Text = "아니용";
            this.no_btn.UseVisualStyleBackColor = true;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "인증하러 가시겠습니까?";
            // 
            // SetForm_fin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.yes_btn);
            this.Controls.Add(this.label1);
            this.Name = "SetForm_fin";
            this.Text = "SetForm_fin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yes_btn;
        private System.Windows.Forms.Button no_btn;
        private System.Windows.Forms.Label label2;
    }
}
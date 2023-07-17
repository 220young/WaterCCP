namespace WaterCCP
{
    partial class 로그인
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
            this.btnPWChange = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.UserPW = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPWChange
            // 
            this.btnPWChange.Location = new System.Drawing.Point(59, 198);
            this.btnPWChange.Name = "btnPWChange";
            this.btnPWChange.Size = new System.Drawing.Size(117, 30);
            this.btnPWChange.TabIndex = 12;
            this.btnPWChange.Text = "비밀번호 변경";
            this.btnPWChange.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(182, 198);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(98, 30);
            this.btnLogIn.TabIndex = 11;
            this.btnLogIn.Text = "로그인";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(147, 148);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(133, 26);
            this.txtPW.TabIndex = 10;
            // 
            // UserPW
            // 
            this.UserPW.AutoSize = true;
            this.UserPW.Location = new System.Drawing.Point(56, 151);
            this.UserPW.Name = "UserPW";
            this.UserPW.Size = new System.Drawing.Size(81, 16);
            this.UserPW.TabIndex = 9;
            this.UserPW.Text = "비밀번호 :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(147, 107);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(133, 26);
            this.txtID.TabIndex = 8;
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(56, 110);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(83, 16);
            this.UserID.TabIndex = 7;
            this.UserID.Text = "사용자 ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(119, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "로그인";
            // 
            // 로그인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(336, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPWChange);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.UserPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.UserID);
            this.Name = "로그인";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPWChange;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label UserPW;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label label1;
    }
}
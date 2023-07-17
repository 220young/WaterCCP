namespace WaterCCP
{
    partial class 원자재등록
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
            this.Rad_500 = new System.Windows.Forms.RadioButton();
            this.Rad_1000 = new System.Windows.Forms.RadioButton();
            this.Rad_250 = new System.Windows.Forms.RadioButton();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Num_Regi = new System.Windows.Forms.NumericUpDown();
            this.PetCap = new System.Windows.Forms.Label();
            this.CodeNum = new System.Windows.Forms.Label();
            this.Regi_Date = new System.Windows.Forms.DateTimePicker();
            this.btnRegi = new System.Windows.Forms.Button();
            this.Regi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Regi)).BeginInit();
            this.SuspendLayout();
            // 
            // Rad_500
            // 
            this.Rad_500.AutoSize = true;
            this.Rad_500.Location = new System.Drawing.Point(168, 178);
            this.Rad_500.Name = "Rad_500";
            this.Rad_500.Size = new System.Drawing.Size(68, 20);
            this.Rad_500.TabIndex = 43;
            this.Rad_500.TabStop = true;
            this.Rad_500.Text = "500ml";
            this.Rad_500.UseVisualStyleBackColor = true;
            // 
            // Rad_1000
            // 
            this.Rad_1000.AutoSize = true;
            this.Rad_1000.Location = new System.Drawing.Point(254, 178);
            this.Rad_1000.Name = "Rad_1000";
            this.Rad_1000.Size = new System.Drawing.Size(76, 20);
            this.Rad_1000.TabIndex = 42;
            this.Rad_1000.TabStop = true;
            this.Rad_1000.Text = "1000ml";
            this.Rad_1000.UseVisualStyleBackColor = true;
            // 
            // Rad_250
            // 
            this.Rad_250.AutoSize = true;
            this.Rad_250.Location = new System.Drawing.Point(80, 178);
            this.Rad_250.Name = "Rad_250";
            this.Rad_250.Size = new System.Drawing.Size(68, 20);
            this.Rad_250.TabIndex = 41;
            this.Rad_250.TabStop = true;
            this.Rad_250.Text = "250ml";
            this.Rad_250.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(80, 275);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(91, 26);
            this.txtCode.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "개";
            // 
            // Num_Regi
            // 
            this.Num_Regi.Location = new System.Drawing.Point(213, 217);
            this.Num_Regi.Name = "Num_Regi";
            this.Num_Regi.Size = new System.Drawing.Size(84, 26);
            this.Num_Regi.TabIndex = 38;
            // 
            // PetCap
            // 
            this.PetCap.AutoSize = true;
            this.PetCap.Location = new System.Drawing.Point(77, 150);
            this.PetCap.Name = "PetCap";
            this.PetCap.Size = new System.Drawing.Size(85, 16);
            this.PetCap.TabIndex = 37;
            this.PetCap.Text = "PET + CAP";
            // 
            // CodeNum
            // 
            this.CodeNum.AutoSize = true;
            this.CodeNum.Location = new System.Drawing.Point(77, 247);
            this.CodeNum.Name = "CodeNum";
            this.CodeNum.Size = new System.Drawing.Size(71, 16);
            this.CodeNum.TabIndex = 36;
            this.CodeNum.Text = "분류번호";
            // 
            // Regi_Date
            // 
            this.Regi_Date.Location = new System.Drawing.Point(97, 104);
            this.Regi_Date.Name = "Regi_Date";
            this.Regi_Date.Size = new System.Drawing.Size(200, 26);
            this.Regi_Date.TabIndex = 35;
            // 
            // btnRegi
            // 
            this.btnRegi.Location = new System.Drawing.Point(221, 275);
            this.btnRegi.Name = "btnRegi";
            this.btnRegi.Size = new System.Drawing.Size(101, 56);
            this.btnRegi.TabIndex = 34;
            this.btnRegi.Text = "등록";
            this.btnRegi.UseVisualStyleBackColor = true;
            // 
            // Regi
            // 
            this.Regi.AutoSize = true;
            this.Regi.Font = new System.Drawing.Font("문체부 돋음체", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Regi.Location = new System.Drawing.Point(140, 66);
            this.Regi.Name = "Regi";
            this.Regi.Size = new System.Drawing.Size(132, 23);
            this.Regi.TabIndex = 33;
            this.Regi.Text = "원자재 등록";
            // 
            // 원자재등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(406, 396);
            this.Controls.Add(this.Rad_500);
            this.Controls.Add(this.Rad_1000);
            this.Controls.Add(this.Rad_250);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Num_Regi);
            this.Controls.Add(this.PetCap);
            this.Controls.Add(this.CodeNum);
            this.Controls.Add(this.Regi_Date);
            this.Controls.Add(this.btnRegi);
            this.Controls.Add(this.Regi);
            this.Name = "원자재등록";
            this.Text = "원자재등록";
            ((System.ComponentModel.ISupportInitialize)(this.Num_Regi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rad_500;
        private System.Windows.Forms.RadioButton Rad_1000;
        private System.Windows.Forms.RadioButton Rad_250;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Num_Regi;
        private System.Windows.Forms.Label PetCap;
        private System.Windows.Forms.Label CodeNum;
        private System.Windows.Forms.DateTimePicker Regi_Date;
        private System.Windows.Forms.Button btnRegi;
        private System.Windows.Forms.Label Regi;
    }
}
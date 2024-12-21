namespace Buoi4
{
    partial class form2
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
            this.txtmsnv = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.MaskedTextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.btndongy = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmsnv
            // 
            this.txtmsnv.Location = new System.Drawing.Point(148, 42);
            this.txtmsnv.Name = "txtmsnv";
            this.txtmsnv.Size = new System.Drawing.Size(100, 20);
            this.txtmsnv.TabIndex = 0;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(148, 86);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(100, 20);
            this.txttennv.TabIndex = 1;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(148, 131);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(100, 20);
            this.txtluong.TabIndex = 2;
            // 
            // btndongy
            // 
            this.btndongy.Location = new System.Drawing.Point(30, 193);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(88, 31);
            this.btndongy.TabIndex = 3;
            this.btndongy.Text = "Đồng ý";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(159, 193);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(89, 31);
            this.btnboqua.TabIndex = 4;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MSNV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lương căn bản:";
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmsnv);
            this.Name = "form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmsnv;
        private System.Windows.Forms.MaskedTextBox txttennv;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
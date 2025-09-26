namespace bai1Tuan1
{
    partial class FrmBai1_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDangNhap = new Button();
            chkNho = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            btnXoa = new Button();
            btnDung = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(182, 381);
            btnDangNhap.Margin = new Padding(4, 4, 4, 4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(141, 37);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Location = new Point(182, 262);
            chkNho.Margin = new Padding(4, 4, 4, 4);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(110, 30);
            chkNho.TabIndex = 1;
            chkNho.Text = "Ghi nhớ";
            chkNho.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 107);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 26);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 26);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(532, 381);
            btnXoa.Margin = new Padding(4, 4, 4, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(141, 37);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnDung
            // 
            btnDung.Location = new Point(885, 381);
            btnDung.Margin = new Padding(4, 4, 4, 4);
            btnDung.Name = "btnDung";
            btnDung.Size = new Size(141, 37);
            btnDung.TabIndex = 5;
            btnDung.Text = "Dừng";
            btnDung.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(472, 107);
            txtUser.Margin = new Padding(4, 4, 4, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(186, 33);
            txtUser.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(472, 187);
            txtPass.Margin = new Padding(4, 4, 4, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(186, 33);
            txtPass.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 562);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnDung);
            Controls.Add(btnXoa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkNho);
            Controls.Add(btnDangNhap);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form Đăng Nhập";
         
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangNhap;
        private CheckBox chkNho;
        private Label label1;
        private Label label2;
        private Button btnXoa;
        private Button btnDung;
        private TextBox txtUser;
        private TextBox txtPass;
    }
}

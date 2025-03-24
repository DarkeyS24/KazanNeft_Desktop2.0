namespace KazanNeft_Destop
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            cancelBtn = new Button();
            okBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            passwordTxt = new TextBox();
            userTxt = new TextBox();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(226, 35, 26);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 84);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 92, 185);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(cancelBtn);
            panel2.Controls.Add(okBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(passwordTxt);
            panel2.Controls.Add(userTxt);
            panel2.Font = new Font("Myriad Pro", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(396, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(587, 422);
            panel2.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(304, 236);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(186, 32);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += OnCheckedChangeToShowPassword;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(226, 35, 26);
            cancelBtn.Font = new Font("Myriad Pro", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(82, 293);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(150, 40);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += OnCancelBtnClickedToClose;
            // 
            // okBtn
            // 
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.Font = new Font("Myriad Pro", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            okBtn.ForeColor = Color.White;
            okBtn.Location = new Point(340, 293);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(150, 40);
            okBtn.TabIndex = 4;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += OnOkBtnClickedToOtherForm;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Myriad Pro", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(90, 179);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 3;
            label2.Text = "Password: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myriad Pro", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 111);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 2;
            label1.Text = "Username: ";
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Myriad Pro", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Location = new Point(213, 176);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '•';
            passwordTxt.Size = new Size(277, 35);
            passwordTxt.TabIndex = 1;
            // 
            // userTxt
            // 
            userTxt.Font = new Font("Myriad Pro", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTxt.Location = new Point(213, 108);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(277, 35);
            userTxt.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 370);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox passwordTxt;
        private TextBox userTxt;
        private PictureBox pictureBox1;
        private Button cancelBtn;
        private Button okBtn;
        private CheckBox checkBox1;
    }
}

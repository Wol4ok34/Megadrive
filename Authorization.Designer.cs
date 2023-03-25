namespace Мегадрайф
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoauthorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AuthorButton = new System.Windows.Forms.Button();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.NoauthorButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 139);
            this.panel1.TabIndex = 0;
            // 
            // NoauthorButton
            // 
            this.NoauthorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.NoauthorButton.Location = new System.Drawing.Point(14, 53);
            this.NoauthorButton.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.NoauthorButton.Name = "NoauthorButton";
            this.NoauthorButton.Size = new System.Drawing.Size(125, 69);
            this.NoauthorButton.TabIndex = 1;
            this.NoauthorButton.Text = "Вход для гостя";
            this.NoauthorButton.UseVisualStyleBackColor = false;
            this.NoauthorButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Компания «Мегадрайв» ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.AuthorButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 359);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 133);
            this.panel2.TabIndex = 1;
            // 
            // AuthorButton
            // 
            this.AuthorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.AuthorButton.Location = new System.Drawing.Point(184, 37);
            this.AuthorButton.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.AuthorButton.Name = "AuthorButton";
            this.AuthorButton.Size = new System.Drawing.Size(175, 63);
            this.AuthorButton.TabIndex = 0;
            this.AuthorButton.Text = "Авторизация";
            this.AuthorButton.UseVisualStyleBackColor = false;
            this.AuthorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(199, 183);
            this.LoginTB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(142, 30);
            this.LoginTB.TabIndex = 2;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(199, 266);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(142, 30);
            this.PasswordTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Мегадрайф.Properties.Resources.логотип;
            this.pictureBox1.Location = new System.Drawing.Point(420, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authenficazia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NoauthorButton;
        private System.Windows.Forms.Button AuthorButton;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


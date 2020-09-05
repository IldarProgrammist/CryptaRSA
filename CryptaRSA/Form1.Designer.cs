namespace CryptaRSA
{
    partial class Form1
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
            this.LoginTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.passWordTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(151, 79);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(228, 23);
            this.LoginTB.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Логин:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(151, 162);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(228, 43);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Сохранить";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // passWordTB
            // 
            this.passWordTB.Location = new System.Drawing.Point(151, 119);
            this.passWordTB.Name = "passWordTB";
            this.passWordTB.Size = new System.Drawing.Size(228, 23);
            this.passWordTB.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 123);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Пароль:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 270);
            this.Controls.Add(this.passWordTB);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox LoginTB;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox passWordTB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}


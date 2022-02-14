namespace GetProcess
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
            this.ProcessNameText = new System.Windows.Forms.TextBox();
            this.GetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProcessNameText
            // 
            this.ProcessNameText.Location = new System.Drawing.Point(283, 133);
            this.ProcessNameText.Multiline = true;
            this.ProcessNameText.Name = "ProcessNameText";
            this.ProcessNameText.Size = new System.Drawing.Size(178, 70);
            this.ProcessNameText.TabIndex = 0;
            // 
            // GetBtn
            // 
            this.GetBtn.Location = new System.Drawing.Point(333, 239);
            this.GetBtn.Name = "GetBtn";
            this.GetBtn.Size = new System.Drawing.Size(75, 23);
            this.GetBtn.TabIndex = 1;
            this.GetBtn.Text = "Получить";
            this.GetBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetBtn);
            this.Controls.Add(this.ProcessNameText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProcessNameText;
        private System.Windows.Forms.Button GetBtn;
    }
}



namespace forms_arrays_CPC
{
    partial class MainForm
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
            this.nextFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextFormButton
            // 
            this.nextFormButton.Location = new System.Drawing.Point(67, 30);
            this.nextFormButton.Name = "nextFormButton";
            this.nextFormButton.Size = new System.Drawing.Size(328, 69);
            this.nextFormButton.TabIndex = 0;
            this.nextFormButton.Text = "Далее";
            this.nextFormButton.UseVisualStyleBackColor = true;
            this.nextFormButton.Click += new System.EventHandler(this.nextFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 127);
            this.Controls.Add(this.nextFormButton);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "MainForm";
            this.Text = "Многооконные приложения";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextFormButton;
    }
}



namespace forms_arrays_CPC
{
    partial class Form2
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
            this.sourceListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.negativesListBox = new System.Windows.Forms.ListBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceListBox
            // 
            this.sourceListBox.FormattingEnabled = true;
            this.sourceListBox.ItemHeight = 31;
            this.sourceListBox.Location = new System.Drawing.Point(16, 83);
            this.sourceListBox.Margin = new System.Windows.Forms.Padding(7);
            this.sourceListBox.Name = "sourceListBox";
            this.sourceListBox.Size = new System.Drawing.Size(246, 97);
            this.sourceListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный массив";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отсортированный";
            // 
            // negativesListBox
            // 
            this.negativesListBox.FormattingEnabled = true;
            this.negativesListBox.ItemHeight = 31;
            this.negativesListBox.Location = new System.Drawing.Point(284, 83);
            this.negativesListBox.Margin = new System.Windows.Forms.Padding(7);
            this.negativesListBox.Name = "negativesListBox";
            this.negativesListBox.Size = new System.Drawing.Size(246, 97);
            this.negativesListBox.TabIndex = 2;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(16, 230);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(245, 55);
            this.goBackButton.TabIndex = 4;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 314);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.negativesListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceListBox);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form2";
            this.Text = "Задание 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sourceListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox negativesListBox;
        private System.Windows.Forms.Button goBackButton;
    }
}
namespace AADS_LR2_Task2
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.btnFindWords = new System.Windows.Forms.Button();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(17, 39);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(525, 29);
            this.txtInput.TabIndex = 0;
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(287, 83);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(70, 29);
            this.numLength.TabIndex = 1;
            // 
            // btnFindWords
            // 
            this.btnFindWords.Location = new System.Drawing.Point(377, 74);
            this.btnFindWords.Name = "btnFindWords";
            this.btnFindWords.Size = new System.Drawing.Size(165, 48);
            this.btnFindWords.TabIndex = 2;
            this.btnFindWords.Text = "Знайти";
            this.btnFindWords.UseVisualStyleBackColor = true;
            this.btnFindWords.Click += new System.EventHandler(this.btnFindWords_Click);
            // 
            // lstWords
            // 
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 27;
            this.lstWords.Location = new System.Drawing.Point(17, 128);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(525, 193);
            this.lstWords.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введіть слова через пробіл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Довжина слів, які треба знайти:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 346);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstWords);
            this.Controls.Add(this.btnFindWords);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Onest", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошук слів";
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Button btnFindWords;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


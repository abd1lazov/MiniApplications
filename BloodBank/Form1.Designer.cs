namespace project2
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
            this.add = new System.Windows.Forms.Button();
            this.AllRecords = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(110, 125);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(241, 56);
            this.add.TabIndex = 0;
            this.add.Text = "Add Donnor";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // AllRecords
            // 
            this.AllRecords.Location = new System.Drawing.Point(110, 208);
            this.AllRecords.Name = "AllRecords";
            this.AllRecords.Size = new System.Drawing.Size(241, 52);
            this.AllRecords.TabIndex = 1;
            this.AllRecords.Text = "All Records";
            this.AllRecords.UseVisualStyleBackColor = true;
            this.AllRecords.Click += new System.EventHandler(this.AllRecords_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(110, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(241, 52);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.AllRecords);
            this.Controls.Add(this.add);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button AllRecords;
        private System.Windows.Forms.Button btnExit;
    }
}


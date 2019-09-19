namespace тРПО
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FilePath = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Write = new System.Windows.Forms.Button();
            this.tablo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(13, 13);
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Size = new System.Drawing.Size(314, 20);
            this.FilePath.TabIndex = 0;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(334, 11);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(52, 23);
            this.path.TabIndex = 1;
            this.path.Text = "...";
            this.path.UseVisualStyleBackColor = true;
            this.path.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(13, 40);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(314, 20);
            this.TextBox.TabIndex = 2;
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(334, 38);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(52, 23);
            this.Write.TabIndex = 3;
            this.Write.Text = "Write";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // tablo
            // 
            this.tablo.Location = new System.Drawing.Point(13, 67);
            this.tablo.Multiline = true;
            this.tablo.Name = "tablo";
            this.tablo.ReadOnly = true;
            this.tablo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablo.Size = new System.Drawing.Size(373, 176);
            this.tablo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 255);
            this.Controls.Add(this.tablo);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.path);
            this.Controls.Add(this.FilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button path;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.TextBox tablo;
    }
}


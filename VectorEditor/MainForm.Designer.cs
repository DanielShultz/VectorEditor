namespace VectorEditor
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Figure = new System.Windows.Forms.ComboBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.PenSize = new System.Windows.Forms.NumericUpDown();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenSize)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.White;
            this.Picture.Location = new System.Drawing.Point(12, 36);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(615, 372);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.Picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // Figure
            // 
            this.Figure.FormattingEnabled = true;
            this.Figure.Location = new System.Drawing.Point(178, 11);
            this.Figure.Name = "Figure";
            this.Figure.Size = new System.Drawing.Size(121, 21);
            this.Figure.TabIndex = 1;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(12, 12);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(34, 20);
            this.ColorButton.TabIndex = 2;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // PenSize
            // 
            this.PenSize.Location = new System.Drawing.Point(52, 12);
            this.PenSize.Name = "PenSize";
            this.PenSize.Size = new System.Drawing.Size(120, 20);
            this.PenSize.TabIndex = 3;
            this.PenSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(552, 10);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 20);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 420);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.PenSize);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.Figure);
            this.Controls.Add(this.Picture);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.ComboBox Figure;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.NumericUpDown PenSize;
        private System.Windows.Forms.Button Clear;
    }
}


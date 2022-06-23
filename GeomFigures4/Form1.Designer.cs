namespace GeomFigures4
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
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.bColor = new System.Windows.Forms.Button();
            this.bPencil = new System.Windows.Forms.Button();
            this.bEraser = new System.Windows.Forms.Button();
            this.bEllipse = new System.Windows.Forms.Button();
            this.bRectangle = new System.Windows.Forms.Button();
            this.bLine = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bOpen = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bWidthPen = new System.Windows.Forms.NumericUpDown();
            this.bTriangle = new System.Windows.Forms.Button();
            this.bRed = new System.Windows.Forms.Button();
            this.bYellow = new System.Windows.Forms.Button();
            this.bGreen = new System.Windows.Forms.Button();
            this.bCyan = new System.Windows.Forms.Button();
            this.bOrange = new System.Windows.Forms.Button();
            this.bBlack = new System.Windows.Forms.Button();
            this.bWhite = new System.Windows.Forms.Button();
            this.bPurple = new System.Windows.Forms.Button();
            this.ToolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bWidthPen)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ToolPanel.Controls.Add(this.bOrange);
            this.ToolPanel.Controls.Add(this.bBlack);
            this.ToolPanel.Controls.Add(this.bWhite);
            this.ToolPanel.Controls.Add(this.bPurple);
            this.ToolPanel.Controls.Add(this.bCyan);
            this.ToolPanel.Controls.Add(this.bGreen);
            this.ToolPanel.Controls.Add(this.bYellow);
            this.ToolPanel.Controls.Add(this.bRed);
            this.ToolPanel.Controls.Add(this.bTriangle);
            this.ToolPanel.Controls.Add(this.bWidthPen);
            this.ToolPanel.Controls.Add(this.bOpen);
            this.ToolPanel.Controls.Add(this.bSave);
            this.ToolPanel.Controls.Add(this.bClear);
            this.ToolPanel.Controls.Add(this.bLine);
            this.ToolPanel.Controls.Add(this.bRectangle);
            this.ToolPanel.Controls.Add(this.bEllipse);
            this.ToolPanel.Controls.Add(this.bEraser);
            this.ToolPanel.Controls.Add(this.bPencil);
            this.ToolPanel.Controls.Add(this.bColor);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(800, 59);
            this.ToolPanel.TabIndex = 0;
            // 
            // bColor
            // 
            this.bColor.Location = new System.Drawing.Point(324, 7);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(134, 46);
            this.bColor.TabIndex = 0;
            this.bColor.Text = "Own Color";
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // bPencil
            // 
            this.bPencil.Image = ((System.Drawing.Image)(resources.GetObject("bPencil.Image")));
            this.bPencil.Location = new System.Drawing.Point(64, 7);
            this.bPencil.Name = "bPencil";
            this.bPencil.Size = new System.Drawing.Size(46, 46);
            this.bPencil.TabIndex = 2;
            this.bPencil.UseVisualStyleBackColor = true;
            this.bPencil.Click += new System.EventHandler(this.bPencil_Click);
            // 
            // bEraser
            // 
            this.bEraser.Image = ((System.Drawing.Image)(resources.GetObject("bEraser.Image")));
            this.bEraser.Location = new System.Drawing.Point(116, 7);
            this.bEraser.Name = "bEraser";
            this.bEraser.Size = new System.Drawing.Size(46, 46);
            this.bEraser.TabIndex = 3;
            this.bEraser.UseVisualStyleBackColor = true;
            this.bEraser.Click += new System.EventHandler(this.bEraser_Click);
            // 
            // bEllipse
            // 
            this.bEllipse.Image = ((System.Drawing.Image)(resources.GetObject("bEllipse.Image")));
            this.bEllipse.Location = new System.Drawing.Point(168, 7);
            this.bEllipse.Name = "bEllipse";
            this.bEllipse.Size = new System.Drawing.Size(46, 46);
            this.bEllipse.TabIndex = 4;
            this.bEllipse.UseVisualStyleBackColor = true;
            this.bEllipse.Click += new System.EventHandler(this.bEllipse_Click);
            // 
            // bRectangle
            // 
            this.bRectangle.Image = ((System.Drawing.Image)(resources.GetObject("bRectangle.Image")));
            this.bRectangle.Location = new System.Drawing.Point(220, 7);
            this.bRectangle.Name = "bRectangle";
            this.bRectangle.Size = new System.Drawing.Size(46, 46);
            this.bRectangle.TabIndex = 5;
            this.bRectangle.UseVisualStyleBackColor = true;
            this.bRectangle.Click += new System.EventHandler(this.bRectangle_Click);
            // 
            // bLine
            // 
            this.bLine.Image = ((System.Drawing.Image)(resources.GetObject("bLine.Image")));
            this.bLine.Location = new System.Drawing.Point(272, 7);
            this.bLine.Name = "bLine";
            this.bLine.Size = new System.Drawing.Size(46, 46);
            this.bLine.TabIndex = 6;
            this.bLine.UseVisualStyleBackColor = true;
            this.bLine.Click += new System.EventHandler(this.bLine_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(464, 7);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(46, 46);
            this.bClear.TabIndex = 7;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(742, 7);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(46, 23);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // Picture
            // 
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.Location = new System.Drawing.Point(0, 59);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(800, 391);
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            this.Picture.Paint += new System.Windows.Forms.PaintEventHandler(this.Picture_Paint);
            this.Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseDown);
            this.Picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseMove);
            this.Picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseUp);
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(742, 29);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(46, 23);
            this.bOpen.TabIndex = 9;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bWidthPen
            // 
            this.bWidthPen.Location = new System.Drawing.Point(666, 10);
            this.bWidthPen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bWidthPen.Name = "bWidthPen";
            this.bWidthPen.Size = new System.Drawing.Size(70, 20);
            this.bWidthPen.TabIndex = 10;
            this.bWidthPen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bWidthPen.ValueChanged += new System.EventHandler(this.bWidthPen_ValueChanged);
            // 
            // bTriangle
            // 
            this.bTriangle.Image = ((System.Drawing.Image)(resources.GetObject("bTriangle.Image")));
            this.bTriangle.Location = new System.Drawing.Point(12, 7);
            this.bTriangle.Name = "bTriangle";
            this.bTriangle.Size = new System.Drawing.Size(46, 46);
            this.bTriangle.TabIndex = 11;
            this.bTriangle.UseVisualStyleBackColor = true;
            this.bTriangle.Click += new System.EventHandler(this.bTriangle_Click);
            // 
            // bRed
            // 
            this.bRed.BackColor = System.Drawing.Color.Red;
            this.bRed.Location = new System.Drawing.Point(516, 10);
            this.bRed.Name = "bRed";
            this.bRed.Size = new System.Drawing.Size(23, 23);
            this.bRed.TabIndex = 12;
            this.bRed.UseVisualStyleBackColor = false;
            this.bRed.Click += new System.EventHandler(this.bRed_Click);
            // 
            // bYellow
            // 
            this.bYellow.BackColor = System.Drawing.Color.Yellow;
            this.bYellow.Location = new System.Drawing.Point(603, 10);
            this.bYellow.Name = "bYellow";
            this.bYellow.Size = new System.Drawing.Size(23, 23);
            this.bYellow.TabIndex = 13;
            this.bYellow.UseVisualStyleBackColor = false;
            this.bYellow.Click += new System.EventHandler(this.bYellow_Click);
            // 
            // bGreen
            // 
            this.bGreen.BackColor = System.Drawing.Color.Lime;
            this.bGreen.Location = new System.Drawing.Point(574, 10);
            this.bGreen.Name = "bGreen";
            this.bGreen.Size = new System.Drawing.Size(23, 23);
            this.bGreen.TabIndex = 14;
            this.bGreen.UseVisualStyleBackColor = false;
            this.bGreen.Click += new System.EventHandler(this.bGreen_Click);
            // 
            // bCyan
            // 
            this.bCyan.BackColor = System.Drawing.Color.Cyan;
            this.bCyan.Location = new System.Drawing.Point(545, 10);
            this.bCyan.Name = "bCyan";
            this.bCyan.Size = new System.Drawing.Size(23, 23);
            this.bCyan.TabIndex = 15;
            this.bCyan.UseVisualStyleBackColor = false;
            this.bCyan.Click += new System.EventHandler(this.bCyan_Click);
            // 
            // bOrange
            // 
            this.bOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bOrange.Location = new System.Drawing.Point(545, 30);
            this.bOrange.Name = "bOrange";
            this.bOrange.Size = new System.Drawing.Size(23, 23);
            this.bOrange.TabIndex = 19;
            this.bOrange.UseVisualStyleBackColor = false;
            this.bOrange.Click += new System.EventHandler(this.bOrange_Click);
            // 
            // bBlack
            // 
            this.bBlack.BackColor = System.Drawing.Color.Black;
            this.bBlack.Location = new System.Drawing.Point(574, 30);
            this.bBlack.Name = "bBlack";
            this.bBlack.Size = new System.Drawing.Size(23, 23);
            this.bBlack.TabIndex = 18;
            this.bBlack.Text = "Red";
            this.bBlack.UseVisualStyleBackColor = false;
            this.bBlack.Click += new System.EventHandler(this.bBlack_Click);
            // 
            // bWhite
            // 
            this.bWhite.BackColor = System.Drawing.Color.White;
            this.bWhite.Location = new System.Drawing.Point(603, 30);
            this.bWhite.Name = "bWhite";
            this.bWhite.Size = new System.Drawing.Size(23, 23);
            this.bWhite.TabIndex = 17;
            this.bWhite.UseVisualStyleBackColor = false;
            this.bWhite.Click += new System.EventHandler(this.bWhite_Click);
            // 
            // bPurple
            // 
            this.bPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bPurple.Location = new System.Drawing.Point(516, 30);
            this.bPurple.Name = "bPurple";
            this.bPurple.Size = new System.Drawing.Size(23, 23);
            this.bPurple.TabIndex = 16;
            this.bPurple.UseVisualStyleBackColor = false;
            this.bPurple.Click += new System.EventHandler(this.bPurple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.ToolPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ToolPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bWidthPen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bLine;
        private System.Windows.Forms.Button bRectangle;
        private System.Windows.Forms.Button bEllipse;
        private System.Windows.Forms.Button bEraser;
        private System.Windows.Forms.Button bPencil;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown bWidthPen;
        private System.Windows.Forms.Button bTriangle;
        private System.Windows.Forms.Button bOrange;
        private System.Windows.Forms.Button bBlack;
        private System.Windows.Forms.Button bWhite;
        private System.Windows.Forms.Button bPurple;
        private System.Windows.Forms.Button bCyan;
        private System.Windows.Forms.Button bGreen;
        private System.Windows.Forms.Button bYellow;
        private System.Windows.Forms.Button bRed;
    }
}


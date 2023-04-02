namespace DrawFigures
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btBorder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btFill = new System.Windows.Forms.Button();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.txbY = new System.Windows.Forms.TextBox();
            this.txbX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btWhite = new System.Windows.Forms.Button();
            this.btBlack = new System.Windows.Forms.Button();
            this.btBlue = new System.Windows.Forms.Button();
            this.btPurple = new System.Windows.Forms.Button();
            this.btGreen = new System.Windows.Forms.Button();
            this.btYellow = new System.Windows.Forms.Button();
            this.btBrown = new System.Windows.Forms.Button();
            this.btRed = new System.Windows.Forms.Button();
            this.btColors = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRectangle = new System.Windows.Forms.ToolStripButton();
            this.tsbEllipse = new System.Windows.Forms.ToolStripButton();
            this.tsbFillRectangle = new System.Windows.Forms.ToolStripButton();
            this.tsbFillEllipse = new System.Windows.Forms.ToolStripButton();
            this.tsbCursor = new System.Windows.Forms.ToolStripButton();
            this.tsbPencil = new System.Windows.Forms.ToolStripButton();
            this.tsbEraiser = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btBorder);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btFill);
            this.panel1.Controls.Add(this.txbHeight);
            this.panel1.Controls.Add(this.txbWidth);
            this.panel1.Controls.Add(this.txbY);
            this.panel1.Controls.Add(this.txbX);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btWhite);
            this.panel1.Controls.Add(this.btBlack);
            this.panel1.Controls.Add(this.btBlue);
            this.panel1.Controls.Add(this.btPurple);
            this.panel1.Controls.Add(this.btGreen);
            this.panel1.Controls.Add(this.btYellow);
            this.panel1.Controls.Add(this.btBrown);
            this.panel1.Controls.Add(this.btRed);
            this.panel1.Controls.Add(this.btColors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 65);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Border";
            // 
            // btBorder
            // 
            this.btBorder.BackColor = System.Drawing.Color.Black;
            this.btBorder.Location = new System.Drawing.Point(605, 2);
            this.btBorder.Name = "btBorder";
            this.btBorder.Size = new System.Drawing.Size(64, 42);
            this.btBorder.TabIndex = 19;
            this.btBorder.UseVisualStyleBackColor = false;
            this.btBorder.Click += new System.EventHandler(this.btBorder_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(699, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Fill";
            // 
            // btFill
            // 
            this.btFill.BackColor = System.Drawing.Color.White;
            this.btFill.Location = new System.Drawing.Point(685, 2);
            this.btFill.Name = "btFill";
            this.btFill.Size = new System.Drawing.Size(58, 41);
            this.btFill.TabIndex = 17;
            this.btFill.UseVisualStyleBackColor = false;
            this.btFill.Click += new System.EventHandler(this.btFill_Click);
            // 
            // txbHeight
            // 
            this.txbHeight.Enabled = false;
            this.txbHeight.Location = new System.Drawing.Point(197, 7);
            this.txbHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(63, 20);
            this.txbHeight.TabIndex = 16;
            this.txbHeight.TextChanged += new System.EventHandler(this.txbHeight_TextChanged);
            this.txbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxs_KeyPress);
            // 
            // txbWidth
            // 
            this.txbWidth.Enabled = false;
            this.txbWidth.Location = new System.Drawing.Point(197, 36);
            this.txbWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(63, 20);
            this.txbWidth.TabIndex = 15;
            this.txbWidth.TextChanged += new System.EventHandler(this.txbWidth_TextChanged);
            this.txbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxs_KeyPress);
            // 
            // txbY
            // 
            this.txbY.Enabled = false;
            this.txbY.Location = new System.Drawing.Point(51, 36);
            this.txbY.Margin = new System.Windows.Forms.Padding(2);
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(63, 20);
            this.txbY.TabIndex = 14;
            this.txbY.TextChanged += new System.EventHandler(this.txbLocation);
            this.txbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxs_KeyPress);
            // 
            // txbX
            // 
            this.txbX.Enabled = false;
            this.txbX.Location = new System.Drawing.Point(52, 7);
            this.txbX.Margin = new System.Windows.Forms.Padding(2);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(63, 20);
            this.txbX.TabIndex = 13;
            this.txbX.TextChanged += new System.EventHandler(this.txbLocation);
            this.txbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxs_KeyPress);
            // 
            // label4
            // 
            this.label4.Image = global::DrawFigures.Properties.Resources.height11;
            this.label4.Location = new System.Drawing.Point(160, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 28);
            this.label4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Image = global::DrawFigures.Properties.Resources.width;
            this.label3.Location = new System.Drawing.Point(160, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y  :  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "X  :  ";
            // 
            // btWhite
            // 
            this.btWhite.BackColor = System.Drawing.Color.White;
            this.btWhite.Location = new System.Drawing.Point(843, 2);
            this.btWhite.Margin = new System.Windows.Forms.Padding(2);
            this.btWhite.Name = "btWhite";
            this.btWhite.Size = new System.Drawing.Size(26, 28);
            this.btWhite.TabIndex = 8;
            this.btWhite.UseVisualStyleBackColor = false;
            this.btWhite.Click += new System.EventHandler(this.MainColors);
            // 
            // btBlack
            // 
            this.btBlack.BackColor = System.Drawing.Color.Black;
            this.btBlack.Location = new System.Drawing.Point(843, 33);
            this.btBlack.Margin = new System.Windows.Forms.Padding(2);
            this.btBlack.Name = "btBlack";
            this.btBlack.Size = new System.Drawing.Size(26, 28);
            this.btBlack.TabIndex = 7;
            this.btBlack.UseVisualStyleBackColor = false;
            this.btBlack.Click += new System.EventHandler(this.MainColors);
            // 
            // btBlue
            // 
            this.btBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btBlue.Location = new System.Drawing.Point(874, 33);
            this.btBlue.Margin = new System.Windows.Forms.Padding(2);
            this.btBlue.Name = "btBlue";
            this.btBlue.Size = new System.Drawing.Size(26, 28);
            this.btBlue.TabIndex = 6;
            this.btBlue.UseVisualStyleBackColor = false;
            this.btBlue.Click += new System.EventHandler(this.MainColors);
            // 
            // btPurple
            // 
            this.btPurple.BackColor = System.Drawing.Color.Purple;
            this.btPurple.Location = new System.Drawing.Point(933, 2);
            this.btPurple.Margin = new System.Windows.Forms.Padding(2);
            this.btPurple.Name = "btPurple";
            this.btPurple.Size = new System.Drawing.Size(26, 28);
            this.btPurple.TabIndex = 5;
            this.btPurple.UseVisualStyleBackColor = false;
            this.btPurple.Click += new System.EventHandler(this.MainColors);
            // 
            // btGreen
            // 
            this.btGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btGreen.Location = new System.Drawing.Point(874, 2);
            this.btGreen.Margin = new System.Windows.Forms.Padding(2);
            this.btGreen.Name = "btGreen";
            this.btGreen.Size = new System.Drawing.Size(26, 28);
            this.btGreen.TabIndex = 5;
            this.btGreen.UseVisualStyleBackColor = false;
            this.btGreen.Click += new System.EventHandler(this.MainColors);
            // 
            // btYellow
            // 
            this.btYellow.BackColor = System.Drawing.Color.Yellow;
            this.btYellow.Location = new System.Drawing.Point(904, 2);
            this.btYellow.Margin = new System.Windows.Forms.Padding(2);
            this.btYellow.Name = "btYellow";
            this.btYellow.Size = new System.Drawing.Size(26, 28);
            this.btYellow.TabIndex = 4;
            this.btYellow.UseVisualStyleBackColor = false;
            this.btYellow.Click += new System.EventHandler(this.MainColors);
            // 
            // btBrown
            // 
            this.btBrown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btBrown.Location = new System.Drawing.Point(933, 33);
            this.btBrown.Margin = new System.Windows.Forms.Padding(2);
            this.btBrown.Name = "btBrown";
            this.btBrown.Size = new System.Drawing.Size(26, 28);
            this.btBrown.TabIndex = 1;
            this.btBrown.UseVisualStyleBackColor = false;
            this.btBrown.Click += new System.EventHandler(this.MainColors);
            // 
            // btRed
            // 
            this.btRed.BackColor = System.Drawing.Color.Red;
            this.btRed.Location = new System.Drawing.Point(904, 33);
            this.btRed.Margin = new System.Windows.Forms.Padding(2);
            this.btRed.Name = "btRed";
            this.btRed.Size = new System.Drawing.Size(26, 28);
            this.btRed.TabIndex = 2;
            this.btRed.UseVisualStyleBackColor = false;
            this.btRed.Click += new System.EventHandler(this.MainColors);
            // 
            // btColors
            // 
            this.btColors.BackColor = System.Drawing.Color.White;
            this.btColors.BackgroundImage = global::DrawFigures.Properties.Resources.icons8_rgb_color_wheel_48;
            this.btColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btColors.Location = new System.Drawing.Point(776, 2);
            this.btColors.Margin = new System.Windows.Forms.Padding(2);
            this.btColors.Name = "btColors";
            this.btColors.Size = new System.Drawing.Size(63, 60);
            this.btColors.TabIndex = 0;
            this.btColors.UseVisualStyleBackColor = false;
            this.btColors.Click += new System.EventHandler(this.btColors_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRectangle,
            this.tsbEllipse,
            this.tsbFillRectangle,
            this.tsbFillEllipse,
            this.tsbCursor,
            this.tsbPencil,
            this.tsbEraiser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 65);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(54, 435);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRectangle
            // 
            this.tsbRectangle.AutoSize = false;
            this.tsbRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRectangle.Image = ((System.Drawing.Image)(resources.GetObject("tsbRectangle.Image")));
            this.tsbRectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRectangle.Name = "tsbRectangle";
            this.tsbRectangle.Size = new System.Drawing.Size(40, 35);
            this.tsbRectangle.Click += new System.EventHandler(this.tsbRectangle_Click);
            // 
            // tsbEllipse
            // 
            this.tsbEllipse.AutoSize = false;
            this.tsbEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEllipse.Image = ((System.Drawing.Image)(resources.GetObject("tsbEllipse.Image")));
            this.tsbEllipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEllipse.Name = "tsbEllipse";
            this.tsbEllipse.Size = new System.Drawing.Size(40, 35);
            this.tsbEllipse.Click += new System.EventHandler(this.tsbEllipse_Click);
            // 
            // tsbFillRectangle
            // 
            this.tsbFillRectangle.AutoSize = false;
            this.tsbFillRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFillRectangle.Image = ((System.Drawing.Image)(resources.GetObject("tsbFillRectangle.Image")));
            this.tsbFillRectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFillRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFillRectangle.Name = "tsbFillRectangle";
            this.tsbFillRectangle.Size = new System.Drawing.Size(40, 35);
            this.tsbFillRectangle.Click += new System.EventHandler(this.tsbFillRectangle_Click);
            // 
            // tsbFillEllipse
            // 
            this.tsbFillEllipse.AutoSize = false;
            this.tsbFillEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFillEllipse.Image = ((System.Drawing.Image)(resources.GetObject("tsbFillEllipse.Image")));
            this.tsbFillEllipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbFillEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFillEllipse.Name = "tsbFillEllipse";
            this.tsbFillEllipse.Size = new System.Drawing.Size(40, 35);
            this.tsbFillEllipse.Click += new System.EventHandler(this.tsbFillEllipse_Click);
            // 
            // tsbCursor
            // 
            this.tsbCursor.AutoSize = false;
            this.tsbCursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCursor.Image = ((System.Drawing.Image)(resources.GetObject("tsbCursor.Image")));
            this.tsbCursor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCursor.Name = "tsbCursor";
            this.tsbCursor.Size = new System.Drawing.Size(40, 35);
            this.tsbCursor.Click += new System.EventHandler(this.tsbCursor_Click);
            // 
            // tsbPencil
            // 
            this.tsbPencil.AutoSize = false;
            this.tsbPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPencil.Image = ((System.Drawing.Image)(resources.GetObject("tsbPencil.Image")));
            this.tsbPencil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPencil.Name = "tsbPencil";
            this.tsbPencil.Size = new System.Drawing.Size(40, 35);
            this.tsbPencil.Click += new System.EventHandler(this.tsbPencil_Click);
            // 
            // tsbEraiser
            // 
            this.tsbEraiser.AutoSize = false;
            this.tsbEraiser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEraiser.Image = ((System.Drawing.Image)(resources.GetObject("tsbEraiser.Image")));
            this.tsbEraiser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEraiser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEraiser.Name = "tsbEraiser";
            this.tsbEraiser.Size = new System.Drawing.Size(40, 35);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(54, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 435);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Draw Fiqures";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btWhite;
        private System.Windows.Forms.Button btBlack;
        private System.Windows.Forms.Button btBlue;
        private System.Windows.Forms.Button btGreen;
        private System.Windows.Forms.Button btYellow;
        private System.Windows.Forms.Button btRed;
        private System.Windows.Forms.Button btColors;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRectangle;
        private System.Windows.Forms.ToolStripButton tsbEllipse;
        private System.Windows.Forms.ToolStripButton tsbCursor;
        private System.Windows.Forms.ToolStripButton tsbPencil;
        private System.Windows.Forms.ToolStripButton tsbEraiser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btPurple;
        private System.Windows.Forms.Button btBrown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.TextBox txbHeight;
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.ToolStripButton tsbFillRectangle;
        private System.Windows.Forms.ToolStripButton tsbFillEllipse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btBorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btFill;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace DrawFigures
{
    public partial class Form1 : Form
    {
        #region Variables
        Color color;
        Pen pen=new Pen(Color.Black,2);
        Graphics graphics;
        bool isDrawing;
        Point startPoint;
        ShapeContainer shapeContainerForRectangle;
        ShapeContainer shapeContainerForEllipse;
        ShapeContainer shapeContainerForFillRectangle;
        ShapeContainer shapeContainerForFillEllipse;
        RectangleShape rectangleShape;
        RectangleShape fillRectangleShape;
        OvalShape ovalShape;
        OvalShape fillOvalShape;
        Bitmap bitmap;
        int deltaX;
        int deltaY;
        int x0;
        int y0;
        RectangleShape rect;
        RectangleShape rectFill;
        OvalShape oval;
        bool cursorRightBottom;
        bool isRectFocused;
        bool isOvalFocused;
        bool isFillRectFocused;
        bool isFillOvalFocused;
        bool keyPressed;
        bool border;
        bool fill;
        #endregion
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

        #region ColorsClick
        private void btBorder_Click(object sender, EventArgs e)
        {
            border = true;
            fill = false;
        }
        private void btFill_Click(object sender, EventArgs e)
        {
            fill = true;
            border = false;
        }
        private void btColors_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            color = dlg.Color;
            if (border)
            {
                btBorder.BackColor = color;
            }

            if (fill)
            {
                btFill.BackColor = color;
            }
            
            if (tsbPencil.Checked)
            {
                pen = new Pen(color, 2);
            }
        }
        private void MainColors(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            color = button.BackColor;
            if (border)
            {
                btBorder.BackColor = color;
            }

            if (fill)
            {
                btFill.BackColor = color;
            }

            if (tsbPencil.Checked)
            {
                pen = new Pen(color, 2);
            }
        }

        #endregion

        #region PictureBoxMouseEvents
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;

            if (tsbPencil.Checked)
            {
                isDrawing = true;
            }

            if (tsbRectangle.Checked)
            {
                shapeContainerForRectangle = new ShapeContainer();
                rectangleShape = new RectangleShape();
                rectangleShape.MouseClick += rectangleShape_Click;
                rectangleShape.MouseEnter += rectangleShape_MouseEnter;
                shapeContainerForRectangle.Location = new Point(startPoint.X, startPoint.Y);
                shapeContainerForRectangle.Margin = new Padding(0);
                shapeContainerForRectangle.Name = "shapeContainer";
                shapeContainerForRectangle.Shapes.AddRange(new Shape[] {
            rectangleShape});
                //shapeContainerForRectangle.Size = new Size(pictureBox1.Size.Width,pictureBox1.Size.Height);
                shapeContainerForRectangle.TabIndex = 3;
                shapeContainerForRectangle.TabStop = false;

                rectangleShape.Location = new Point(startPoint.X, startPoint.Y);
                rectangleShape.Name = "rectangleShape";
                //rectangleShape.Size = new Size(0, 0);
                rectangleShape.Visible = false;
                rectangleShape.BorderWidth = 3;
                rectangleShape.BorderColor = btBorder.BackColor;
                pictureBox1.Controls.Add(shapeContainerForRectangle);
            }

            if (tsbFillRectangle.Checked)
            {
                shapeContainerForFillRectangle = new ShapeContainer();
                fillRectangleShape = new RectangleShape();
                fillRectangleShape.MouseClick += fillRectangleShape_Click;
                shapeContainerForFillRectangle.Location = new Point(0, 0);
                shapeContainerForFillRectangle.Margin = new Padding(0);
                shapeContainerForFillRectangle.Name = "shapeContainer";
                shapeContainerForFillRectangle.Shapes.AddRange(new Shape[] {
            fillRectangleShape});
                //shapeContainerForFillRectangle.Size = new Size(this.Size.Width, this.Size.Height);
                shapeContainerForFillRectangle.TabIndex = 3;
                shapeContainerForFillRectangle.TabStop = false;

                fillRectangleShape.Location = new Point(startPoint.X, startPoint.Y);
                fillRectangleShape.Name = "fillRectangleShape";
                //fillRectangleShape.Size = new Size(0, 0);
                fillRectangleShape.BorderWidth = 3;
                fillRectangleShape.BorderColor = btBorder.BackColor;
                fillRectangleShape.FillStyle = FillStyle.Solid;
                fillRectangleShape.FillColor = btFill.BackColor;
                pictureBox1.Controls.Add(shapeContainerForFillRectangle);
            }

            if (tsbFillEllipse.Checked)
            {
                shapeContainerForFillEllipse = new ShapeContainer();
                fillOvalShape = new OvalShape();
                fillOvalShape.MouseClick += fillOvalShape_Click;
                shapeContainerForFillEllipse.Location = new Point(0, 0);
                shapeContainerForFillEllipse.Margin = new Padding(0);
                shapeContainerForFillEllipse.Name = "shapeContainer";
                shapeContainerForFillEllipse.Shapes.AddRange(new Shape[] {
            fillOvalShape});
                //shapeContainerForFillEllipse.Size = new Size(this.Size.Width, this.Size.Height);
                shapeContainerForFillEllipse.TabIndex = 3;
                shapeContainerForFillEllipse.TabStop = false;

                fillOvalShape.Location = new Point(startPoint.X, startPoint.Y);
                fillOvalShape.Name = "fillOvalShape";
                //fillOvalShape.Size = new Size(0, 0);
                fillOvalShape.BorderWidth = 3;
                fillOvalShape.BorderColor = btBorder.BackColor;
                fillOvalShape.FillStyle = FillStyle.Solid;
                fillOvalShape.FillColor = btFill.BackColor;
                pictureBox1.Controls.Add(shapeContainerForFillEllipse);
            }

            if (tsbEllipse.Checked)
            {
                shapeContainerForEllipse = new ShapeContainer();
                ovalShape = new OvalShape();
                ovalShape.MouseClick += ovalShape_Click;
                shapeContainerForEllipse.Location = new Point(0, 0);
                shapeContainerForEllipse.Margin = new Padding(0);
                shapeContainerForEllipse.Name = "shapeContainer";
                shapeContainerForEllipse.Shapes.AddRange(new Shape[] {
            ovalShape});
                //shapeContainerForEllipse.Size = new Size(this.Size.Width, this.Size.Height);
                shapeContainerForEllipse.TabIndex = 3;
                shapeContainerForEllipse.TabStop = false;

                ovalShape.Location = new Point(startPoint.X, startPoint.Y);
                ovalShape.Name = "ovalShape";
                //ovalShape.Size = new Size(0, 0);
                ovalShape.BorderWidth = 3;
                ovalShape.BorderColor = btBorder.BackColor;
                pictureBox1.Controls.Add(shapeContainerForEllipse);
            }

            if (cursorRightBottom)
            {
                this.Cursor = Cursors.SizeNWSE;
            }

            x0 = e.X;
            y0 = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                graphics.DrawLine(pen, e.Location, startPoint);
                startPoint = e.Location;
                pictureBox1.Refresh();
            }

            if (tsbRectangle.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    rectangleShape.Visible = true;
                    int width = e.X - startPoint.X;
                    int height = e.Y - startPoint.Y;
                    rectangleShape.Size = new Size(width, height);
                }
            }

            if (tsbFillRectangle.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int width = e.X - startPoint.X;
                    int height = e.Y - startPoint.Y;
                    fillRectangleShape.Size = new Size(width, height);
                }
            }

            if (tsbEllipse.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int width = e.X - startPoint.X;
                    int height = e.Y - startPoint.Y;
                    ovalShape.Size = new Size(width, height);
                }
            }

            if (tsbFillEllipse.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int width = e.X - startPoint.X;
                    int height = e.Y - startPoint.Y;
                    fillOvalShape.Size = new Size(width, height);
                }
            }

            RectangleMove(e, rect);
            //RectangleMove(e, rectFill);
        }
        private void RectangleMove(MouseEventArgs e,RectangleShape rect)
        {
            if (tsbCursor.Checked && rect != null)
            {
                bool x1 = e.X < rect.Width + rect.Location.X + 15 && e.X > rect.Width + rect.Location.X;
                bool y1 = e.Y < rect.Height + rect.Location.Y + 15 && e.Y > rect.Height + rect.Location.Y;
                cursorRightBottom = x1 && y1;
                if (cursorRightBottom)
                {
                    this.Cursor = Cursors.SizeNWSE;
                }

                if (e.Button == MouseButtons.Left && this.Cursor == Cursors.SizeNWSE)
                {
                    deltaX = e.X - x0;
                    deltaY = e.Y - y0;
                    rect.Width = rect.Width + deltaX;
                    rect.Height = rect.Height + deltaY;
                    x0 = e.X;
                    y0 = e.Y;
                }

                //if (e.Button== MouseButtons.None && cursorRightBottom == false)
                //{
                //    this.Cursor = Cursors.Default;
                //}

                bool x2 = e.X < rect.Width + rect.Location.X + 10 && e.X > rect.Width + rect.Location.X - 5;
                bool y2 = e.Y < rect.Location.Y + (rect.Height / 2) + 10 && e.Y > rect.Location.Y + (rect.Height / 2) - 5;
                bool cursorRight = x2 && y2;
                if (cursorRight)
                {
                    this.Cursor = Cursors.SizeWE;
                }

                if (e.Button == MouseButtons.Left && this.Cursor == Cursors.SizeWE)
                {
                    deltaX = e.X - x0;
                    rect.Width = rect.Width + deltaX;
                    x0 = e.X;
                }

                if (e.Button == MouseButtons.None && cursorRight == false && cursorRightBottom == false)
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            cursorRightBottom = false;
        }

        #endregion
        
        #region ToolStripButtonsClick
        private void tsbPencil_Click(object sender, EventArgs e)
        {
            tsbPencil.Checked = true;
            tsbFillRectangle.Checked = false;
            tsbRectangle.Checked = false;
            tsbEllipse.Checked = false;
            tsbFillEllipse.Checked = false;
            tsbCursor.Checked = false;
        }
        private void tsbRectangle_Click(object sender, EventArgs e)
        {
            tsbRectangle.Checked = true;
            tsbEllipse.Checked = false;
            tsbPencil.Checked = false;
            tsbFillEllipse.Checked = false;
            tsbFillRectangle.Checked = false;
            tsbCursor.Checked = false;
        }
        private void tsbEllipse_Click(object sender, EventArgs e)
        {
            tsbEllipse.Checked = true;
            tsbPencil.Checked = false;
            tsbRectangle.Checked = false;
            tsbFillEllipse.Checked = false;
            tsbFillRectangle.Checked = false;
            tsbCursor.Checked = false;
        }
        private void tsbFillRectangle_Click(object sender, EventArgs e)
        {
            tsbFillRectangle.Checked = true;
            tsbRectangle.Checked = false;
            tsbEllipse.Checked = false;
            tsbPencil.Checked = false;
            tsbFillEllipse.Checked = false;
            tsbCursor.Checked = false;
        }
        private void tsbFillEllipse_Click(object sender, EventArgs e)
        {
            tsbFillEllipse.Checked = true;
            tsbRectangle.Checked = false;
            tsbEllipse.Checked = false;
            tsbPencil.Checked = false;
            tsbFillRectangle.Checked = false;
            tsbCursor.Checked = false;
        }
        private void tsbCursor_Click(object sender, EventArgs e)
        {
            tsbCursor.Checked = true;
            tsbFillRectangle.Checked = false;
            tsbRectangle.Checked = false;
            tsbEllipse.Checked = false;
            tsbPencil.Checked = false;
            tsbFillEllipse.Checked = false;
        }

        #endregion

        #region FiguresClick
        private void rectangleShape_Click(object sender, EventArgs e)
        {
            if (tsbCursor.Checked)
            {
                txbHeight.Enabled = true;
                txbWidth.Enabled = true;
                txbX.Enabled = true;
                txbY.Enabled = true;

                isOvalFocused = false;
                isFillRectFocused = false;
                isFillOvalFocused = false;
                isRectFocused = false;//bu nedi da.Silirem bir cur isleyir.Yaziram bir cur isleyir.
                rect = (RectangleShape)sender;
                txbX.Text = rect.Location.X.ToString();
                txbY.Text = rect.Location.Y.ToString();
                txbHeight.Text = rect.Height.ToString();
                txbWidth.Text = rect.Width.ToString();
                isRectFocused = true;
            }
        }
        private void ovalShape_Click(object sender, EventArgs e)
        {
            if (tsbCursor.Checked)
            {
                txbHeight.Enabled = true;
                txbWidth.Enabled = true;
                txbX.Enabled = true;
                txbY.Enabled = true;

                isRectFocused = false;
                isFillOvalFocused = false;
                isFillRectFocused = false;
                isOvalFocused = false;
                oval = (OvalShape)sender;
                txbX.Text = oval.Location.X.ToString();
                txbY.Text = oval.Location.Y.ToString();
                txbHeight.Text = oval.Height.ToString();
                txbWidth.Text = oval.Width.ToString();
                isOvalFocused = true;
            }

        }
        private void fillRectangleShape_Click(object sender, EventArgs e)
        {
            if (tsbCursor.Checked)
            {
                txbHeight.Enabled = true;
                txbWidth.Enabled = true;
                txbX.Enabled = true;
                txbY.Enabled = true;

                isOvalFocused = false;
                isRectFocused = false;
                isFillOvalFocused = false;
                isFillRectFocused = false;
                rectFill = (RectangleShape)sender;
                txbX.Text = rectFill.Location.X.ToString();
                txbY.Text = rectFill.Location.Y.ToString();
                txbHeight.Text = rectFill.Height.ToString();
                txbWidth.Text = rectFill.Width.ToString();
                isFillRectFocused = true;
            }
        }
        private void fillOvalShape_Click(object sender, EventArgs e)
        {
            if (tsbCursor.Checked)
            {
                txbHeight.Enabled = true;
                txbWidth.Enabled = true;
                txbX.Enabled = true;
                txbY.Enabled = true;

                isRectFocused = false;
                isFillRectFocused = false;
                isOvalFocused = false;
                isFillOvalFocused = false;
                OvalShape oval = (OvalShape)sender;
                txbX.Text = oval.Location.X.ToString();
                txbY.Text = oval.Location.Y.ToString();
                txbHeight.Text = oval.Height.ToString();
                txbWidth.Text = oval.Width.ToString();
                isFillOvalFocused = true;
            }
        }
        private void rectangleShape_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        #endregion

        #region TextBoxsEvents
        private void txbHeight_TextChanged(object sender, EventArgs e)
        {
            if (isRectFocused && txbHeight.Text != "" && keyPressed)
            {
                rect.Height = int.Parse(txbHeight.Text);
            }
            else if (isOvalFocused && txbHeight.Text != "" && keyPressed)
            {
                oval.Height = int.Parse(txbHeight.Text);
            }
            else if (isFillRectFocused && txbHeight.Text != "" && keyPressed)
            {
                fillRectangleShape.Height = int.Parse(txbHeight.Text);
            }
            else if (isFillOvalFocused && txbHeight.Text != "" && keyPressed)
            {
                fillOvalShape.Height = int.Parse(txbHeight.Text);
            }
        }
        private void txbWidth_TextChanged(object sender, EventArgs e)
        {
            if (isRectFocused && txbWidth.Text != "" && keyPressed)
            {
                rect.Width = int.Parse(txbWidth.Text);
            }
            else if (isOvalFocused && txbWidth.Text != "" && keyPressed)
            {
                oval.Width = int.Parse(txbWidth.Text);
            }
            else if (isFillRectFocused && txbWidth.Text != "" && keyPressed)
            {
                fillRectangleShape.Width = int.Parse(txbWidth.Text);
            }
            else if (isFillOvalFocused && txbWidth.Text != "" && keyPressed)
            {
                fillOvalShape.Width = int.Parse(txbWidth.Text);
            }
        }
        private void txbLocation(object sender, EventArgs e)
        {
            if (isRectFocused && txbX.Text != "" && txbY.Text != "" && keyPressed)
            {
                rect.Location = new Point(int.Parse(txbX.Text), int.Parse(txbY.Text));
            }
            else if (isOvalFocused && txbX.Text != "" && txbY.Text != "" && keyPressed)
            {
                oval.Location = new Point(int.Parse(txbX.Text), int.Parse(txbY.Text));
            }
            else if (isFillRectFocused && txbX.Text != "" && txbY.Text != "" && keyPressed)
            {
                fillRectangleShape.Location = new Point(int.Parse(txbX.Text), int.Parse(txbY.Text));
            }
            else if (isFillOvalFocused && txbX.Text != "" && txbY.Text != "" && keyPressed)
            {
                fillOvalShape.Location = new Point(int.Parse(txbX.Text), int.Parse(txbY.Text));
            }
        }
        private void textBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressed = true;
        }

        #endregion
        
    }
}
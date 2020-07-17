using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VectorEditor
{
    public partial class MainForm : Form
    {
        Pen pen;
        Graphics graphics;
        Bitmap bitmap;
        public int x, y;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            bitmap = new Bitmap(Picture.Width, Picture.Height);
            graphics = Graphics.FromImage(bitmap);
            pen = new Pen(Color.Black, 1);
            ColorButton.BackColor = Color.Black;
            Picture.Image = bitmap;

            List<Figure> figures = new List<Figure>();
            figures.Add(new Figure() { Name = "Линия", Id = 0 });
            figures.Add(new Figure() { Name = "Прямоугольник", Id = 1 });
            figures.Add(new Figure() { Name = "Эллипс", Id = 2 });

            Figure.DataSource = figures;
            Figure.ValueMember = "Id";
            Figure.DisplayMember = "Name";
        }

        private void Draw (Line line)
        {
            graphics.DrawLine(pen, line.x1, line.y1, line.x2, line.y2);
        }

        private void Draw (Rectangle rectangle)
        {
            graphics.DrawRectangle(pen, rectangle.x1, rectangle.y1, rectangle.width, rectangle.height);
        }

        private void Draw (Ellipse ellipse)
        {
            graphics.DrawEllipse(pen, ellipse.x1, ellipse.y1, ellipse.width, ellipse.height);
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            pen.Color = ColorButton.BackColor;
            pen.Width = (float)PenSize.Value;

            if (Figure.SelectedIndex == 0)
            {
                Line line = new Line(x, y, e.X, e.Y);
                Draw(line);
            }
            if (Figure.SelectedIndex == 1)
            {
                Rectangle rectangle = new Rectangle(x, y, e.X, e.Y);
                Draw(rectangle);
            }
            if (Figure.SelectedIndex == 2)
            {
                Ellipse ellipse = new Ellipse(x, y, e.X, e.Y);
                Draw(ellipse);
            }

            Picture.Image = bitmap;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorButton.BackColor = ColorDialog.Color;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            Picture.Image = bitmap;
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GeomFigures4
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px,py;
        Pen p = new Pen(Color.Black, 2f);
        Pen eraser = new Pen(Color.White, 20);
        int index;
        int x,y, sx,sy,cx,cy;
        Point Start, End;
        Image OpenedFile;

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(Picture.Width, Picture.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Picture.Image = bm; 
        }

        private void bRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void bLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void Picture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cx, cy, x, y);
                }
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Picture.Image = bm;
            index = 0;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.JPG";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Picture.Image != null)
                {
                    Picture.Image.Save(saveFileDialog1.FileName);
                }
            }
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                OpenedFile = Image.FromFile(ofd.FileName);
                Picture.Image = OpenedFile;
                }
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void bWidthPen_ValueChanged(object sender, EventArgs e)
        {
            p.Width = ((float)bWidthPen.Value);
            bWidthPen.Maximum = 100;
            bWidthPen.Minimum = 1;
        }

        private void bRed_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void bCyan_Click(object sender, EventArgs e)
        {
            p.Color = Color.Cyan;
        }

        private void bGreen_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void bYellow_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void bPurple_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void bOrange_Click(object sender, EventArgs e)
        {
            p.Color = Color.Orange;
        }

        private void bBlack_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void bWhite_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void bTriangle_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cx = e.X;
            cy = e.Y;
        }

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if(index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p,px,py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }

                x = e.X;
                y = e.Y;
                sx = e.X - cx;
                sy = e.Y - cy;
            }
            Picture.Refresh();
        }

        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sx = x - cx;
            sy = y - cy;

            End = PointToClient(MousePosition);

            

            if (index == 3)
            {
                px = e.Location;
                g.DrawEllipse(p, cx, cy, sx, sy);
                py = px;
            }
            if (index == 4)
            {
                px = e.Location;
                g.DrawRectangle(p, cx, cy, sx, sy);
                py = px;
            }
            if (index == 5)
            {
                px = e.Location;
                g.DrawLine(p, cx, cy, x, y);
                py = px;
            }
            if (index == 7)
            {
                double xMid = (Start.X + End.Y) / 2;

                Point first = new Point(Start.X, End.Y);
                Point mid = new Point((int)xMid, Start.Y);

                g.DrawLine(p, first, mid);
                g.DrawLine(p, first, End);
                g.DrawLine(p, End, mid);
            }
        }

        private void bEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void bEllipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void bPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics
{
    public partial class Form1 : Form
    {
        System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        double labelValue;
        public const double E = 2.7182818284590451;
        Graphics g;
        Graphics g2;
        Pen p;
        int drawX;
        int drawY;
    

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
          

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g2 = panel2.CreateGraphics();
            g = panel1.CreateGraphics();
            p = new Pen(Color.Black);
            labelValue = 0;
            label5.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (labelValue == -9)
            {
                MessageBox.Show("Cant go above 0.9");
            }
            else
            {
                labelValue -= 1;
                if (labelValue < 0)
                {
                    label5.Text = "-0." + (-1 * labelValue).ToString();
                }
                else {
                    label5.Text = "0." + labelValue.ToString();
                }
            }
            double x = (1 / Math.Sqrt(1 - Math.Pow(labelValue * 0.1, 2))) * (drawY - labelValue * 0.1 * drawX);
            double y = (1 / Math.Sqrt(1 - Math.Pow(labelValue * 0.1, 2))) * (drawX - labelValue * 0.1 * drawY);
            g2.FillRectangle(Brushes.Green, (float)x, (float)y, 10, 10);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelValue == 9) {
                MessageBox.Show("Cant go above 0.9");
            }
            else {
                labelValue += 1;
                label5.Text = "0." + labelValue.ToString();
            }
            double x = (1 / Math.Sqrt(1 - Math.Pow(labelValue * 0.1, 2))) * (drawY - labelValue * 0.1 * drawX);
            double y = (1 / Math.Sqrt(1 - Math.Pow(labelValue * 0.1, 2))) * (drawX - labelValue * 0.1 * drawY);
            g2.FillRectangle(Brushes.Green, (float)x, (float)y, 10, 10);


        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
         
            
            g.FillRectangle(Brushes.Red, e.X, e.Y, 10, 10);
            drawX = e.X;
            drawY = e.Y;
            double x = (1 / Math.Sqrt(1 - Math.Pow(labelValue * 0.1, 2))) * (drawY - labelValue * 0.1 * drawX);
            double y = (1 / Math.Sqrt(1 - Math.Pow(labelValue * 0.1, 2))) * (drawX - labelValue * 0.1 * drawY);
            g2.FillRectangle(Brushes.Green, (float)x, (float)y, 10, 10);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            label9.Text = e.X.ToString();
            label8.Text = e.Y.ToString();
        }
    }
}

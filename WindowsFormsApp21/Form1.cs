using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        IFigureFactory Factory;
        public Form1()
        {
           
            comboBox1.Items.Add("Rectangle");
            comboBox1.Items.Add("Circle");
            comboBox1.Items.Add("Triangle");
            //Button button2 = new Button();
            //button2.Location = new Point(304,19);
            //button2.BackColor = Color.White;
            //button2.Size = new Size(75,23);
            //button2.Text = "Color";
            //this.Controls.Add(button2);
            //TextBox textBox = new TextBox();
            //textBox.Location = new Point(21,72);
            //textBox.BackColor = Color.White;
            //textBox.Size = new Size(746, 366);
            //this.Controls.Add(textBox);
            InitializeComponent();
           
            
    }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (var g = e.Graphics)
            {

                var Pen = Pens.Green;

              //  g.FillEllipse(Brushes.Aquamarine,new (10,10,10,10));


            }
        }
    }
    interface IFigure
        {
         int Height {  set; }
         int Width {  set; }
         string Color {  set; }
        int Location { set; }
        string isField { set; }
    }
    class Rectangle : IFigure
    {
        public int Height {  set => Height = value; }
        public int Width {  set => Width=value; }
        public string Color {  set => Color=value; }
        public int Location {  set => Location=value; }
        public string isField { set => isField = value; }

    }
    class Circle : IFigure
    {
        public int Height { set => Height = value; }
        public int Width { set => Width = value; }
        public string Color { set => Color = value; }
        public int Location { set => Location = value; }
        public string isField { set => isField = value; }

    }
    class Triangle : IFigure
    {
        public int Height { set => Height = value; }
        public int Width { set => Width = value; }
        public string Color { set => Color = value; }
        public int Location { set => Location = value; }
        public string isField { set => isField = value; }


    }
    interface IFigureFactory
    {
        IFigure create();

    }
    class RectangleFactory : IFigureFactory
    {
        public IFigure create()
        {
            return new Rectangle();
        }
    }
    class CircleFactory : IFigureFactory
    {
        public IFigure create()
        {
            return new Circle();
        }
    }
    class TriangleFactory: IFigureFactory
    {
        public IFigure create()
        {
            return new Triangle();
        }
    }
}

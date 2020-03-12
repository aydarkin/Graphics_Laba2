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

namespace ILoveBasicLaba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            //    Dim G As Graphics = pe.Graphics
            //' Далее можно вставить какой-нибудь код для рисования
            //Dim Point1 As New Point(100, 100)
            //Dim Point2 As New Point(200, 200)
            //Dim MyPen As New Pen(Color.Red, 3)
            //G.DrawLine(MyPen, Point1, Point2)
            e.Graphics.DrawLine(new Pen(Color.Red, 3), new Point(100, 100), new Point(200, 200));
        }

        private void tabPage2_Paint(object sender, PaintEventArgs e)
        {
            //Dim g As Graphics = pe.Graphics
            //Dim MyBox As New Rectangle(5, 10, 150, 200)
            //Dim MyPen As New Pen(Color.Blue, 2)
            //g.DrawEllipse(MyPen, MyBox)
            e.Graphics.DrawEllipse(new Pen(Color.Blue, 2), new Rectangle(5, 10, 150, 200));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dim s1 As New Point(10, 100) ' Начальная точка
            //Dim e1 As New Point(100, 10) ' Первая контрольная точка
            //Dim e2 As New Point(150, 150) ' Вторая контрольная точка
            //Dim s2 As New Point(200, 100) ' Конечная точка
            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //G.Clear(Color.White)
            //Dim Mypen As New Pen(Color.Black, 3)
            //G.DrawBezier(Mypen, s1, e1, e2, s2)

            var g = tabPage3.CreateGraphics();
            g.Clear(Color.White);
            g.DrawBezier(new Pen(Color.Black, 3), 
                new Point(10, 100), new Point(100, 10), 
                new Point(150, 150), new Point(200, 100));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Dim MyPoints As Point() = {
            //New Point(10, 100), _
            //New Point(75, 10), New Point(80, 50), _
            //New Point(100, 150), New Point(125, 80), _
            //New Point(175, 200), New Point(200, 80)}
            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //G.Clear(Color.White)
            //Dim Mypen As New Pen(Color.Red, 3)
            //G.DrawBeziers(Mypen, MyPoints)

            var g = tabPage4.CreateGraphics();
            g.Clear(Color.White);

            g.DrawBeziers(
                new Pen(Color.Black, 3), 
                new Point[] { 
                    new Point(10, 100), new Point(75, 10),
                    new Point(80, 50), new Point(10, 150),
                    new Point(125, 80), new Point(175, 200),
                    new Point(200, 80) 
                } 
                );

        }

        private void tabPage5_Paint(object sender, PaintEventArgs e)
        {
            //' Создаем однотонную кисть
            //Dim blueBrush As New SolidBrush(Color.Blue)
            //' указываем расположение и размеры эллипса
            //Dim x As Single = 0.0F
            //Dim y As Single = 0.0F
            //Dim width As Single = 150.0F
            //Dim height As Single = 150.0F
            //' Указываем начальный и конечный углы
            //Dim startAngle As Single = 0.0F
            //Dim endAngle As Single = 120.0F
            //' Заливаем сегмент
            //pe.Graphics.FillPie(blueBrush, x, y, width, height, _
            //startAngle, endAngle)

            float x = .0F;
            float y = .0F;
            float width = 150.0F;
            float height = 150.0F;

            float startAngle = .0F;
            float endAngle = 120.0F;

            e.Graphics.FillPie(
                new SolidBrush(Color.Blue), x, y, width, 
                height, startAngle, endAngle);
        }

        private void tabPage6_Paint(object sender, PaintEventArgs e)
        {
            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //Dim brush As New SolidBrush(Color.Honeydew)
            //Dim Angles() As Single = { 0, 130, 205, 290, 360 }
            //Dim Colors() As Color = {Color.LightGoldenrodYellow, _
            //Color.PaleTurquoise, Color.RoyalBlue, Color.Purple}
            //G.Clear(Color.Ivory)
            //Dim rect As New Rectangle(10, 50, 250, 150)
            //Dim angle As Integer
            //For angle = 1 To Angles.Length - 1
            //    brush.Color = Colors(angle - 1)
            //    G.FillPie(brush, rect, Angles(angle - 1), _
            //    Angles(angle) - Angles(angle - 1))
            //Next
            //G.DrawEllipse(Pens.Black, rect)

            var rect = new Rectangle(10, 50, 250, 150);
            float[] angles = new float[] { 0, 130, 205, 290, 360 };
            var colors = new Color[] { 
                Color.LightGoldenrodYellow, Color.PaleTurquoise, 
                Color.RoyalBlue, Color.Purple 
            };
            for (int i = 0; i < angles.Length - 1; i++)
            {
                e.Graphics.FillPie(new SolidBrush(colors[i]),
                    rect, angles[i],
                    angles[i + 1] - angles[i]
                );
            }

            e.Graphics.DrawEllipse(Pens.Black, rect);
        }

        private void tabPage7_Paint(object sender, PaintEventArgs e)
        {
            //    'Определяем штриховую кисть
            //Dim hBrush As New HatchBrush(HatchStyle.DarkUpwardDiagonal, _
            //Color.DarkGoldenrod, Color.Crimson)
            //' Создаем точки, определяющие полигон
            //Dim point1 As New PointF(0.0F, 0.0F)
            //Dim point2 As New PointF(100.0F, 25.0F)
            //Dim point3 As New PointF(200.0F, 5.0F)
            //Dim point4 As New PointF(250.0F, 50.0F)
            //Dim point5 As New PointF(300.0F, 100.0F)
            //Dim point6 As New PointF(350.0F, 200.0F)
            //Dim point7 As New PointF(200.0F, 200.0F)
            //Dim point8 As New PointF(130.0F, 230.0F)
            //Dim curvePoints As PointF() = {
            //        point1, point2, point3, point4, _
            //point5, point6, point7, point8}
            //    ' Определяем режим заливки
            //Dim newFillMode As FillMode = FillMode.Winding
            //' Заливаем полигон
            //pe.Graphics.FillPolygon(hBrush, curvePoints, newFillMode)

            var points = new PointF[]
            {
                new PointF(0.0F, 0.0F),
                new PointF(100.0F, 25.0F),
                new PointF(200.0F, 5.0F),
                new PointF(250.0F, 50.0F),
                new PointF(300.0F, 100.0F),
                new PointF(350.0F, 200.0F),
                new PointF(200.0F, 200.0F),
                new PointF(130.0F, 230.0F)
            };
            e.Graphics.FillPolygon(
                new HatchBrush
                (
                    HatchStyle.DarkUpwardDiagonal,
                    Color.DarkGoldenrod,
                    Color.Crimson
                ),
                points,
                FillMode.Winding
            );
        }

        private void tabPage9_Paint(object sender, PaintEventArgs e)
        {
            //tabPage1_PaintDim myGraphicsPath As New GraphicsPath
            //Dim myPointArray As Point() = {
            //  New Point(15, 50), _
            //  New Point(20, 40), New Point(50, 30)}
            //Dim myFontFamily As New FontFamily("Comic Sans Ms")
            //        Dim myPointF As New PointF(50, 50)
            //        Dim myStringFormat As New StringFormat
            //        myGraphicsPath.AddArc(0, 0, 30, 60, 30, 180)
            //        myGraphicsPath.AddCurve(myPointArray)
            //        myGraphicsPath.AddString("О сколько нам открытий...", _
            //        myFontFamily, 0, 32, myPointF, myStringFormat)
            //        Dim CurvePoints As PointF() = {
            //                New PointF(300.0F, 100.0F), _
            //New PointF(350.0F, 200.0F), New PointF(200.0F, 200.0F), _
            //New PointF(130.0F, 230.0F)}
            //            myGraphicsPath.AddPolygon(CurvePoints)
            //        Dim G As Graphics
            //        G = MyPictureBox.CreateGraphics
            //        Dim MyPen As New Pen(Color.Black, 1)
            //        Dim pthGrBrush As New PathGradientBrush(myGraphicsPath)
            //        pthGrBrush.CenterColor = Color.DarkRed
            //        Dim colors As Color() = { Color.DarkViolet}
            //        pthGrBrush.SurroundColors = colors
            //        G.FillPath(pthGrBrush, myGraphicsPath)
            //        G.DrawPath(MyPen, myGraphicsPath)
            var grPath = new GraphicsPath();
            grPath.AddArc(0, 0, 30, 60, 30, 180);
            grPath.AddCurve(
                new Point[] { new Point(15, 50), new Point(20, 40), new Point(50, 30) }
            );
            grPath.AddString(
                "О сколько нам открытий...", new FontFamily("Comic Sans Ms"),
                0, 32, new PointF(50, 50), new StringFormat()
            );
            grPath.AddPolygon(
                new PointF[] {
                    new PointF(300.0F, 100.0F), new PointF(350.0F, 200.0F),
                    new PointF(200.0F, 200.0F), new PointF(130.0F, 230.0F)
                }
            );
            var gr = e.Graphics;
            var grBrush = new PathGradientBrush(grPath);
            grBrush.CenterColor = Color.DarkRed;
            grBrush.SurroundColors = new Color[] { Color.DarkViolet };
            gr.FillPath(grBrush, grPath);
            gr.DrawPath(new Pen(Color.Black, 1), grPath);
        }
    }
}            
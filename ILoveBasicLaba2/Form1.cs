﻿using ILoveBasicLaba2.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
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
                0, 32, new PointF(50, 50), StringFormat.GenericDefault
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

        private void tabPage11_Paint(object sender, PaintEventArgs e)
        {
            //' Строим градиент, основанный на массиве точке
            //Dim myPoints As PointF() = {
            //        _
            //New PointF(30, 0), _
            //New PointF(60, 0), _
            //New PointF(90, 30), _
            //New PointF(90, 60), _
            //New PointF(60, 90), _
            //New PointF(30, 90), _
            //New PointF(0, 60), _
            //New PointF(0, 30)}

            //Dim myBrush As New PathGradientBrush(myPoints)
            //Dim colors As Color() = {
            //        _
            //   Color.FromArgb(255, 255, 0, 0), _
            //   Color.FromArgb(255, 0, 255, 0), _
            //   Color.FromArgb(255, 0, 0, 255), _
            //   Color.FromArgb(255, 0, 255, 0), _
            //   Color.FromArgb(255, 255, 0, 0), _
            //   Color.FromArgb(255, 0, 255, 0), _
            //   Color.FromArgb(255, 0, 0, 255), _
            //   Color.FromArgb(255, 255, 0, 0)}
            //    myBrush.SurroundColors = colors
            //' Центр будет белым
            //myBrush.CenterColor = Color.White
            //' Используем градиентную кисть для заливки прямоугольника
            //pe.Graphics.FillRectangle(myBrush, New Rectangle(0, 0, 200, 200))

            var grBrush = new PathGradientBrush(new PointF[] {
                new PointF(30, 0), new PointF(60, 0), new PointF(90, 30),
                new PointF(90, 60), new PointF(60, 90), new PointF(30, 90),
                new PointF(0, 60), new PointF(0, 30)
            });

            grBrush.SurroundColors = new Color[] {
                Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 0, 0, 255), Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 0, 0, 255), Color.FromArgb(255, 255, 0, 0)
            };

            e.Graphics.FillRectangle(grBrush, new Rectangle(0, 0, 200, 200));
        }

        private void tabPage13_Paint(object sender, PaintEventArgs e)
        {
            //' Вершины внешнего квадрата
            //Dim myPoints As Point() = {
            //    New Point(0, 0), _
            //    New Point(200, 0), New Point(200, 200), New Point(0, 200)}
            //' Градиентный путь не используется. 
            //'Градиентная кисть строится прямо из массива точек
            //Dim myBrush As New PathGradientBrush(myPoints)

            //' Создаем массив цветов
            //Dim colors As Color() = {
            //        _
            //   Color.FromArgb(255, 0, 128, 0), _
            //   Color.FromArgb(255, 128, 0, 255), _
            //   Color.FromArgb(255, 0, 128, 128)}
            //Dim relativePositions As Single() = { 0.0F, 0.4F, 1.0F}
            //Dim colorBlend As New ColorBlend
            //colorBlend.Colors = colors
            //colorBlend.Positions = relativePositions
            //myBrush.InterpolationColors = colorBlend
            //' Заливаем прямоугольник, больший по размерам, чем квадрат
            //pe.Graphics.FillRectangle(myBrush, 0, 0, 200, 200)

            var intrBrush = new PathGradientBrush(new Point[] {
                new Point(0, 0), new Point(200, 0), new Point(200, 200), new Point(0, 200)
            });

            var cb = new ColorBlend();
            cb.Colors = new Color[] {
                Color.FromArgb(255, 0, 128, 0),
                Color.FromArgb(255, 128, 0, 255),
                Color.FromArgb(255, 0, 128, 128)
            };
            cb.Positions = new float[] { 0, 0.4f, 1 };
            intrBrush.InterpolationColors = cb;

            e.Graphics.FillRectangle(intrBrush, 0, 0, 200, 200);
        }

        private void tabPage15_Paint(object sender, PaintEventArgs e)
        {
            //Dim img As Image
            //img = Image.FromFile("c:/Texture.jpg")
            //Dim tBrush As New TextureBrush(img)
            //Dim texturedPen As New Pen(tBrush, 60)
            //pe.Graphics.DrawImage(img, 0, 0, img.Width, img.Height)
            //pe.Graphics.DrawEllipse(texturedPen, 20, 20, 250, 200)

            var img = Resources.Texture;
            e.Graphics.DrawImage(img, 0, 0, img.Width, img.Height);
            e.Graphics.DrawEllipse(new Pen(new TextureBrush(img), 60), 20, 20, 250, 200);
        }

        private void tabPage8_Paint(object sender, PaintEventArgs e)
        {

            //Dim linGrBrush As New LinearGradientBrush(New Point(0, 10), _
            //New Point(200, 10), Color.DarkOliveGreen, Color.DarkOrchid)
            //Dim FirstCurvePoints As PointF() = {
            //New PointF(0.0F, 0.0F), _
            //New PointF(100.0F, 50.0F), New PointF(200.0F, 5.0F), _
            //New PointF(250.0F, 50.0F)}

            //Dim SecondCurvePoints As PointF() = {
            //New PointF(300.0F, 100.0F), _
            //New PointF(350.0F, 200.0F), New PointF(200.0F, 200.0F), _
            //New PointF(130.0F, 230.0F)}

            //    ' Объявляем путь
            //Dim graphPath As New GraphicsPath
            //' Добавляем к пути первый полигон
            //graphPath.AddPolygon(FirstCurvePoints)
            //' Добавляем к пути второй полигон
            //graphPath.AddPolygon(SecondCurvePoints)
            //' Закрашиваем путь градиентной заливкой
            //pe.Graphics.FillPath(linGrBrush, graphPath)

            var linGrBrush = new LinearGradientBrush(new Point(0, 10), new Point(200, 10),
                Color.DarkOliveGreen, Color.DarkOrchid);

            PointF[] FirstCurvePoints = new PointF[] {
                new PointF(0.0F, 0.0F),
                new PointF(100.0F, 50.0F),
                new PointF(200.0F, 5.0F),
                new PointF(250.0F, 50.0F)
            };

            PointF[] SecondCurvePoints = new PointF[] {
                new PointF(300.0F, 100.0F),
                new PointF(350.0F, 200.0F),
                new PointF(200.0F, 200.0F),
                new PointF(130.0F, 230.0F)
            };

            var graphPath = new GraphicsPath();
            graphPath.AddPolygon(FirstCurvePoints);
            graphPath.AddPolygon(SecondCurvePoints);
            e.Graphics.FillPath(linGrBrush, graphPath);
        }

        private void tabPage10_Paint(object sender, PaintEventArgs e)
        {
            //Dim MyRectangle As New Rectangle(0, 0, 200, 200)
            //Dim MyPen As New Pen(Color.Red, 2)

            //Dim path As New GraphicsPath
            //path.AddEllipse(MyRectangle)

            //Dim pthGrBrush As New PathGradientBrush(path)
            //' Центр пути будет красного цвета
            //pthGrBrush.CenterColor = Color.FromArgb(255, 255, 0, 0)
            //pe.Graphics.DrawEllipse(MyPen, MyRectangle)
            //pe.Graphics.FillPath(pthGrBrush, path)

            var path = new GraphicsPath();
            path.AddEllipse(new Rectangle(0, 0, 200, 200));

            var pthGrBrush = new PathGradientBrush(path);
            pthGrBrush.CenterColor = Color.FromArgb(255, 255, 0, 0);
            e.Graphics.DrawEllipse(new Pen(Color.Red, 2), new Rectangle(0, 0, 200, 200));
            e.Graphics.FillPath(pthGrBrush, path);

        }

        private void tabPage12_Paint(object sender, PaintEventArgs e)
        {
            //    ' Создаем путь содержащий отдельный прямоугольник
            //Dim MyPath As New GraphicsPath
            //MyPath.AddRectangle(New Rectangle(0, 0, 200, 100))

            //' Создаем градиентную кисть, основанную на пути прямоугольника
            //Dim myBrush As New PathGradientBrush(MyPath)
            //' Цвет за пределами границы будет красным
            //' Изменяем имя переменной для цвета
            //Dim redColor As Color() = { Color.Red}
            //    myBrush.SurroundColors = redColor
            //' Цвет центра будет морской волны
            //myBrush.CenterColor = Color.Aqua
            //' Используем градиентную ксить для заливки прямоугольника
            //pe.Graphics.FillPath(myBrush, MyPath)
            //' Устанавливаем масштаб фокуса для градиентной кисти
            //myBrush.FocusScales = New PointF(0.2F, 0.5F)
            //' Используем градиентную кисть для заливки прямоугольника снова
            //' Показываем этот залитый прямоугольник справа 
            //‘от первого залитого прямоугольника
            //pe.Graphics.TranslateTransform(0.0F, 150.0F)
            //pe.Graphics.FillPath(myBrush, MyPath)

            var MyPath = new GraphicsPath();
            MyPath.AddRectangle(new Rectangle(0, 0, 200, 100));

            var myBrush = new PathGradientBrush(MyPath);
            myBrush.SurroundColors = new Color[] { Color.Red };
            myBrush.CenterColor = Color.Aqua;

            e.Graphics.FillPath(myBrush, MyPath);

            myBrush.FocusScales = new PointF(0.2F, 0.5F);
            e.Graphics.TranslateTransform(0.0F, 150.0F);
            e.Graphics.FillPath(myBrush, MyPath);
        }

        private void tabPage14_Paint(object sender, PaintEventArgs e)
        {
            //' Создаем путь, содержащий полигон
            //Dim path As New GraphicsPath
            //Dim Mypoints As PointF() = {
            //    New Point(0, 200), _
            //New Point(200, 0), New Point(400, 200), _
            //New Point(200, 400)}
            //path.AddPolygon(Mypoints)

            //' Используем путь для создания кисти
            //Dim pthGrBrush As New PathGradientBrush(path)
            //' Размещаем центральную точку,
            //' не являющуюся центром полигона
            //pthGrBrush.CenterPoint = New PointF(120, 40)
            //pthGrBrush.CenterColor = Color.DarkRed

            //Dim colors As Color() = { Color.CornflowerBlue}
            //pthGrBrush.SurroundColors = colors
            //pe.Graphics.FillPolygon(pthGrBrush, Mypoints)

            var path = new GraphicsPath();
            var Mypoints = new PointF[] {
                new Point(0, 200),
                new Point(200, 0),
                new Point(400, 200),
                new Point(200, 400)
            };
            path.AddPolygon(Mypoints);

            var pthGrBrush = new PathGradientBrush(path);
            pthGrBrush.CenterPoint = new PointF(120, 40);
            pthGrBrush.CenterColor = Color.DarkRed;
            pthGrBrush.SurroundColors = new Color[] { Color.CornflowerBlue };
            e.Graphics.FillPolygon(pthGrBrush, Mypoints);
        }

        private void tabPage17_Paint(object sender, PaintEventArgs e)
        {
            // 'Создаем первый путь
            // Dim FirstPath As New GraphicsPath
            // 'Добавляем к первому путиэллипс
            // FirstPath.AddEllipse(New Rectangle(0, 0, 200, 100))

            // 'Добавляем к области первый путь
            // Dim myRegion As New[Region](FirstPath)

            //'Создаем второй путь
            // Dim SecondPath As New GraphicsPath
            // Dim myBrush As New SolidBrush(Color.Red)
            // 'Добавляем прямоугольник ко второму пути
            // SecondPath.AddRectangle(New Rectangle(50, 50, 250, 150))

            // 'Вычитаем второй путь из области
            // myRegion.Xor(SecondPath)
            // pe.Graphics.FillRegion(myBrush, myRegion)


            var fpath = new GraphicsPath();
            fpath.AddEllipse(new Rectangle(0, 0, 200, 100));
            var reg = new Region(fpath);

            var spath = new GraphicsPath();
            spath.AddRectangle(new Rectangle(50, 50, 250, 150));
            reg.Xor(spath);

            e.Graphics.FillRegion(new SolidBrush(Color.Red), reg);
        }

        private void tabPage19_Paint(object sender, PaintEventArgs e)
        {
            // Dim FirstPath As New GraphicsPath
            // Dim SecondPath As New GraphicsPath

            // ' Создаем эллипс и отображаем его на экране 
            // ' с помощью черного цвета
            // Dim regionRect As New Rectangle(20, 20, 100, 100)
            // FirstPath.AddEllipse(regionRect)

            // pe.Graphics.DrawPath(Pens.Black, FirstPath)


            // ' Создаем второй эллипс, пересекающийся с первым, 
            // 'и отображаем его на экране с помощью красного цвета
            // Dim complementRect As New Rectangle(90, 30, 100, 100)
            // SecondPath.AddEllipse(complementRect)

            // pe.Graphics.DrawPath(Pens.Red, SecondPath)

            // ' Создаем две области, используя соответственно 
            // 'первый и второй пути
            // Dim myRegion As New[Region](FirstPath)
            //' Возвращаем дополнение первой области 
            // 'при объединении со второй областью
            // Dim complementRegion As New[Region](SecondPath)
            //' Выполняем заливку области дополнения 
            // 'синим цветом и изображаем ее на экране
            // myRegion.Complement(SecondPath)
            // ' Заливаем дополнение синим цветом
            // Dim myBrush As New SolidBrush(Color.Blue)
            // pe.Graphics.FillRegion(myBrush, myRegion)
            var fPath = new GraphicsPath();
            fPath.AddEllipse(new Rectangle(20, 20, 100, 100));
            e.Graphics.DrawPath(Pens.Black, fPath);

            var sPath = new GraphicsPath();
            sPath.AddEllipse(new Rectangle(90, 30, 100, 100));
            e.Graphics.DrawPath(Pens.Red, sPath);

            var reg = new Region(fPath);
            reg.Complement(sPath);
            e.Graphics.FillRegion(new SolidBrush(Color.Blue), reg);
        }

        private void tabPage21_Paint(object sender, PaintEventArgs e)
        {
            // Dim FirstPath As New GraphicsPath
            // Dim SecondPath As New GraphicsPath

            // ' Создаем первый эллипс и отображаем 
            // 'его на экране с помощью черного цвета
            // Dim regionRect As New Rectangle(20, 20, 100, 100)
            // FirstPath.AddEllipse(regionRect)
            // pe.Graphics.DrawPath(Pens.Black, FirstPath)
            // ' Создаем второй эллипс и отображаем его 
            // 'на экране с помощью красного цвета
            // Dim complementRect As New RectangleF(90, 30, 100, 100)
            // SecondPath.AddEllipse(complementRect)
            // pe.Graphics.DrawPath(Pens.Red, SecondPath)
            // ' Создаем область, используя первый эллипс
            // Dim myRegion As New[Region](FirstPath)
            //' Возвращаем для области область пересечения 
            // 'при объединении со вторым эллипсом
            // myRegion.Intersect(SecondPath)
            // ' Выполняем заливку области пересечения 
            // 'синим цветом и отображаем ее на экране
            // Dim myBrush As New SolidBrush(Color.Blue)
            // pe.Graphics.FillRegion(myBrush, myRegion)
            var fPath = new GraphicsPath();
            fPath.AddEllipse(new Rectangle(20, 20, 100, 100));
            e.Graphics.DrawPath(Pens.Black, fPath);

            var sPath = new GraphicsPath();
            sPath.AddEllipse(new Rectangle(90, 30, 100, 100));
            e.Graphics.DrawPath(Pens.Red, sPath);

            var reg = new Region(fPath);
            reg.Intersect(sPath);
            e.Graphics.FillRegion(new SolidBrush(Color.Blue), reg);

        }

        private void tabPage23_Paint(object sender, PaintEventArgs e)
        {
            //Dim FirstRectangle As New Rectangle(100, 80, 3, 3)
            //Dim SecondRectangle As New Rectangle(-60, -30, 120, 60)
            //Dim graphics As Graphics = pe.Graphics
            //Dim pen As New Pen(Color.Black)
            //Dim graphicsContainer As GraphicsContainer
            //graphics.FillEllipse(Brushes.Black, FirstRectangle)
            //graphics.TranslateTransform(100, 80)
            //graphicsContainer = graphics.BeginContainer()
            //'Вращение на 45 градусов
            //graphics.RotateTransform(45)
            //graphics.DrawEllipse(pen, SecondRectangle)
            //graphics.EndContainer(graphicsContainer)
            //graphics.DrawEllipse(pen, SecondRectangle)

            var g = e.Graphics;
            g.FillEllipse(Brushes.Black, new Rectangle(100, 80, 3, 3));
            g.TranslateTransform(100, 80);

            var gc = g.BeginContainer();
            g.RotateTransform(45);
            g.DrawEllipse(Pens.Red, new Rectangle(-60, -30, 120, 60));
            g.EndContainer(gc);
            g.DrawEllipse(Pens.Blue, new Rectangle(-60, -30, 120, 60));
        }

        private void tabPage25_Paint(object sender, PaintEventArgs e)
        {
            //Dim graphics As Graphics = pe.Graphics
            //Dim innerContainer As GraphicsContainer
            //Dim outerContainer As GraphicsContainer
            //Dim brush As New SolidBrush(Color.Blue)
            //Dim fontFamily As New FontFamily("Comic Sans MS")
            //Dim font As New Font(fontFamily, 24, FontStyle.Regular, _
            //GraphicsUnit.Pixel)
            //graphics.TextRenderingHint = TextRenderingHint.AntiAlias
            //outerContainer = graphics.BeginContainer()
            //graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixel
            //innerContainer = graphics.BeginContainer()
            //graphics.TextRenderingHint = TextRenderingHint.AntiAlias
            //graphics.DrawString("Внутренний контейнер", font, brush, New _
            //PointF(0, 10))
            //graphics.EndContainer(innerContainer)
            //graphics.DrawString("Внешний контейнер", font, brush, New _
            // PointF(0, 40))
            //graphics.EndContainer(outerContainer)
            //graphics.DrawString("Графический объект", font, brush, New _
            //PointF(0, 80))
            var g = e.Graphics;
            var font = new Font(
                new FontFamily("Comic Sans MS"), 24, 
                FontStyle.Regular, GraphicsUnit.Pixel
            );

            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            var outer = g.BeginContainer();

            g.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
            var inner = g.BeginContainer();

            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.DrawString("Внутренний контейнер", font, Brushes.Blue, new PointF(0, 10));
            g.EndContainer(inner);

            g.DrawString("Внешний контейнер", font, Brushes.Blue, new PointF(0, 50));
            g.EndContainer(outer);

            g.DrawString("Графический объект", font, Brushes.Blue, new PointF(0, 90));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Dim myStream As Stream
            //Dim MyopenFileDialog As New OpenFileDialog()

            //MyopenFileDialog.InitialDirectory = "c:\"
            //MyopenFileDialog.Filter = "Images|*.GIF;*JPG;*.TIF;*BMP"
            //MyopenFileDialog.FilterIndex = 2
            //MyopenFileDialog.RestoreDirectory = True

            //If MyopenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            //    myStream = MyopenFileDialog.OpenFile()
            //    If Not(myStream Is Nothing) Then
            //    MyPictureBox.Image = Image.FromFile(MyopenFileDialog.FileName)
            //        myStream.Close()
            //    End If
            //End If
            var dlg = new OpenFileDialog();
            dlg.Filter = "Images|*.GIF;*JPG;*.TIF;*BMP";
            dlg.FilterIndex = 2;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tabPage27.BackgroundImage = Image.FromFile(dlg.FileName);
            }
        }

        private void tabPage29_Paint(object sender, PaintEventArgs e)
        {
            //Dim img As Image
            //img = Image.FromFile("c:\Sea.jpg")
            //Dim Point1 As New Point(50, 50)
            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //G.DrawImage(img, Point1)

            e.Graphics.DrawImage(Resources.Sea, new Point(50, 50));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Convert.ToInt32(numericUpDown1.Value) - 1;
        }

        private void tabPage31_Paint(object sender, PaintEventArgs e)
        {
            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //G.Clear(Color.White)
            //Dim myBitmap As New Imaging.Metafile("c:/phone.wmf")
            //G.DrawImage(myBitmap, 10, 10)

            e.Graphics.DrawImage(new System.Drawing.Imaging.Metafile("..\\..\\..\\PictureGlava4\\phone.wmf"), new Point(50, 50));
        }

        private void tabPage33_Paint(object sender, PaintEventArgs e)
        {
            //Dim WMfont As New Font("Comic Sans MS", 40, FontStyle.Bold)
            //Dim WMBrush As New SolidBrush(Color.FromArgb(92, 9, 97, 18))
            //MyPictureBox.CreateGraphics.DrawString("MySite.ru", WMfont, _
            //WMBrush, 100, 40)

            //Dim img As Image
            //img = Image.FromFile("c:\OlympicPark.jpg")
            //MyPictureBox.Image = img

            e.Graphics.DrawString("MySite.ru", 
                new Font("Comic Sans MS", 40, FontStyle.Bold), 
                new SolidBrush(Color.FromArgb(92, 9, 97, 30)), 
                new Point(100, 40)
            );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MyPictureBox.Image = Image.FromFile("c:/building.jpg")
            //Dim bmap As New Bitmap(MyPictureBox.Image)
            //MyPictureBox.Image = bmap
            //Dim tempbmp As New Bitmap(MyPictureBox.Image)
            //Dim DX As Integer = 1
            //Dim DY As Integer = 1
            //Dim red, green, blue As Integer
            //Dim i, j As Integer
            //With tempbmp
            //    For i = DX To.Height - DX - 1
            //        For j = DY To.Width - DY - 1
            //            red = CInt((CInt(.GetPixel(j - 1, i - 1).R) + _
            //            CInt(.GetPixel(j - 1, i).R) + _
            //            CInt(.GetPixel(j - 1, i + 1).R) + _
            //            CInt(.GetPixel(j, i).R) + _
            //            CInt(.GetPixel(j + 1, i - 1).R) + _
            //            CInt(.GetPixel(j + 1, i).R) + _
            //            CInt(.GetPixel(j + 1, i + 1).R)) / 9)

            //            green = CInt((CInt(.GetPixel(j - 1, i - 1).G) + _
            //            CInt(.GetPixel(j - 1, i).G) + _
            //            CInt(.GetPixel(j - 1, i + 1).G) + _
            //            CInt(.GetPixel(j, i).G) + _
            //            CInt(.GetPixel(j + 1, i - 1).G) + _
            //            CInt(.GetPixel(j + 1, i).G) + _
            //            CInt(.GetPixel(j + 1, i + 1).G)) / 9)

            //            blue = CInt((CInt(.GetPixel(j - 1, i - 1).B) + _
            //            CInt(.GetPixel(j - 1, i).B) + _
            //            CInt(.GetPixel(j - 1, i + 1).B) + _
            //            CInt(.GetPixel(j, i).B) + _
            //            CInt(.GetPixel(j + 1, i - 1).B) + _
            //            CInt(.GetPixel(j + 1, i).B) + _
            //            CInt(.GetPixel(j + 1, i + 1).B)) / 9)

            //            red = Math.Min(Math.Max(red, 0), 255)
            //            green = Math.Min(Math.Max(green, 0), 255)
            //            blue = Math.Min(Math.Max(blue, 0), 255)

            //            bmap.SetPixel(j, i, Color.FromArgb(red, green, blue))

            //            If i Mod 10 = 0 Then
            //                MyPictureBox.Invalidate()
            //                MyPictureBox.Refresh()
            //                Me.Text = Int(100 * i / _
            //                (MyPictureBox.Image.Height - 2)).ToString & "%"
            //            End If

            //        Next j
            //    Next i
            //End With
            //Me.Text = "Создание эффекта сглаживания выполнено!"
            var bmp = new Bitmap(tabPage35.BackgroundImage);
            var tmp = new Bitmap(bmp);
            int dx = 1, dy = 3;
            for(int i = dx; i < tmp.Width - dx; i++)
                for(int j = dy; j < tmp.Height - dy; j++)
                {
                    int r = 0, g = 0, b = 0;
                    for (int di = -dx; di <= dx; di++)
                        for (int dj = -dy; dj <= dy; dj++)
                        {
                            r += tmp.GetPixel(i + di, j + dj).R;
                            g += tmp.GetPixel(i + di, j + dj).G;
                            b += tmp.GetPixel(i + di, j + dj).B;
                        }
                    r /= (2 * dx + 1) * (2 * dy + 1);
                    g /= (2 * dx + 1) * (2 * dy + 1);
                    b /= (2 * dx + 1) * (2 * dy + 1);
                    bmp.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            tabPage35.BackgroundImage = bmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MyPictureBox.Image = Image.FromFile("c:/skyscraper.jpg")

            //Dim bmap As New Bitmap(MyPictureBox.Image)
            //MyPictureBox.Image = bmap
            //Dim tempbmp As New Bitmap(MyPictureBox.Image)
            //Dim DispX As Integer = 1
            //Dim DispY As Integer = 1
            //Dim red, green, blue As Integer
            //Dim i, j As Integer
            //With tempbmp
            //    For i = 0 To.Height - 2
            //        For j = 0 To.Width - 2
            //            Dim Pixel1, Pixel2 As System.Drawing.Color
            //            Pixel1 = .GetPixel(j, i)
            //            Pixel2 = .GetPixel(j + DispX, i + DispY)
            //            red = Math.Min(Math.Abs(CInt(Pixel1.R) - _
            //            CInt(Pixel2.R)) + 128, 255)
            //            green = Math.Min(Math.Abs(CInt(Pixel1.G) - _
            //            CInt(Pixel2.G)) + 128, 255)
            //            blue = Math.Min(Math.Abs(CInt(Pixel1.B) - _
            //            CInt(Pixel2.B)) + 128, 255)
            //            bmap.SetPixel(j, i, Color.FromArgb(red, green, blue))

            //            If i Mod 10 = 0 Then
            //                MyPictureBox.Invalidate()
            //                MyPictureBox.Refresh()
            //                Me.Text = Int(100 * i / _
            //                 (MyPictureBox.Image.Height - 2)).ToString & "%"
            //            End If

            //        Next j
            //    Next i
            //End With
            //MyPictureBox.Refresh()
            //Me.Text = "Создание эффекта рельефа изображения выполнено!"            

            var bmp = new Bitmap(tabPage37.BackgroundImage);
            int dispx = 1, dispy = 1;
            for (int i = 0; i < bmp.Width - dispx; i++)
                for (int j = 0; j < bmp.Height - dispy; j++)
                {
                    int r = Math.Abs(bmp.GetPixel(i, j).R - bmp.GetPixel(i + dispx, j + dispy).R) + 128;
                    int g = Math.Abs(bmp.GetPixel(i, j).G - bmp.GetPixel(i + dispx, j + dispy).G) + 128;
                    int b = Math.Abs(bmp.GetPixel(i, j).B - bmp.GetPixel(i + dispx, j + dispy).B) + 128;
                    bmp.SetPixel(i, j, Color.FromArgb(Math.Min(r, 255), Math.Min(g, 255), Math.Min(b, 255)));
                }
            tabPage37.BackgroundImage = bmp;
        }

        private void tabPage39_Paint(object sender, PaintEventArgs e)
        {
            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //G.Clear(Color.White)
            //Dim myBitmap As New Bitmap("c:/Boy.jpg")
            //Dim expansionRectangle As New Rectangle(135, 10, _
            //myBitmap.Width, myBitmap.Height)
            //Dim compressionRectangle As New Rectangle(400, 10, _
            //myBitmap.Width / 2, myBitmap.Height / 2)
            //G.DrawImage(myBitmap, 0, 0)
            //G.DrawImage(myBitmap, expansionRectangle)
            //G.DrawImage(myBitmap, compressionRectangle)
            var img = Resources.Boy;
            e.Graphics.DrawImage(img, 0, 0);
            e.Graphics.DrawImage(img, new Rectangle(135, 10, img.Width, img.Height)); 
            e.Graphics.DrawImage(img, new Rectangle(400, 10, img.Width / 2, img.Height / 2));
        }

        private void correct_picture()
        {
            //Dim XOffset, YOffset As Integer
            //XOffset = MyHScrollBar.Value
            //YOffset = MyVScrollBar.Value

            //Dim img As Image
            //img = Image.FromFile("c:/Sport.jpg")
            //Dim Point1 As New Point(XOffset, YOffset)
            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //G.Clear(Color.White)
            //G.DrawImage(img, Point1)
            var g = tabPage41.CreateGraphics();
            g.Clear(Color.White);
            var img = Resources.Sport;
            int x = hScrollBar1.Value * (tabPage41.Width - img.Width) / 100;
            int y = vScrollBar2.Value * (tabPage41.Height - img.Height) / 100;
            g.DrawImage(img, new Point(x, y));
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            correct_picture();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            correct_picture();
        }

        private void correct_picture_1()
        {
            //Dim Angle As Single
            //Angle = MyHScrollBar.Value
            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //G.Clear(Color.White)
            //G.TranslateTransform(MyPictureBox.Width / 2, _
            //MyPictureBox.Height / 2)
            //G.RotateTransform(Angle)
            //DrawShape(G)
            var g = tabPage43.CreateGraphics();
            g.Clear(Color.White);
            g.TranslateTransform(300, 250);
            g.RotateTransform(360 * hScrollBar2.Value / 100);
            g.DrawImage(Resources.Car, new Point(0, 0));
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            correct_picture_1();
        }

        private void correct_ellipce()
        {
            //Dim XScaleFactor, YScaleFactor As Double
            //XScaleFactor = (MyHScrollBar.Value) / 100
            //YScaleFactor = (MyVScrollBar.Value) / 100
            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //Dim MyPen As New Pen(Color.Green, 2)
            //G.ScaleTransform(XScaleFactor, YScaleFactor)
            //G.Clear(Color.White)
            //G.DrawEllipse(MyPen, 100, 100, 300, 200)
            var g = tabPage45.CreateGraphics();
            g.Clear(Color.White);
            g.ScaleTransform(hScrollBar3.Value / 100.0f, vScrollBar1.Value / 100.0f);
            g.DrawEllipse(new Pen(Color.Green, 2), 100, 100, 300, 200);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            correct_ellipce();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            correct_ellipce();
        }

        private void tabPage45_Paint(object sender, PaintEventArgs e)
        {
            correct_ellipce();
        }
        
        private void tabPage41_Paint(object sender, PaintEventArgs e)
        {
            correct_picture();
        }

        private void tabPage43_Paint(object sender, PaintEventArgs e)
        {
            correct_picture_1();
        }

        private void tabPage16_Paint(object sender, PaintEventArgs e)
        {
            //'Создаем путь
            //Dim MyPath As New GraphicsPath
            //Dim FirstRectangle As New Rectangle(0, 0, 100, 50)
            //Dim SecondRectangle As New Rectangle(50, 50, 150, 100)
            //'Добавляем к пути эллипс и прямоугольник
            //MyPath.AddEllipse(FirstRectangle)
            //MyPath.AddRectangle(SecondRectangle)
            //'Добавляем путь к области
            //Dim myRegion As New[Region](MyPath)
            //Dim MyBrush As New SolidBrush(Color.DarkCyan)
            //'Закрашиваем область
            //pe.Graphics.FillRegion(MyBrush, myRegion)

            var MyPath = new GraphicsPath();
            var FirstRectangle = new Rectangle(0, 0, 100, 50);
            var SecondRectangle = new Rectangle(50, 50, 150, 100);
            MyPath.AddEllipse(FirstRectangle);
            MyPath.AddRectangle(SecondRectangle);
            var myRegion = new Region(MyPath);
            var MyBrush = new SolidBrush(Color.DarkCyan);
            e.Graphics.FillRegion(MyBrush, myRegion);

        }

        private void tabPage18_Paint(object sender, PaintEventArgs e)
        {
            //'Создаем первый путь
            //Dim FirstPath As New GraphicsPath
            //'Добавляем к первому путиэллипс
            //FirstPath.AddEllipse(New Rectangle(0, 0, 200, 100))

            //'Добавляем к области первый путь
            //Dim myRegion As New[Region](FirstPath)

            //'Создаем второй путь
            //Dim SecondPath As New GraphicsPath
            //Dim myBrush As New SolidBrush(Color.Red)
            //'Добавляем прямоугольник ко второму пути
            //SecondPath.AddRectangle(New Rectangle(50, 50, 250, 150))

            //'Объединяем второй путь с областью
            //myRegion.Union(SecondPath)
            //pe.Graphics.FillRegion(myBrush, myRegion)

            var FirstPath = new GraphicsPath();
            FirstPath.AddEllipse(new Rectangle(0, 0, 200, 100));
            
            var myRegion = new Region(FirstPath);
            var SecondPath = new GraphicsPath();
            var myBrush = new SolidBrush(Color.Red);
            
            SecondPath.AddRectangle(new Rectangle(50, 50, 250, 150));
            myRegion.Union(SecondPath);
            
            e.Graphics.FillRegion(myBrush, myRegion);
        }

        private void tabPage20_Paint(object sender, PaintEventArgs e)
        {
            //Dim FirstPath As New GraphicsPath
            //Dim SecondPath As New GraphicsPath

            //' Создаем эллипс и отображаем его 
            //'на экране с помощью черного цвета
            //Dim regionRect As New Rectangle(20, 20, 100, 100)
            //FirstPath.AddEllipse(regionRect)

            //pe.Graphics.DrawPath(Pens.Black, FirstPath)
            //' Создаем второй эллипс, пересекающийся с первым, 
            //'и отображаем его на экране с помощью красного цвета
            //Dim complementRect As New RectangleF(90, 30, 100, 100)
            //SecondPath.AddEllipse(complementRect)


            //pe.Graphics.DrawPath(Pens.Red, SecondPath)
            //' Создаем область, используя первый эллипс
            //Dim myRegion As New[Region](FirstPath)
            //' Возвращаем неисключенную часть области 
            //'при объединении со вторым эллипсом
            //myRegion.Exclude(SecondPath)
            //' Выполняем заливку неисключенной области 
            //'синим цветом и изображает ее на экране
            //Dim myBrush As New SolidBrush(Color.Blue)
            //pe.Graphics.FillRegion(myBrush, myRegion)

            var FirstPath = new GraphicsPath();
            var SecondPath = new GraphicsPath();

            var regionRect = new Rectangle(20, 20, 100, 100);
            FirstPath.AddEllipse(regionRect);
            e.Graphics.DrawPath(Pens.Black, FirstPath);

            var complementRect = new RectangleF(90, 30, 100, 100);
            SecondPath.AddEllipse(complementRect);
            e.Graphics.DrawPath(Pens.Red, SecondPath);

            var myRegion = new Region(FirstPath);
            myRegion.Exclude(SecondPath);
            var myBrush = new SolidBrush(Color.Blue);
            e.Graphics.FillRegion(myBrush, myRegion);

        }

        private void tabPage22_Paint(object sender, PaintEventArgs e)
        {
            //Dim FirstPath As New GraphicsPath
            //Dim SecondPath As New GraphicsPath

            //' Создаем эллипс и отображаем его 
            //'на экране с помощью синего цвета
            //Dim regionRect As New Rectangle(150, 50, 100, 200)
            //FirstPath.AddEllipse(regionRect)
            //pe.Graphics.DrawPath(Pens.Blue, FirstPath)

            //' Создаем область из эллипса
            //Dim myRegion As New[Region](FirstPath)

            //' Создаем матрицу преобразования и 
            //'устанавливаем ее на 45 градусов
            //Dim transformMatrix As New Matrix
            //transformMatrix.RotateAt(45, New PointF(175, 0))
            //' Применяем к области преобразование
            //myRegion.Transform(transformMatrix)
            //' Выполняем заливку преобразованной области 
            //'красным цветом и отображаем ее на экране
            //Dim myBrush As New SolidBrush(Color.Red)
            //pe.Graphics.FillRegion(myBrush, myRegion)

            var FirstPath = new GraphicsPath();

            var regionRect = new Rectangle(150, 50, 100, 200);
            FirstPath.AddEllipse(regionRect);
            e.Graphics.DrawPath(Pens.Blue, FirstPath);

            var myRegion = new Region(FirstPath);
            var transformMatrix = new Matrix();

            transformMatrix.RotateAt(45, new PointF(175, 0));
            myRegion.Transform(transformMatrix);

            var myBrush = new SolidBrush(Color.Red);
            e.Graphics.FillRegion(myBrush, myRegion);

        }

        private void tabPage24_Paint(object sender, PaintEventArgs e)
        {
            //Dim graphics As Graphics = pe.Graphics
            //Dim graphicsContainer As GraphicsContainer
            //Dim redPen As New Pen(Color.Red, 2)
            //Dim bluePen As New Pen(Color.Blue, 2)
            //Dim redBrush As New SolidBrush(Color.Red)
            //Dim greenBrush As New SolidBrush(Color.Green)


            //Dim Mypoints As PointF() = {
            //    New Point(0, 0), New Point(100, 10), _
            //New Point(200, 200), New Point(100, 400)}

            //Dim MyPath As New GraphicsPath
            //MyPath.AddPolygon(Mypoints)

            //graphics.SetClip(MyPath)

            //graphics.FillRectangle(redBrush, 20, 20, 150, 150)

            //graphicsContainer = graphics.BeginContainer()
            //' Создаем путь, содержащий отдельный эллипс
            //Dim path As New GraphicsPath
            //path.AddEllipse(30, 30, 150, 100)

            //' Создаем область, построенную на пути
            //Dim[region] As New[Region](path)
            //graphics.FillRegion(greenBrush, [region])

            //graphics.SetClip([region], CombineMode.Replace)
            //graphics.DrawLine(redPen, 50, 0, 350, 300)
            //graphics.EndContainer(graphicsContainer)

            //graphics.DrawLine(bluePen, 70, 0, 370, 300)

            var graphics = e.Graphics;
            GraphicsContainer graphicsContainer;

            var redPen = new Pen(Color.Red, 2);
            var bluePen = new Pen(Color.Blue, 2);
            var redBrush = new SolidBrush(Color.Red);
            var greenBrush = new SolidBrush(Color.Green);

            PointF[] Mypoints = {
                new Point(0, 0),
                new Point(100, 10),
                new Point(200, 200),
                new Point(100, 400)
            };

            var MyPath = new GraphicsPath();
            MyPath.AddPolygon(Mypoints);

            graphics.SetClip(MyPath);
            graphics.FillRectangle(redBrush, 20, 20, 150, 150);

            graphicsContainer = graphics.BeginContainer();

            var path = new GraphicsPath();
            path.AddEllipse(30, 30, 150, 100);

            var region = new Region(path);
            graphics.FillRegion(greenBrush, region);
            graphics.SetClip(region, CombineMode.Replace);
            graphics.DrawLine(redPen, 50, 0, 350, 300);
            graphics.EndContainer(graphicsContainer);
            graphics.DrawLine(bluePen, 70, 0, 370, 300);

        }

        private void tabPage26_Paint(object sender, PaintEventArgs e)
        {
            //Dim img As Image
            //img = Image.FromFile("c:\CheerLady.jpg")
            //MyPictureBox.Image = img

            Image img;
            img = Resources.CheerLady;
            pictureBox26.Image = img;

        }

        private void tabPage28_Paint(object sender, PaintEventArgs e)
        {
            //Dim img As Image
            //img = Image.FromFile("c:\Parad.jpg")
            //MyPictureBox.Image = img

            //MyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            //MyPictureBox.Invalidate()
            //Dim tmp As Integer
            //tmp = MyPictureBox.Width
            //MyPictureBox.Width = MyPictureBox.Height
            //MyPictureBox.Width = tmp

            Image img;
            img = Resources.Parad;

            pictureBox28.Image = img;
            pictureBox28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox28.Invalidate();

        }

        private void tabPage30_Paint(object sender, PaintEventArgs e)
        {
            //Dim Mypoints As PointF() = {
            //    New Point(0, 0), _
            //New Point(100, 10), _
            //New Point(200, 200), New Point(100, 400)}

            //Dim MyPath As New GraphicsPath
            //MyPath.AddPolygon(Mypoints)

            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //Dim clipRect As New RectangleF(0, 0, 300, 300)

            //G.SetClip(MyPath)
            //G.DrawImage(Image.FromFile("c:/Atlanta.jpg"), 0, 0)

            PointF[] Mypoints = {
                new Point(0, 0),
                new Point(100, 10),
                new Point(200, 200),
                new Point(100, 400)
            };
            var MyPath = new GraphicsPath();
            MyPath.AddPolygon(Mypoints);

            //RectangleF clipRect = new RectangleF(0, 0, 300, 300);
            e.Graphics.SetClip(MyPath);
            e.Graphics.DrawImage(Resources.Atlanta, 0, 0);

        }

        private void tabPage32_Paint(object sender, PaintEventArgs e)
        {
            //Dim newColor As Color
            //newColor = Color.FromArgb(128, 128, 128)
            //MyPictureBox.BackColor = newColor

            tabPage32.BackColor = Color.FromArgb(128, 128, 128);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //MyPictureBox.Image = Image.FromFile("c:/cnn.jpg")

            //Dim bmap As New Bitmap(MyPictureBox.Image)
            //MyPictureBox.Image = bmap
            //Dim tempbmp As New Bitmap(MyPictureBox.Image)
            //Dim DX As Integer = 1
            //Dim DY As Integer = 1
            //Dim red, green, blue As Integer
            //Dim i, j As Integer
            //For i = DX To.Height - DX - 1
            //    For j = DY To.Width - DY - 1
            //        tempbmp.red = 255 - CInt((CInt(.GetPixel(j - 1, i - 1).R)))
            //        tempbmp.green = 255 - CInt((CInt(.GetPixel(j - 1, i - 1).G)))
            //        tempbmp.blue = 255 - CInt((CInt(.GetPixel(j - 1, i - 1).B)))

            //        tempbmp.red = Math.Min(Math.Max(red, 0), 255)
            //        tempbmp.green = Math.Min(Math.Max(green, 0), 255)
            //        tempbmp.blue = Math.Min(Math.Max(blue, 0), 255)

            //        tempbmp.bmap.SetPixel(j, i, Color.FromArgb(red, green, blue))

            //        If i Mod 10 = 0 Then
            //            MyPictureBox.Invalidate()
            //            MyPictureBox.Refresh()
            //            Me.Text = Int(100 * i / _
            //            (MyPictureBox.Image.Height - 2)).ToString & "%"
            //        End If
            //    Next j
            //Next i
            //MyPictureBox.Refresh()

            Bitmap bmap = new Bitmap(pictureBox34.Image);
            Bitmap tempbmp = new Bitmap(pictureBox34.Image);
            int DX = 0;
            int DY = 0;
            int red;
            int green;
            int blue;
            int i;
            int j;
            for (i = DX; i <= tempbmp.Height - DX - 1; i++)
            {
                for (j = DY; j <= tempbmp.Width - DY - 1; j++)
                {
                    red = 255 - (int)((int)tempbmp.GetPixel(j, i).R);
                    green = 255 - (int)((int)tempbmp.GetPixel(j, i).G);
                    blue = 255 - (int)((int)tempbmp.GetPixel(j, i).B);
                    red = Math.Min(Math.Max(red, 0), 255);
                    green = Math.Min(Math.Max(green, 0), 255);
                    blue = Math.Min(Math.Max(blue, 0), 255);
                    bmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }
            }

            pictureBox34.Image = bmap;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //MyPictureBox.Image = Image.FromFile("c:/Church.jpg")

            //Dim bmap As New Bitmap(MyPictureBox.Image)
            //MyPictureBox.Image = bmap
            //Dim tempbmp As New Bitmap(MyPictureBox.Image)
            //Dim DX As Integer = 1
            //Dim DY As Integer = 1
            //Dim red, green, blue As Integer
            //Dim i, j As Integer
            //For i = DX To tempbmp.Height - DX - 1
            //For j = DY To tempbmp.Width - DY - 1
            //red = CInt(tempbmp.GetPixel(j, i).R) + 0.5 * _
            //CInt((tempbmp.GetPixel(j, i).R) - _
            //CInt(bmap.GetPixel(j - DX, i - DY).R))

            //green = CInt(tempbmp.GetPixel(j, i).G) + 0.5 * _
            //CInt((tempbmp.GetPixel(j, i).G) - _
            //CInt(bmap.GetPixel(j - DX, i - DY).G))

            //blue = CInt(tempbmp.GetPixel(j, i).B) + 0.5 * _
            //CInt((tempbmp.GetPixel(j, i).B) - _
            //CInt(bmap.GetPixel(j - DX, i - DY).B))



            //red = Math.Min(Math.Max(red, 0), 255)
            //green = Math.Min(Math.Max(green, 0), 255)
            //blue = Math.Min(Math.Max(blue, 0), 255)

            //bmap.SetPixel(j, i, Color.FromArgb(red, green, blue))

            //If i Mod 10 = 0 Then
            //MyPictureBox.Invalidate()
            //MyPictureBox.Refresh()
            //Me.Text = Int(100 * i / _
            //(MyPictureBox.Image.Height - 2)).ToString & "%"
            //End If

            //Next j
            //Next i
            //MyPictureBox.Refresh()

            Bitmap bmap = new Bitmap(pictureBox36.Image);
            Bitmap tempbmp = new Bitmap(pictureBox36.Image);
            int DX = 1;
            int DY = 1;
            int red;
            int green;
            int blue;
            int i;
            int j;
            for (i = DX; i <= tempbmp.Height - DX - 1; i++)
            {
                for (j = DY; j <= tempbmp.Width - DY - 1; j++)
                {
                    red = Convert.ToInt32((double)tempbmp.GetPixel(j, i).R + 0.5 * (double)(tempbmp.GetPixel(j, i).R) - bmap.GetPixel(j - DX, i - DY).R);
                    green = Convert.ToInt32((double)tempbmp.GetPixel(j, i).G + 0.5 * (double)(tempbmp.GetPixel(j, i).G) - bmap.GetPixel(j - DX, i - DY).G);
                    blue = Convert.ToInt32((double)tempbmp.GetPixel(j, i).B + 0.5 * (double)(tempbmp.GetPixel(j, i).B) - bmap.GetPixel(j - DX, i - DY).B);
                    
                    red = Math.Min(Math.Max(red, 0), 255);
                    green = Math.Min(Math.Max(green, 0), 255);
                    blue = Math.Min(Math.Max(blue, 0), 255);

                    bmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }
            }
            pictureBox36.Image = bmap;

        }

        private void tabPage38_Paint(object sender, PaintEventArgs e)
        {
            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //G.Clear(Color.White)
            //Dim originalBitmap As New Bitmap("c:/Boat.jpg")
            //Dim sourceRectangle As New Rectangle(0, 0, originalBitmap.Width, _
            //originalBitmap.Height / 2)
            //Dim secondBitmap As Bitmap = _
            //originalBitmap.Clone(sourceRectangle, Imaging.PixelFormat.DontCare)
            //G.DrawImage(originalBitmap, 10, 10)
            //G.DrawImage(secondBitmap, 250, 30)

            e.Graphics.Clear(Color.White);

            Bitmap originalBitmap = new Bitmap(Resources.Boat);
            Rectangle sourceRectangle = new Rectangle(0, 0, originalBitmap.Width, originalBitmap.Height / 2);
            Bitmap secondBitmap = originalBitmap.Clone(sourceRectangle, System.Drawing.Imaging.PixelFormat.DontCare);
            e.Graphics.DrawImage(originalBitmap, 10, 10);
            e.Graphics.DrawImage(secondBitmap, 250, 30);
        }

        private void tabPage40_Paint(object sender, PaintEventArgs e)
        {
            //G.Clear(Color.White)
            //Dim myBitmap As New Bitmap("c:/FootBall.jpg")
            //Dim sourceRectangle As New Rectangle(20, 70, 80, 45)
            //Dim destRectangle1 As New Rectangle(200, 10, 20, 16)
            //Dim destRectangle2 As New Rectangle(200, 40, 200, 160)
            //G.DrawImage(myBitmap, 0, 0)
            //G.DrawImage(myBitmap, destRectangle1, sourceRectangle, GraphicsUnit.Pixel)
            //G.DrawImage(myBitmap, destRectangle2, sourceRectangle, GraphicsUnit.Pixel)

            e.Graphics.Clear(Color.White);
            Bitmap myBitmap = new Bitmap(Resources.FootBall);

            Rectangle sourceRectangle = new Rectangle(20, 70, 80, 45);
            Rectangle destRectangle1 = new Rectangle(200, 10, 20, 16);
            Rectangle destRectangle2 = new Rectangle(200, 40, 200, 160);

            e.Graphics.DrawImage(myBitmap, 0, 0);
            e.Graphics.DrawImage(myBitmap, destRectangle1, sourceRectangle, GraphicsUnit.Pixel);
            e.Graphics.DrawImage(myBitmap, destRectangle2, sourceRectangle, GraphicsUnit.Pixel);

        }

        private void hScrollBar42_Scroll(object sender, ScrollEventArgs e)
        {
            //Dim XOffset, YOffset As Integer
            //XOffset = MyHScrollBar.Value
            //YOffset = MyVScrollBar.Value
            //Dim G As Graphics
            //G = MyPictureBox.CreateGraphics
            //Dim MyBox As New Rectangle(XOffset, YOffset, 100, 100)
            //Dim MyPen As New Pen(Color.Red, 2)
            //G.Clear(Color.White)
            //G.DrawRectangle(MyPen, MyBox)

            int XOffset;
            int YOffset;
            XOffset = hScrollBar42.Value;
            YOffset = vScrollBar42.Value;

            Graphics G = tabPage42.CreateGraphics();
            var MyBox = new Rectangle(XOffset, YOffset, 100, 100);
            var MyPen = new Pen(Color.Red, 2);
            G.Clear(Color.White);
            G.DrawRectangle(MyPen, MyBox);

        }

        private void hScrollBar44_Scroll(object sender, ScrollEventArgs e)
        {
            //G.Clear(Color.White)
            //Dim Minimum, Maximum, Value As Integer
            //Minimum = 0
            //Maximum = 370
            //MyHScrollBar.Minimum = Minimum
            //MyHScrollBar.Maximum = Maximum
            //MyHScrollBar.SmallChange = 0.1
            //MyHScrollBar.LargeChange = 10
            //Value = MyHScrollBar.Value
            //Dim x, y As Single
            //x = CSng(MyPictureBox.Width / 2)
            //y = CSng(MyPictureBox.Height / 2)

            //Dim rotatePoint As New PointF(x, y)
            //G.ResetTransform()

            //Dim myMatrix As New Matrix
            //myMatrix.RotateAt(Value, rotatePoint, MatrixOrder.Append)
            //G.Transform = myMatrix

            //Dim MyPen As Pen = New Pen(Color.Black, 1)
            //Dim Point1 As New Point((MyPictureBox.Width / 2) - 50, _
            //(MyPictureBox.Height / 2) - 50)
            //Dim Point2 As New Point((MyPictureBox.Width / 2) + 50, _
            //(MyPictureBox.Height / 2) + 50)
            //GraphicObject.DrawLine(MyPen, Point1, Point2)

            var G = tabPage44.CreateGraphics();
            G.Clear(Color.White);
            int Minimum, Maximum, Value;

            Minimum = 0;
            Maximum = 370;

            hScrollBar44.Minimum = Minimum;
            hScrollBar44.Maximum = Maximum;
            hScrollBar44.SmallChange = 1;
            hScrollBar44.LargeChange = 10;

            Value = hScrollBar44.Value;

            float x = (float)hScrollBar44.Width / 2;
            float y = (float)hScrollBar44.Height / 2;

            PointF rotatePoint = new PointF(x, y);

            G.ResetTransform();

            var myMatrix = new Matrix();
            myMatrix.RotateAt(Value, rotatePoint, MatrixOrder.Append);
            G.Transform = myMatrix;

            Pen MyPen = new Pen(Color.Black, 1);            
            var Point1 = new Point((hScrollBar44.Width / 2) - 50, (hScrollBar44.Height / 2) - 50);
            var Point2 = new Point((hScrollBar44.Width / 2) + 50, (hScrollBar44.Height / 2) + 50);

            G.DrawLine(MyPen, Point1, Point2);
        }

        //начало 46
        public class Beta
        {
            public double x;
            public double y;
            public Beta(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }

        void DrawShape(Graphics GraphicObject)
        {
            //Dim XPixels, YPixels As Single
            //XPixels = MyPictureBox.Width - 10
            //YPixels = MyPictureBox.Height - 10
            //Dim IterationCount As Integer
            //IterationCount = 1000
            //Dim XInitial, XFinal As Double
            //XInitial = -2 * Math.PI
            //XFinal = 2 * Math.PI
            //Dim Delta As Double
            //Delta = (XFinal - XInitial) / IterationCount
            //Dim i As Double
            //Dim MyList As New ArrayList
            //Dim FunctionList As New ArrayList
            //For i = XInitial To XFinal Step Delta
            //    MyList.Add(New Beta(i, Alpha(i)))
            //    FunctionList.Add(Alpha(i))
            //Next
            //FunctionList.Sort()
            //Dim YMin, Ymax As Double
            //YMin = FunctionList(0)
            //Ymax = FunctionList(FunctionList.Count - 1)
            //Dim MyPen As Pen = New Pen(Color.Black, 1)
            //Dim graphPath As New GraphicsPath
            //Dim blackPen As New Pen(Color.Black, 1)
            //Dim x(IterationCount), y(IterationCount) As Double
            //x(0) = XInitial
            //y(0) = Alpha(XInitial)
            //Dim XScale, YScale As Single
            //XScale = (XPixels / 2) / (XFinal - XInitial)
            //YScale = (YPixels / 2) / (Ymax - YMin)
            //Dim j As Integer
            //For j = 1 To IterationCount -1
            //    graphPath.AddLine(CInt(XScale * MyList(j - 1).x), _
            //    CInt(YScale * MyList(j - 1).y), _
            //    CInt(XScale * MyList(j).x), CInt(YScale * MyList(j).y))
            //Next
            //GraphicObject.DrawPath(blackPen, graphPath)


            float XPixels, YPixels;

            XPixels = tabPage46.Width - 10;
            YPixels = tabPage46.Height - 10;

            int IterationCount = 1000;

            double XInitial = -2 * Math.PI;
            double XFinal = 2 * Math.PI;
            double Delta = (XFinal - XInitial) / IterationCount;

            double i;

            List<Beta> MyList = new List<Beta>();
            List<double> FunctionList = new List<double>();

            for (i = XInitial; i <= XFinal; i += Delta)
            {
                MyList.Add(new Beta(i, Math.Sin(i)));
                FunctionList.Add(Math.Sin(i));
            }
            FunctionList.Sort();

            double YMin = FunctionList[0];
            double Ymax = FunctionList[FunctionList.Count - 1];

            var graphPath = new GraphicsPath();
            var blackPen = new Pen(Color.Black, 1);

            double[] x = new double[IterationCount];
            double[] y = new double[IterationCount];
            x[0] = XInitial;
            y[0] = Math.Sin(XInitial);

            double XScale = XPixels / (XFinal - XInitial);
            double YScale = YPixels / (Ymax - YMin);

            for (int j = 1; j <= IterationCount - 1; j++)
            {
                graphPath.AddLine((int)(XScale * MyList[j - 1].x), (int)(YScale * MyList[j - 1].y), (int)(XScale * MyList[j].x), (int)(YScale * MyList[j].y));
            }
            GraphicObject.DrawPath(blackPen, graphPath);
        }

        private void hScrollBar46_Scroll(object sender, ScrollEventArgs e)
        {
            //G.Clear(Color.White)
            //Dim Value As Integer
            //Value = MyHScrollBar.Value
            //Dim x, y As Single
            //x = MyPictureBox.Width / 2 + 300
            //y = MyPictureBox.Height / 2 + 300
            //Dim rotatePoint As New PointF(x, y)
            //G.ResetTransform()
            //Dim myMatrix As New System.Drawing.Drawing2D.Matrix
            //myMatrix.Rotate(Value)
            //myMatrix.Scale(0.3, 0.3)
            //myMatrix.Translate(x, y)
            //G.Transform = myMatrix
            //DrawShape(G)

            var G = tabPage46.CreateGraphics();
            G.Clear(Color.White);

            int Value = hScrollBar46.Value;

            float x = tabPage46.Width / 2 + 300;
            float y = tabPage46.Height / 2 + 300;

            //PointF rotatePoint = new PointF(x, y);

            G.ResetTransform();

            Matrix myMatrix = new Matrix();
            myMatrix.Rotate(Value);

            myMatrix.Scale(0.3f, 0.3f);
            myMatrix.Translate(x, y);
            G.Transform = myMatrix;
            DrawShape(G);

        }

        private void button46_Click(object sender, EventArgs e)
        {
            //Dim XPixels, YPixels As Single
            //XPixels = MyPictureBox.Width - 10
            //YPixels = MyPictureBox.Height - 10
            //Dim IterationCount As Integer
            //IterationCount = 1000
            //Dim XInitial, XFinal As Double
            //XInitial = -2 * Math.PI
            //XFinal = 2 * Math.PI
            //Dim Delta As Double
            //Delta = (XFinal - XInitial) / IterationCount
            //Dim i As Double
            //Dim MyList As New ArrayList
            //Dim FunctionList As New ArrayList
            //For i = XInitial To XFinal Step Delta
            //    MyList.Add(New Beta(i, Alpha(i)))
            //    FunctionList.Add(Alpha(i))
            //Next
            //FunctionList.Sort()
            //Dim YMin, Ymax As Double
            //YMin = FunctionList(0)
            //Ymax = FunctionList(FunctionList.Count - 1)
            //Dim MyPen As Pen = New Pen(Color.Black, 1)
            //Dim graphPath As New GraphicsPath
            //Dim blackPen As New Pen(Color.Black, 1)
            //Dim x(IterationCount), y(IterationCount) As Double
            //x(0) = XInitial
            //y(0) = Alpha(XInitial)
            //Dim XScale, YScale As Single
            //XScale = XPixels / (XFinal - XInitial)
            //YScale = YPixels / (Ymax - YMin)
            //Dim j As Integer
            //For j = 1 To IterationCount -1
            //    graphPath.AddLine(CInt(XScale * MyList(j - 1).x), _
            //    CInt(YScale * MyList(j - 1).y), _
            //    CInt(XScale * MyList(j).x), CInt(YScale * MyList(j).y))
            //Next
            //G.ResetTransform()
            //Dim myMatrix As New Matrix
            //myMatrix.Translate(XPixels / 2, YPixels / 2)
            //G.Transform = myMatrix
            //G.DrawPath(blackPen, graphPath)

            var G = tabPage46.CreateGraphics();

            float XPixels = tabPage46.Width - 10;
            float YPixels = tabPage46.Height - 10;

            int IterationCount = 1000;

            double XInitial = -2 * Math.PI;
            double XFinal = 2 * Math.PI;

            double Delta = (XFinal - XInitial) / IterationCount;
            double i;

            List<Beta> MyList = new List<Beta>();
            List<double> FunctionList = new List<double>();
            for (i = XInitial; i <= XFinal; i += Delta)
            {
                MyList.Add(new Beta(i, Math.Sin(i)));
                FunctionList.Add(Math.Sin(i));
            }
            FunctionList.Sort();

            double YMin = FunctionList[0];
            double Ymax = FunctionList[FunctionList.Count - 1];

            GraphicsPath graphPath = new GraphicsPath();
            Pen blackPen = new Pen(Color.Black, 1);

            double[] x = new double[IterationCount];
            double[] y = new double[IterationCount];
            x[0] = XInitial;
            y[0] = Math.Sin(XInitial);

            double XScale = XPixels / (XFinal - XInitial);
            double YScale = YPixels / (Ymax - YMin);

            for (int j = 1; j <= IterationCount - 1; j++)
            {
                graphPath.AddLine((int)(XScale * MyList[j - 1].x), (int)(YScale * MyList[j - 1].y), (int)(XScale * MyList[j].x), (int)(YScale * MyList[j].y));
            }

            G.ResetTransform();

            Matrix myMatrix = new Matrix();
            myMatrix.Translate(XPixels / 2, YPixels / 2);
            G.Transform = myMatrix;
            G.DrawPath(blackPen, graphPath);

        }
    }
}            
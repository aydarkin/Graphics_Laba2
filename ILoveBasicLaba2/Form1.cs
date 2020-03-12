using ILoveBasicLaba2.Properties;
using System;
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
    }
}            
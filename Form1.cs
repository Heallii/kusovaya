using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ParticlesCourse
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter; // добавим поле для эмиттера
        RecolorPoint point1; // добавили поле под первую точку
        RecolorPoint point2; // добавили поле под вторую точку
        RecolorPoint point3; // добавили поле под третью точку
        Color color = Color.Red; // цвет по умолчанию красный
        public Form1()
        {
            InitializeComponent();
            // определяем область рисования
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            // создаем эмиттер
            emitter = new TopEmitter
            {
                // ширина на весь экран, гравитация 0.2, время жизни частиц такое
                Width = picDisplay.Width,
                GravitationY = 0.2f,
                LifeMin = 70,
                LifeMax = 150
            };

            // добавляем эмиттер в общий список
            emitters.Add(this.emitter);

            // привязываем точки перекраски
            point1 = new RecolorPoint
            {
                // в центре экрана
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
                color = color
            };

            point2 = new RecolorPoint
            {
                // на четверть ширины экрана
                X = picDisplay.Width / 4,
                Y = picDisplay.Height / 2,
                color = Color.Yellow
            };

            point3 = new RecolorPoint
            {
                // в правой части экрана, на 3/4 ширины
                X = 3 * picDisplay.Width / 4,
                Y = picDisplay.Height / 2,
                color = Color.Green
            };

            // привязываем поля к эмиттеру
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(point3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // каждый тик обновляем систему
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); // очистка
                emitter.Render(g); // рендер
            }
            // обновление области рисования
            picDisplay.Invalidate();
        }

        private void tbHorizontal_Scroll(object sender, EventArgs e)
        {
            // горизонтальный скролл для точки 1
            // т.к. на нём значения от 0 до 100, двигаем первую точку от 0 до 100% ширины экрана
            point1.X =  picDisplay.Width * tbHorizontal.Value / 100;
        }

        private void tbGraviton2_Scroll(object sender, EventArgs e)
        {
           
        }

        private void tbVertical_Scroll(object sender, EventArgs e)
        {
            // вертикальный скролл для точки 1
            // то же самое, что в горизонтальном, только вместо Width будет Height
            point1.Y = picDisplay.Height - picDisplay.Height * tbVertical.Value / 100 ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // вызываем встроенную системную палитру из компонента colorDialog1 для точки 1
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // и назначаем точке цвет, в который она перекрашивает снежинки
                point1.color = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // вызываем встроенную системную палитру из компонента colorDialog1 для точки 2
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                point2.color = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // вызываем встроенную системную палитру из компонента colorDialog1 для точки 3
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                point3.color = colorDialog1.Color;
            }
        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        private void tbHorizontal2_Scroll(object sender, EventArgs e)
        {
            // горизонтальный скролл для точки 2
            point2.X = picDisplay.Width * tbHorizontal2.Value / 100;
        }

        private void tbHorizontal3_Scroll(object sender, EventArgs e)
        {
            // горизонтальный скролл для точки 3
            point3.X = picDisplay.Width * tbHorizontal3.Value / 100;
        }

        private void tbVertical2_Scroll(object sender, EventArgs e)
        {
            // вертикальный скролл для точки 2
            point2.Y = picDisplay.Height - picDisplay.Height * tbVertical2.Value / 100;
        }

        private void tbVertical3_Scroll(object sender, EventArgs e)
        {
            // вертикальный скролл для точки 3
            point3.Y = picDisplay.Height - picDisplay.Height * tbVertical3.Value / 100;
        }

        private void tbSize_Scroll(object sender, EventArgs e)
        {
            // изменяем размер точки 1
            point1.Size = tbSize.Value;
            lblSize.Text = tbSize.Value.ToString();
        }

        private void tbSize2_Scroll(object sender, EventArgs e)
        {
            // изменяем размер точки 2
            point2.Size = tbSize2.Value;
            lblSize2.Text = tbSize2.Value.ToString();
        }

        private void tbSize3_Scroll(object sender, EventArgs e)
        {
            // изменяем размер точки 3
            point3.Size = tbSize3.Value;
            lblSize3.Text = tbSize3.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}

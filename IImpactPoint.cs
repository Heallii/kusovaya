using System;
using System.Drawing;

namespace ParticlesCourse
{
    public abstract class IImpactPoint
    {
        public float X; 
        public float Y;

        // абстрактный метод с помощью которого будем изменять состояние частиц
        public abstract void ImpactParticle(Particle particle);

        // базовый класс для отрисовки точечки
        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }

    public class RecolorPoint : IImpactPoint
    {
        public int Size = 100;
        public Color color;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < Size / 2) // если частица оказалось внутри окружности
            {
                particle.FromColor = color;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(color),
                   X - Size / 2,
                   Y - Size / 2,
                   Size,
                   Size
            );
        }
    }
}

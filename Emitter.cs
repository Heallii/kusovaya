using System;
using System.Collections.Generic;
using System.Drawing;

namespace ParticlesCourse
{
    public class Emitter
    {
        List<Particle> particles = new List<Particle>();
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>(); 

        public int ParticlesCount = 500;

        public int X; // координата X центра эмиттера, будем ее использовать вместо MousePositionX
        public int Y; // соответствующая координата Y 
        public int Direction = 0; // вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 360; // разброс частиц относительно Direction
        public int SpeedMin = 1; // начальная минимальная скорость движения частицы
        public int SpeedMax = 10; // начальная максимальная скорость движения частицы
        public int RadiusMin = 2; // минимальный радиус частицы
        public int RadiusMax = 10; // максимальный радиус частицы
        public int LifeMin = 20; // минимальное время жизни частицы
        public int LifeMax = 100; // максимальное время жизни частицы

        public int ParticlesPerTick = 1; // частиц за тик

        public Color ColorFrom = Color.White; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.Black); // конечный цвет частиц

        public float GravitationX = 0;
        public float GravitationY = 1; // пусть гравитация будет силой один пиксель за такт, нам хватит

        public virtual Particle CreateParticle()
        {
            // создаем новые цветные частицы
            var particle = new ParticleColorful();
            // задаем цвет
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }

        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick; // фиксируем счетчик сколько частиц нам создавать за тик

            foreach (var particle in particles)
            {
                particle.Life -= 1; 
                if (particle.Life < 0)
                {
                    // частица умерла, обновляем
                    ResetParticle(particle);
                }
                else
                {
                    // двигаем частицу
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;

                    // перебираем все точки и пересчитываем их влияние на частицы
                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }

                    // изменяем скорость частиц под действием гравитации
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;
                }
            }

            while (particlesToCreate >= 1)
            {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
        }

        public void Render(Graphics g)
        {
            // отрисовка частиц
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            foreach (var point in impactPoints)
            {
                // для каждой точки перекраски вызываем метод Render
                point.Render(g);
            }
        }

        public virtual void ResetParticle(Particle particle)
        {
            // при сбросе частицы задаем случайное время жизни, белый цвет и координаты
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);
            particle.FromColor = Color.White;
            particle.X = X;
            particle.Y = Y;

            // задаем направление полета
            var direction = Direction
                + (double)Particle.rand.Next(Spreading)
                - Spreading / 2;

            // скорость
            var speed = Particle.rand.Next(SpeedMin, SpeedMax);

            // задаем горизонтальную и вертикальную скорость на основе направления
            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            // выбираем случайный радиус
            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }

    }

    public class TopEmitter : Emitter
    {
        public int Width; // длина экрана
        public override void ResetParticle(Particle particle)
        {
            base.ResetParticle(particle); // вызываем базовый сброс частицы

            // а теперь тут уже подкручиваем параметры движения
            particle.X = Particle.rand.Next(Width); // позиция X -- произвольная точка от 0 до Width
            particle.Y = 0;  // ноль -- это верх экрана 

            particle.SpeedY = 1; // падаем вниз по умолчанию
            particle.SpeedX = Particle.rand.Next(-2, 2); // разброс влево и вправа у частиц 
        }
    }
}

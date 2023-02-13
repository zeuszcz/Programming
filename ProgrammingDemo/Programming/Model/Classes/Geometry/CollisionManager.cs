﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для проверки пересечения геометрических фигур.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли два прямоугольника.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если прямоугольники пересекаются.
        /// И false, если они не пересекаются.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double dX = Math.Abs((rectangle1.Center.X + rectangle1.Length / 2)
                - (rectangle2.Center.X + rectangle2.Length / 2));
            double dY = Math.Abs((rectangle1.Center.Y + rectangle1.Width / 2)
                - (rectangle2.Center.Y + rectangle2.Width / 2));
            double halfSumWidth = (rectangle1.Width + rectangle2.Width) / 2;
            double halfSumLength = (rectangle1.Length + rectangle2.Length) / 2;
            return (dX < halfSumLength) && (dY < halfSumWidth);
        }

        /// <summary>
        /// Проверяет, пересекаются ли два кольца.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если кольца пересекаются.
        /// И false, если они не пересекаются.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(Math.Pow(dX, 2)
                + Math.Pow(dY, 2));
            double sumRadii = Math.Pow(ring1.OuterRadius, 2)
                + Math.Pow(ring2.OuterRadius, 2);
            return c < sumRadii;
        }
    }
}

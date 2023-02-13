using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EstablishmentsApp.Model
{
    /// <summary>
    /// Предоставляет методы для валидации.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что значение входит в заданный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда значение не входит в заданный диапазон.</exception>
        public static void AssertValueInRange(int value, int max, string propertyName)
        {
            if (value > max)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range up to {max}, " +
                    $"but was {value}.");
            }
        }

        /// <summary>
        /// Проверяет, что значение входит в заданный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда значение не входит в заданный диапазон.</exception>
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (value > max || value < min)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range from {min} to {max}, " +
                    $"but was {value}.");
            }
        }

        /// <summary>
        /// Проверяет, что значение входит в заданный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда значение не входит в заданный диапазон.</exception>
        public static void AssertValueInRange(DateTime value, DateTime max, string propertyName)
        {
            if (value > max)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range up to {max}, " +
                    $"but was {value}.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace EstablishmentsApp.Model
{
    /// <summary>
    /// Хранит данные о заведении.
    /// </summary>
    public class Establishment
    {
        /// <summary>
        /// Ограничение на количество символов в названии заведения.
        /// </summary>
        private readonly int _nameCharacterLimit = 200;

        /// <summary>
        /// Ограничение на количество символов в адресе заведения.
        /// </summary>
        private readonly int _addressCharacterLimit = 100;

        /// <summary>
        /// Название заведения.
        /// </summary>
        private string _name;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private Category _category;

        /// <summary>
        /// Рейтинг заведения.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Адрес заведения.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задает название заведения.
        /// Длина не более 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertValueInRange(
                    value.Length, _nameCharacterLimit, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию заведения.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает адрес заведения.
        /// Длина не более 200 символов.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validator.AssertValueInRange(
                    value.Length, _addressCharacterLimit, nameof(Name));
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг заведения.
        /// Должен быть от 0 до 5.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 5, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Establishment"/>.
        /// </summary>
        public Establishment()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Establishment"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="category">Категория.</param>
        /// <param name="address">Адрес.</param>
        /// <param name="rating">Рейтинг.</param>
        [JsonConstructor]
        public Establishment(string name, Category category, string address, double rating)
        {
            Name = name;
            Category = category;
            Address = address;
            Rating = rating;
        }

    }
}

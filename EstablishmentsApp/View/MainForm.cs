using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstablishmentsApp.Model;

namespace EstablishmentsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Текущее заведение.
        /// </summary>
        private Establishment _currentEstablishment = new Establishment();

        /// <summary>
        /// Список заведений.
        /// </summary>
        private List<Establishment> _establishments = ContactSerializer.LoadFromFile();

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о заведениях в текстовых полях.
        /// </summary>
        /// <param name="establishment">Заведение,
        /// информация о котором обновляется.</param>
        private void UpdateEstablishmentInfo(Establishment establishment)
        {
            NameTextBox.Text = establishment.Name;
            CategoryComboBox.Text = establishment.Category.ToString();
            RatingTextBox.Text = establishment.Rating.ToString();
            AddressTextBox.Text = establishment.Address;
        }

        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
        private void ClearEstablishmentInfo()
        {
            NameTextBox.Clear();
            CategoryComboBox.Text = "";
            CategoryComboBox.Items.Clear();
            RatingTextBox.Clear();
            AddressTextBox.Clear();
            NameTextBox.BackColor = AppColors.NormalColor;
            CategoryComboBox.BackColor = AppColors.NormalColor;
            RatingTextBox.BackColor = AppColors.NormalColor;
            AddressTextBox.BackColor = AppColors.NormalColor;
        }

        /// <summary>
        /// Меняет доступ к редактированию элементов.
        /// </summary>
        private void ChangeAccessToChangeElements()
        {
            bool value = EstablishmentsListBox.SelectedIndex == -1;
            NameTextBox.ReadOnly = value;
            RatingTextBox.ReadOnly = value;
            AddressTextBox.ReadOnly = value;
            CategoryComboBox.Enabled = !value;
        }

        private void AddEstablishmentButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int lengthCategory = Enum.GetNames(typeof(Category)).Length;
            var establishment = new Establishment("Name",
                ((Category)random.Next(lengthCategory)), "Address", 5);
            _establishments.Add(establishment);
            EstablishmentsListBox.Items.Add($"{establishment.Category} - {establishment.Name}");
            EstablishmentsListBox.SelectedIndex = EstablishmentsListBox.Items.Count - 1;
        }

        private void EstablishmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = EstablishmentsListBox.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    _currentEstablishment = _establishments[selectedIndex];
                    UpdateEstablishmentInfo(_currentEstablishment);
                }
                ChangeAccessToChangeElements();
            }
            catch
            {
                ClearEstablishmentInfo();
                ChangeAccessToChangeElements();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedIndex = EstablishmentsListBox.SelectedIndex;
                _currentEstablishment.Name = NameTextBox.Text;
                NameTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(NameTextBox, "");
                EstablishmentsListBox.Items[selectedIndex] =
                    ($"{_currentEstablishment.Category} - {_currentEstablishment.Name}");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(NameTextBox,
                    exception.Message);
                NameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(CategoryComboBox.Text, out Category category);
            _currentEstablishment.Category = category;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentEstablishment.Address = AddressTextBox.Text;
                AddressTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(NameTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(AddressTextBox,
                    exception.Message);
                AddressTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentEstablishment.Rating = Convert.ToDouble(RatingTextBox.Text);
                RatingTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(RatingTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(RatingTextBox,
                    exception.Message);
                RatingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void RemoveEstablishmentButton_Click(
            object sender, EventArgs e)
        {
            if (EstablishmentsListBox.SelectedIndex != -1)
            {
                int selectedIndex = EstablishmentsListBox.SelectedIndex;
                _establishments.RemoveAt(selectedIndex);
                EstablishmentsListBox.Items.RemoveAt(selectedIndex);
                if (_establishments.Count != 0)
                {
                    EstablishmentsListBox.SelectedIndex = selectedIndex - 1;
                }
                if (EstablishmentsListBox.SelectedIndex == -1)
                {
                    ClearEstablishmentInfo();
                }
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            EstablishmentsListBox.Items.Clear();
            _establishments = (from establishment in _establishments
                              orderby establishment.Category, establishment.Name
                                select establishment).ToList();
            foreach (var establishment in _establishments)
            {
                EstablishmentsListBox.Items.Add(
                    $"{establishment.Category} - {establishment.Name}");
            }
            EstablishmentsListBox.SelectedIndex =
                EstablishmentsListBox.Items.Count - 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeAccessToChangeElements();

            for (var i = 0; i < _establishments.Count; i++)
            {
                EstablishmentsListBox.Items.Add(
                    $"{_establishments[i].Category} - {_establishments[i].Name}");
            }

            foreach (var value in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(value);
            }

            CategoryComboBox.SelectedIndex = 0;
        }

        private void MainForm_FormClosing(
            object sender, FormClosingEventArgs e)
        {
            try
            {
                ContactSerializer.SaveToFile(_establishments);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CategoryComboBox_Leave(object sender, EventArgs e)
        {
            EstablishmentsListBox.Items.Clear();
            _establishments = (from establishment in _establishments
                               orderby establishment.Category, establishment.Name
                               select establishment).ToList();
            foreach (var establishment in _establishments)
            {
                EstablishmentsListBox.Items.Add(
                    $"{establishment.Category} - {establishment.Name}");
            }
            EstablishmentsListBox.SelectedIndex =
                EstablishmentsListBox.Items.Count - 1;
        }
    }
}

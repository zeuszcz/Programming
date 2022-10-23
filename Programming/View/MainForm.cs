using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Color = System.Drawing.Color;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonComboBox.SelectedIndex = 0;
        }
        
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Enum)EnumsListBox.SelectedItem;
            switch (item)
            {
                case Enums.Color:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.Color));
                    break;
                case Enums.FormOfEducation:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.FormOfEducation));
                    break;
                case Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.Genre));
                    break;
                case Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.Season));
                    break;
                case Enums.SmartphoneManufacturers:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.SmartphoneManufacturers));
                    break;
                case Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedIndex).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday value;
            if (Enum.TryParse(ParseTextBox.Text, out value))
            {
                ParseInfoLabel.Text = $"Это день недели ({ParseTextBox.Text} = {(int)value + 1})";
            }
            else
            {
                ParseInfoLabel.Text = "Нет такого дня недели";
            }
        }
        
        private void GoButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                return;
            }

            switch (SeasonComboBox.SelectedItem)
            {
                case Season.Winter :
                    MessageBox.Show("Подвороты самое то");
                    break;
                case Season.Summer:
                    MessageBox.Show("Хуёво");
                    break;
                case Season.Fall:
                    BackColor = Color.Orange;
                    break;
                case Season.Spring:
                    BackColor = Color.Green;
                    break;
            }
        }
    }
}
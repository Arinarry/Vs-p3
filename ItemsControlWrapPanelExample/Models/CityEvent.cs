using DynamicData.Binding;
using System.Xml.Serialization;
using System;
using static ItemsControlWrapPanelExample.Models.CityEvent;

namespace ItemsControlWrapPanelExample.Models
{
    [Serializable]
    [XmlRoot("CityEvents", Namespace = "")]
    public class CityEvent : AbstractNotifyPropertyChanged
    {
        private string _Header = "";

        private string _Description = "Описание отсутствует";

        private string _Image = "";

        private string _Date = "";

        private category _Category;

        private double _Price = 0;
        public string Header
        {
            get => _Header;
            set => SetAndRaise(ref _Header, value);

        }
        public string Date
        {
            get => _Date;
            set => SetAndRaise(ref _Date, value);
        }
        private string CheckStringLenght(string? str)
        {
            const int maxLength = 135;

            if (!string.IsNullOrEmpty(str) && str.Length > maxLength)
            {
                str = str[..(maxLength - 2)] + "...";
            }

            return str;
        }
        public string Description
        {
            get => _Description;
            set => SetAndRaise(ref _Description, CheckStringLenght(value));
        }
        public double Price
        {
            get => _Price;
            set => SetAndRaise(ref _Price, value);
        }
        public enum category
        {
            [XmlEnum("Дети")]
            Children,
            [XmlEnum("Спорт")]
            Sport,
            [XmlEnum("Культура")]
            Culture,
            [XmlEnum("Экскурсия")]
            Excursion,
            [XmlEnum("Образ жизни")]
            Lifestyles,
            [XmlEnum("Вечеринка")]
            Party,
            [XmlEnum("Обучение")]
            Education,
            [XmlEnum("Онлайн")]
            Online,
            [XmlEnum("Шоу")]
            Show
        }
        public category Category
        {
            get => _Category;
            set => SetAndRaise(ref _Category, value);
        }
        public string Image
        {
            get => _Image;
            set => SetAndRaise(ref _Image, value);
        }
    }
}

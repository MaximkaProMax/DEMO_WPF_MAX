using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using App1.Models; //Подключаем файл Shift.cs, чтобы с ним могу работать .XAML файл

namespace App1
{
    /// <summary>
    /// Логика взаимодействия для Shift_Management.xaml
    /// </summary>

    public partial class Shift_Management : Window
    {
        public Shift_Management()
        {
            InitializeComponent();
            LoadData(); //Добавляем LoadData();
        }

        private void LoadData() // Метод для загрузки данных в DataGrid
        {
            List<Shift> shifts = new List<Shift> // Создаем список объектов Shift и инициализируем его данными
            {
                new Shift { Number = 1, ShiftName = "Дневная", Start = "14.03 08:00", End = "14.03 15:00" }, // Добавляем первую смену с номером 1, названием "Дневная", временем начала и окончания
                new Shift { Number = 2, ShiftName = "Вечерняя", Start = "14.03 15:00", End = "14.03 22:00" } // Добавляем вторую смену с номером 2, названием "Вечерняя", временем начала и окончания
            };

            shiftDataGrid.ItemsSource = shifts; // Устанавливаем источник данных для DataGrid, чтобы он отображал список смен
            /*
            shiftDataGrid - это элемент DataGrid, который был определен в XAML-файле. Он используется для отображения табличных данных в интерфейсе пользователя
            ItemsSource - это свойство DataGrid, которое определяет источник данных для отображения. Оно принимает коллекцию объектов, которые будут отображаться в строках DataGrid
            shifts - это список объектов Shift, который был создан и инициализирован в методе LoadData

            Как это работает:
            Когда вы устанавливаете shiftDataGrid.ItemsSource = shifts, вы говорите DataGrid, что его источник данных - это коллекция shifts
            DataGrid автоматически создает строки для каждого объекта в коллекции shifts

            Каждое свойство объекта Shift 
            (например, Number, ShiftName, Start, End) привязывается к соответствующему столбцу 
            в DataGrid через привязку данных (Binding), определенную в XAML

            Таким образом, DataGrid автоматически отображает данные из списка shifts в табличном формате
            */
        }
    }
}
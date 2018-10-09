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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompanyStruct
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Employee> items = new List<Employee>();
        public MainWindow()
        {
            InitializeComponent();

            //new Employee() { Name = "Петров Петр Петрович", Departament = "IT", Capacity = "Системный администратор", Salary = 50000 },
            //new Employee() { Name = "Бабкина Надежда Витальевна", Departament = "Бухгалтерия", Capacity = "Главный бухгалтер", Salary = 40000 },
            //new Employee() { Name = "Васильев Василий Васильевич", Departament = "Кадровое ДП", Capacity = "Директор по персоналу", Salary = 40000 },
            //new Employee() { Name = "Щукин Антон Антонович", Departament = "Рабочий класс", Capacity = "Монтажник", Salary = 30000 },
            //new Employee() { Name = "Карлсон Виктор Александрович", Departament = "Рабочий класс", Capacity = "Монтажник", Salary = 30000 }



        }
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
        }

        private void addWorker_Click(object sender, RoutedEventArgs e)
        {
            int salary = 0;
            if (int.TryParse(Salary.Text, out salary))
            {
                if (Departament.Text != "Выберите департамент сотрудника")
                {
                    addNewWorker();
                }
                else
                {
                    MessageBox.Show("Департамент сотрудника выбран не корректно!");
                }
            }
            else
            {
                MessageBox.Show("Зарплата введена не корректно");
            }
        }
        private void addNewWorker()
        {
            items.Add(new Employee() { Name = FIO.Text, Departament = Departament.Text, Capacity = Capacity.Text, Salary = int.Parse(Salary.Text) });
            
            //lvEmployee.ItemsSource = items;
            listEmployee.Items.Add(items[items.Count-1]);
        }

        private void deleteWorker_Click(object sender, RoutedEventArgs e)
        {
            items.Remove(items[listEmployee.SelectedIndex]);
            listEmployee.Items.RemoveAt(listEmployee.SelectedIndex);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace to_done_it
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        {
        public ObservableCollection<string> tasks { get; } = new ObservableCollection<string>();
        public ObservableCollection<string> c_tasks { get; } = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            ltodo.ItemsSource = tasks;
            ltodone.ItemsSource = c_tasks;
        }
        public void TaskCreate(object sender, RoutedEventArgs e)
        {
            string taskName = newT.Text;
            if (!string.IsNullOrEmpty(taskName))
            {
                tasks.Add(taskName);
                newT.Text = "";
            }
        }
        private void addT(object sender, RoutedEventArgs e)
        {
            string taskName = newT.Text;
            if (!string.IsNullOrEmpty(taskName))
            {
                tasks.Add(taskName);
                newT.Text = "";
            }
        }
        private void TaskIsDone(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var task = ltodo.SelectedItem as string;
            if (!string.IsNullOrEmpty(task))
            {
                c_tasks.Add(task);
                tasks.Remove(task);
            }
        }
        private void TaskWasDone(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var completedTask = ltodone.SelectedItem as string;
            if (!string.IsNullOrEmpty(completedTask))
            {
                c_tasks.Remove(completedTask);
                ltodone.ItemsSource = null;
                ltodone.ItemsSource = c_tasks;
            }
        }
        public void Question(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Двойное нажатие на задачу в первом листбоксе - перенос её во второй листбокс \nДвойное нажатие на задачу во втором листбоксе - удаляет её \nДвойное нажатие на текстбокс - добавление задачи в первый листбокс","Инструкции");
        }
    }

}

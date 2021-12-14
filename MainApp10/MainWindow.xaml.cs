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

namespace MainApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void seventh_Click(object sender, RoutedEventArgs e)
        {
            double one = 0, two = 0, three = 0, four = 0, five = 0, six = 0; //ввод пременных
            List<double> arr = new List<double>();// динамический массив типа дабл


            one = Convert.ToInt32(first.Text);
            //проверка на то что число отрицательное
            if (one > 0)
            {
                Error();// ошибка
                one = 0;
            }
            arr.Add(one);//добавление в массив

            two = Convert.ToInt32(second.Text);
            if (two > 0)
            {
                Error();
                two = 0;
            }
            arr.Add(two);

            three = Convert.ToInt32(third.Text);
            if (three > 0)
            {
                Error();
                three = 0;
            }
            arr.Add(three);

            four = Convert.ToInt32(fourth.Text);
            if (four > 0)
            {
                Error();
                four = 0;
            }
            arr.Add(four);

            five = Convert.ToInt32(fifth.Text); 
            if (five > 0)
            {
                Error();
                five = 0;
            }
            arr.Add(five);

            six = Convert.ToInt32(sixth.Text); 
            if (six > 0)
            {
                Error();
                six = 0;
            }
            arr.Add(six);

            var average = arr.Average();//расчет среднего арифметического

            result.Text = Convert.ToString(average);//вывод
        }

        public void Error() //ошибка
        {
            MessageBox.Show("Введено не отрицательное число!");
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пичугин Дмитрий ИСП-31 Составьте программу вычисления среднего арифметического отрицательных элементов.");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

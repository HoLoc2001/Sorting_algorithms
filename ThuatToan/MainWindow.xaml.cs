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
using System.Text.RegularExpressions;

namespace ThuatToan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Number;
        double[] array;
        double countWidth = 0;
        Random rand = new Random();


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }

        

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            //create();
            for (int i = 0; i < array.Length - 1; ++i)
            {
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if (array[i] == array[j])
                    {
                        a += 1;
                    }
                }
            }
            MessageBox.Show(a.ToString());
        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            random();
        }

        private void NumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           if(NumberTextBox.Text != " " && !string.IsNullOrEmpty(NumberTextBox.Text) && double.TryParse(NumberTextBox.Text, out double b)) {sliderNumber.Value = Convert.ToDouble(NumberTextBox.Text);}
        }

        private void sliderNumber_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Number = Convert.ToInt32(sliderNumber.Value);
            random();
        }

        void random()
        {
            if (canvas1 != null) {canvas1.Children.Clear();}
            countWidth = 0;
            int maxWidth = 1161;
            int maxHieght = 500;
            //int Number = Convert.ToInt32(sliderNumber.Value);
            array = new double[Number];
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    int intrand = rand.Next(1, maxHieght);
                    if (!array.Contains(intrand))
                    {
                        array[i] = intrand;
                        break;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Rectangle rtgNext = new Rectangle();
                rtgNext.Width = maxWidth / Number;
                rtgNext.Height = array[i];
                rtgNext.Fill = new SolidColorBrush(Colors.Black);
                Canvas.SetLeft(rtgNext, countWidth);
                Canvas.SetBottom(rtgNext, 0);
                canvas1.Children.Add(rtgNext);
                countWidth = countWidth + (maxWidth / (double)Number);
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
        //    bubble_sort.Bubble_sort(array);
        }

        //private void create()
        //{
        //    Rectangle rtgNext = new Rectangle();
        //    rtgNext.Width = 10;
        //    rtgNext.Height = 240;
        //    rtgNext.Fill = new SolidColorBrush(Colors.Black);
        //    Canvas.SetLeft(rtgNext, countWidth);
        //    Canvas.SetBottom(rtgNext, 0);
        //    canvas1.Children.Add(rtgNext);
        //    countWidth = countWidth + 10;
        //}
    }
}

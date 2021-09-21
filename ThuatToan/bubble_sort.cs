using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ThuatToan
{
    class bubble_sort
    {
        public static Array Bubble_sort(double[] arr)
        {
            double temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                //Rectangle rtgNext = new Rectangle();
                //rtgNext.Width = maxWidth / Number;
                //rtgNext.Height = arr[i];
                //rtgNext.Fill = new SolidColorBrush(Colors.Black);
                //Canvas.SetLeft(rtgNext, countWidth);
                //Canvas.SetBottom(rtgNext, 0);
                //canvas1.Children.Add(rtgNext);
                //countWidth = countWidth + (maxWidth / (double)Number);
            }
            return arr;
        }
    }
}

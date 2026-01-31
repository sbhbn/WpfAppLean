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

namespace WpfAppLean
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            // int i = 0;
            // int j = 1;
            // int k = j / i;
            this.ShowInfo.Text = "Hello World";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Button b2 = new Button();

            b2.Height = 25;
            b2.Width = 200;
            b2.Content = "Here Hello!!!";
            b2.HorizontalAlignment = HorizontalAlignment.Left;
            b2.Margin = new Thickness(10, 10, 0, 0);
            this.MyGrid.Children.Add(b2);
            b2.Click += B1_Click;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Button b1= new Button();
           
            b1.Height = 25;
            b1.Width = 200;
            b1.Content = "Hello There!";
            b1.HorizontalAlignment = HorizontalAlignment.Left;
            b1.Margin = new Thickness(10, 10, 0, 0);
            this.MyGrid.Children.Add(b1);
            b1.Click += B1_Click;//動態Clicked事件(後決定)

        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}

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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppLean
{
    /// <summary>
    /// ToggleButtonDemo.xaml 的互動邏輯
    /// </summary>
    public partial class ToggleButtonDemo : Window
    {
        private bool isMenuExpanded = true;// 欄位
        public ToggleButtonDemo()
        {
            InitializeComponent();
        }

        private void MenuToggleButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                Duration = TimeSpan.FromSeconds(0.2)
            };
            if (isMenuExpanded)
            {
                animation.To = 50;
            }
            else {
                animation.To = 250;
            }
            this.SideMenu.BeginAnimation(WidthProperty, animation);
            isMenuExpanded = !isMenuExpanded;

        }

        private void MenuToggleButton_Checked(object sender, RoutedEventArgs e)
        {

        }


        private void Mask_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Mask_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

    
        private void MenuToggleButton_Click_2(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                Duration = TimeSpan.FromSeconds(0.2)
            };
            if (isMenuExpanded)
            {
                animation.To = 10;
            }
            else {
                animation.From = 250;
            }

            this.SideMenu.BeginAnimation(WidthProperty, animation);
            isMenuExpanded= !isMenuExpanded;
        }
    }
}

using Microsoft.Win32;
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
    /// WrapPanel.xaml 的互動邏輯
    /// </summary>
    public partial class WrapPanel : Window
    {
        public WrapPanel()
        {
            InitializeComponent();
        }
        private void PhotoBlock_Click(object sender, MouseButtonEventArgs e)
        {
            Border border = sender as Border;
            if (border == null) return;

            Image img = border.Child as Image;
            if (img == null) return;

            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "圖片檔案|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (dialog.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new System.Uri(dialog.FileName);
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();

                img.Source = bitmap;

                // 有圖片後，背景可選擇清掉或保留
                border.Background = null;
            }
        }
    }
}

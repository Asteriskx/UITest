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

namespace UITest
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Mouse Over & Start Clicked.";
            NowStatus.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0x7D, 0x11));
        }

        private void EndButton_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Mouse Over & End Clicked.";
        }

        private void StartButton_MouseEnter(object sender, MouseEventArgs e)
        {
            StartButton.Background = Brushes.DimGray;
            label.Content = "Mouse Over.";
        }

        private void StartButton_MouseLeave(object sender, MouseEventArgs e)
        {
            NowStatus.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0x18, 0x99, 0x81));
            label.Content = "準備完了";
        }

        private void EndButton_MouseEnter(object sender, MouseEventArgs e)
        {
            EndButton.Background = Brushes.DimGray;
            label.Content = "Mouse Over.";
        }

        private void EndButton_MouseLeave(object sender, MouseEventArgs e)
        {
            label.Content = "準備完了";

        }

        private void WindowButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new ChildWindow();

            win.Owner = this; /* Owner Settings. */

            label.Content = "ChildWindow Mode.";

            win.Show();


        }
    }
}
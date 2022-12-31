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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
namespace Scrolling_Label
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /* Name: Kelem Nyarko
     * Project: WPF.NET C#
     * App Name: SCROLLING LABEL 
     **/
    public partial class MainWindow : Window
    {
        DispatcherTimer scrollTimer = new DispatcherTimer();
        
        public MainWindow()
        {
            InitializeComponent();
            
            scrollTimer.Tick += scrollTimerEvent;
            scrollTimer.Interval = TimeSpan.FromMilliseconds(100);
            scrollTimer.Start();
        }

        private void btnStartScroll_Click(object sender, RoutedEventArgs e)
        {
            scrollTimer.Start();

            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = this.ActualWidth;
            doubleAnimation.To = -lblScrollingLabel.ActualWidth;
            doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(20)); 
            lblScrollingLabel.BeginAnimation(Canvas.LeftProperty, doubleAnimation);
        }

        private void scrollTimerEvent(object? sender, EventArgs e)
        {
            scrollTimer.Start();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtScrollingText_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblScrollingLabel.Content = txtScrollingText.Text;
        }
    }
}

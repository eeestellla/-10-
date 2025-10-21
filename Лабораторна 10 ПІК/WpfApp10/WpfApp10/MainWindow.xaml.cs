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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Анімація переміщення по X
            var moveX = new DoubleAnimation
            {
                From = 50,
                To = 400,
                Duration = TimeSpan.FromSeconds(3),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            // Анімація переміщення по Y
            var moveY = new DoubleAnimation
            {
                From = 50,
                To = 250,
                Duration = TimeSpan.FromSeconds(3),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            // Анімація масштабу (ефект глибини)
            var scaleAnimation = new DoubleAnimation
            {
                From = 0.5,
                To = 2.0,
                Duration = TimeSpan.FromSeconds(3),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            // Трансформація масштабу для еліпса
            ScaleTransform scale = new ScaleTransform();
            myEllipse.RenderTransform = scale;
            myEllipse.RenderTransformOrigin = new Point(0.5, 0.5);

            // Запуск анімацій
            myEllipse.BeginAnimation(Canvas.LeftProperty, moveX);
            myEllipse.BeginAnimation(Canvas.TopProperty, moveY);
            scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
            scale.BeginAnimation(ScaleTransform.ScaleYProperty, scaleAnimation);
        }
    }
}

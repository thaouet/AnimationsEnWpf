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
using System.Windows.Media.Animation;
namespace animation
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 250;
            da.Duration = TimeSpan.FromSeconds(5);
            da.AccelerationRatio = 0.5;
            da.AutoReverse = true;
           
            ballon.BeginAnimation(Canvas.LeftProperty, da);
            ballon.BeginAnimation(Canvas.TopProperty, da);
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //ColorAnimation animation;
            //animation = new ColorAnimation();
            //animation.From = Colors.Orange;
            //animation.To = Colors.Gray;
            //animation.RepeatBehavior = RepeatBehavior.Forever;
            //animation.AutoReverse = true;
            //animation.Duration = new Duration(TimeSpan.FromSeconds(1));
            //rect1.Stroke.BeginAnimation(SolidColorBrush.ColorProperty, animation);

            ColorAnimation animation = new ColorAnimation
            {
                From = Colors.Yellow,
                To = Colors.Red,
                Duration = new Duration(TimeSpan.FromSeconds(1.5)),
                AutoReverse = true
                
            };
            animation.RepeatBehavior = RepeatBehavior.Forever;
            SolidColorBrush brush = new SolidColorBrush(Colors.Transparent);
            animation.AccelerationRatio = 0.5;

            Background = brush;
            brush.BeginAnimation(SolidColorBrush.ColorProperty, animation);




            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 360;
            da.Duration = new Duration(TimeSpan.FromSeconds(3));
            da.RepeatBehavior = RepeatBehavior.Forever;
            RotateTransform rt = new RotateTransform();
            rect1.RenderTransform = rt;
            rect1.RenderTransformOrigin = new Point(0.5, 0.5);
            cercles.RenderTransform = rt;
            cercles.RenderTransformOrigin = new Point(0.5, 0.5);

            lines.RenderTransform = rt;
            lines.RenderTransformOrigin = new Point(0.5, 0.5);

            rt.BeginAnimation(RotateTransform.AngleProperty, da);
   

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation db = new DoubleAnimation();
            db.From = 0;
            db.To = 250;
            db.Duration = TimeSpan.FromSeconds(5);
            db.AutoReverse = true;
            db.RepeatBehavior = RepeatBehavior.Forever;
          



            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 360;
            da.Duration = new Duration(TimeSpan.FromSeconds(5));
            da.RepeatBehavior = RepeatBehavior.Forever;
            da.AutoReverse = true;
            RotateTransform rt = new RotateTransform();
            image1.RenderTransformOrigin = new Point(0.5, 0.5);
            image1.RenderTransform = rt;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
            image1.BeginAnimation(Canvas.LeftProperty, db);
          
        }
    }
}

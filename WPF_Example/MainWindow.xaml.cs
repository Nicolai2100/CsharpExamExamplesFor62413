using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace WPF_Example
{   /// Husk: XAML, Data binding properties, Events
    /// Interaction logic for MainWindow.xaml - Extensible application markup language
    public partial class MainWindow : Window
    {
        private bool hasBeenClicked = false;
        public string BoundStr { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            OnStartUp();
        }

        private void OnStartUp()
        {
            var path = @Environment.CurrentDirectory;
            Console.WriteLine(path);
            BitmapImage bi = new BitmapImage(new Uri(string.Format(@"{0}\giphy(1).gif", path)));
            imag.Source = bi;
            TextBox1.Text = "Indtast titel på yndlingsfilm:";
        }

        protected void Button_Click(object sender, RoutedEventArgs rea)
        {
            var outPut = TextBox1.Text;
            if (TextBox1.Text == "Indtast titel på yndlingsfilm:")
            {
                outPut = "Du glemte at indtaste en titel! - \nPrøv igen...";
            }
            else
            {
                if (TextBox1.Text.Length % 2 == 0)
                {
                    outPut += " er en god film - \nDu har god smag!";
                }
                else
                {
                    outPut = " er en dårlig film...";
                }
            }
            MessageBox.Show(outPut);
            Animation_Click(sender, rea);
        }

        protected void Button_Click2(object sender, RoutedEventArgs rea)
        {
            if (webb.IsVisible)
            {
                webb.Visibility = Visibility.Hidden;
            }
            else
            {
                webb.Visibility = Visibility.Visible;
            }
        }

        private void Animation_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation();
            da.To = 45;
            da.From = 0;
            RotateTransform rt1 = new RotateTransform();
            Rect1.RenderTransform = rt1;
            RotateTransform rt2 = new RotateTransform();
            //ellipse1.RenderTransform = rt2;
            da.AutoReverse = true; // Reverse
            //da.RepeatBehavior = new RepeatBehavior(5); // 5 times
            rt1.BeginAnimation(RotateTransform.AngleProperty, da);
            rt2.BeginAnimation(RotateTransform.AngleProperty, da);
        }

        private void Textbox_Focus(object sender, System.Windows.Input.MouseEventArgs e)
        {
            hasBeenClicked = !hasBeenClicked;
            var str = "";
            if (!hasBeenClicked)
            {
                str = "Indtast titel på yndlingsfilm:";
            }
        }
    }
}

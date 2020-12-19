using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace WPF_Example
{   /// Husk: XAML, Data binding properties, Events
    /// Interaction logic for MainWindow.xaml - Extensible application markup language
    public partial class MainWindow : INotifyPropertyChanged
    {
        private bool hasBeenClicked = false;

        public event PropertyChangedEventHandler PropertyChanged;

        private string _boundStr = "Indtast titel på yndlingsfilm:";

        public string BoundStr
        {
            get { return _boundStr; }
            set {
                if (_boundStr != value)
                {
                    _boundStr = value;
                    OnPropertyChanged();
                }
            }
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            OnStartUp();
        }

        private void OnStartUp()
        {
            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            Console.WriteLine(path + "//giphy(1).gif");
            BitmapImage bi = new BitmapImage(new Uri(string.Format(@"{0}\giphy(1).gif", path)));
            imag.Source = bi;
        }

        protected void Button_Click1(object sender, RoutedEventArgs rea)
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
            BoundStr = outPut;
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
    }
}

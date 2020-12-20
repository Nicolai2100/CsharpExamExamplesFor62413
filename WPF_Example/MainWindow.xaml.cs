using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using static CsExam.Examples.Collections;

namespace WPF_Example
{   /// Husk: XAML, Data binding properties, Events
    /// Interaction logic for MainWindow.xaml - Extensible application markup language
    public partial class MainWindow : INotifyPropertyChanged, INotifyCollectionChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private string _boundStr = "Indtast titel på yndlingsfilm:";
        public string BoundStr
        {
            get { return _boundStr; }
            set
            {
                if (_boundStr != value)
                {
                    _boundStr = value;
                    OnPropertyChanged();
                }
            }
        }
        private ObservableCollection<Element> _boundElements = new ObservableCollection<Element>();

        public ObservableCollection<Element> BoundElements
        {
            get { return _boundElements; }
            set
            {
                if (_boundElements != value)
                {
                    _boundElements = value;
                    OnPropertyChanged();
                }
            }
        }
        public MainWindow()
        {
            DataContext = this;
            

            InitializeComponent();
            OnStartUp();

        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnCollectionChanged([CallerMemberName] string propertyName = null)
        {
            //PropertyChanged?.Invoke(this, new NotifyCollectionChangedEventHandler(propertyName));
        }

        private void OnStartUp()
        {
            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            Console.WriteLine(path + "//giphy(1).gif");
            BitmapImage bi = new BitmapImage(new Uri(string.Format(@"{0}\giphy(1).gif", path)));
            imag.Source = bi;

            ElementList.ItemsSource = BoundElements;
            foreach (var element in BuildList())
            {
                BoundElements.Add(element);
                Thread.Sleep(2000);
            }
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

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace okienko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string VLogin { get; set; }
        public string Password { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext=this;
        }
        private void Btn_login(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Twój login to: "+this.VLogin);
        }
    }
}
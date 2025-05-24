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
using Engine.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;
        public MainWindow()
        {
            InitializeComponent();

            _gameSession = new GameSession();

            DataContext = _gameSession;
        }

        private void OnClick_LocID0(object sender, RoutedEventArgs e)
        {
            _gameSession.OnClick_setLocID(0);
        }

        private void OnClick_LocID1(object sender, RoutedEventArgs e)
        {
            _gameSession.OnClick_setLocID(1);
        }

        private void OnClick_LocID2(object sender, RoutedEventArgs e)
        {
            _gameSession.OnClick_setLocID(2);
        }

        private void OnClick_LocID3(object sender, RoutedEventArgs e)
        {
            _gameSession.OnClick_setLocID(3);
        }

        private void OnClick_LocID4(object sender, RoutedEventArgs e)
        {
            _gameSession.OnClick_setLocID(4);
        }
    }


}
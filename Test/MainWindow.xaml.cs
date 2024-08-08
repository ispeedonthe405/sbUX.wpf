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
using sbux.wpf.Themer;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cb_Theme.ItemsSource = ThemeManager.Themes;
            datagrid.DataContext = TestData0.Data;
            listview.ItemsSource = TestData0.Data;

            cb_Theme.SelectedIndex = cb_Theme.Items.Count - 1;
        }

        private void cb_Theme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cb_Theme.SelectedItem is Theme theme)
            {
                ThemeManager.SetTheme(theme.DisplayName);
            }
        }
    }
}
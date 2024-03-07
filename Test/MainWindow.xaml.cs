using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using sbUX;
using sbUX.wpf.Themer;

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
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            cb_Theme.ItemsSource = sbUX.wpf.Themer.ThemeManager.Themes;
            cb_Theme.DisplayMemberPath = "DisplayName";
            cb_Theme.SelectedItem = ThemeManager.ActiveTheme;
        }

        private void cb_Theme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cb_Theme.SelectedItem is Theme theme)
            {
                ThemeManager.ActiveTheme = theme;
                tb_Description.Text = theme.Description;
            }
        }
    }
}
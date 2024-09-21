using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace sbux.wpf.Controls
{

    /// <summary>
    /// NOTE: Color is a struct, not a class. This complicates databinding for editing.
    /// In brief, you can't write: ColorPicker.SelectedColor.R = newValue because what
    /// you get is a copy, not a reference. Instead, the color must be constructed anew
    /// when the components change.
    /// Note to Microsoft: Durr make it a class durrrrrrrrrr.
    /// </summary>
    public partial class ColorPicker : UserControl
    {
        ///////////////////////////////////////////////////////////
        #region Dependency Properties

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(ColorPicker),
                new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty SelectedColorProperty =
            DependencyProperty.Register("SelectedColor", typeof(Color), typeof(ColorPicker),
                new PropertyMetadata(Colors.Black));

        public static DependencyProperty SelectedColorBrushProperty =
            DependencyProperty.Register("SelectedColorBrush", typeof(SolidColorBrush), typeof(ColorPicker),
                new PropertyMetadata(new SolidColorBrush(Colors.Black)));

        public static readonly DependencyProperty ColorRProperty =
            DependencyProperty.Register("ColorR", typeof(byte), typeof(ColorPicker), 
                new PropertyMetadata((byte)0, OnColorByteChanged));

        public static readonly DependencyProperty ColorGProperty =
            DependencyProperty.Register("ColorG", typeof(byte), typeof(ColorPicker), 
                new PropertyMetadata((byte)0, OnColorByteChanged));

        public static readonly DependencyProperty ColorBProperty =
            DependencyProperty.Register("ColorB", typeof(byte), typeof(ColorPicker), 
                new PropertyMetadata((byte)0, OnColorByteChanged));

        #endregion Dependency Properties
        ///////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////
        #region Dependency Property Callbacks

        private static void OnColorByteChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ColorPicker cp)
            {
                cp.SelectedColor = Color.FromRgb(cp.ColorR, cp.ColorG, cp.ColorB);
                cp.SelectedColorBrush = new SolidColorBrush(cp.SelectedColor);
            }
        }

        #endregion Dependency Property Callbacks
        ///////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////
        #region Properties

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public Color SelectedColor
        {
            get { return (Color)GetValue(SelectedColorProperty); }
            set { SetValue(SelectedColorProperty, value); }
        }

        public SolidColorBrush SelectedColorBrush
        {
            get { return (SolidColorBrush)GetValue(SelectedColorBrushProperty); }
            set { SetValue(SelectedColorBrushProperty, value); }
        }

        public byte ColorR
        {
            get { return (byte)GetValue(ColorRProperty); }
            set { SetValue(ColorRProperty, value); }
        }

        public byte ColorG
        {
            get { return (byte)GetValue(ColorGProperty); }
            set { SetValue(ColorGProperty, value); }
        }

        public byte ColorB
        {
            get { return (byte)GetValue(ColorBProperty); }
            set { SetValue(ColorBProperty, value); }
        }

        #endregion Properties
        ///////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////
        #region Interface

        public ColorPicker()
        {
            DataContext = this;
            InitializeComponent();            
        }

        private void btnCloseDetails_Click(object sender, RoutedEventArgs e)
        {
            tglDetails.IsChecked = false;
        }

        #endregion Interface
        ///////////////////////////////////////////////////////////


    }
}

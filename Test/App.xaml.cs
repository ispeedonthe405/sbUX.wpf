﻿using System.Configuration;
using System.Data;
using System.Windows;
using sbux.wpf.Themer;

namespace Test
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ThemeManager.SetApplication(this);

            //FrameworkElement.StyleProperty.OverrideMetadata(typeof(Window), new FrameworkPropertyMetadata
            //{
            //    DefaultValue = FindResource(typeof(Window))
            //});
        }
    }

}

﻿using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace App.Core
{
    class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
        {
            if ( value is bool )
            {
                return ( (bool)value ) || DesignerProperties.GetIsInDesignMode( Application.Current.MainWindow )
                    ? Visibility.Visible
                    : Visibility.Hidden;
            }
            return Visibility.Hidden;
        }

        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
}

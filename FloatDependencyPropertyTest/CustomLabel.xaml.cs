using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace FloatDependencyPropertyTest
{
    public sealed partial class CustomLabel : UserControl
    {
        public CustomLabel()
        {
            this.InitializeComponent();
        }


        public float FValue
        {
            get { return (float)GetValue(FValueProperty); }
            set { SetValue(FValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FValueProperty =
            DependencyProperty.Register("FValue", typeof(float), typeof(CustomLabel), new PropertyMetadata(0f));



        public double DValue
        {
            get { return (double)GetValue(DValueProperty); }
            set { SetValue(DValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DValueProperty =
            DependencyProperty.Register("DValue", typeof(double), typeof(CustomLabel), new PropertyMetadata(0));



    }
}

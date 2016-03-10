using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PVCR.DragDropExample.UserControls
{
    
    /// <summary>
    /// Interaction logic for SamplesContainerCtrl.xaml
    /// </summary>
    public partial class SamplesContainerCtrl : UserControl
    {
        public int MaxDisplayValue
        {
            get { return (int)GetValue(MaxDisplayValueProperty); }
            set { SetValue(MaxDisplayValueProperty, value); }
        }

        public static readonly DependencyProperty MaxDisplayValueProperty =
            DependencyProperty.Register("MaxDisplayValue", typeof(int), typeof(SamplesContainerCtrl), new FrameworkPropertyMetadata(0));


        public string DisplayMethodName
        {
            get { return (string)GetValue(DisplayMethodNameProperty); }
            set { SetValue(DisplayMethodNameProperty, value); }
        }

        public static readonly DependencyProperty DisplayMethodNameProperty =
            DependencyProperty.Register("DisplayMethodName", typeof(string), typeof(SamplesContainerCtrl),
                  new FrameworkPropertyMetadata("Default"));


        public SamplesContainerCtrl()
        {
            InitializeComponent();
            Loaded += SamplesGroupCtrl_Loaded;
        }

        private void SamplesGroupCtrl_Loaded(object sender, RoutedEventArgs e)
        {
            samplesGroupCtrlImgContainer.Children.Add(GetDisplayCtrl(MaxDisplayValue));

           
        }

        private UIElement GetDisplayCtrl(int maxValue)
        {
            var samplesCtrl = new SamplesGroupCtrl();
            samplesCtrl.DisplayMethodName = DisplayMethodName;
            samplesCtrl.DisplayValue = maxValue;

            return samplesCtrl;
        }
    }
}

﻿using System;
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

namespace PVCR.DragDropExample.Content
{
    /// <summary>
    /// Interaction logic for WorkSchedulePage.xaml
    /// </summary>
    public partial class WorkSchedulePage : UserControl
    {
        public WorkSchedulePage()
        {
            InitializeComponent();
            this.ScheduleView.Background = new SolidColorBrush(new Color());
        }
    }
}

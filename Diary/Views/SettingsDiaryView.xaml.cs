﻿using Diary.ViewModels;
using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace Diary.Views
{
    /// <summary>
    /// Interaction logic for SettingsDiary.xaml
    /// </summary>
    public partial class SettingsDiaryView : MetroWindow
    {
        public SettingsDiaryView(bool canCloseWindow)
        {
            InitializeComponent();
            DataContext = new SettingsDiaryViewModel(canCloseWindow);

        }
    }
}

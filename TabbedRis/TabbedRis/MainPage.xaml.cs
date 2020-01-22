﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedRis
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            Children.Add(new NavigationPage(new Page1(1)));
            Children.Add(new NavigationPage(new Page1(1)));
            Children.Add(new NavigationPage(new Page1(1)));
            Children.Add(new NavigationPage(new Page1(1)));
        }
    }
}